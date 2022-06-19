using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {

        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadDVGMemberList();
            dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
        }

        public void DgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                Text = "Update Member",
                MemberInfo = GetMemberObject(),
                InsertOrUpdate = "Update",
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadDVGMemberList();
                source.Position = source.Count - 1;
            }
        }

    /*    public void UpdateByButton()
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                Text = "Update Member",
                MemberInfo = GetMemberObject(),
                InsertOrUpdate = "Update",
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadDVGMemberList();
                source.Position = source.Count - 1;
            }
        } */

        private void LoadDVGMemberList()
        {
            //display all member
            var member = memberRepository.getMembers();
            //check button id or name
            if (rdId.Checked && txtSearch.Text.Length >= 1)
            {
                member = memberRepository.getMemberById(Convert.ToInt32(txtSearch.Text));
            }
            else if (rdName.Checked && txtSearch.Text.Length >= 1)
            {
                member = memberRepository.getMembersByName(txtSearch.Text);
            }

            try
            {
                source = new BindingSource();
                source.DataSource = member;
                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list");
            }
        }
        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member()
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Null");
            }
            return member;
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.deleteMember(member.MemberID);
                LoadDVGMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete");
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            LoadDVGMemberList();
            txtSearch.Clear();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                MemberRepository = memberRepository,
                InsertOrUpdate = "Insert",
                Text = "Add Member"
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadDVGMemberList();
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                Text = "Update Member",
                MemberInfo = GetMemberObject(),
                InsertOrUpdate = "Update",
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadDVGMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdCity_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
