namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            this.lbMemberID = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(70, 26);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(72, 15);
            this.lbMemberID.TabIndex = 0;
            this.lbMemberID.Text = "Member ID :";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(70, 62);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(93, 15);
            this.lbMemberName.TabIndex = 1;
            this.lbMemberName.Text = "Member Name :";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(70, 98);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(56, 15);
            this.lbCountry.TabIndex = 2;
            this.lbCountry.Text = "Country :";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(387, 26);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 15);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email :";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(387, 62);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(63, 15);
            this.lbPass.TabIndex = 4;
            this.lbPass.Text = "Password :";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(387, 98);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 15);
            this.lbCity.TabIndex = 5;
            this.lbCity.Text = "City :";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(180, 23);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(138, 23);
            this.txtMemberID.TabIndex = 6;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(180, 59);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(138, 23);
            this.txtMemberName.TabIndex = 7;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(180, 95);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(138, 23);
            this.txtCountry.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(461, 23);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(461, 59);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(138, 23);
            this.txtPass.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(461, 95);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(138, 23);
            this.txtCity.TabIndex = 11;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(226, 155);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(387, 155);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // frmMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 237);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbMemberID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMemberDetails";
            this.Text = "Member Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}