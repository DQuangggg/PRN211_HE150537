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
using BusinessObject;
using static BusinessObject.Member;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }
        MemberObject memberObject = new MemberObject();
        private void LoadMember() { 
            var members = memberObject.GetMembers();
            txtMemberID.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtPass.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", members, "MemberID");
            txtEmail.DataBindings.Add("Text", members, "Email");
            txtCity.DataBindings.Add("Text", members, "City");
            txtCompanyName.DataBindings.Add("Text", members, "CompanyName");
            txtCountry.DataBindings.Add("Text", members, "Country");
            txtPass.DataBindings.Add("Text", members, "Pass");

            dgvMemberList.DataSource = members;


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var members = new Member
                {
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    CompanyName = txtCompanyName.Text,
                    Country = txtCountry.Text,
                    Password = txtPass.Text,

                };
                memberObject.InsertMember(members);
                LoadMember();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Insert Category");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var members = new Member
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    CompanyName = txtCompanyName.Text,
                    Country = txtCountry.Text,
                    Password = txtPass.Text,

                };
                memberObject.UpdateMember(members);
                LoadMember();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Category");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var members = new Member
                {
                    MemberID = int.Parse(txtMemberID.Text),

                };
                memberObject.DeleteMember(members);
                LoadMember();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Category");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();


        private void frmMembers_Load(object sender, EventArgs e) => LoadMember();

    }
}
