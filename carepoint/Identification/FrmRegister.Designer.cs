﻿namespace carepoint
{
    partial class FrmRegister
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
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.cboInsurance = new System.Windows.Forms.ComboBox();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpDoctor = new System.Windows.Forms.GroupBox();
            this.lblSpecialties = new System.Windows.Forms.Label();
            this.cklSpecialties = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFlatFee = new System.Windows.Forms.Label();
            this.grpPatient.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCieName
            // 
            this.lblCieName.AutoSize = true;
            this.lblCieName.Location = new System.Drawing.Point(176, 23);
            this.lblCieName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCieName.Name = "lblCieName";
            this.lblCieName.Size = new System.Drawing.Size(105, 25);
            this.lblCieName.TabIndex = 0;
            this.lblCieName.Text = "Carepoint";
            // 
            // lblDivider
            // 
            this.lblDivider.BackColor = System.Drawing.Color.Black;
            this.lblDivider.Location = new System.Drawing.Point(-8, 71);
            this.lblDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(500, 2);
            this.lblDivider.TabIndex = 1;
            this.lblDivider.Text = "label1";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(160, 1077);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(128, 56);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpPatient
            // 
            this.grpPatient.Controls.Add(this.cboInsurance);
            this.grpPatient.Controls.Add(this.lblInsurance);
            this.grpPatient.Location = new System.Drawing.Point(40, 631);
            this.grpPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPatient.Size = new System.Drawing.Size(384, 177);
            this.grpPatient.TabIndex = 3;
            this.grpPatient.TabStop = false;
            this.grpPatient.Visible = false;
            // 
            // cboInsurance
            // 
            this.cboInsurance.FormattingEnabled = true;
            this.cboInsurance.Location = new System.Drawing.Point(42, 92);
            this.cboInsurance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboInsurance.Name = "cboInsurance";
            this.cboInsurance.Size = new System.Drawing.Size(300, 33);
            this.cboInsurance.TabIndex = 1;
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(42, 50);
            this.lblInsurance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(106, 25);
            this.lblInsurance.TabIndex = 0;
            this.lblInsurance.Text = "&Insurance";
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.lblEmail);
            this.grpContact.Controls.Add(this.lblPhone);
            this.grpContact.Controls.Add(this.txtPhone);
            this.grpContact.Controls.Add(this.txtLastname);
            this.grpContact.Controls.Add(this.lblLastname);
            this.grpContact.Controls.Add(this.lblFirstname);
            this.grpContact.Controls.Add(this.txtFirstname);
            this.grpContact.Controls.Add(this.txtUsername);
            this.grpContact.Controls.Add(this.lblUsername);
            this.grpContact.Location = new System.Drawing.Point(40, 88);
            this.grpContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpContact.Name = "grpContact";
            this.grpContact.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpContact.Size = new System.Drawing.Size(384, 519);
            this.grpContact.TabIndex = 2;
            this.grpContact.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(44, 450);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 31);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 408);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "&E-mail";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(42, 315);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 25);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "&Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(42, 358);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 31);
            this.txtPhone.TabIndex = 7;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(42, 265);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(300, 31);
            this.txtLastname.TabIndex = 5;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(42, 223);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(106, 25);
            this.lblLastname.TabIndex = 4;
            this.lblLastname.Text = "&Lastname";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(42, 131);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(107, 25);
            this.lblFirstname.TabIndex = 2;
            this.lblFirstname.Text = "&Firstname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(42, 173);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(300, 31);
            this.txtFirstname.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(42, 83);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 31);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(42, 38);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "&Username";
            // 
            // grpDoctor
            // 
            this.grpDoctor.Controls.Add(this.lblSpecialties);
            this.grpDoctor.Controls.Add(this.cklSpecialties);
            this.grpDoctor.Controls.Add(this.textBox1);
            this.grpDoctor.Controls.Add(this.lblFlatFee);
            this.grpDoctor.Location = new System.Drawing.Point(40, 631);
            this.grpDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDoctor.Name = "grpDoctor";
            this.grpDoctor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpDoctor.Size = new System.Drawing.Size(384, 415);
            this.grpDoctor.TabIndex = 4;
            this.grpDoctor.TabStop = false;
            this.grpDoctor.Visible = false;
            // 
            // lblSpecialties
            // 
            this.lblSpecialties.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblSpecialties.AutoSize = true;
            this.lblSpecialties.Location = new System.Drawing.Point(40, 144);
            this.lblSpecialties.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialties.Name = "lblSpecialties";
            this.lblSpecialties.Size = new System.Drawing.Size(117, 25);
            this.lblSpecialties.TabIndex = 2;
            this.lblSpecialties.Text = "&Specialties";
            // 
            // cklSpecialties
            // 
            this.cklSpecialties.FormattingEnabled = true;
            this.cklSpecialties.Location = new System.Drawing.Point(40, 192);
            this.cklSpecialties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cklSpecialties.Name = "cklSpecialties";
            this.cklSpecialties.Size = new System.Drawing.Size(304, 172);
            this.cklSpecialties.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.textBox1.Location = new System.Drawing.Point(42, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 31);
            this.textBox1.TabIndex = 1;
            // 
            // lblFlatFee
            // 
            this.lblFlatFee.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.lblFlatFee.AutoSize = true;
            this.lblFlatFee.Location = new System.Drawing.Point(42, 52);
            this.lblFlatFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlatFee.Name = "lblFlatFee";
            this.lblFlatFee.Size = new System.Drawing.Size(254, 25);
            this.lblFlatFee.TabIndex = 0;
            this.lblFlatFee.Text = "Flat Fee per &Appointment";
            // 
            // FrmRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 1160);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpPatient);
            this.Controls.Add(this.lblCieName);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpDoctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRegister";
            this.Text = "Register";
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpDoctor.ResumeLayout(false);
            this.grpDoctor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCieName;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.ComboBox cboInsurance;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox grpDoctor;
        private System.Windows.Forms.Label lblSpecialties;
        private System.Windows.Forms.CheckedListBox cklSpecialties;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFlatFee;
    }
}