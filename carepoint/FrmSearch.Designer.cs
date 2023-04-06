﻿namespace carepoint.PatientSide
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboSearchCriteria = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.grpSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoDoctor
            // 
            this.rdoDoctor.AutoSize = true;
            this.rdoDoctor.Location = new System.Drawing.Point(12, 12);
            this.rdoDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDoctor.Name = "rdoDoctor";
            this.rdoDoctor.Size = new System.Drawing.Size(57, 17);
            this.rdoDoctor.TabIndex = 0;
            this.rdoDoctor.TabStop = true;
            this.rdoDoctor.Text = "&Doctor";
            this.rdoDoctor.UseVisualStyleBackColor = true;
            // 
            // rdoSpecialty
            // 
            this.rdoSpecialty.AutoSize = true;
            this.rdoSpecialty.Location = new System.Drawing.Point(100, 12);
            this.rdoSpecialty.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSpecialty.Name = "rdoSpecialty";
            this.rdoSpecialty.Size = new System.Drawing.Size(68, 17);
            this.rdoSpecialty.TabIndex = 1;
            this.rdoSpecialty.TabStop = true;
            this.rdoSpecialty.Text = "&Specialty";
            this.rdoSpecialty.UseVisualStyleBackColor = true;
            // 
            // grpSearchCriteria
            // 
            this.grpSearchCriteria.Controls.Add(this.rdoSpecialty);
            this.grpSearchCriteria.Controls.Add(this.rdoDoctor);
            this.grpSearchCriteria.Location = new System.Drawing.Point(12, 42);
            this.grpSearchCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.grpSearchCriteria.Name = "grpSearchCriteria";
            this.grpSearchCriteria.Padding = new System.Windows.Forms.Padding(2);
            this.grpSearchCriteria.Size = new System.Drawing.Size(184, 37);
            this.grpSearchCriteria.TabIndex = 1;
            this.grpSearchCriteria.TabStop = false;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(12, 25);
            this.lblSearchBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(55, 13);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "Search by";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 116);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // cboSearchCriteria
            // 
            this.cboSearchCriteria.AutoSize = true;
            this.cboSearchCriteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboSearchCriteria.Location = new System.Drawing.Point(16, 100);
            this.cboSearchCriteria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cboSearchCriteria.Name = "cboSearchCriteria";
            this.cboSearchCriteria.Size = new System.Drawing.Size(55, 13);
            this.cboSearchCriteria.TabIndex = 2;
            this.cboSearchCriteria.Text = "Searc&h by";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 183);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(180, 129);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(68, 329);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 21);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cance&l";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAvailability.Location = new System.Drawing.Point(16, 166);
            this.lblAvailability.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(64, 13);
            this.lblAvailability.TabIndex = 4;
            this.lblAvailability.Text = "&Availabilities";
            // 
            // btnBook
            // 
            this.btnBook.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBook.Location = new System.Drawing.Point(144, 160);
            this.btnBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(52, 21);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "&Book !";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(212, 363);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboSearchCriteria);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.grpSearchCriteria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearch";
            this.Text = "Search";
            this.grpSearchCriteria.ResumeLayout(false);
            this.grpSearchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoDoctor;
        private System.Windows.Forms.RadioButton rdoSpecialty;
        private System.Windows.Forms.GroupBox grpSearchCriteria;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cboSearchCriteria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button btnBook;
    }
}