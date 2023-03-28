namespace carepoint
{
    partial class FrmDashboard
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
            this.tabPastApp = new System.Windows.Forms.TabControl();
            this.tpNextApp = new System.Windows.Forms.TabPage();
            this.dgvNextApp = new System.Windows.Forms.DataGridView();
            this.tpPastApp = new System.Windows.Forms.TabPage();
            this.dgvPastApp = new System.Windows.Forms.DataGridView();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabPastApp.SuspendLayout();
            this.tpNextApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextApp)).BeginInit();
            this.tpPastApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastApp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPastApp
            // 
            this.tabPastApp.Controls.Add(this.tpNextApp);
            this.tabPastApp.Controls.Add(this.tpPastApp);
            this.tabPastApp.Location = new System.Drawing.Point(34, 80);
            this.tabPastApp.Name = "tabPastApp";
            this.tabPastApp.SelectedIndex = 0;
            this.tabPastApp.Size = new System.Drawing.Size(736, 288);
            this.tabPastApp.TabIndex = 0;
            // 
            // tpNextApp
            // 
            this.tpNextApp.Controls.Add(this.dgvNextApp);
            this.tpNextApp.Location = new System.Drawing.Point(4, 22);
            this.tpNextApp.Name = "tpNextApp";
            this.tpNextApp.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpNextApp.Size = new System.Drawing.Size(728, 262);
            this.tpNextApp.TabIndex = 0;
            this.tpNextApp.Text = "Next Appointment";
            this.tpNextApp.UseVisualStyleBackColor = true;
            // 
            // dgvNextApp
            // 
            this.dgvNextApp.BackgroundColor = System.Drawing.Color.White;
            this.dgvNextApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextApp.Location = new System.Drawing.Point(16, 37);
            this.dgvNextApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNextApp.Name = "dgvNextApp";
            this.dgvNextApp.RowHeadersWidth = 82;
            this.dgvNextApp.RowTemplate.Height = 33;
            this.dgvNextApp.Size = new System.Drawing.Size(692, 212);
            this.dgvNextApp.TabIndex = 1;
            // 
            // tpPastApp
            // 
            this.tpPastApp.Controls.Add(this.dgvPastApp);
            this.tpPastApp.Location = new System.Drawing.Point(4, 22);
            this.tpPastApp.Name = "tpPastApp";
            this.tpPastApp.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpPastApp.Size = new System.Drawing.Size(728, 262);
            this.tpPastApp.TabIndex = 1;
            this.tpPastApp.Text = "Past Appointment";
            this.tpPastApp.UseVisualStyleBackColor = true;
            // 
            // dgvPastApp
            // 
            this.dgvPastApp.BackgroundColor = System.Drawing.Color.White;
            this.dgvPastApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastApp.Location = new System.Drawing.Point(16, 37);
            this.dgvPastApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPastApp.Name = "dgvPastApp";
            this.dgvPastApp.RowHeadersWidth = 82;
            this.dgvPastApp.RowTemplate.Height = 33;
            this.dgvPastApp.Size = new System.Drawing.Size(692, 212);
            this.dgvPastApp.TabIndex = 0;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(600, 32);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(163, 23);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book an Apppointment !";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(40, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(121, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome <Username> !";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 387);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.tabPastApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.tabPastApp.ResumeLayout(false);
            this.tpNextApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextApp)).EndInit();
            this.tpPastApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPastApp;
        private System.Windows.Forms.TabPage tpNextApp;
        private System.Windows.Forms.TabPage tpPastApp;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvPastApp;
        private System.Windows.Forms.DataGridView dgvNextApp;
    }
}