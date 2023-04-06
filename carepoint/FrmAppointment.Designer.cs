namespace carepoint
{
    partial class FrmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppointment));
            this.lblAppOf = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAt = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblWith = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblSpecializedIn = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cklServices = new System.Windows.Forms.CheckedListBox();
            this.cklMedications = new System.Windows.Forms.CheckedListBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblMedications = new System.Windows.Forms.Label();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.txtSearchServices = new System.Windows.Forms.TextBox();
            this.txtSearchMedications = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReopen = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAppOf
            // 
            this.lblAppOf.AutoSize = true;
            this.lblAppOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppOf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblAppOf.Location = new System.Drawing.Point(21, 28);
            this.lblAppOf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppOf.Name = "lblAppOf";
            this.lblAppOf.Size = new System.Drawing.Size(119, 15);
            this.lblAppOf.TabIndex = 0;
            this.lblAppOf.Text = "Apointment of the";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(171, 28);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "<DATE>";
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblAt.Location = new System.Drawing.Point(267, 28);
            this.lblAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(19, 15);
            this.lblAt.TabIndex = 2;
            this.lblAt.Text = "at";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.Black;
            this.lblHours.Location = new System.Drawing.Point(309, 28);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(72, 15);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "<HOURS>";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(491, 28);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "<STATUS>";
            // 
            // lblWith
            // 
            this.lblWith.AutoSize = true;
            this.lblWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWith.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblWith.Location = new System.Drawing.Point(21, 74);
            this.lblWith.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(35, 15);
            this.lblWith.TabIndex = 5;
            this.lblWith.Text = "With";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.Black;
            this.lblDoctor.Location = new System.Drawing.Point(85, 74);
            this.lblDoctor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(80, 15);
            this.lblDoctor.TabIndex = 6;
            this.lblDoctor.Text = "<DOCTOR>";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialty.ForeColor = System.Drawing.Color.Black;
            this.lblSpecialty.Location = new System.Drawing.Point(320, 74);
            this.lblSpecialty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(81, 15);
            this.lblSpecialty.TabIndex = 8;
            this.lblSpecialty.Text = "<Specialty>";
            // 
            // lblSpecializedIn
            // 
            this.lblSpecializedIn.AutoSize = true;
            this.lblSpecializedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecializedIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblSpecializedIn.Location = new System.Drawing.Point(203, 74);
            this.lblSpecializedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecializedIn.Name = "lblSpecializedIn";
            this.lblSpecializedIn.Size = new System.Drawing.Size(96, 15);
            this.lblSpecializedIn.TabIndex = 7;
            this.lblSpecializedIn.Text = "specialized in";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(544, 65);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cance&l";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Location = new System.Drawing.Point(469, 65);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(64, 28);
            this.btnCloseApp.TabIndex = 9;
            this.btnCloseApp.Text = "&Close";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // lblDivider
            // 
            this.lblDivider.BackColor = System.Drawing.Color.Black;
            this.lblDivider.Location = new System.Drawing.Point(-11, 120);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(651, 1);
            this.lblDivider.TabIndex = 11;
            this.lblDivider.Text = "label10";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblDescription.Location = new System.Drawing.Point(21, 148);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 15);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "&Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(21, 175);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(596, 101);
            this.txtDescription.TabIndex = 13;
            // 
            // cklServices
            // 
            this.cklServices.FormattingEnabled = true;
            this.cklServices.Location = new System.Drawing.Point(21, 369);
            this.cklServices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cklServices.Name = "cklServices";
            this.cklServices.Size = new System.Drawing.Size(287, 100);
            this.cklServices.TabIndex = 16;
            // 
            // cklMedications
            // 
            this.cklMedications.FormattingEnabled = true;
            this.cklMedications.Location = new System.Drawing.Point(331, 369);
            this.cklMedications.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cklMedications.Name = "cklMedications";
            this.cklMedications.Size = new System.Drawing.Size(287, 100);
            this.cklMedications.TabIndex = 20;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblServices.Location = new System.Drawing.Point(21, 314);
            this.lblServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(61, 15);
            this.lblServices.TabIndex = 14;
            this.lblServices.Text = "&Services";
            // 
            // lblMedications
            // 
            this.lblMedications.AutoSize = true;
            this.lblMedications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblMedications.Location = new System.Drawing.Point(341, 314);
            this.lblMedications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedications.Name = "lblMedications";
            this.lblMedications.Size = new System.Drawing.Size(85, 15);
            this.lblMedications.TabIndex = 18;
            this.lblMedications.Text = "&Medications";
            // 
            // btnPrescription
            // 
            this.btnPrescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.btnPrescription.FlatAppearance.BorderSize = 0;
            this.btnPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrescription.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescription.ForeColor = System.Drawing.Color.White;
            this.btnPrescription.Location = new System.Drawing.Point(533, 305);
            this.btnPrescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(85, 28);
            this.btnPrescription.TabIndex = 21;
            this.btnPrescription.Text = "&Prescrition";
            this.btnPrescription.UseVisualStyleBackColor = false;
            this.btnPrescription.Visible = false;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(213, 305);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(85, 28);
            this.btnInvoice.TabIndex = 17;
            this.btnInvoice.Text = "&Invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Visible = false;
            // 
            // txtSearchServices
            // 
            this.txtSearchServices.Location = new System.Drawing.Point(21, 342);
            this.txtSearchServices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchServices.Name = "txtSearchServices";
            this.txtSearchServices.Size = new System.Drawing.Size(287, 21);
            this.txtSearchServices.TabIndex = 15;
            // 
            // txtSearchMedications
            // 
            this.txtSearchMedications.Location = new System.Drawing.Point(331, 342);
            this.txtSearchMedications.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchMedications.Name = "txtSearchMedications";
            this.txtSearchMedications.Size = new System.Drawing.Size(287, 21);
            this.txtSearchMedications.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(96, 488);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 28);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReopen
            // 
            this.btnReopen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.btnReopen.FlatAppearance.BorderSize = 0;
            this.btnReopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReopen.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReopen.ForeColor = System.Drawing.Color.White;
            this.btnReopen.Location = new System.Drawing.Point(491, 65);
            this.btnReopen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(75, 28);
            this.btnReopen.TabIndex = 22;
            this.btnReopen.Text = "Re&open";
            this.btnReopen.UseVisualStyleBackColor = false;
            this.btnReopen.Visible = false;
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(395, 488);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(139, 28);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "Con&firm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmAppointment
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(640, 530);
            this.Controls.Add(this.btnReopen);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearchMedications);
            this.Controls.Add(this.txtSearchServices);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.lblMedications);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.cklMedications);
            this.Controls.Add(this.cklServices);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSpecializedIn);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblWith);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblAt);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAppOf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAppointment";
            this.Text = "Appointment Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppOf;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAt;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblWith;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblSpecializedIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckedListBox cklServices;
        private System.Windows.Forms.CheckedListBox cklMedications;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblMedications;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.TextBox txtSearchServices;
        private System.Windows.Forms.TextBox txtSearchMedications;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReopen;
        private System.Windows.Forms.Button btnConfirm;
    }
}