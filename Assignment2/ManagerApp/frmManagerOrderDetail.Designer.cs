namespace ManagerApp
{
    partial class frmManagerOrderDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdOrderID = new System.Windows.Forms.RadioButton();
            this.rdProductID = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Detail Management";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(38, 121);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(48, 15);
            this.lbOrderID.TabIndex = 1;
            this.lbOrderID.Text = "OrderID";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(38, 227);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(55, 15);
            this.lbUnitPrice.TabIndex = 2;
            this.lbUnitPrice.Text = "UnitPrice";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(38, 175);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(60, 15);
            this.lbProductID.TabIndex = 3;
            this.lbProductID.Text = "ProductID";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(386, 175);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(54, 15);
            this.lbDiscount.TabIndex = 4;
            this.lbDiscount.Text = "Discount";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(386, 121);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(53, 15);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "Quantity";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(132, 118);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(211, 23);
            this.txtOrderID.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(467, 118);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(211, 23);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(132, 172);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(211, 23);
            this.txtProductID.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(132, 224);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(211, 23);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(467, 172);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(211, 23);
            this.txtDiscount.TabIndex = 10;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(132, 287);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(280, 287);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(429, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(280, 652);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(12, 415);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowTemplate.Height = 25;
            this.dgvOrderDetail.Size = new System.Drawing.Size(666, 215);
            this.dgvOrderDetail.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.managerMemberToolStripMenuItem,
            this.managerProductToolStripMenuItem,
            this.managerOrderToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // managerMemberToolStripMenuItem
            // 
            this.managerMemberToolStripMenuItem.Name = "managerMemberToolStripMenuItem";
            this.managerMemberToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.managerMemberToolStripMenuItem.Text = "Manager Member";
            this.managerMemberToolStripMenuItem.Click += new System.EventHandler(this.managerMemberToolStripMenuItem_Click);
            // 
            // managerProductToolStripMenuItem
            // 
            this.managerProductToolStripMenuItem.Name = "managerProductToolStripMenuItem";
            this.managerProductToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.managerProductToolStripMenuItem.Text = "Manager Product";
            this.managerProductToolStripMenuItem.Click += new System.EventHandler(this.managerProductToolStripMenuItem_Click);
            // 
            // managerOrderToolStripMenuItem
            // 
            this.managerOrderToolStripMenuItem.Name = "managerOrderToolStripMenuItem";
            this.managerOrderToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.managerOrderToolStripMenuItem.Text = "Manager Order";
            this.managerOrderToolStripMenuItem.Click += new System.EventHandler(this.managerOrderToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(132, 342);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 23);
            this.txtSearch.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdOrderID
            // 
            this.rdOrderID.AutoSize = true;
            this.rdOrderID.Location = new System.Drawing.Point(151, 380);
            this.rdOrderID.Name = "rdOrderID";
            this.rdOrderID.Size = new System.Drawing.Size(85, 19);
            this.rdOrderID.TabIndex = 19;
            this.rdOrderID.TabStop = true;
            this.rdOrderID.Text = "By Order ID";
            this.rdOrderID.UseVisualStyleBackColor = true;
            // 
            // rdProductID
            // 
            this.rdProductID.AutoSize = true;
            this.rdProductID.Location = new System.Drawing.Point(270, 380);
            this.rdProductID.Name = "rdProductID";
            this.rdProductID.Size = new System.Drawing.Size(97, 19);
            this.rdProductID.TabIndex = 20;
            this.rdProductID.TabStop = true;
            this.rdProductID.Text = "By Product ID";
            this.rdProductID.UseVisualStyleBackColor = true;
            // 
            // frmManagerOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 726);
            this.Controls.Add(this.rdProductID);
            this.Controls.Add(this.rdOrderID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbProductID);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManagerOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.frmManagerOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdOrderID;
        private System.Windows.Forms.RadioButton rdProductID;
    }
}