namespace ManagerApp
{
    partial class frmManegerOrder
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
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerOrderDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdOrderID = new System.Windows.Forms.RadioButton();
            this.rdMemberID = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Mangement";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(54, 122);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(48, 15);
            this.lbOrderID.TabIndex = 1;
            this.lbOrderID.Text = "OrderID";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(54, 167);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(63, 15);
            this.lbMemberID.TabIndex = 2;
            this.lbMemberID.Text = "MemberID";
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(359, 122);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(78, 15);
            this.lbRequiredDate.TabIndex = 3;
            this.lbRequiredDate.Text = "RequiredDate";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(359, 167);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(74, 15);
            this.lbShippedDate.TabIndex = 4;
            this.lbShippedDate.Text = "ShippedDate";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(54, 210);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(44, 15);
            this.lbFreight.TabIndex = 5;
            this.lbFreight.Text = "Freight";
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(359, 210);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(61, 15);
            this.lbOrderDate.TabIndex = 6;
            this.lbOrderDate.Text = "OrderDate";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(132, 119);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(196, 23);
            this.txtOrderID.TabIndex = 7;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(455, 119);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(196, 23);
            this.txtRequiredDate.TabIndex = 8;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(132, 164);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(196, 23);
            this.txtMemberID.TabIndex = 9;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(455, 207);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(196, 23);
            this.txtOrderDate.TabIndex = 10;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(455, 164);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(196, 23);
            this.txtShippedDate.TabIndex = 11;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(132, 207);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(196, 23);
            this.txtFreight.TabIndex = 12;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(156, 253);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(286, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(410, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 660);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 383);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 25;
            this.dgvOrder.Size = new System.Drawing.Size(664, 252);
            this.dgvOrder.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.managerMemberToolStripMenuItem,
            this.managerProductToolStripMenuItem,
            this.managerOrderDetailToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 18;
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
            // managerOrderDetailToolStripMenuItem
            // 
            this.managerOrderDetailToolStripMenuItem.Name = "managerOrderDetailToolStripMenuItem";
            this.managerOrderDetailToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.managerOrderDetailToolStripMenuItem.Text = "Manager Order Detail";
            this.managerOrderDetailToolStripMenuItem.Click += new System.EventHandler(this.managerOrderDetailToolStripMenuItem_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(156, 300);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(239, 23);
            this.txtSearch.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdOrderID
            // 
            this.rdOrderID.AutoSize = true;
            this.rdOrderID.Location = new System.Drawing.Point(199, 340);
            this.rdOrderID.Name = "rdOrderID";
            this.rdOrderID.Size = new System.Drawing.Size(85, 19);
            this.rdOrderID.TabIndex = 21;
            this.rdOrderID.TabStop = true;
            this.rdOrderID.Text = "By Order ID";
            this.rdOrderID.UseVisualStyleBackColor = true;
            // 
            // rdMemberID
            // 
            this.rdMemberID.AutoSize = true;
            this.rdMemberID.Location = new System.Drawing.Point(339, 344);
            this.rdMemberID.Name = "rdMemberID";
            this.rdMemberID.Size = new System.Drawing.Size(100, 19);
            this.rdMemberID.TabIndex = 22;
            this.rdMemberID.TabStop = true;
            this.rdMemberID.Text = "By Member ID";
            this.rdMemberID.UseVisualStyleBackColor = true;
            // 
            // frmManegerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 695);
            this.Controls.Add(this.rdMemberID);
            this.Controls.Add(this.rdOrderID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbOrderDate);
            this.Controls.Add(this.lbFreight);
            this.Controls.Add(this.lbShippedDate);
            this.Controls.Add(this.lbRequiredDate);
            this.Controls.Add(this.lbMemberID);
            this.Controls.Add(this.lbOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManegerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.frmManegerOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerOrderDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdOrderID;
        private System.Windows.Forms.RadioButton rdMemberID;
    }
}