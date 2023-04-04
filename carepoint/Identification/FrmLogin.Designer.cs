namespace carepoint
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.lblPsw = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llbResetPsw = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCieName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(88, 119);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "&Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(88, 152);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 31);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(88, 240);
            this.txtPsw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(300, 31);
            this.txtPsw.TabIndex = 5;
            this.txtPsw.UseSystemPasswordChar = true;
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Location = new System.Drawing.Point(88, 208);
            this.lblPsw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(106, 25);
            this.lblPsw.TabIndex = 4;
            this.lblPsw.Text = "&Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(176, 344);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 56);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // llbResetPsw
            // 
            this.llbResetPsw.AutoSize = true;
            this.llbResetPsw.Location = new System.Drawing.Point(88, 281);
            this.llbResetPsw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbResetPsw.Name = "llbResetPsw";
            this.llbResetPsw.Size = new System.Drawing.Size(190, 25);
            this.llbResetPsw.TabIndex = 6;
            this.llbResetPsw.TabStop = true;
            this.llbResetPsw.Text = "&Forgot password ?";
            this.llbResetPsw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbResetPsw_LinkClicked);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-8, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 2);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 429);
            this.Controls.Add(this.lblCieName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llbResetPsw);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llbResetPsw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCieName;
    }
}

