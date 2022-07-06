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
    public partial class frmManegerMember : Form
    {
        public frmManegerMember()
        {
            InitializeComponent();
        }
        ManagerMember managerMember = new ManagerMember();

        private void LoadMember() {
            var members = managerMember.GetMembers();
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

            dgvMembers.DataSource = members;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try {
                var member = new Member { City = txtCity.Text, CompanyName = txtCompanyName.Text,
                                           Country = txtCountry.Text, Email = txtEmail.Text,
                                           Password = txtPassword.Text };
                managerMember.InsertMember(member);
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
                LoadMember();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Member");
            }
        }
        private void frmManegerMember_Load(object sender, EventArgs e)
        {
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadMember();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    }
}
