namespace NOSQL_PROJECT
{
    partial class MainForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlCreateTicket = new System.Windows.Forms.Panel();
            this.lblTicketIdStore = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.comboboxStatus = new System.Windows.Forms.ComboBox();
            this.btnDeleteIncident = new System.Windows.Forms.Button();
            this.btnUpdateIncident = new System.Windows.Forms.Button();
            this.btn_CancelIncident = new System.Windows.Forms.Button();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.dtp_Deadline = new System.Windows.Forms.DateTimePicker();
            this.dtPick_IncidentTimeReported = new System.Windows.Forms.DateTimePicker();
            this.comb_IncidentPriority = new System.Windows.Forms.ComboBox();
            this.comb_ReportedByUser = new System.Windows.Forms.ComboBox();
            this.comb_TypeIncident = new System.Windows.Forms.ComboBox();
            this.txt_IncidentDescription = new System.Windows.Forms.TextBox();
            this.txtIncidentSubject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIncidentHeading = new System.Windows.Forms.Label();
            this.pnlIncidentManagement = new System.Windows.Forms.Panel();
            this.txtboxFilterByKeyword = new System.Windows.Forms.TextBox();
            this.btnSearchTicketByEmail = new System.Windows.Forms.Button();
            this.listViewIncidents = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.subject = new System.Windows.Forms.ColumnHeader();
            this.user = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.btnCreateNewIncident = new System.Windows.Forms.Button();
            this.txtboxFilterEmailIncidents = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlUserManagement = new System.Windows.Forms.Panel();
            this.btnSearchUserByEmail = new System.Windows.Forms.Button();
            this.listViewOverviewUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.txtboxFilterEmailUsers = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlCreateUser = new System.Windows.Forms.Panel();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.comboUserType = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxSendEmail = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlCreateTicket.SuspendLayout();
            this.pnlIncidentManagement.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            this.pnlCreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1679, 1060);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1663, 1006);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlIncidentManagement);
            this.tabPage2.Controls.Add(this.pnlCreateTicket);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1663, 1006);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incident Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlCreateTicket
            // 
            this.pnlCreateTicket.Controls.Add(this.lblTicketIdStore);
            this.pnlCreateTicket.Controls.Add(this.lblstatus);
            this.pnlCreateTicket.Controls.Add(this.comboboxStatus);
            this.pnlCreateTicket.Controls.Add(this.btnDeleteIncident);
            this.pnlCreateTicket.Controls.Add(this.btnUpdateIncident);
            this.pnlCreateTicket.Controls.Add(this.btn_CancelIncident);
            this.pnlCreateTicket.Controls.Add(this.btnSubmitTicket);
            this.pnlCreateTicket.Controls.Add(this.dtp_Deadline);
            this.pnlCreateTicket.Controls.Add(this.dtPick_IncidentTimeReported);
            this.pnlCreateTicket.Controls.Add(this.comb_IncidentPriority);
            this.pnlCreateTicket.Controls.Add(this.comb_ReportedByUser);
            this.pnlCreateTicket.Controls.Add(this.comb_TypeIncident);
            this.pnlCreateTicket.Controls.Add(this.txt_IncidentDescription);
            this.pnlCreateTicket.Controls.Add(this.txtIncidentSubject);
            this.pnlCreateTicket.Controls.Add(this.label9);
            this.pnlCreateTicket.Controls.Add(this.label8);
            this.pnlCreateTicket.Controls.Add(this.label7);
            this.pnlCreateTicket.Controls.Add(this.label6);
            this.pnlCreateTicket.Controls.Add(this.label5);
            this.pnlCreateTicket.Controls.Add(this.label3);
            this.pnlCreateTicket.Controls.Add(this.label4);
            this.pnlCreateTicket.Controls.Add(this.lblIncidentHeading);
            this.pnlCreateTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreateTicket.Location = new System.Drawing.Point(6, 6);
            this.pnlCreateTicket.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlCreateTicket.Name = "pnlCreateTicket";
            this.pnlCreateTicket.Size = new System.Drawing.Size(1651, 994);
            this.pnlCreateTicket.TabIndex = 0;
            // 
            // lblTicketIdStore
            // 
            this.lblTicketIdStore.AutoSize = true;
            this.lblTicketIdStore.ForeColor = System.Drawing.Color.Transparent;
            this.lblTicketIdStore.Location = new System.Drawing.Point(1285, 617);
            this.lblTicketIdStore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTicketIdStore.Name = "lblTicketIdStore";
            this.lblTicketIdStore.Size = new System.Drawing.Size(178, 32);
            this.lblTicketIdStore.TabIndex = 22;
            this.lblTicketIdStore.Text = "lblTicketIdStore";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblstatus.Location = new System.Drawing.Point(1185, 646);
            this.lblstatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(221, 38);
            this.lblstatus.TabIndex = 21;
            this.lblstatus.Text = "Incident Status:";
            // 
            // comboboxStatus
            // 
            this.comboboxStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboboxStatus.FormattingEnabled = true;
            this.comboboxStatus.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Service"});
            this.comboboxStatus.Location = new System.Drawing.Point(1185, 693);
            this.comboboxStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(279, 58);
            this.comboboxStatus.TabIndex = 20;
            this.comboboxStatus.SelectedIndexChanged += new System.EventHandler(this.comboboxStatus_SelectedIndexChanged);
            // 
            // btnDeleteIncident
            // 
            this.btnDeleteIncident.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteIncident.Location = new System.Drawing.Point(1153, 858);
            this.btnDeleteIncident.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteIncident.Name = "btnDeleteIncident";
            this.btnDeleteIncident.Size = new System.Drawing.Size(160, 70);
            this.btnDeleteIncident.TabIndex = 19;
            this.btnDeleteIncident.Text = "DELETE";
            this.btnDeleteIncident.UseVisualStyleBackColor = false;
            this.btnDeleteIncident.Click += new System.EventHandler(this.btnDeleteIncident_Click);
            // 
            // btnUpdateIncident
            // 
            this.btnUpdateIncident.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdateIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateIncident.Location = new System.Drawing.Point(1348, 858);
            this.btnUpdateIncident.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdateIncident.Name = "btnUpdateIncident";
            this.btnUpdateIncident.Size = new System.Drawing.Size(254, 70);
            this.btnUpdateIncident.TabIndex = 18;
            this.btnUpdateIncident.Text = "UPDATE";
            this.btnUpdateIncident.UseVisualStyleBackColor = false;
            this.btnUpdateIncident.Click += new System.EventHandler(this.btnUpdateIncident_Click);
            // 
            // btn_CancelIncident
            // 
            this.btn_CancelIncident.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CancelIncident.BackColor = System.Drawing.Color.White;
            this.btn_CancelIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelIncident.Location = new System.Drawing.Point(1185, 459);
            this.btn_CancelIncident.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_CancelIncident.Name = "btn_CancelIncident";
            this.btn_CancelIncident.Size = new System.Drawing.Size(258, 76);
            this.btn_CancelIncident.TabIndex = 16;
            this.btn_CancelIncident.Text = "CANCEL";
            this.btn_CancelIncident.UseVisualStyleBackColor = false;
            this.btn_CancelIncident.Click += new System.EventHandler(this.btn_CancelIncident_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmitTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitTicket.Location = new System.Drawing.Point(1183, 337);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(262, 70);
            this.btnSubmitTicket.TabIndex = 17;
            this.btnSubmitTicket.Text = "SUBMIT TICKET";
            this.btnSubmitTicket.UseVisualStyleBackColor = false;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // dtp_Deadline
            // 
            this.dtp_Deadline.Location = new System.Drawing.Point(455, 597);
            this.dtp_Deadline.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtp_Deadline.Name = "dtp_Deadline";
            this.dtp_Deadline.Size = new System.Drawing.Size(554, 39);
            this.dtp_Deadline.TabIndex = 15;
            // 
            // dtPick_IncidentTimeReported
            // 
            this.dtPick_IncidentTimeReported.Location = new System.Drawing.Point(455, 111);
            this.dtPick_IncidentTimeReported.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtPick_IncidentTimeReported.Name = "dtPick_IncidentTimeReported";
            this.dtPick_IncidentTimeReported.Size = new System.Drawing.Size(554, 39);
            this.dtPick_IncidentTimeReported.TabIndex = 15;
            // 
            // comb_IncidentPriority
            // 
            this.comb_IncidentPriority.FormattingEnabled = true;
            this.comb_IncidentPriority.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.comb_IncidentPriority.Location = new System.Drawing.Point(455, 514);
            this.comb_IncidentPriority.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comb_IncidentPriority.Name = "comb_IncidentPriority";
            this.comb_IncidentPriority.Size = new System.Drawing.Size(554, 40);
            this.comb_IncidentPriority.TabIndex = 12;
            // 
            // comb_ReportedByUser
            // 
            this.comb_ReportedByUser.FormattingEnabled = true;
            this.comb_ReportedByUser.Location = new System.Drawing.Point(455, 410);
            this.comb_ReportedByUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comb_ReportedByUser.Name = "comb_ReportedByUser";
            this.comb_ReportedByUser.Size = new System.Drawing.Size(554, 40);
            this.comb_ReportedByUser.TabIndex = 13;
            // 
            // comb_TypeIncident
            // 
            this.comb_TypeIncident.FormattingEnabled = true;
            this.comb_TypeIncident.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Service"});
            this.comb_TypeIncident.Location = new System.Drawing.Point(455, 318);
            this.comb_TypeIncident.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comb_TypeIncident.Name = "comb_TypeIncident";
            this.comb_TypeIncident.Size = new System.Drawing.Size(554, 40);
            this.comb_TypeIncident.TabIndex = 14;
            // 
            // txt_IncidentDescription
            // 
            this.txt_IncidentDescription.Location = new System.Drawing.Point(455, 710);
            this.txt_IncidentDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_IncidentDescription.MaximumSize = new System.Drawing.Size(1854, 2129);
            this.txt_IncidentDescription.MinimumSize = new System.Drawing.Size(368, 102);
            this.txt_IncidentDescription.Multiline = true;
            this.txt_IncidentDescription.Name = "txt_IncidentDescription";
            this.txt_IncidentDescription.Size = new System.Drawing.Size(554, 213);
            this.txt_IncidentDescription.TabIndex = 9;
            // 
            // txtIncidentSubject
            // 
            this.txtIncidentSubject.Location = new System.Drawing.Point(455, 209);
            this.txtIncidentSubject.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIncidentSubject.Name = "txtIncidentSubject";
            this.txtIncidentSubject.Size = new System.Drawing.Size(554, 39);
            this.txtIncidentSubject.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 717);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 617);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Deadline/Follow-up:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 516);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Priority:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Reported by user:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 337);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type of incident:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date/time reported:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject of incident:";
            // 
            // lblIncidentHeading
            // 
            this.lblIncidentHeading.AutoSize = true;
            this.lblIncidentHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIncidentHeading.Location = new System.Drawing.Point(420, 26);
            this.lblIncidentHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncidentHeading.Name = "lblIncidentHeading";
            this.lblIncidentHeading.Size = new System.Drawing.Size(514, 54);
            this.lblIncidentHeading.TabIndex = 0;
            this.lblIncidentHeading.Text = "Create new incident ticket";
            // 
            // pnlIncidentManagement
            // 
            this.pnlIncidentManagement.Controls.Add(this.txtboxFilterByKeyword);
            this.pnlIncidentManagement.Controls.Add(this.btnSearchTicketByEmail);
            this.pnlIncidentManagement.Controls.Add(this.listViewIncidents);
            this.pnlIncidentManagement.Controls.Add(this.btnCreateNewIncident);
            this.pnlIncidentManagement.Controls.Add(this.txtboxFilterEmailIncidents);
            this.pnlIncidentManagement.Controls.Add(this.label18);
            this.pnlIncidentManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlIncidentManagement.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlIncidentManagement.Name = "pnlIncidentManagement";
            this.pnlIncidentManagement.Size = new System.Drawing.Size(1666, 1007);
            this.pnlIncidentManagement.TabIndex = 18;
            // 
            // txtboxFilterByKeyword
            // 
            this.txtboxFilterByKeyword.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxFilterByKeyword.Location = new System.Drawing.Point(43, 226);
            this.txtboxFilterByKeyword.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtboxFilterByKeyword.Name = "txtboxFilterByKeyword";
            this.txtboxFilterByKeyword.PlaceholderText = "Filter by keywords...";
            this.txtboxFilterByKeyword.Size = new System.Drawing.Size(323, 50);
            this.txtboxFilterByKeyword.TabIndex = 24;
            // 
            // btnSearchTicketByEmail
            // 
            this.btnSearchTicketByEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchTicketByEmail.BackgroundImage")));
            this.btnSearchTicketByEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchTicketByEmail.Location = new System.Drawing.Point(377, 162);
            this.btnSearchTicketByEmail.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSearchTicketByEmail.Name = "btnSearchTicketByEmail";
            this.btnSearchTicketByEmail.Size = new System.Drawing.Size(56, 55);
            this.btnSearchTicketByEmail.TabIndex = 23;
            this.btnSearchTicketByEmail.UseVisualStyleBackColor = true;
            this.btnSearchTicketByEmail.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewIncidents
            // 
            this.listViewIncidents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.subject,
            this.user,
            this.date,
            this.Status,
            this.Description});
            this.listViewIncidents.FullRowSelect = true;
            this.listViewIncidents.HideSelection = false;
            this.listViewIncidents.Location = new System.Drawing.Point(43, 286);
            this.listViewIncidents.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.listViewIncidents.MultiSelect = false;
            this.listViewIncidents.Name = "listViewIncidents";
            this.listViewIncidents.Size = new System.Drawing.Size(1477, 616);
            this.listViewIncidents.TabIndex = 22;
            this.listViewIncidents.UseCompatibleStateImageBehavior = false;
            this.listViewIncidents.View = System.Windows.Forms.View.Details;
            this.listViewIncidents.SelectedIndexChanged += new System.EventHandler(this.listViewIncidents_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // subject
            // 
            this.subject.Text = "Subject";
            this.subject.Width = 300;
            // 
            // user
            // 
            this.user.Text = "User";
            this.user.Width = 300;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 150;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 100;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 200;
            // 
            // btnCreateNewIncident
            // 
            this.btnCreateNewIncident.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateNewIncident.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateNewIncident.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNewIncident.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateNewIncident.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateNewIncident.Location = new System.Drawing.Point(1252, 145);
            this.btnCreateNewIncident.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnCreateNewIncident.Name = "btnCreateNewIncident";
            this.btnCreateNewIncident.Size = new System.Drawing.Size(269, 92);
            this.btnCreateNewIncident.TabIndex = 21;
            this.btnCreateNewIncident.Text = "CREATE INCIDENT";
            this.btnCreateNewIncident.UseVisualStyleBackColor = false;
            this.btnCreateNewIncident.Click += new System.EventHandler(this.btnCreateNewIncident_Click);
            // 
            // txtboxFilterEmailIncidents
            // 
            this.txtboxFilterEmailIncidents.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxFilterEmailIncidents.Location = new System.Drawing.Point(43, 162);
            this.txtboxFilterEmailIncidents.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtboxFilterEmailIncidents.Name = "txtboxFilterEmailIncidents";
            this.txtboxFilterEmailIncidents.PlaceholderText = "Filter by email...";
            this.txtboxFilterEmailIncidents.Size = new System.Drawing.Size(323, 50);
            this.txtboxFilterEmailIncidents.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(43, 49);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(369, 60);
            this.label18.TabIndex = 19;
            this.label18.Text = "Overview tickets";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlUserManagement);
            this.tabPage3.Controls.Add(this.pnlCreateUser);
            this.tabPage3.Location = new System.Drawing.Point(8, 46);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Size = new System.Drawing.Size(1663, 1006);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.Controls.Add(this.btnSearchUserByEmail);
            this.pnlUserManagement.Controls.Add(this.listViewOverviewUsers);
            this.pnlUserManagement.Controls.Add(this.btnAddNewUser);
            this.pnlUserManagement.Controls.Add(this.txtboxFilterEmailUsers);
            this.pnlUserManagement.Controls.Add(this.label19);
            this.pnlUserManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlUserManagement.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.Size = new System.Drawing.Size(1666, 1007);
            this.pnlUserManagement.TabIndex = 24;
            // 
            // btnSearchUserByEmail
            // 
            this.btnSearchUserByEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchUserByEmail.BackgroundImage")));
            this.btnSearchUserByEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchUserByEmail.Location = new System.Drawing.Point(377, 162);
            this.btnSearchUserByEmail.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSearchUserByEmail.Name = "btnSearchUserByEmail";
            this.btnSearchUserByEmail.Size = new System.Drawing.Size(56, 55);
            this.btnSearchUserByEmail.TabIndex = 24;
            this.btnSearchUserByEmail.UseVisualStyleBackColor = true;
            this.btnSearchUserByEmail.Click += new System.EventHandler(this.btnSearchUserByEmail_Click);
            // 
            // listViewOverviewUsers
            // 
            this.listViewOverviewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listViewOverviewUsers.FullRowSelect = true;
            this.listViewOverviewUsers.HideSelection = false;
            this.listViewOverviewUsers.Location = new System.Drawing.Point(43, 286);
            this.listViewOverviewUsers.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.listViewOverviewUsers.MultiSelect = false;
            this.listViewOverviewUsers.Name = "listViewOverviewUsers";
            this.listViewOverviewUsers.Size = new System.Drawing.Size(1477, 616);
            this.listViewOverviewUsers.TabIndex = 23;
            this.listViewOverviewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewOverviewUsers.View = System.Windows.Forms.View.Details;
            this.listViewOverviewUsers.SelectedIndexChanged += new System.EventHandler(this.listViewOverviewUsers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Name";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Last Name";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "# of Tickets";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNewUser.Location = new System.Drawing.Point(1252, 145);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(269, 92);
            this.btnAddNewUser.TabIndex = 22;
            this.btnAddNewUser.Text = "+ ADD NEW USER";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtboxFilterEmailUsers
            // 
            this.txtboxFilterEmailUsers.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxFilterEmailUsers.Location = new System.Drawing.Point(43, 162);
            this.txtboxFilterEmailUsers.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtboxFilterEmailUsers.Name = "txtboxFilterEmailUsers";
            this.txtboxFilterEmailUsers.PlaceholderText = "Filter by email...";
            this.txtboxFilterEmailUsers.Size = new System.Drawing.Size(323, 50);
            this.txtboxFilterEmailUsers.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(43, 49);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(341, 60);
            this.label19.TabIndex = 20;
            this.label19.Text = "Overview users";
            // 
            // pnlCreateUser
            // 
            this.pnlCreateUser.Controls.Add(this.comboLocation);
            this.pnlCreateUser.Controls.Add(this.comboUserType);
            this.pnlCreateUser.Controls.Add(this.txtLastName);
            this.pnlCreateUser.Controls.Add(this.txtUsername);
            this.pnlCreateUser.Controls.Add(this.txtPhoneNo);
            this.pnlCreateUser.Controls.Add(this.txtEmail);
            this.pnlCreateUser.Controls.Add(this.txtFirstName);
            this.pnlCreateUser.Controls.Add(this.label10);
            this.pnlCreateUser.Controls.Add(this.checkBoxSendEmail);
            this.pnlCreateUser.Controls.Add(this.btnCancel);
            this.pnlCreateUser.Controls.Add(this.btnAddUser);
            this.pnlCreateUser.Controls.Add(this.label2);
            this.pnlCreateUser.Controls.Add(this.label11);
            this.pnlCreateUser.Controls.Add(this.label12);
            this.pnlCreateUser.Controls.Add(this.label13);
            this.pnlCreateUser.Controls.Add(this.label14);
            this.pnlCreateUser.Controls.Add(this.label15);
            this.pnlCreateUser.Controls.Add(this.label16);
            this.pnlCreateUser.Controls.Add(this.label17);
            this.pnlCreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreateUser.Location = new System.Drawing.Point(6, 6);
            this.pnlCreateUser.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnlCreateUser.Name = "pnlCreateUser";
            this.pnlCreateUser.Size = new System.Drawing.Size(1651, 994);
            this.pnlCreateUser.TabIndex = 0;
            // 
            // comboLocation
            // 
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Knuppeldam",
            "Headquarters(HQ)"});
            this.comboLocation.Location = new System.Drawing.Point(579, 674);
            this.comboLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(554, 40);
            this.comboLocation.TabIndex = 22;
            // 
            // comboUserType
            // 
            this.comboUserType.FormattingEnabled = true;
            this.comboUserType.Items.AddRange(new object[] {
            "Regular",
            "Service Desk"});
            this.comboUserType.Location = new System.Drawing.Point(579, 399);
            this.comboUserType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboUserType.Name = "comboUserType";
            this.comboUserType.Size = new System.Drawing.Size(554, 40);
            this.comboUserType.TabIndex = 23;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(579, 290);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(554, 39);
            this.txtLastName.TabIndex = 18;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(579, 770);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(554, 39);
            this.txtUsername.TabIndex = 19;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(579, 578);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(554, 39);
            this.txtPhoneNo.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(579, 480);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(554, 39);
            this.txtEmail.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(579, 188);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(554, 39);
            this.txtFirstName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(306, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 72);
            this.label10.TabIndex = 17;
            this.label10.Text = "Create user";
            // 
            // checkBoxSendEmail
            // 
            this.checkBoxSendEmail.AutoSize = true;
            this.checkBoxSendEmail.Location = new System.Drawing.Point(583, 875);
            this.checkBoxSendEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxSendEmail.Name = "checkBoxSendEmail";
            this.checkBoxSendEmail.Size = new System.Drawing.Size(591, 36);
            this.checkBoxSendEmail.TabIndex = 16;
            this.checkBoxSendEmail.Text = "Yes, a password will be sent in an email to the user.";
            this.checkBoxSendEmail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(1261, 467);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 70);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(1261, 341);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(262, 70);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 787);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 862);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 32);
            this.label11.TabIndex = 7;
            this.label11.Text = "Send password?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 687);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 32);
            this.label12.TabIndex = 8;
            this.label12.Text = "Location/branch:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 585);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 32);
            this.label13.TabIndex = 9;
            this.label13.Text = "Phone number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 489);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 32);
            this.label14.TabIndex = 10;
            this.label14.Text = "E-mail address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(303, 407);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 32);
            this.label15.TabIndex = 11;
            this.label15.Text = "Type of user:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(303, 297);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 32);
            this.label16.TabIndex = 12;
            this.label16.Text = "Last name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(303, 194);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 32);
            this.label17.TabIndex = 13;
            this.label17.Text = "First name:";
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 1060);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm2";
            this.Text = "MainForm2";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlCreateTicket.ResumeLayout(false);
            this.pnlCreateTicket.PerformLayout();
            this.pnlIncidentManagement.ResumeLayout(false);
            this.pnlIncidentManagement.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.pnlUserManagement.ResumeLayout(false);
            this.pnlUserManagement.PerformLayout();
            this.pnlCreateUser.ResumeLayout(false);
            this.pnlCreateUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlCreateTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CancelIncident;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.DateTimePicker dtPick_IncidentTimeReported;
        private System.Windows.Forms.ComboBox comb_IncidentPriority;
        private System.Windows.Forms.ComboBox comb_ReportedByUser;
        private System.Windows.Forms.ComboBox comb_TypeIncident;
        private System.Windows.Forms.TextBox txt_IncidentDescription;
        private System.Windows.Forms.TextBox txtIncidentSubject;
        private System.Windows.Forms.Panel pnlCreateUser;
        private System.Windows.Forms.CheckBox checkBoxSendEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.ComboBox comboUserType;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_Deadline;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlIncidentManagement;
        private System.Windows.Forms.ListView listViewIncidents;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader user;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button btnCreateNewIncident;
        private System.Windows.Forms.TextBox txtboxFilterEmailIncidents;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlUserManagement;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.TextBox txtboxFilterEmailUsers;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListView listViewOverviewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnSearchTicketByEmail;
        private System.Windows.Forms.Button btnSearchUserByEmail;
        private System.Windows.Forms.TextBox txtboxFilterByKeyword;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ComboBox comboboxStatus;
        private System.Windows.Forms.Button btnDeleteIncident;
        private System.Windows.Forms.Button btnUpdateIncident;
        private System.Windows.Forms.Label lblIncidentHeading;
        private System.Windows.Forms.Label lblTicketIdStore;
    }
}