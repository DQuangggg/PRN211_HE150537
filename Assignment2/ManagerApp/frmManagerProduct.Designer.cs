namespace ManagerApp
{
    partial class frmManagerProduct
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
            this.lbProductID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCategoryID = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerOrderDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdID = new System.Windows.Forms.RadioButton();
            this.rdName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(35, 101);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(60, 15);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "ProductID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(117, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Management";
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.AutoSize = true;
            this.lbCategoryID.Location = new System.Drawing.Point(35, 198);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(66, 15);
            this.lbCategoryID.TabIndex = 2;
            this.lbCategoryID.Text = "CategoryID";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(35, 150);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(81, 15);
            this.lbProductName.TabIndex = 3;
            this.lbProductName.Text = "ProductName";
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(356, 101);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(45, 15);
            this.lbWeight.TabIndex = 4;
            this.lbWeight.Text = "Weight";
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(356, 198);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(68, 15);
            this.lbUnitInStock.TabIndex = 5;
            this.lbUnitInStock.Text = "UnitInStock";
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(356, 150);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(55, 15);
            this.lbUnitPrice.TabIndex = 6;
            this.lbUnitPrice.Text = "UnitPrice";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(438, 98);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(177, 23);
            this.txtWeight.TabIndex = 7;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(438, 147);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(177, 23);
            this.txtUnitPrice.TabIndex = 8;
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(438, 195);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(177, 23);
            this.txtUnitInStock.TabIndex = 9;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(131, 98);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(177, 23);
            this.txtProductID.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(131, 147);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(177, 23);
            this.txtProductName.TabIndex = 11;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(131, 195);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(177, 23);
            this.txtCategoryID.TabIndex = 12;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(131, 242);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(254, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 621);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(23, 367);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.Size = new System.Drawing.Size(636, 210);
            this.dgvProduct.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.mangerMemberToolStripMenuItem,
            this.managerOrderToolStripMenuItem,
            this.managerOrderDetailToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // mangerMemberToolStripMenuItem
            // 
            this.mangerMemberToolStripMenuItem.Name = "mangerMemberToolStripMenuItem";
            this.mangerMemberToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.mangerMemberToolStripMenuItem.Text = "Manger Member";
            this.mangerMemberToolStripMenuItem.Click += new System.EventHandler(this.mangerMemberToolStripMenuItem_Click);
            // 
            // managerOrderToolStripMenuItem
            // 
            this.managerOrderToolStripMenuItem.Name = "managerOrderToolStripMenuItem";
            this.managerOrderToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.managerOrderToolStripMenuItem.Text = "Manager Order";
            this.managerOrderToolStripMenuItem.Click += new System.EventHandler(this.managerOrderToolStripMenuItem_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(131, 291);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 23);
            this.txtSearch.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdID
            // 
            this.rdID.AutoSize = true;
            this.rdID.Location = new System.Drawing.Point(167, 333);
            this.rdID.Name = "rdID";
            this.rdID.Size = new System.Drawing.Size(52, 19);
            this.rdID.TabIndex = 22;
            this.rdID.TabStop = true;
            this.rdID.Text = "By ID";
            this.rdID.UseVisualStyleBackColor = true;
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Location = new System.Drawing.Point(275, 333);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(73, 19);
            this.rdName.TabIndex = 23;
            this.rdName.TabStop = true;
            this.rdName.Text = "By Name";
            this.rdName.UseVisualStyleBackColor = true;
            // 
            // frmManagerProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 667);
            this.Controls.Add(this.rdName);
            this.Controls.Add(this.rdID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtUnitInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.lbUnitInStock);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbCategoryID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbProductID);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManagerProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmManagerProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbUnitInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangerMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerOrderDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdID;
        private System.Windows.Forms.RadioButton rdName;
    }
}