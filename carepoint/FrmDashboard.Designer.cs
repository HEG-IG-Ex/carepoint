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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.tabPastApp = new System.Windows.Forms.TabControl();
            this.tpNextApp = new System.Windows.Forms.TabPage();
            this.dgvNextApp = new System.Windows.Forms.DataGridView();
            this.cmsApp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tpPastApp = new System.Windows.Forms.TabPage();
            this.dgvPastApp = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.tabPastApp.SuspendLayout();
            this.tpNextApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextApp)).BeginInit();
            this.cmsApp.SuspendLayout();
            this.tpPastApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPastApp
            // 
            this.tabPastApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPastApp.Controls.Add(this.tpNextApp);
            this.tabPastApp.Controls.Add(this.tpPastApp);
            this.tabPastApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPastApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPastApp.Location = new System.Drawing.Point(32, 80);
            this.tabPastApp.Name = "tabPastApp";
            this.tabPastApp.SelectedIndex = 0;
            this.tabPastApp.Size = new System.Drawing.Size(678, 288);
            this.tabPastApp.TabIndex = 2;
            // 
            // tpNextApp
            // 
            this.tpNextApp.Controls.Add(this.dgvNextApp);
            this.tpNextApp.Location = new System.Drawing.Point(4, 24);
            this.tpNextApp.Name = "tpNextApp";
            this.tpNextApp.Padding = new System.Windows.Forms.Padding(3);
            this.tpNextApp.Size = new System.Drawing.Size(670, 260);
            this.tpNextApp.TabIndex = 0;
            this.tpNextApp.Text = "Next Appointment";
            this.tpNextApp.UseVisualStyleBackColor = true;
            // 
            // dgvNextApp
            // 
            this.dgvNextApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNextApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNextApp.BackgroundColor = System.Drawing.Color.White;
            this.dgvNextApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextApp.ContextMenuStrip = this.cmsApp;
            this.dgvNextApp.Location = new System.Drawing.Point(16, 37);
            this.dgvNextApp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNextApp.Name = "dgvNextApp";
            this.dgvNextApp.ReadOnly = true;
            this.dgvNextApp.RowHeadersWidth = 82;
            this.dgvNextApp.RowTemplate.Height = 33;
            this.dgvNextApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNextApp.Size = new System.Drawing.Size(634, 210);
            this.dgvNextApp.TabIndex = 0;
            this.dgvNextApp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNextApp_CellDoubleClick);
            this.dgvNextApp.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNextApp_CellMouseDown);
            // 
            // cmsApp
            // 
            this.cmsApp.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsApp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiCancel});
            this.cmsApp.Name = "cmsApp";
            this.cmsApp.Size = new System.Drawing.Size(111, 48);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(110, 22);
            this.tsmiOpen.Text = "&Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(110, 22);
            this.tsmiCancel.Text = "Cance&l";
            this.tsmiCancel.Click += new System.EventHandler(this.tsmiCancel_Click);
            // 
            // tpPastApp
            // 
            this.tpPastApp.Controls.Add(this.dgvPastApp);
            this.tpPastApp.Location = new System.Drawing.Point(4, 24);
            this.tpPastApp.Name = "tpPastApp";
            this.tpPastApp.Padding = new System.Windows.Forms.Padding(3);
            this.tpPastApp.Size = new System.Drawing.Size(670, 260);
            this.tpPastApp.TabIndex = 1;
            this.tpPastApp.Text = "Past Appointment";
            this.tpPastApp.UseVisualStyleBackColor = true;
            // 
            // dgvPastApp
            // 
            this.dgvPastApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPastApp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPastApp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPastApp.BackgroundColor = System.Drawing.Color.White;
            this.dgvPastApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastApp.Location = new System.Drawing.Point(16, 37);
            this.dgvPastApp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPastApp.Name = "dgvPastApp";
            this.dgvPastApp.ReadOnly = true;
            this.dgvPastApp.RowHeadersWidth = 82;
            this.dgvPastApp.RowTemplate.Height = 33;
            this.dgvPastApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPastApp.Size = new System.Drawing.Size(692, 210);
            this.dgvPastApp.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblWelcome.Location = new System.Drawing.Point(40, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(80, 18);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome,";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(136)))), ((int)(((byte)(171)))));
            this.lblUsername.Location = new System.Drawing.Point(131, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 18);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "<User Name>";
            // 
            // picBook
            // 
            this.picBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBook.Image = global::carepoint.Properties.Resources.appointment_book;
            this.picBook.Location = new System.Drawing.Point(640, 16);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(50, 50);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBook.TabIndex = 5;
            this.picBook.TabStop = false;
            this.picBook.Click += new System.EventHandler(this.picBook_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 387);
            this.Controls.Add(this.picBook);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.tabPastApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(747, 381);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.tabPastApp.ResumeLayout(false);
            this.tpNextApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextApp)).EndInit();
            this.cmsApp.ResumeLayout(false);
            this.tpPastApp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabPastApp;
        private System.Windows.Forms.TabPage tpNextApp;
        private System.Windows.Forms.TabPage tpPastApp;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvPastApp;
        private System.Windows.Forms.DataGridView dgvNextApp;
        private System.Windows.Forms.ContextMenuStrip cmsApp;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
    }
}