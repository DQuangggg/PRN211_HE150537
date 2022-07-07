namespace ManagerApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerOrderDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerMemberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managerProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managerOrderDetailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.managerMemberToolStripMenuItem1,
            this.managerProductToolStripMenuItem,
            this.managerOrderToolStripMenuItem1,
            this.managerOrderDetailToolStripMenuItem1,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerMemberToolStripMenuItem,
            this.manageProductToolStripMenuItem,
            this.managerOrderToolStripMenuItem,
            this.managerOrderDetailToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // managerMemberToolStripMenuItem
            // 
            this.managerMemberToolStripMenuItem.Name = "managerMemberToolStripMenuItem";
            this.managerMemberToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.managerMemberToolStripMenuItem.Text = "Manager Member";
            this.managerMemberToolStripMenuItem.Click += new System.EventHandler(this.managerMemberToolStripMenuItem_Click);
            // 
            // manageProductToolStripMenuItem
            // 
            this.manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            this.manageProductToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.manageProductToolStripMenuItem.Text = "Manage Product";
            this.manageProductToolStripMenuItem.Click += new System.EventHandler(this.manageProductToolStripMenuItem_Click);
            // 
            // managerOrderToolStripMenuItem
            // 
            this.managerOrderToolStripMenuItem.Name = "managerOrderToolStripMenuItem";
            this.managerOrderToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.managerOrderToolStripMenuItem.Text = "Manager Order";
            this.managerOrderToolStripMenuItem.Click += new System.EventHandler(this.managerOrderToolStripMenuItem_Click);
            // 
            // managerOrderDetailToolStripMenuItem
            // 
            this.managerOrderDetailToolStripMenuItem.Name = "managerOrderDetailToolStripMenuItem";
            this.managerOrderDetailToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.managerOrderDetailToolStripMenuItem.Text = "Manager Order Detail";
            this.managerOrderDetailToolStripMenuItem.Click += new System.EventHandler(this.managerOrderDetailToolStripMenuItem_Click);
            // 
            // managerMemberToolStripMenuItem1
            // 
            this.managerMemberToolStripMenuItem1.Name = "managerMemberToolStripMenuItem1";
            this.managerMemberToolStripMenuItem1.Size = new System.Drawing.Size(114, 20);
            this.managerMemberToolStripMenuItem1.Text = "Manager Member";
            this.managerMemberToolStripMenuItem1.Click += new System.EventHandler(this.managerMemberToolStripMenuItem1_Click);
            // 
            // managerProductToolStripMenuItem
            // 
            this.managerProductToolStripMenuItem.Name = "managerProductToolStripMenuItem";
            this.managerProductToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.managerProductToolStripMenuItem.Text = "Manager Product";
            this.managerProductToolStripMenuItem.Click += new System.EventHandler(this.managerProductToolStripMenuItem_Click);
            // 
            // managerOrderToolStripMenuItem1
            // 
            this.managerOrderToolStripMenuItem1.Name = "managerOrderToolStripMenuItem1";
            this.managerOrderToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.managerOrderToolStripMenuItem1.Text = "Manager Order";
            this.managerOrderToolStripMenuItem1.Click += new System.EventHandler(this.managerOrderToolStripMenuItem1_Click);
            // 
            // managerOrderDetailToolStripMenuItem1
            // 
            this.managerOrderDetailToolStripMenuItem1.Name = "managerOrderDetailToolStripMenuItem1";
            this.managerOrderDetailToolStripMenuItem1.Size = new System.Drawing.Size(132, 20);
            this.managerOrderDetailToolStripMenuItem1.Text = "Manager Order Detail";
            this.managerOrderDetailToolStripMenuItem1.Click += new System.EventHandler(this.managerOrderDetailToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Manager App";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerOrderDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem managerMemberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managerProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerOrderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managerOrderDetailToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}