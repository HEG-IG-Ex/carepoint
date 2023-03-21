namespace carepoint
{
    partial class frmRegister
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
            this.lblCieName = new System.Windows.Forms.Label();
            this.lblDivider = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCieName
            // 
            this.lblCieName.AutoSize = true;
            this.lblCieName.Location = new System.Drawing.Point(176, 24);
            this.lblCieName.Name = "lblCieName";
            this.lblCieName.Size = new System.Drawing.Size(105, 25);
            this.lblCieName.TabIndex = 14;
            this.lblCieName.Text = "Carepoint";
            // 
            // lblDivider
            // 
            this.lblDivider.BackColor = System.Drawing.Color.Black;
            this.lblDivider.Location = new System.Drawing.Point(-8, 72);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(500, 1);
            this.lblDivider.TabIndex = 13;
            this.lblDivider.Text = "label1";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(168, 792);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(128, 56);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(87, 208);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(107, 25);
            this.lblFirstname.TabIndex = 11;
            this.lblFirstname.Text = "Firstname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(87, 240);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(300, 31);
            this.txtFirstname.TabIndex = 10;
            this.txtFirstname.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(87, 152);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 31);
            this.txtUsername.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(87, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(87, 392);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 25);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(87, 424);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 31);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.UseSystemPasswordChar = true;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(87, 336);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(300, 31);
            this.txtLastname.TabIndex = 16;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(87, 304);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(106, 25);
            this.lblLastname.TabIndex = 15;
            this.lblLastname.Text = "Lastname";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 536);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 31);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(88, 504);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-mail";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 878);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblCieName);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCieName;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}