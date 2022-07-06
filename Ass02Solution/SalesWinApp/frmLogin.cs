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
using System.IO;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string jsonText = File.ReadAllText(@"appsetting.json");
            Account account = Newtonsoft.Json.JsonConvert.DeserializeObject<Account>(jsonText);
            if (account.Email.Equals(txtUser.Text) && account.Password.Equals(txtPass.Text))
            {
                frmMembers frmMembers = new frmMembers();
                frmMembers.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong account or password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
