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
            this.lblDivider = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblMedications = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReopen = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblServiceDivider = new System.Windows.Forms.Label();
            this.lblMedDivider = new System.Windows.Forms.Label();
            this.lsbServices = new System.Windows.Forms.ListBox();
            this.lsbMedications = new System.Windows.Forms.ListBox();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.cboMedications = new System.Windows.Forms.ComboBox();
            this.picSearchMedication = new System.Windows.Forms.PictureBox();
            this.picSearchService = new System.Windows.Forms.PictureBox();
            this.picAddMed = new System.Windows.Forms.PictureBox();
            this.picAddService = new System.Windows.Forms.PictureBox();
            this.picPrescription = new System.Windows.Forms.PictureBox();
            this.picInvoice = new System.Windows.Forms.PictureBox();
            this.picCancelled = new System.Windows.Forms.PictureBox();
            this.picClosed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchMedication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClosed)).BeginInit();
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
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(171)))));
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
            this.lblHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(171)))));
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
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(171)))));
            this.lblStatus.Location = new System.Drawing.Point(509, 24);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(3);
            this.lblStatus.Size = new System.Drawing.Size(81, 21);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "<STATUS>";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(171)))));
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
            this.lblSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(171)))));
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
            this.lblSpecializedIn.Size = new System.Drawing.Size(90, 15);
            this.lblSpecializedIn.TabIndex = 7;
            this.lblSpecializedIn.Text = "consulted for";
            // 
            // lblDivider
            // 
            this.lblDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
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
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.txtDescription.Location = new System.Drawing.Point(21, 175);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(596, 101);
            this.txtDescription.TabIndex = 13;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblServices.Location = new System.Drawing.Point(24, 312);
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
            this.lblMedications.Location = new System.Drawing.Point(336, 312);
            this.lblMedications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedications.Name = "lblMedications";
            this.lblMedications.Size = new System.Drawing.Size(85, 15);
            this.lblMedications.TabIndex = 18;
            this.lblMedications.Text = "&Medications";
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
            this.btnBack.TabIndex = 22;
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
            this.btnReopen.Location = new System.Drawing.Point(512, 64);
            this.btnReopen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(75, 28);
            this.btnReopen.TabIndex = 10;
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
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Con&firm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblServiceDivider
            // 
            this.lblServiceDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblServiceDivider.Location = new System.Drawing.Point(24, 365);
            this.lblServiceDivider.Name = "lblServiceDivider";
            this.lblServiceDivider.Size = new System.Drawing.Size(280, 2);
            this.lblServiceDivider.TabIndex = 16;
            this.lblServiceDivider.Text = "label10";
            // 
            // lblMedDivider
            // 
            this.lblMedDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblMedDivider.Location = new System.Drawing.Point(335, 365);
            this.lblMedDivider.Name = "lblMedDivider";
            this.lblMedDivider.Size = new System.Drawing.Size(280, 2);
            this.lblMedDivider.TabIndex = 20;
            this.lblMedDivider.Text = "label10";
            // 
            // lsbServices
            // 
            this.lsbServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.lsbServices.FormattingEnabled = true;
            this.lsbServices.ItemHeight = 15;
            this.lsbServices.Location = new System.Drawing.Point(24, 376);
            this.lsbServices.Name = "lsbServices";
            this.lsbServices.Size = new System.Drawing.Size(280, 94);
            this.lsbServices.TabIndex = 17;
            // 
            // lsbMedications
            // 
            this.lsbMedications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbMedications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.lsbMedications.FormattingEnabled = true;
            this.lsbMedications.ItemHeight = 15;
            this.lsbMedications.Location = new System.Drawing.Point(336, 376);
            this.lsbMedications.Name = "lsbMedications";
            this.lsbMedications.Size = new System.Drawing.Size(280, 94);
            this.lsbMedications.TabIndex = 21;
            // 
            // cboServices
            // 
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(24, 336);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(224, 23);
            this.cboServices.TabIndex = 15;
            // 
            // cboMedications
            // 
            this.cboMedications.FormattingEnabled = true;
            this.cboMedications.Location = new System.Drawing.Point(336, 336);
            this.cboMedications.Name = "cboMedications";
            this.cboMedications.Size = new System.Drawing.Size(224, 23);
            this.cboMedications.TabIndex = 19;
            // 
            // picSearchMedication
            // 
            this.picSearchMedication.Image = global::carepoint.Properties.Resources.magnifying_glass;
            this.picSearchMedication.Location = new System.Drawing.Point(592, 340);
            this.picSearchMedication.Name = "picSearchMedication";
            this.picSearchMedication.Size = new System.Drawing.Size(18, 18);
            this.picSearchMedication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchMedication.TabIndex = 39;
            this.picSearchMedication.TabStop = false;
            // 
            // picSearchService
            // 
            this.picSearchService.Image = global::carepoint.Properties.Resources.magnifying_glass;
            this.picSearchService.Location = new System.Drawing.Point(280, 340);
            this.picSearchService.Name = "picSearchService";
            this.picSearchService.Size = new System.Drawing.Size(18, 18);
            this.picSearchService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchService.TabIndex = 38;
            this.picSearchService.TabStop = false;
            // 
            // picAddMed
            // 
            this.picAddMed.Image = global::carepoint.Properties.Resources.add;
            this.picAddMed.Location = new System.Drawing.Point(568, 340);
            this.picAddMed.Name = "picAddMed";
            this.picAddMed.Size = new System.Drawing.Size(18, 18);
            this.picAddMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddMed.TabIndex = 33;
            this.picAddMed.TabStop = false;
            // 
            // picAddService
            // 
            this.picAddService.Image = global::carepoint.Properties.Resources.add;
            this.picAddService.Location = new System.Drawing.Point(256, 340);
            this.picAddService.Name = "picAddService";
            this.picAddService.Size = new System.Drawing.Size(18, 18);
            this.picAddService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddService.TabIndex = 31;
            this.picAddService.TabStop = false;
            // 
            // picPrescription
            // 
            this.picPrescription.Image = global::carepoint.Properties.Resources.prescription;
            this.picPrescription.Location = new System.Drawing.Point(576, 296);
            this.picPrescription.Name = "picPrescription";
            this.picPrescription.Size = new System.Drawing.Size(40, 40);
            this.picPrescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrescription.TabIndex = 30;
            this.picPrescription.TabStop = false;
            this.picPrescription.Visible = false;
            // 
            // picInvoice
            // 
            this.picInvoice.Image = global::carepoint.Properties.Resources.invoice;
            this.picInvoice.Location = new System.Drawing.Point(264, 296);
            this.picInvoice.Name = "picInvoice";
            this.picInvoice.Size = new System.Drawing.Size(40, 40);
            this.picInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInvoice.TabIndex = 29;
            this.picInvoice.TabStop = false;
            this.picInvoice.Visible = false;
            // 
            // picCancelled
            // 
            this.picCancelled.Image = global::carepoint.Properties.Resources.cnl;
            this.picCancelled.Location = new System.Drawing.Point(560, 64);
            this.picCancelled.Name = "picCancelled";
            this.picCancelled.Size = new System.Drawing.Size(32, 32);
            this.picCancelled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancelled.TabIndex = 28;
            this.picCancelled.TabStop = false;
            this.picCancelled.Click += new System.EventHandler(this.picCancelled_Click);
            // 
            // picClosed
            // 
            this.picClosed.Image = global::carepoint.Properties.Resources.check;
            this.picClosed.Location = new System.Drawing.Point(512, 64);
            this.picClosed.Name = "picClosed";
            this.picClosed.Size = new System.Drawing.Size(32, 32);
            this.picClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClosed.TabIndex = 27;
            this.picClosed.TabStop = false;
            this.picClosed.Click += new System.EventHandler(this.picClosed_Click);
            // 
            // FrmAppointment
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(640, 530);
            this.Controls.Add(this.picSearchMedication);
            this.Controls.Add(this.picSearchService);
            this.Controls.Add(this.cboMedications);
            this.Controls.Add(this.cboServices);
            this.Controls.Add(this.lsbMedications);
            this.Controls.Add(this.lsbServices);
            this.Controls.Add(this.picAddMed);
            this.Controls.Add(this.picAddService);
            this.Controls.Add(this.picPrescription);
            this.Controls.Add(this.picInvoice);
            this.Controls.Add(this.picCancelled);
            this.Controls.Add(this.picClosed);
            this.Controls.Add(this.lblMedDivider);
            this.Controls.Add(this.lblServiceDivider);
            this.Controls.Add(this.btnReopen);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblMedications);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDivider);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(171)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAppointment";
            this.Text = "Appointment Details";
            ((System.ComponentModel.ISupportInitialize)(this.picSearchMedication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClosed)).EndInit();
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
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblMedications;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReopen;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblServiceDivider;
        private System.Windows.Forms.Label lblMedDivider;
        private System.Windows.Forms.PictureBox picClosed;
        private System.Windows.Forms.PictureBox picCancelled;
        private System.Windows.Forms.PictureBox picInvoice;
        private System.Windows.Forms.PictureBox picPrescription;
        private System.Windows.Forms.PictureBox picAddService;
        private System.Windows.Forms.PictureBox picAddMed;
        private System.Windows.Forms.ListBox lsbServices;
        private System.Windows.Forms.ListBox lsbMedications;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.ComboBox cboMedications;
        private System.Windows.Forms.PictureBox picSearchMedication;
        private System.Windows.Forms.PictureBox picSearchService;
    }
}