namespace carepoint
{
    partial class frmLogin
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_psw = new System.Windows.Forms.TextBox();
            this.lbl_psw = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.llb_reset_psw = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cie_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(88, 120);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(110, 25);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(88, 152);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(300, 31);
            this.txt_username.TabIndex = 1;
            // 
            // txt_psw
            // 
            this.txt_psw.Location = new System.Drawing.Point(88, 240);
            this.txt_psw.Name = "txt_psw";
            this.txt_psw.Size = new System.Drawing.Size(300, 31);
            this.txt_psw.TabIndex = 2;
            this.txt_psw.UseSystemPasswordChar = true;
            // 
            // lbl_psw
            // 
            this.lbl_psw.AutoSize = true;
            this.lbl_psw.Location = new System.Drawing.Point(88, 208);
            this.lbl_psw.Name = "lbl_psw";
            this.lbl_psw.Size = new System.Drawing.Size(106, 25);
            this.lbl_psw.TabIndex = 3;
            this.lbl_psw.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(176, 344);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(128, 56);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // llb_reset_psw
            // 
            this.llb_reset_psw.AutoSize = true;
            this.llb_reset_psw.Location = new System.Drawing.Point(88, 280);
            this.llb_reset_psw.Name = "llb_reset_psw";
            this.llb_reset_psw.Size = new System.Drawing.Size(190, 25);
            this.llb_reset_psw.TabIndex = 5;
            this.llb_reset_psw.TabStop = true;
            this.llb_reset_psw.Text = "Forgot password ?";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 1);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // lbl_cie_name
            // 
            this.lbl_cie_name.AutoSize = true;
            this.lbl_cie_name.Location = new System.Drawing.Point(176, 24);
            this.lbl_cie_name.Name = "lbl_cie_name";
            this.lbl_cie_name.Size = new System.Drawing.Size(105, 25);
            this.lbl_cie_name.TabIndex = 7;
            this.lbl_cie_name.Text = "Carepoint";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 429);
            this.Controls.Add(this.lbl_cie_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llb_reset_psw);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_psw);
            this.Controls.Add(this.txt_psw);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_psw;
        private System.Windows.Forms.Label lbl_psw;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel llb_reset_psw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cie_name;
    }
}

