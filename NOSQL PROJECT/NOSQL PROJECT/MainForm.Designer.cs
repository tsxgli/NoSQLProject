namespace NOSQL_PROJECT
{
    partial class MainForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlCreateIncident = new System.Windows.Forms.Panel();
            this.btn_CancelIncident = new System.Windows.Forms.Button();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.dtPick_IncidentTimeReported = new System.Windows.Forms.DateTimePicker();
            this.comb_IncidentDeadline = new System.Windows.Forms.ComboBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSendEmail = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.comboUserType = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.pnlCreateIncident.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pnlCreateIncident);
            this.tabPage2.Location = new System.Drawing.Point(8, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage2.Size = new System.Drawing.Size(1225, 1343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incident Management";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlCreateIncident
            // 
            this.pnlCreateIncident.Controls.Add(this.btn_CancelIncident);
            this.pnlCreateIncident.Controls.Add(this.btnSubmitTicket);
            this.pnlCreateIncident.Controls.Add(this.dtPick_IncidentTimeReported);
            this.pnlCreateIncident.Controls.Add(this.comb_IncidentDeadline);
            this.pnlCreateIncident.Controls.Add(this.comb_IncidentPriority);
            this.pnlCreateIncident.Controls.Add(this.comb_ReportedByUser);
            this.pnlCreateIncident.Controls.Add(this.comb_TypeIncident);
            this.pnlCreateIncident.Controls.Add(this.txt_IncidentDescription);
            this.pnlCreateIncident.Controls.Add(this.txtIncidentSubject);
            this.pnlCreateIncident.Controls.Add(this.label9);
            this.pnlCreateIncident.Controls.Add(this.label8);
            this.pnlCreateIncident.Controls.Add(this.label7);
            this.pnlCreateIncident.Controls.Add(this.label6);
            this.pnlCreateIncident.Controls.Add(this.label5);
            this.pnlCreateIncident.Controls.Add(this.label4);
            this.pnlCreateIncident.Controls.Add(this.label3);
            this.pnlCreateIncident.Controls.Add(this.label2);
            this.pnlCreateIncident.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateIncident.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlCreateIncident.Name = "pnlCreateIncident";
            this.pnlCreateIncident.Size = new System.Drawing.Size(1917, 1331);
            this.pnlCreateIncident.TabIndex = 1;
            this.pnlCreateIncident.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCreateIncident_Paint);
            // 
            // btn_CancelIncident
            // 
            this.btn_CancelIncident.BackColor = System.Drawing.Color.White;
            this.btn_CancelIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelIncident.Location = new System.Drawing.Point(420, 1077);
            this.btn_CancelIncident.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_CancelIncident.Name = "btn_CancelIncident";
            this.btn_CancelIncident.Size = new System.Drawing.Size(260, 70);
            this.btn_CancelIncident.TabIndex = 5;
            this.btn_CancelIncident.Text = "CANCEL";
            this.btn_CancelIncident.UseVisualStyleBackColor = false;
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmitTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitTicket.Location = new System.Drawing.Point(715, 1077);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(262, 70);
            this.btnSubmitTicket.TabIndex = 5;
            this.btnSubmitTicket.Text = "SUBMIT TICKET";
            this.btnSubmitTicket.UseVisualStyleBackColor = false;
            // 
            // dtPick_IncidentTimeReported
            // 
            this.dtPick_IncidentTimeReported.Location = new System.Drawing.Point(420, 169);
            this.dtPick_IncidentTimeReported.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtPick_IncidentTimeReported.Name = "dtPick_IncidentTimeReported";
            this.dtPick_IncidentTimeReported.Size = new System.Drawing.Size(554, 39);
            this.dtPick_IncidentTimeReported.TabIndex = 4;
            // 
            // comb_IncidentDeadline
            // 
            this.comb_IncidentDeadline.FormattingEnabled = true;
            this.comb_IncidentDeadline.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.comb_IncidentDeadline.Location = new System.Drawing.Point(420, 668);
            this.comb_IncidentDeadline.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comb_IncidentDeadline.Name = "comb_IncidentDeadline";
            this.comb_IncidentDeadline.Size = new System.Drawing.Size(554, 40);
            this.comb_IncidentDeadline.TabIndex = 3;
            // 
            // comb_IncidentPriority
            // 
            this.comb_IncidentPriority.FormattingEnabled = true;
            this.comb_IncidentPriority.Location = new System.Drawing.Point(420, 572);
            this.comb_IncidentPriority.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comb_IncidentPriority.Name = "comb_IncidentPriority";
            this.comb_IncidentPriority.Size = new System.Drawing.Size(554, 40);
            this.comb_IncidentPriority.TabIndex = 3;
            // 
            // comb_ReportedByUser
            // 
            this.comb_ReportedByUser.FormattingEnabled = true;
            this.comb_ReportedByUser.Location = new System.Drawing.Point(420, 467);
            this.comb_ReportedByUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comb_ReportedByUser.Name = "comb_ReportedByUser";
            this.comb_ReportedByUser.Size = new System.Drawing.Size(554, 40);
            this.comb_ReportedByUser.TabIndex = 3;
            // 
            // comb_TypeIncident
            // 
            this.comb_TypeIncident.FormattingEnabled = true;
            this.comb_TypeIncident.Location = new System.Drawing.Point(420, 375);
            this.comb_TypeIncident.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comb_TypeIncident.Name = "comb_TypeIncident";
            this.comb_TypeIncident.Size = new System.Drawing.Size(554, 40);
            this.comb_TypeIncident.TabIndex = 3;
            // 
            // txt_IncidentDescription
            // 
            this.txt_IncidentDescription.Location = new System.Drawing.Point(420, 768);
            this.txt_IncidentDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_IncidentDescription.MaximumSize = new System.Drawing.Size(1854, 2129);
            this.txt_IncidentDescription.MinimumSize = new System.Drawing.Size(368, 102);
            this.txt_IncidentDescription.Multiline = true;
            this.txt_IncidentDescription.Name = "txt_IncidentDescription";
            this.txt_IncidentDescription.Size = new System.Drawing.Size(554, 213);
            this.txt_IncidentDescription.TabIndex = 2;
            // 
            // txtIncidentSubject
            // 
            this.txtIncidentSubject.Location = new System.Drawing.Point(420, 267);
            this.txtIncidentSubject.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtIncidentSubject.Name = "txtIncidentSubject";
            this.txtIncidentSubject.Size = new System.Drawing.Size(554, 39);
            this.txtIncidentSubject.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 774);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 674);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Deadline/Follow-up:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 572);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Priority:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 474);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Reported by user:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 393);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type of incident:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Subject of incident:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date/time reported:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(147, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(704, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create new incident ticket.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overview Tickets";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage1.Size = new System.Drawing.Size(1225, 1343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1241, 1397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(8, 46);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tabPage3.Size = new System.Drawing.Size(1225, 1343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User Management";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxSendEmail);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.comboLocation);
            this.panel1.Controls.Add(this.comboUserType);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 1331);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxSendEmail
            // 
            this.checkBoxSendEmail.AutoSize = true;
            this.checkBoxSendEmail.Location = new System.Drawing.Point(423, 770);
            this.checkBoxSendEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxSendEmail.Name = "checkBoxSendEmail";
            this.checkBoxSendEmail.Size = new System.Drawing.Size(591, 36);
            this.checkBoxSendEmail.TabIndex = 6;
            this.checkBoxSendEmail.Text = "Yes, a password will be sent in an email to the user.";
            this.checkBoxSendEmail.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(373, 924);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(260, 70);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(745, 924);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(262, 70);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // comboLocation
            // 
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Knuppeldam",
            "Headquarters(HQ)"});
            this.comboLocation.Location = new System.Drawing.Point(420, 668);
            this.comboLocation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(554, 40);
            this.comboLocation.TabIndex = 3;
            // 
            // comboUserType
            // 
            this.comboUserType.FormattingEnabled = true;
            this.comboUserType.Items.AddRange(new object[] {
            "Employee",
            "Service desk employee"});
            this.comboUserType.Location = new System.Drawing.Point(420, 393);
            this.comboUserType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboUserType.Name = "comboUserType";
            this.comboUserType.Size = new System.Drawing.Size(554, 40);
            this.comboUserType.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(420, 284);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(554, 39);
            this.txtLastName.TabIndex = 2;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(420, 572);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(554, 39);
            this.txtPhoneNo.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(420, 474);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(554, 39);
            this.txtEmail.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(420, 181);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(554, 39);
            this.txtFirstName.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 757);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Send password?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(147, 674);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 32);
            this.label12.TabIndex = 1;
            this.label12.Text = "Location/branch:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(147, 572);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 32);
            this.label13.TabIndex = 1;
            this.label13.Text = "Phone number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(147, 474);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(174, 32);
            this.label14.TabIndex = 1;
            this.label14.Text = "E-mail address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(147, 393);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 32);
            this.label15.TabIndex = 1;
            this.label15.Text = "Type of user:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(147, 284);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 32);
            this.label16.TabIndex = 1;
            this.label16.Text = "Last name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(147, 181);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 32);
            this.label17.TabIndex = 1;
            this.label17.Text = "First name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(147, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 72);
            this.label10.TabIndex = 0;
            this.label10.Text = "Create user";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 1408);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlCreateIncident.ResumeLayout(false);
            this.pnlCreateIncident.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlCreateIncident;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIncidentSubject;
        private System.Windows.Forms.DateTimePicker dtPick_IncidentTimeReported;
        private System.Windows.Forms.ComboBox comb_IncidentDeadline;
        private System.Windows.Forms.ComboBox comb_IncidentPriority;
        private System.Windows.Forms.ComboBox comb_ReportedByUser;
        private System.Windows.Forms.ComboBox comb_TypeIncident;
        private System.Windows.Forms.TextBox txt_IncidentDescription;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.Button btn_CancelIncident;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.ComboBox comboUserType;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox checkBoxSendEmail;
        private System.Windows.Forms.Label label11;
    }
}