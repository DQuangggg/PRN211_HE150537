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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void managerMemberToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerProduct frmManagerProduct = new frmManagerProduct();
            frmManagerProduct.Show();
            this.Hide();
        }

        private void managerMemberToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmManegerMember frmManegerMember = new frmManegerMember();
            frmManegerMember.Show();
            this.Hide();
        }

        private void managerProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerProduct frmManagerProduct = new frmManagerProduct();
            frmManagerProduct.Show();
            this.Hide();
        }

        private void managerOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManegerOrder frmManegerOrder = new frmManegerOrder();
            frmManegerOrder.Show();
            this.Hide();
        }

        private void managerOrderDetailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManagerOrderDetail frmManagerOrderDetail = new frmManagerOrderDetail();
            frmManagerOrderDetail.Show();
            this.Hide();
        }
    }
}
