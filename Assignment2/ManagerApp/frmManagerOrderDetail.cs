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
                    Discount = float.Parse(txtDiscount.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text)
                };
                managerOrderDetail.InsertOrderDetail(orderDetail);
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
                    Discount = float.Parse(txtDiscount.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text)
                };
                managerOrderDetail.UpdateOrderDetail(orderDetail);
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
        }
    }
}
