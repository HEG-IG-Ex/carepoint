namespace carepoint
{
    partial class FrmMdi
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
            this.mnsMdiMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAvailabilities = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStats = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiServices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMedications = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnsMdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMdiMenu
            // 
            this.mnsMdiMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnsMdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHome,
            this.tsmiApp,
            this.tsmiAdmin});
            this.mnsMdiMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMdiMenu.Name = "mnsMdiMenu";
            this.mnsMdiMenu.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.mnsMdiMenu.Size = new System.Drawing.Size(752, 24);
            this.mnsMdiMenu.TabIndex = 0;
            this.mnsMdiMenu.Text = "menuStrip1";
            // 
            // tsmiHome
            // 
            this.tsmiHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDashboard});
            this.tsmiHome.Name = "tsmiHome";
            this.tsmiHome.Size = new System.Drawing.Size(52, 22);
            this.tsmiHome.Text = "&Home";
            // 
            // tsmiDashboard
            // 
            this.tsmiDashboard.Name = "tsmiDashboard";
            this.tsmiDashboard.Size = new System.Drawing.Size(163, 22);
            this.tsmiDashboard.Text = "Open Dashboard";
            this.tsmiDashboard.Click += new System.EventHandler(this.tsmiDashboard_Click);
            // 
            // tsmiApp
            // 
            this.tsmiApp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBook,
            this.tsmiAvailabilities});
            this.tsmiApp.Name = "tsmiApp";
            this.tsmiApp.Size = new System.Drawing.Size(90, 22);
            this.tsmiApp.Text = "&Appointment";
            // 
            // tsmiBook
            // 
            this.tsmiBook.Name = "tsmiBook";
            this.tsmiBook.Size = new System.Drawing.Size(180, 22);
            this.tsmiBook.Text = "&Book";
            this.tsmiBook.Click += new System.EventHandler(this.tsmiBook_Click);
            // 
            // tsmiAvailabilities
            // 
            this.tsmiAvailabilities.Name = "tsmiAvailabilities";
            this.tsmiAvailabilities.Size = new System.Drawing.Size(180, 22);
            this.tsmiAvailabilities.Text = "A&vailabilities";
            this.tsmiAvailabilities.Click += new System.EventHandler(this.tsmiAvailabilities_Click);
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStats,
            this.tsmiDocs,
            this.tsmiServices,
            this.tsmiMedications});
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(98, 22);
            this.tsmiAdmin.Text = "A&dministration";
            this.tsmiAdmin.Visible = false;
            // 
            // tsmiStats
            // 
            this.tsmiStats.Name = "tsmiStats";
            this.tsmiStats.Size = new System.Drawing.Size(139, 22);
            this.tsmiStats.Text = "&Statistics";
            // 
            // tsmiDocs
            // 
            this.tsmiDocs.Name = "tsmiDocs";
            this.tsmiDocs.Size = new System.Drawing.Size(139, 22);
            this.tsmiDocs.Text = "&Doctors";
            // 
            // tsmiServices
            // 
            this.tsmiServices.Name = "tsmiServices";
            this.tsmiServices.Size = new System.Drawing.Size(139, 22);
            this.tsmiServices.Text = "Ser&vices";
            // 
            // tsmiMedications
            // 
            this.tsmiMedications.Name = "tsmiMedications";
            this.tsmiMedications.Size = new System.Drawing.Size(139, 22);
            this.tsmiMedications.Text = "&Medications";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.mnsMdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMdiMenu;
            this.Name = "FrmMdi";
            this.Text = "Carepoint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsMdiMenu.ResumeLayout(false);
            this.mnsMdiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMdiMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHome;
        private System.Windows.Forms.ToolStripMenuItem tsmiDashboard;
        private System.Windows.Forms.ToolStripMenuItem tsmiApp;
        private System.Windows.Forms.ToolStripMenuItem tsmiBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiStats;
        private System.Windows.Forms.ToolStripMenuItem tsmiDocs;
        private System.Windows.Forms.ToolStripMenuItem tsmiServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiMedications;
        private System.Windows.Forms.ToolStripMenuItem tsmiAvailabilities;
    }
}