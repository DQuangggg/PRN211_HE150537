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
    public partial class frmManagerProduct : Form
    {
        public frmManagerProduct()
        {
            InitializeComponent();
        }
        ManagerProduct managerProduct = new ManagerProduct();

        private void LoadProduct() {
            var products = managerProduct.GetProducts();
            Validate valid = new Validate();
            if (rdID.Checked && txtSearch.Text.Length >= 1)
            {
                if (!valid.checkNumber(txtSearch.Text))
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    products = managerProduct.GetProductsByID(Convert.ToInt32(txtSearch.Text));
                }
            }
            else if (rdName.Checked && txtSearch.Text.Length >= 1)
            {
                products = managerProduct.GetProductsByName(txtSearch.Text);
            }

            txtProductID.DataBindings.Clear();
            txtCategoryID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtUnitInStock.DataBindings.Clear();
            txtUnitPrice.DataBindings.Clear();
            txtWeight.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text", products, "ProductID");
            txtCategoryID.DataBindings.Add("Text", products, "CategoryID");
            txtProductName.DataBindings.Add("Text", products, "ProductName");
            txtUnitInStock.DataBindings.Add("Text", products, "UnitInStock");
            txtUnitPrice.DataBindings.Add("Text", products, "UnitPrice");
            txtWeight.DataBindings.Add("Text", products, "Weight");

            dgvProduct.DataSource = products;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    CategoryID = int.Parse(txtCategoryID.Text) ,
                    ProductName = txtProductName.Text,
                    UnitInStock = int.Parse(txtUnitInStock.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Weight = txtWeight.Text
                };
                managerProduct.InsertProduct(product);
                dgvProduct.DataSource = null;
                dgvProduct.Refresh();
                LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Product");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    ProductID = int.Parse(txtProductID.Text) ,
                    CategoryID = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    UnitInStock = int.Parse(txtUnitInStock.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Weight = txtWeight.Text
                };
                managerProduct.UpdateProduct(product);
                dgvProduct.DataSource = null;
                dgvProduct.Refresh();
                LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    ProductID= int.Parse(txtProductID.Text) ,
                };
                managerProduct.DeleteProduct(product);
                dgvProduct.DataSource = null;
                dgvProduct.Refresh();
                LoadProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();
 

        private void frmManagerProduct_Load(object sender, EventArgs e)
        {
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadProduct();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void mangerMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManegerMember frmManegerMember = new frmManegerMember();
            frmManegerMember.Show();
            this.Hide();
        }

        private void managerOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManegerOrder frmManegerOrder = new frmManegerOrder();
            frmManegerOrder.Show();
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
            LoadProduct();
            txtSearch.Clear();
        }
    }
}
