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
            this.lblAppOf.Location = new System.Drawing.Point(32, 46);
            this.lblAppOf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAppOf.Name = "lblAppOf";
            this.lblAppOf.Size = new System.Drawing.Size(180, 25);
            this.lblAppOf.TabIndex = 0;
            this.lblAppOf.Text = "Apointment of the";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(256, 46);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "<DATE>";
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Location = new System.Drawing.Point(400, 46);
            this.lblAt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAt.Name = "lblAt";
            this.lblAt.Size = new System.Drawing.Size(30, 25);
            this.lblAt.TabIndex = 2;
            this.lblAt.Text = "at";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(464, 46);
            this.lblHours.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(111, 25);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "<HOURS>";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(736, 46);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(119, 25);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "<STATUS>";
            // 
            // lblWith
            // 
            this.lblWith.AutoSize = true;
            this.lblWith.Location = new System.Drawing.Point(32, 123);
            this.lblWith.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWith.Name = "lblWith";
            this.lblWith.Size = new System.Drawing.Size(55, 25);
            this.lblWith.TabIndex = 5;
            this.lblWith.Text = "With";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(128, 123);
            this.lblDoctor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(126, 25);
            this.lblDoctor.TabIndex = 6;
            this.lblDoctor.Text = "<DOCTOR>";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(480, 123);
            this.lblSpecialty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(124, 25);
            this.lblSpecialty.TabIndex = 8;
            this.lblSpecialty.Text = "<Specialty>";
            // 
            // lblSpecializedIn
            // 
            this.lblSpecializedIn.AutoSize = true;
            this.lblSpecializedIn.Location = new System.Drawing.Point(304, 123);
            this.lblSpecializedIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpecializedIn.Name = "lblSpecializedIn";
            this.lblSpecializedIn.Size = new System.Drawing.Size(143, 25);
            this.lblSpecializedIn.TabIndex = 7;
            this.lblSpecializedIn.Text = "specialized in";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(816, 108);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 46);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cance&l";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Location = new System.Drawing.Point(704, 108);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(96, 46);
            this.btnCloseApp.TabIndex = 9;
            this.btnCloseApp.Text = "&Close";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // lblDivider
            // 
            this.lblDivider.BackColor = System.Drawing.Color.Black;
            this.lblDivider.Location = new System.Drawing.Point(-16, 200);
            this.lblDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(976, 2);
            this.lblDivider.TabIndex = 11;
            this.lblDivider.Text = "label10";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(32, 246);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 25);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "&Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(32, 292);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(892, 166);
            this.txtDescription.TabIndex = 13;
            // 
            // cklServices
            // 
            this.cklServices.FormattingEnabled = true;
            this.cklServices.Location = new System.Drawing.Point(32, 615);
            this.cklServices.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cklServices.Name = "cklServices";
            this.cklServices.Size = new System.Drawing.Size(428, 200);
            this.cklServices.TabIndex = 16;
            // 
            // cklMedications
            // 
            this.cklMedications.FormattingEnabled = true;
            this.cklMedications.Location = new System.Drawing.Point(496, 615);
            this.cklMedications.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cklMedications.Name = "cklMedications";
            this.cklMedications.Size = new System.Drawing.Size(428, 200);
            this.cklMedications.TabIndex = 20;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(32, 523);
            this.lblServices.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(95, 25);
            this.lblServices.TabIndex = 14;
            this.lblServices.Text = "&Services";
            // 
            // lblMedications
            // 
            this.lblMedications.AutoSize = true;
            this.lblMedications.Location = new System.Drawing.Point(512, 523);
            this.lblMedications.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMedications.Name = "lblMedications";
            this.lblMedications.Size = new System.Drawing.Size(128, 25);
            this.lblMedications.TabIndex = 18;
            this.lblMedications.Text = "&Medications";
            // 
            // btnPrescription
            // 
            this.btnPrescription.Location = new System.Drawing.Point(800, 508);
            this.btnPrescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(128, 46);
            this.btnPrescription.TabIndex = 21;
            this.btnPrescription.Text = "&Prescrition";
            this.btnPrescription.UseVisualStyleBackColor = true;
            this.btnPrescription.Visible = false;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(320, 508);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(128, 46);
            this.btnInvoice.TabIndex = 17;
            this.btnInvoice.Text = "&Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Visible = false;
            // 
            // txtSearchServices
            // 
            this.txtSearchServices.Location = new System.Drawing.Point(32, 569);
            this.txtSearchServices.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchServices.Name = "txtSearchServices";
            this.txtSearchServices.Size = new System.Drawing.Size(428, 31);
            this.txtSearchServices.TabIndex = 15;
            // 
            // txtSearchMedications
            // 
            this.txtSearchMedications.Location = new System.Drawing.Point(496, 569);
            this.txtSearchMedications.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchMedications.Name = "txtSearchMedications";
            this.txtSearchMedications.Size = new System.Drawing.Size(428, 31);
            this.txtSearchMedications.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(144, 862);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 46);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReopen
            // 
            this.btnReopen.Location = new System.Drawing.Point(736, 108);
            this.btnReopen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(112, 46);
            this.btnReopen.TabIndex = 22;
            this.btnReopen.Text = "Re&open";
            this.btnReopen.UseVisualStyleBackColor = true;
            this.btnReopen.Visible = false;
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(592, 862);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(208, 46);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "Con&firm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmAppointment
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(960, 927);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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