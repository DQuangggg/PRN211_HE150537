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
    public partial class frmManagerOrderDetail : Form
    {
        public frmManagerOrderDetail()
        {
            InitializeComponent();
        }
        ManagerOrderDetail managerOrderDetail = new ManagerOrderDetail();

        private void LoadOrderDetail() {
            var orderDetail = managerOrderDetail.GetOrderDetails();
            Validate valid = new Validate();
            if (rdOrderID.Checked && txtSearch.Text.Length >= 1)
            {
                if (!valid.checkNumber(txtSearch.Text))
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    orderDetail = managerOrderDetail.GetOrderDetailByOrderID(Convert.ToInt32(txtSearch.Text));
                }
            }
            else if (rdProductID.Checked && txtSearch.Text.Length >= 1)
            {
                if (!valid.checkNumber(txtSearch.Text))
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    orderDetail = managerOrderDetail.GetOrderDetailByProductID(Convert.ToInt32(txtSearch.Text));
                }
            }
            txtOrderID.DataBindings.Clear();
            txtProductID.DataBindings.Clear();
            txtDiscount.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();

            txtOrderID.DataBindings.Add("Text",orderDetail,"OrderID");
            txtProductID.DataBindings.Add("Text", orderDetail, "ProductID");
            txtDiscount.DataBindings.Add("Text", orderDetail, "Discount");
            txtQuantity.DataBindings.Add("Text", orderDetail, "Quantity");
            txtUnitPrice.DataBindings.Add("Text", orderDetail, "UnitPrice");

            dgvOrderDetail.DataSource = orderDetail;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try {
                var orderDetail = new OrderDetail
                {
                    Discount = double.Parse(txtDiscount.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text)
                };
                managerOrderDetail.InsertOrderDetail(orderDetail);
                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.Refresh();
                LoadOrderDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Order Detail");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = new OrderDetail
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    ProductID = int.Parse(txtProductID.Text),
                    Discount = double.Parse(txtDiscount.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text)
                };
                managerOrderDetail.UpdateOrderDetail(orderDetail);
                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.Refresh();
                LoadOrderDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Order Detail");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var orderDetail = new OrderDetail
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    ProductID = int.Parse(txtProductID.Text),
                };
                managerOrderDetail.DeleteOrderDetail(orderDetail);
                dgvOrderDetail.DataSource = null;
                dgvOrderDetail.Refresh();
                LoadOrderDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Order Detail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();


        private void frmManagerOrderDetail_Load(object sender, EventArgs e)
        {
            dgvOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadOrderDetail();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void managerMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManegerMember frmManegerMember = new frmManegerMember();
            frmManegerMember.Show();
            this.Hide();
        }

        private void managerProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerProduct frmManagerProduct = new frmManagerProduct();
            frmManagerProduct.Show();
            this.Hide();
        }

        private void managerOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManegerOrder frmManegerOrder = new frmManegerOrder();
            frmManegerOrder.Show();
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
            LoadOrderDetail();
            txtSearch.Clear();
        }
    }
}
