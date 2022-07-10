using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerSystem;
using Microsoft.Data.SqlClient;



namespace ManagerApp
{
    public partial class frmManegerMember : Form
    {
        public frmManegerMember()
        {
            InitializeComponent();
        }
        ManagerMember managerMember = new ManagerMember();

        private void LoadMember() {
            Validate valid = new Validate();
            var members = managerMember.GetMembers();
            if (rdID.Checked && txtSearch.Text.Length >= 1)
            {
                if (!valid.checkNumber(txtSearch.Text))
                {
                    MessageBox.Show("error");
                }
                else
                {
                    members = managerMember.getmembersbyid(Convert.ToInt32(txtSearch.Text));
                }
            }
            else if (rdName.Checked && txtSearch.Text.Length >= 1)
            {
                members = managerMember.getmembersbyname(txtSearch.Text);

            }

            try
            {

                txtMemberID.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", members, "MemberID");
                txtCity.DataBindings.Add("Text", members, "City");
                txtCompanyName.DataBindings.Add("Text", members, "CompanyName");
                txtCountry.DataBindings.Add("Text", members, "Country");
                txtEmail.DataBindings.Add("Text", members, "Email");
                txtPassword.DataBindings.Add("Text", members, "Password");
               
                dgvMembers.DataSource = null;
                dgvMembers.Rows.Clear();
                dgvMembers.DataSource = members;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Load list");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try {
                var member = new Member { City = txtCity.Text, CompanyName = txtCompanyName.Text,
                                           Country = txtCountry.Text, Email = txtEmail.Text,
                                           Password = txtPassword.Text };
                managerMember.InsertMember(member);
                dgvMembers.DataSource = null;
                dgvMembers.Refresh();
                LoadMember();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Member");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                var member = new Member
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    City = txtCity.Text,
                    CompanyName = txtCompanyName.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };
                managerMember.UpdateMember(member);
                dgvMembers.DataSource = null;
                dgvMembers.Refresh();
                dgvMembers.Update();
                LoadMember();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Member");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                var member = new Member {
                    MemberID = int.Parse(txtMemberID.Text),
                };
                managerMember.DeleteMember(member);
                dgvMembers.DataSource = null;
                dgvMembers.Refresh();
                dgvMembers.Update();
                LoadMember();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Member");
            }
        }
        private void frmManegerMember_Load(object sender, EventArgs e)
        { 
            LoadMember();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
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



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMember();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
