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
using Microsoft.Data.SqlClient;

namespace ManagerApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=QUANGGGG\\QUANG;uid=sa;pwd=dangquang2001;database=Ass2PRN;";
            SqlConnection connection = new SqlConnection(ConnectionString);
            string SQL = "Select * from Member where Email = '" +txtUsername.Text+ "' and Password = '" +txtPassword.Text+ "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(SQL,connection);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Error");
            }
        }
    }
}
