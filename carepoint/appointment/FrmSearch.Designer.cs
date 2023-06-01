namespace carepoint.PatientSide
{
    partial class FrmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.rdoDoctor = new System.Windows.Forms.RadioButton();
            this.rdoSpecialty = new System.Windows.Forms.RadioButton();
            this.grpSearchCriteria = new System.Windows.Forms.GroupBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cboCriteriaList = new System.Windows.Forms.ComboBox();
            this.cboSearchCriteria = new System.Windows.Forms.Label();
            this.dgvNextAvailabilities = new System.Windows.Forms.DataGridView();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.grpSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextAvailabilities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoDoctor
            // 
            this.rdoDoctor.AutoSize = true;
            this.rdoDoctor.BackColor = System.Drawing.Color.White;
            this.rdoDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.rdoDoctor.Location = new System.Drawing.Point(24, 23);
            this.rdoDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.rdoDoctor.Name = "rdoDoctor";
            this.rdoDoctor.Size = new System.Drawing.Size(121, 33);
            this.rdoDoctor.TabIndex = 0;
            this.rdoDoctor.TabStop = true;
            this.rdoDoctor.Text = "&Doctor";
            this.rdoDoctor.UseVisualStyleBackColor = false;
            this.rdoDoctor.CheckedChanged += new System.EventHandler(this.rdoDoctor_CheckedChanged);
            // 
            // rdoSpecialty
            // 
            this.rdoSpecialty.AutoSize = true;
            this.rdoSpecialty.BackColor = System.Drawing.Color.White;
            this.rdoSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.rdoSpecialty.Location = new System.Drawing.Point(200, 23);
            this.rdoSpecialty.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSpecialty.Name = "rdoSpecialty";
            this.rdoSpecialty.Size = new System.Drawing.Size(151, 33);
            this.rdoSpecialty.TabIndex = 1;
            this.rdoSpecialty.TabStop = true;
            this.rdoSpecialty.Text = "&Specialty";
            this.rdoSpecialty.UseVisualStyleBackColor = false;
            this.rdoSpecialty.CheckedChanged += new System.EventHandler(this.rdoSpecialty_CheckedChanged);
            // 
            // grpSearchCriteria
            // 
            this.grpSearchCriteria.Controls.Add(this.rdoSpecialty);
            this.grpSearchCriteria.Controls.Add(this.rdoDoctor);
            this.grpSearchCriteria.Location = new System.Drawing.Point(24, 81);
            this.grpSearchCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.grpSearchCriteria.Name = "grpSearchCriteria";
            this.grpSearchCriteria.Padding = new System.Windows.Forms.Padding(4);
            this.grpSearchCriteria.Size = new System.Drawing.Size(368, 71);
            this.grpSearchCriteria.TabIndex = 1;
            this.grpSearchCriteria.TabStop = false;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblSearchBy.Location = new System.Drawing.Point(24, 48);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(129, 29);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search by";
            // 
            // cboCriteriaList
            // 
            this.cboCriteriaList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.cboCriteriaList.FormattingEnabled = true;
            this.cboCriteriaList.Location = new System.Drawing.Point(32, 223);
            this.cboCriteriaList.Margin = new System.Windows.Forms.Padding(4);
            this.cboCriteriaList.Name = "cboCriteriaList";
            this.cboCriteriaList.Size = new System.Drawing.Size(360, 33);
            this.cboCriteriaList.TabIndex = 3;
            this.cboCriteriaList.SelectedIndexChanged += new System.EventHandler(this.cboCriteriaList_SelectedIndexChanged);
            // 
            // cboSearchCriteria
            // 
            this.cboSearchCriteria.AutoSize = true;
            this.cboSearchCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchCriteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.cboSearchCriteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboSearchCriteria.Location = new System.Drawing.Point(32, 192);
            this.cboSearchCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cboSearchCriteria.Name = "cboSearchCriteria";
            this.cboSearchCriteria.Size = new System.Drawing.Size(129, 29);
            this.cboSearchCriteria.TabIndex = 2;
            this.cboSearchCriteria.Text = "Searc&h by";
            // 
            // dgvNextAvailabilities
            // 
            this.dgvNextAvailabilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNextAvailabilities.Location = new System.Drawing.Point(32, 352);
            this.dgvNextAvailabilities.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNextAvailabilities.Name = "dgvNextAvailabilities";
            this.dgvNextAvailabilities.RowHeadersWidth = 82;
            this.dgvNextAvailabilities.RowTemplate.Height = 33;
            this.dgvNextAvailabilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNextAvailabilities.Size = new System.Drawing.Size(360, 248);
            this.dgvNextAvailabilities.TabIndex = 5;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblAvailability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAvailability.Location = new System.Drawing.Point(32, 319);
            this.lblAvailability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(161, 29);
            this.lblAvailability.TabIndex = 4;
            this.lblAvailability.Text = "&Availabilities";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(185)))), ((int)(((byte)(192)))));
            this.lblExit.Location = new System.Drawing.Point(184, 646);
            this.lblExit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(53, 26);
            this.lblExit.TabIndex = 6;
            this.lblExit.Text = "&Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // picBook
            // 
            this.picBook.Image = global::carepoint.Properties.Resources.appointment_book;
            this.picBook.Location = new System.Drawing.Point(336, 292);
            this.picBook.Margin = new System.Windows.Forms.Padding(6);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(60, 58);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBook.TabIndex = 9;
            this.picBook.TabStop = false;
            this.picBook.Click += new System.EventHandler(this.picBook_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 698);
            this.Controls.Add(this.picBook);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.dgvNextAvailabilities);
            this.Controls.Add(this.cboSearchCriteria);
            this.Controls.Add(this.cboCriteriaList);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.grpSearchCriteria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearch";
            this.Text = "Search";
            this.grpSearchCriteria.ResumeLayout(false);
            this.grpSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNextAvailabilities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDoctor;
        private System.Windows.Forms.RadioButton rdoSpecialty;
        private System.Windows.Forms.GroupBox grpSearchCriteria;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cboCriteriaList;
        private System.Windows.Forms.Label cboSearchCriteria;
        private System.Windows.Forms.DataGridView dgvNextAvailabilities;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox picBook;
    }
}