namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lbMemberId = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.rdId = new System.Windows.Forms.RadioButton();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.btClose = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(479, 110);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(208, 23);
            this.txtCity.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(479, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(208, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(479, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(156, 69);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(208, 23);
            this.txtMemberName.TabIndex = 3;
            // 
            // lbMemberId
            // 
            this.lbMemberId.AutoSize = true;
            this.lbMemberId.Location = new System.Drawing.Point(61, 31);
            this.lbMemberId.Name = "lbMemberId";
            this.lbMemberId.Size = new System.Drawing.Size(72, 15);
            this.lbMemberId.TabIndex = 4;
            this.lbMemberId.Text = "Member ID :";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(61, 72);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(93, 15);
            this.lbMemberName.TabIndex = 5;
            this.lbMemberName.Text = "Member Name :";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(61, 113);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(56, 15);
            this.lbCountry.TabIndex = 6;
            this.lbCountry.Text = "Country :";
            this.lbCountry.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(413, 31);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 15);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email :";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(413, 72);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(66, 15);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Password : ";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(413, 113);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 9;
            this.lbCity.Text = "City";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(156, 28);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(208, 23);
            this.txtMemberID.TabIndex = 10;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(156, 110);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(208, 23);
            this.txtCountry.TabIndex = 11;
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(27, 289);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.RowTemplate.Height = 25;
            this.dgvMemberList.Size = new System.Drawing.Size(749, 183);
            this.dgvMemberList.TabIndex = 12;
            this.dgvMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMemberList_CellDoubleClick);
            // 
            // btAdd
            // 
            this.btAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAdd.Location = new System.Drawing.Point(264, 163);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btUpdate.Location = new System.Drawing.Point(380, 163);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 14;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(502, 163);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(156, 215);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(323, 23);
            this.txtSearch.TabIndex = 16;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(502, 215);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 17;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // rdId
            // 
            this.rdId.AutoSize = true;
            this.rdId.Location = new System.Drawing.Point(186, 255);
            this.rdId.Name = "rdId";
            this.rdId.Size = new System.Drawing.Size(90, 19);
            this.rdId.TabIndex = 18;
            this.rdId.TabStop = true;
            this.rdId.Text = "Search by ID";
            this.rdId.UseVisualStyleBackColor = true;
            this.rdId.CheckedChanged += new System.EventHandler(this.rdID_CheckedChanged);
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Location = new System.Drawing.Point(330, 255);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(111, 19);
            this.rdName.TabIndex = 19;
            this.rdName.TabStop = true;
            this.rdName.Text = "Search by Name";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(355, 482);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 20;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(156, 163);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 21;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.rdName);
            this.Controls.Add(this.rdId);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbMemberId);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCity);
            this.Name = "frmMemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.RadioButton rdId;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btLoad;
    }
}