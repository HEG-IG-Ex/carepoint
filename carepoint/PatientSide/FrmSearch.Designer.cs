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
            this.rdoDoctor = new System.Windows.Forms.RadioButton();
            this.rdoSpecialty = new System.Windows.Forms.RadioButton();
            this.grpSearchCriteria = new System.Windows.Forms.GroupBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboSearchCriteria = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.grpSearchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoDoctor
            // 
            this.rdoDoctor.AutoSize = true;
            this.rdoDoctor.Location = new System.Drawing.Point(24, 24);
            this.rdoDoctor.Name = "rdoDoctor";
            this.rdoDoctor.Size = new System.Drawing.Size(106, 29);
            this.rdoDoctor.TabIndex = 0;
            this.rdoDoctor.TabStop = true;
            this.rdoDoctor.Text = "Doctor";
            this.rdoDoctor.UseVisualStyleBackColor = true;
            // 
            // rdoSpecialty
            // 
            this.rdoSpecialty.AutoSize = true;
            this.rdoSpecialty.Location = new System.Drawing.Point(200, 24);
            this.rdoSpecialty.Name = "rdoSpecialty";
            this.rdoSpecialty.Size = new System.Drawing.Size(131, 29);
            this.rdoSpecialty.TabIndex = 1;
            this.rdoSpecialty.TabStop = true;
            this.rdoSpecialty.Text = "Specialty";
            this.rdoSpecialty.UseVisualStyleBackColor = true;
            // 
            // grpSearchCriteria
            // 
            this.grpSearchCriteria.Controls.Add(this.rdoSpecialty);
            this.grpSearchCriteria.Controls.Add(this.rdoDoctor);
            this.grpSearchCriteria.Location = new System.Drawing.Point(24, 80);
            this.grpSearchCriteria.Name = "grpSearchCriteria";
            this.grpSearchCriteria.Size = new System.Drawing.Size(368, 72);
            this.grpSearchCriteria.TabIndex = 2;
            this.grpSearchCriteria.TabStop = false;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Location = new System.Drawing.Point(24, 48);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(109, 25);
            this.lblSearchBy.TabIndex = 3;
            this.lblSearchBy.Text = "Search by";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // cboSearchCriteria
            // 
            this.cboSearchCriteria.AutoSize = true;
            this.cboSearchCriteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboSearchCriteria.Location = new System.Drawing.Point(32, 192);
            this.cboSearchCriteria.Name = "cboSearchCriteria";
            this.cboSearchCriteria.Size = new System.Drawing.Size(109, 25);
            this.cboSearchCriteria.TabIndex = 5;
            this.cboSearchCriteria.Text = "Search by";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(360, 248);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(136, 632);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAvailability.Location = new System.Drawing.Point(32, 320);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(132, 25);
            this.lblAvailability.TabIndex = 8;
            this.lblAvailability.Text = "Availabilities";
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 699);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboSearchCriteria);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.grpSearchCriteria);
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
    }
}