using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerSystem;

namespace ManagerApp
{
    public partial class frmManegerOrder : Form
    {
        public frmManegerOrder()
        {
            InitializeComponent();
        }
        ManagerOrder managerOrder = new ManagerOrder();

        private void LoadOrder() {
            var orders = managerOrder.GetOrders();
            Validate valid = new Validate();
            if (rdOrderID.Checked && txtSearch.Text.Length >= 1)
            {
                if (!valid.checkNumber(txtSearch.Text))
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    orders = managerOrder.GetOrdersByOrderID(Convert.ToInt32(txtSearch.Text));
                }
            }
            else if (rdMemberID.Checked && txtSearch.Text.Length >= 1)
            {
                if (!valid.checkNumber(txtSearch.Text))
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    orders = managerOrder.GetOrdersByMemberID(Convert.ToInt32(txtSearch.Text));
                }
            }
            txtOrderID.DataBindings.Clear();
            txtMemberID.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtRequiredDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();
            txtFreight.DataBindings.Clear();

            txtOrderID.DataBindings.Add("Text", orders, "OrderID");
            txtMemberID.DataBindings.Add("Text", orders, "MemberID");
            txtOrderDate.DataBindings.Add("Text", orders, "OrderDate");
            txtRequiredDate.DataBindings.Add("Text", orders, "RequiredDate");
            txtShippedDate.DataBindings.Add("Text", orders, "ShippedDate");
            txtFreight.DataBindings.Add("Text", orders, "Freight");

            dgvOrder.DataSource = orders;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new Order
                {
                    MemberID = int.Parse(txtMemberID.Text) ,
                    OrderDate = DateTime.Parse(txtOrderDate.Text) ,
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text) ,
                    ShippedDate = DateTime.Parse(txtShippedDate.Text) ,
                    Freight = decimal.Parse(txtFreight.Text),
                    
                };
                managerOrder.InsertOrder(order);
                dgvOrder.DataSource = null;
                dgvOrder.Refresh();
                LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Order");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new Order
                {
                    OrderID = int.Parse(txtMemberID.Text) ,
                    MemberID = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),

                };
                managerOrder.UpdateOrder(order);
                dgvOrder.DataSource = null;
                dgvOrder.Refresh();
                LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Order");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = new Order
                {
                    OrderID = int.Parse(txtMemberID.Text),
                };
                managerOrder.DeleteOrder(order);
                dgvOrder.DataSource = null;
                dgvOrder.Refresh();
                LoadOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Order");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();


        private void frmManegerOrder_Load(object sender, EventArgs e)
        {
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadOrder();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void managerMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerProduct frmManagerProduct = new frmManagerProduct();
            frmManagerProduct.Show();
            this.Hide();
        }

        private void managerProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerProduct frmManagerProduct = new frmManagerProduct();
            frmManagerProduct.Show();
            this.Hide();
        }

        private void managerOrderDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerOrderDetail frmManagerOrderDetail = new frmManagerOrderDetail();
            frmManagerOrderDetail.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadOrder();
            txtSearch.Clear();
        }
    }
}
