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
            this.components = new System.ComponentModel.Container();
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
            this.cmsServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.lblServices = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReopen = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblServiceDivider = new System.Windows.Forms.Label();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.picSearchService = new System.Windows.Forms.PictureBox();
            this.picAddService = new System.Windows.Forms.PictureBox();
            this.picInvoice = new System.Windows.Forms.PictureBox();
            this.picCancelled = new System.Windows.Forms.PictureBox();
            this.picClosed = new System.Windows.Forms.PictureBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.cmsPrescriptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCancelPresc = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDetails = new System.Windows.Forms.TabControl();
            this.tpServices = new System.Windows.Forms.TabPage();
            this.tpPrescription = new System.Windows.Forms.TabPage();
            this.picPrescription = new System.Windows.Forms.PictureBox();
            this.lblMedications = new System.Windows.Forms.Label();
            this.lblMedDivider = new System.Windows.Forms.Label();
            this.dgvMedications = new System.Windows.Forms.DataGridView();
            this.picAddMed = new System.Windows.Forms.PictureBox();
            this.cboMedications = new System.Windows.Forms.ComboBox();
            this.picSearchMedication = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.cmsPrescriptions.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.tpServices.SuspendLayout();
            this.tpPrescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchMedication)).BeginInit();
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
            this.lblDate.Location = new System.Drawing.Point(152, 28);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "<DATE>";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAt
            // 
            this.lblAt.AutoSize = true;
            this.lblAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblAt.Location = new System.Drawing.Point(320, 28);
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
            this.lblHours.Location = new System.Drawing.Point(362, 28);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(72, 15);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "<HOURS>";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lblDoctor.Location = new System.Drawing.Point(64, 74);
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
            this.lblSpecialty.Location = new System.Drawing.Point(360, 74);
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
            this.lblSpecializedIn.Location = new System.Drawing.Point(248, 74);
            this.lblSpecializedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecializedIn.Name = "lblSpecializedIn";
            this.lblSpecializedIn.Size = new System.Drawing.Size(90, 15);
            this.lblSpecializedIn.TabIndex = 7;
            this.lblSpecializedIn.Text = "consulted for";
            // 
            // lblDivider
            // 
            this.lblDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblDivider.Location = new System.Drawing.Point(0, 120);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(658, 1);
            this.lblDivider.TabIndex = 11;
            this.lblDivider.Text = "label10";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblDescription.Location = new System.Drawing.Point(16, 136);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 15);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "&Description";
            // 
            // txtDescription
            // 
            this.txtDescription.ContextMenuStrip = this.cmsServices;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.txtDescription.Location = new System.Drawing.Point(16, 160);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(596, 101);
            this.txtDescription.TabIndex = 13;
            // 
            // cmsServices
            // 
            this.cmsServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancel});
            this.cmsServices.Name = "contextMenuStrip1";
            this.cmsServices.Size = new System.Drawing.Size(111, 26);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(110, 22);
            this.tsmiCancel.Text = "Cancel";
            this.tsmiCancel.Click += new System.EventHandler(this.tsmiCancel_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblServices.Location = new System.Drawing.Point(40, 36);
            this.lblServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(61, 15);
            this.lblServices.TabIndex = 14;
            this.lblServices.Text = "&Services";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(96, 600);
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
            this.btnConfirm.Location = new System.Drawing.Point(395, 600);
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
            this.lblServiceDivider.Location = new System.Drawing.Point(40, 89);
            this.lblServiceDivider.Name = "lblServiceDivider";
            this.lblServiceDivider.Size = new System.Drawing.Size(584, 2);
            this.lblServiceDivider.TabIndex = 16;
            this.lblServiceDivider.Text = "label10";
            // 
            // cboServices
            // 
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(40, 60);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(528, 23);
            this.cboServices.TabIndex = 15;
            // 
            // picSearchService
            // 
            this.picSearchService.Image = global::carepoint.Properties.Resources.magnifying_glass;
            this.picSearchService.Location = new System.Drawing.Point(600, 64);
            this.picSearchService.Name = "picSearchService";
            this.picSearchService.Size = new System.Drawing.Size(18, 18);
            this.picSearchService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchService.TabIndex = 38;
            this.picSearchService.TabStop = false;
            // 
            // picAddService
            // 
            this.picAddService.Image = global::carepoint.Properties.Resources.add;
            this.picAddService.Location = new System.Drawing.Point(576, 64);
            this.picAddService.Name = "picAddService";
            this.picAddService.Size = new System.Drawing.Size(18, 18);
            this.picAddService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddService.TabIndex = 31;
            this.picAddService.TabStop = false;
            this.picAddService.Click += new System.EventHandler(this.picAddService_Click);
            // 
            // picInvoice
            // 
            this.picInvoice.Image = global::carepoint.Properties.Resources.invoice;
            this.picInvoice.Location = new System.Drawing.Point(584, 20);
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
            // dgvServices
            // 
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.ContextMenuStrip = this.cmsServices;
            this.dgvServices.Location = new System.Drawing.Point(40, 104);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(584, 112);
            this.dgvServices.TabIndex = 41;
            // 
            // cmsPrescriptions
            // 
            this.cmsPrescriptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancelPresc});
            this.cmsPrescriptions.Name = "cmsPrescriptions";
            this.cmsPrescriptions.Size = new System.Drawing.Size(111, 26);
            // 
            // tsmiCancelPresc
            // 
            this.tsmiCancelPresc.Name = "tsmiCancelPresc";
            this.tsmiCancelPresc.Size = new System.Drawing.Size(110, 22);
            this.tsmiCancelPresc.Text = "Cancel";
            this.tsmiCancelPresc.Click += new System.EventHandler(this.tsmiCancelPresc_Click);
            // 
            // tabDetails
            // 
            this.tabDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDetails.Controls.Add(this.tpServices);
            this.tabDetails.Controls.Add(this.tpPrescription);
            this.tabDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDetails.Location = new System.Drawing.Point(0, 320);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedIndex = 0;
            this.tabDetails.Size = new System.Drawing.Size(664, 264);
            this.tabDetails.TabIndex = 43;
            // 
            // tpServices
            // 
            this.tpServices.Controls.Add(this.dgvServices);
            this.tpServices.Controls.Add(this.lblServices);
            this.tpServices.Controls.Add(this.lblServiceDivider);
            this.tpServices.Controls.Add(this.picInvoice);
            this.tpServices.Controls.Add(this.picSearchService);
            this.tpServices.Controls.Add(this.picAddService);
            this.tpServices.Controls.Add(this.cboServices);
            this.tpServices.Location = new System.Drawing.Point(4, 24);
            this.tpServices.Name = "tpServices";
            this.tpServices.Padding = new System.Windows.Forms.Padding(3);
            this.tpServices.Size = new System.Drawing.Size(656, 236);
            this.tpServices.TabIndex = 0;
            this.tpServices.Text = "Services";
            this.tpServices.UseVisualStyleBackColor = true;
            // 
            // tpPrescription
            // 
            this.tpPrescription.Controls.Add(this.picPrescription);
            this.tpPrescription.Controls.Add(this.lblMedications);
            this.tpPrescription.Controls.Add(this.lblMedDivider);
            this.tpPrescription.Controls.Add(this.dgvMedications);
            this.tpPrescription.Controls.Add(this.picAddMed);
            this.tpPrescription.Controls.Add(this.cboMedications);
            this.tpPrescription.Controls.Add(this.picSearchMedication);
            this.tpPrescription.Location = new System.Drawing.Point(4, 24);
            this.tpPrescription.Name = "tpPrescription";
            this.tpPrescription.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrescription.Size = new System.Drawing.Size(656, 236);
            this.tpPrescription.TabIndex = 1;
            this.tpPrescription.Text = "Prescription";
            this.tpPrescription.UseVisualStyleBackColor = true;
            // 
            // picPrescription
            // 
            this.picPrescription.Image = global::carepoint.Properties.Resources.prescription;
            this.picPrescription.Location = new System.Drawing.Point(584, 20);
            this.picPrescription.Name = "picPrescription";
            this.picPrescription.Size = new System.Drawing.Size(40, 40);
            this.picPrescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrescription.TabIndex = 46;
            this.picPrescription.TabStop = false;
            this.picPrescription.Visible = false;
            // 
            // lblMedications
            // 
            this.lblMedications.AutoSize = true;
            this.lblMedications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblMedications.Location = new System.Drawing.Point(40, 36);
            this.lblMedications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedications.Name = "lblMedications";
            this.lblMedications.Size = new System.Drawing.Size(85, 15);
            this.lblMedications.TabIndex = 43;
            this.lblMedications.Text = "&Medications";
            // 
            // lblMedDivider
            // 
            this.lblMedDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.lblMedDivider.Location = new System.Drawing.Point(39, 89);
            this.lblMedDivider.Name = "lblMedDivider";
            this.lblMedDivider.Size = new System.Drawing.Size(584, 2);
            this.lblMedDivider.TabIndex = 45;
            this.lblMedDivider.Text = "label10";
            // 
            // dgvMedications
            // 
            this.dgvMedications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedications.ContextMenuStrip = this.cmsPrescriptions;
            this.dgvMedications.Location = new System.Drawing.Point(40, 104);
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.ReadOnly = true;
            this.dgvMedications.RowHeadersVisible = false;
            this.dgvMedications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedications.Size = new System.Drawing.Size(584, 112);
            this.dgvMedications.TabIndex = 49;
            // 
            // picAddMed
            // 
            this.picAddMed.Image = global::carepoint.Properties.Resources.add;
            this.picAddMed.Location = new System.Drawing.Point(576, 64);
            this.picAddMed.Name = "picAddMed";
            this.picAddMed.Size = new System.Drawing.Size(18, 18);
            this.picAddMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddMed.TabIndex = 47;
            this.picAddMed.TabStop = false;
            this.picAddMed.Click += new System.EventHandler(this.picAddMed_Click);
            // 
            // cboMedications
            // 
            this.cboMedications.FormattingEnabled = true;
            this.cboMedications.Location = new System.Drawing.Point(40, 60);
            this.cboMedications.Name = "cboMedications";
            this.cboMedications.Size = new System.Drawing.Size(528, 23);
            this.cboMedications.TabIndex = 44;
            // 
            // picSearchMedication
            // 
            this.picSearchMedication.Image = global::carepoint.Properties.Resources.magnifying_glass;
            this.picSearchMedication.Location = new System.Drawing.Point(600, 64);
            this.picSearchMedication.Name = "picSearchMedication";
            this.picSearchMedication.Size = new System.Drawing.Size(18, 18);
            this.picSearchMedication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchMedication.TabIndex = 48;
            this.picSearchMedication.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.label1.Location = new System.Drawing.Point(0, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 1);
            this.label1.TabIndex = 44;
            this.label1.Text = "label10";
            // 
            // FrmAppointment
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(660, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabDetails);
            this.Controls.Add(this.picCancelled);
            this.Controls.Add(this.picClosed);
            this.Controls.Add(this.btnReopen);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
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
            this.cmsServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSearchService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.cmsPrescriptions.ResumeLayout(false);
            this.tabDetails.ResumeLayout(false);
            this.tpServices.ResumeLayout(false);
            this.tpServices.PerformLayout();
            this.tpPrescription.ResumeLayout(false);
            this.tpPrescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchMedication)).EndInit();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReopen;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblServiceDivider;
        private System.Windows.Forms.PictureBox picClosed;
        private System.Windows.Forms.PictureBox picCancelled;
        private System.Windows.Forms.PictureBox picInvoice;
        private System.Windows.Forms.PictureBox picAddService;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.PictureBox picSearchService;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.ContextMenuStrip cmsServices;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancel;
        private System.Windows.Forms.ContextMenuStrip cmsPrescriptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelPresc;
        private System.Windows.Forms.TabControl tabDetails;
        private System.Windows.Forms.TabPage tpServices;
        private System.Windows.Forms.TabPage tpPrescription;
        private System.Windows.Forms.PictureBox picPrescription;
        private System.Windows.Forms.Label lblMedications;
        private System.Windows.Forms.Label lblMedDivider;
        private System.Windows.Forms.DataGridView dgvMedications;
        private System.Windows.Forms.PictureBox picAddMed;
        private System.Windows.Forms.ComboBox cboMedications;
        private System.Windows.Forms.PictureBox picSearchMedication;
        private System.Windows.Forms.Label label1;
    }
}