using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageCategories1;

namespace ManageCategoriesApp
{
    public partial class frmManageCategories : Form
    {
        public frmManageCategories()
        {
            InitializeComponent();
        }
        ManageCategories manageCategories = new ManageCategories();
        private void LoadCategories() {
            var categories = manageCategories.GetCategories();
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();

            txtCategoryID.DataBindings.Add("Text", categories, "MemberID");
            txtCategoryName.DataBindings.Add("Text", categories, "Email");

            dgvCategories.DataSource = categories;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category { Email = txtCategoryName.Text };
                manageCategories.InsertCategory(category);
                LoadCategories();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message,"Insert Category");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category
                {
                    MemberID = int.Parse(txtCategoryID.Text),
                    Email = txtCategoryName.Text
                };
                manageCategories.UpdateCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Category");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                var category = new Category
                {
                    MemberID = int.Parse(txtCategoryID.Text)
                };
                manageCategories.DeleteCategory(category);
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Category");
            }
        }

        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadCategories();
        }
    }
}
