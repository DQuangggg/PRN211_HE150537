using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using DemoDisconnectedLayer.DAO;

namespace DemoDisconnectedLayer
{
    public partial class frmMyStore : Form
    {
        public frmMyStore()
        {
            InitializeComponent();
        }

        DataSet dsMyStore = new DataSet();
        private void frmMyStore_Load(object sender, EventArgs e) {
            string ConnectionString = "Server=QUANGGGG\\QUANG;uid=sa;pwd=dangquang2001;database=MyStore;";
            string SQL = "Select ProductID , ProductName , UnitStock From Products ; Select * From Catgories ";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, ConnectionString);
                dataAdapter.Fill(dsMyStore);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Get Data From Database");
            }
        }
       
 

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = ProductDAO.GetAllProduct();
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = CategoriesDAO.GetAllCategories();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

    }
}
