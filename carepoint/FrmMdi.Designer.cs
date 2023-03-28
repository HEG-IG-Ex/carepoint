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
            this.tsrAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBook = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMdiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMdiMenu
            // 
            this.mnsMdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrAppointment,
            this.appointmentToolStripMenuItem});
            this.mnsMdiMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMdiMenu.Name = "mnsMdiMenu";
            this.mnsMdiMenu.Size = new System.Drawing.Size(800, 24);
            this.mnsMdiMenu.TabIndex = 1;
            this.mnsMdiMenu.Text = "menuStrip1";
            // 
            // tsrAppointment
            // 
            this.tsrAppointment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBook});
            this.tsrAppointment.Name = "tsrAppointment";
            this.tsrAppointment.Size = new System.Drawing.Size(52, 20);
            this.tsrAppointment.Text = "Home";
            // 
            // tsmiBook
            // 
            this.tsmiBook.Name = "tsmiBook";
            this.tsmiBook.Size = new System.Drawing.Size(180, 22);
            this.tsmiBook.Text = "Open Dashboard";
            this.tsmiBook.Click += new System.EventHandler(this.tsmiBook_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.reviewToolStripMenuItem});
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // reviewToolStripMenuItem
            // 
            this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
            this.reviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reviewToolStripMenuItem.Text = "Review";
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.ToolStripMenuItem tsrAppointment;
        private System.Windows.Forms.ToolStripMenuItem tsmiBook;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewToolStripMenuItem;
    }
}