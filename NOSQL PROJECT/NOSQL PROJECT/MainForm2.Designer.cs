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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlCreateTicket = new System.Windows.Forms.Panel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.incidentsPastDeadlinePictureBox = new System.Windows.Forms.PictureBox();
            this.unresolvedIncidentsPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.unresolvedIncidentsGroupBox = new System.Windows.Forms.GroupBox();
            this.incidentsPastDeadlineGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlCreateTicket.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsPastDeadlinePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unresolvedIncidentsPictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(8, 46);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Size = new System.Drawing.Size(1663, 1007);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboLocation);
            this.panel1.Controls.Add(this.comboUserType);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.checkBoxSendEmail);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1653, 995);
            this.panel1.TabIndex = 0;
            // 
            // comboLocation
            // 
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Knuppeldam",
            "Headquarters(HQ)"});
            this.comboLocation.Location = new System.Drawing.Point(580, 674);
            this.comboLocation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(553, 40);
            this.comboLocation.TabIndex = 22;
            // 
            // comboUserType
            // 
            this.comboUserType.FormattingEnabled = true;
            this.comboUserType.Items.AddRange(new object[] {
            "Regular",
            "Service Desk"});
            this.comboUserType.Location = new System.Drawing.Point(580, 398);
            this.comboUserType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboUserType.Name = "comboUserType";
            this.comboUserType.Size = new System.Drawing.Size(553, 40);
            this.comboUserType.TabIndex = 23;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(580, 290);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(553, 39);
            this.txtLastName.TabIndex = 18;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(580, 770);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(553, 39);
            this.txtUsername.TabIndex = 19;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(580, 578);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(553, 39);
            this.txtPhoneNo.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(580, 480);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(553, 39);
            this.txtEmail.TabIndex = 20;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(580, 187);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(553, 39);
            this.txtFirstName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(307, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 72);
            this.label10.TabIndex = 17;
            this.label10.Text = "Create user";
            // 
            // checkBoxSendEmail
            // 
            this.checkBoxSendEmail.AutoSize = true;
            this.checkBoxSendEmail.Location = new System.Drawing.Point(583, 875);
            this.checkBoxSendEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.label2.Location = new System.Drawing.Point(302, 787);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 862);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 32);
            this.label11.TabIndex = 7;
            this.label11.Text = "Send password?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 686);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 32);
            this.label12.TabIndex = 8;
            this.label12.Text = "Location/branch:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 584);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 32);
            this.label13.TabIndex = 9;
            this.label13.Text = "Phone number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(302, 488);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 32);
            this.label14.TabIndex = 10;
            this.label14.Text = "E-mail address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 408);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 32);
            this.label15.TabIndex = 11;
            this.label15.Text = "Type of user:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(302, 296);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 32);
            this.label16.TabIndex = 12;
            this.label16.Text = "Last name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(302, 194);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 32);
            this.label17.TabIndex = 13;
            this.label17.Text = "First name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlCreateTicket);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Size = new System.Drawing.Size(1663, 1007);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incident Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlCreateTicket
            // 
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
            this.pnlCreateTicket.Controls.Add(this.label1);
            this.pnlCreateTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreateTicket.Location = new System.Drawing.Point(5, 6);
            this.pnlCreateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCreateTicket.Name = "pnlCreateTicket";
            this.pnlCreateTicket.Size = new System.Drawing.Size(1653, 995);
            this.pnlCreateTicket.TabIndex = 0;
            // 
            // btn_CancelIncident
            // 
            this.btn_CancelIncident.BackColor = System.Drawing.Color.White;
            this.btn_CancelIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelIncident.Location = new System.Drawing.Point(1261, 456);
            this.btn_CancelIncident.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_CancelIncident.Name = "btn_CancelIncident";
            this.btn_CancelIncident.Size = new System.Drawing.Size(260, 70);
            this.btn_CancelIncident.TabIndex = 16;
            this.btn_CancelIncident.Text = "CANCEL";
            this.btn_CancelIncident.UseVisualStyleBackColor = false;
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmitTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitTicket.Location = new System.Drawing.Point(1259, 325);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(262, 70);
            this.btnSubmitTicket.TabIndex = 17;
            this.btnSubmitTicket.Text = "SUBMIT TICKET";
            this.btnSubmitTicket.UseVisualStyleBackColor = false;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // dtp_Deadline
            // 
            this.dtp_Deadline.Location = new System.Drawing.Point(546, 603);
            this.dtp_Deadline.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtp_Deadline.Name = "dtp_Deadline";
            this.dtp_Deadline.Size = new System.Drawing.Size(553, 39);
            this.dtp_Deadline.TabIndex = 15;
            // 
            // dtPick_IncidentTimeReported
            // 
            this.dtPick_IncidentTimeReported.Location = new System.Drawing.Point(546, 117);
            this.dtPick_IncidentTimeReported.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtPick_IncidentTimeReported.Name = "dtPick_IncidentTimeReported";
            this.dtPick_IncidentTimeReported.Size = new System.Drawing.Size(553, 39);
            this.dtPick_IncidentTimeReported.TabIndex = 15;
            // 
            // comb_IncidentPriority
            // 
            this.comb_IncidentPriority.FormattingEnabled = true;
            this.comb_IncidentPriority.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.comb_IncidentPriority.Location = new System.Drawing.Point(546, 520);
            this.comb_IncidentPriority.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comb_IncidentPriority.Name = "comb_IncidentPriority";
            this.comb_IncidentPriority.Size = new System.Drawing.Size(553, 40);
            this.comb_IncidentPriority.TabIndex = 12;
            // 
            // comb_ReportedByUser
            // 
            this.comb_ReportedByUser.FormattingEnabled = true;
            this.comb_ReportedByUser.Location = new System.Drawing.Point(546, 416);
            this.comb_ReportedByUser.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comb_ReportedByUser.Name = "comb_ReportedByUser";
            this.comb_ReportedByUser.Size = new System.Drawing.Size(553, 40);
            this.comb_ReportedByUser.TabIndex = 13;
            // 
            // comb_TypeIncident
            // 
            this.comb_TypeIncident.FormattingEnabled = true;
            this.comb_TypeIncident.Items.AddRange(new object[] {
            "Hardware",
            "Software",
            "Service"});
            this.comb_TypeIncident.Location = new System.Drawing.Point(546, 325);
            this.comb_TypeIncident.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comb_TypeIncident.Name = "comb_TypeIncident";
            this.comb_TypeIncident.Size = new System.Drawing.Size(553, 40);
            this.comb_TypeIncident.TabIndex = 14;
            // 
            // txt_IncidentDescription
            // 
            this.txt_IncidentDescription.Location = new System.Drawing.Point(546, 717);
            this.txt_IncidentDescription.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_IncidentDescription.MaximumSize = new System.Drawing.Size(1853, 2129);
            this.txt_IncidentDescription.MinimumSize = new System.Drawing.Size(368, 102);
            this.txt_IncidentDescription.Multiline = true;
            this.txt_IncidentDescription.Name = "txt_IncidentDescription";
            this.txt_IncidentDescription.Size = new System.Drawing.Size(553, 214);
            this.txt_IncidentDescription.TabIndex = 9;
            // 
            // txtIncidentSubject
            // 
            this.txtIncidentSubject.Location = new System.Drawing.Point(546, 216);
            this.txtIncidentSubject.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIncidentSubject.Name = "txtIncidentSubject";
            this.txtIncidentSubject.Size = new System.Drawing.Size(553, 39);
            this.txtIncidentSubject.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 717);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 616);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 32);
            this.label8.TabIndex = 4;
            this.label8.Text = "Deadline/Follow-up:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 517);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Priority:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Reported by user:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type of incident:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date/time reported:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject of incident:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(510, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new incident ticket";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.incidentsPastDeadlinePictureBox);
            this.tabPage1.Controls.Add(this.unresolvedIncidentsPictureBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.unresolvedIncidentsGroupBox);
            this.tabPage1.Controls.Add(this.incidentsPastDeadlineGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Size = new System.Drawing.Size(1663, 1007);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label22.Location = new System.Drawing.Point(964, 277);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(493, 32);
            this.label22.TabIndex = 25;
            this.label22.Text = "These tickets need your immediate attention";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label21.Location = new System.Drawing.Point(289, 277);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(279, 32);
            this.label21.TabIndex = 24;
            this.label21.Text = "All tickets currently open";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(1046, 221);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(356, 45);
            this.label20.TabIndex = 23;
            this.label20.Text = "Incidents past deadline";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(268, 221);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(324, 45);
            this.label19.TabIndex = 22;
            this.label19.Text = "Unresolved incidents";
            // 
            // incidentsPastDeadlinePictureBox
            // 
            this.incidentsPastDeadlinePictureBox.Location = new System.Drawing.Point(941, 342);
            this.incidentsPastDeadlinePictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.incidentsPastDeadlinePictureBox.Name = "incidentsPastDeadlinePictureBox";
            this.incidentsPastDeadlinePictureBox.Size = new System.Drawing.Size(552, 483);
            this.incidentsPastDeadlinePictureBox.TabIndex = 21;
            this.incidentsPastDeadlinePictureBox.TabStop = false;
            // 
            // unresolvedIncidentsPictureBox
            // 
            this.unresolvedIncidentsPictureBox.Location = new System.Drawing.Point(153, 342);
            this.unresolvedIncidentsPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.unresolvedIncidentsPictureBox.Name = "unresolvedIncidentsPictureBox";
            this.unresolvedIncidentsPictureBox.Size = new System.Drawing.Size(552, 483);
            this.unresolvedIncidentsPictureBox.TabIndex = 20;
            this.unresolvedIncidentsPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1298, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 70);
            this.button1.TabIndex = 19;
            this.button1.Text = "SHOW LIST";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(78, 38);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(466, 72);
            this.label18.TabIndex = 18;
            this.label18.Text = "Current incidents";
            // 
            // unresolvedIncidentsGroupBox
            // 
            this.unresolvedIncidentsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.unresolvedIncidentsGroupBox.Location = new System.Drawing.Point(84, 178);
            this.unresolvedIncidentsGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.unresolvedIncidentsGroupBox.Name = "unresolvedIncidentsGroupBox";
            this.unresolvedIncidentsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.unresolvedIncidentsGroupBox.Size = new System.Drawing.Size(694, 702);
            this.unresolvedIncidentsGroupBox.TabIndex = 26;
            this.unresolvedIncidentsGroupBox.TabStop = false;
            // 
            // incidentsPastDeadlineGroupBox
            // 
            this.incidentsPastDeadlineGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.incidentsPastDeadlineGroupBox.Location = new System.Drawing.Point(868, 178);
            this.incidentsPastDeadlineGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.incidentsPastDeadlineGroupBox.Name = "incidentsPastDeadlineGroupBox";
            this.incidentsPastDeadlineGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.incidentsPastDeadlineGroupBox.Size = new System.Drawing.Size(694, 702);
            this.incidentsPastDeadlineGroupBox.TabIndex = 28;
            this.incidentsPastDeadlineGroupBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1679, 1061);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 1061);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm2";
            this.Text = "MainForm2";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlCreateTicket.ResumeLayout(false);
            this.pnlCreateTicket.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsPastDeadlinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unresolvedIncidentsPictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.ComboBox comboUserType;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxSendEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlCreateTicket;
        private System.Windows.Forms.Button btn_CancelIncident;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.DateTimePicker dtp_Deadline;
        private System.Windows.Forms.DateTimePicker dtPick_IncidentTimeReported;
        private System.Windows.Forms.ComboBox comb_IncidentPriority;
        private System.Windows.Forms.ComboBox comb_ReportedByUser;
        private System.Windows.Forms.ComboBox comb_TypeIncident;
        private System.Windows.Forms.TextBox txt_IncidentDescription;
        private System.Windows.Forms.TextBox txtIncidentSubject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox incidentsPastDeadlinePictureBox;
        private System.Windows.Forms.PictureBox unresolvedIncidentsPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox unresolvedIncidentsGroupBox;
        private System.Windows.Forms.GroupBox incidentsPastDeadlineGroupBox;
        private System.Windows.Forms.TabControl tabControl1;
    }
}