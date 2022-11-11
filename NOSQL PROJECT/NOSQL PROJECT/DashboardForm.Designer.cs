namespace NOSQL_PROJECT
{
    partial class DashboardForm
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
            this.ticketsAttentionLbl = new System.Windows.Forms.Label();
            this.ticketsOpenLbl = new System.Windows.Forms.Label();
            this.ticketsPastDeadlineLbl = new System.Windows.Forms.Label();
            this.unresolvedIncidentsLbl = new System.Windows.Forms.Label();
            this.incidentsPastDeadlinePictureBox = new System.Windows.Forms.PictureBox();
            this.unresolvedIncidentsPictureBox = new System.Windows.Forms.PictureBox();
            this.showTicketsListBtn = new System.Windows.Forms.Button();
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.unresolvedIncidentsGroupBox = new System.Windows.Forms.GroupBox();
            this.incidentsPastDeadlineGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsPastDeadlinePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unresolvedIncidentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketsAttentionLbl
            // 
            this.ticketsAttentionLbl.AutoSize = true;
            this.ticketsAttentionLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ticketsAttentionLbl.Location = new System.Drawing.Point(596, 194);
            this.ticketsAttentionLbl.Name = "ticketsAttentionLbl";
            this.ticketsAttentionLbl.Size = new System.Drawing.Size(303, 20);
            this.ticketsAttentionLbl.TabIndex = 36;
            this.ticketsAttentionLbl.Text = "These tickets need your immediate attention";
            // 
            // ticketsOpenLbl
            // 
            this.ticketsOpenLbl.AutoSize = true;
            this.ticketsOpenLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ticketsOpenLbl.Location = new System.Drawing.Point(181, 194);
            this.ticketsOpenLbl.Name = "ticketsOpenLbl";
            this.ticketsOpenLbl.Size = new System.Drawing.Size(172, 20);
            this.ticketsOpenLbl.TabIndex = 35;
            this.ticketsOpenLbl.Text = "All tickets currently open";
            // 
            // ticketsPastDeadlineLbl
            // 
            this.ticketsPastDeadlineLbl.AutoSize = true;
            this.ticketsPastDeadlineLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketsPastDeadlineLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ticketsPastDeadlineLbl.Location = new System.Drawing.Point(647, 159);
            this.ticketsPastDeadlineLbl.Name = "ticketsPastDeadlineLbl";
            this.ticketsPastDeadlineLbl.Size = new System.Drawing.Size(223, 28);
            this.ticketsPastDeadlineLbl.TabIndex = 34;
            this.ticketsPastDeadlineLbl.Text = "Incidents past deadline";
            // 
            // unresolvedIncidentsLbl
            // 
            this.unresolvedIncidentsLbl.AutoSize = true;
            this.unresolvedIncidentsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unresolvedIncidentsLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.unresolvedIncidentsLbl.Location = new System.Drawing.Point(168, 159);
            this.unresolvedIncidentsLbl.Name = "unresolvedIncidentsLbl";
            this.unresolvedIncidentsLbl.Size = new System.Drawing.Size(203, 28);
            this.unresolvedIncidentsLbl.TabIndex = 33;
            this.unresolvedIncidentsLbl.Text = "Unresolved incidents";
            // 
            // incidentsPastDeadlinePictureBox
            // 
            this.incidentsPastDeadlinePictureBox.Location = new System.Drawing.Point(582, 235);
            this.incidentsPastDeadlinePictureBox.Name = "incidentsPastDeadlinePictureBox";
            this.incidentsPastDeadlinePictureBox.Size = new System.Drawing.Size(340, 302);
            this.incidentsPastDeadlinePictureBox.TabIndex = 32;
            this.incidentsPastDeadlinePictureBox.TabStop = false;
            // 
            // unresolvedIncidentsPictureBox
            // 
            this.unresolvedIncidentsPictureBox.Location = new System.Drawing.Point(97, 235);
            this.unresolvedIncidentsPictureBox.Name = "unresolvedIncidentsPictureBox";
            this.unresolvedIncidentsPictureBox.Size = new System.Drawing.Size(340, 302);
            this.unresolvedIncidentsPictureBox.TabIndex = 31;
            this.unresolvedIncidentsPictureBox.TabStop = false;
            // 
            // showTicketsListBtn
            // 
            this.showTicketsListBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.showTicketsListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showTicketsListBtn.Location = new System.Drawing.Point(802, 53);
            this.showTicketsListBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showTicketsListBtn.Name = "showTicketsListBtn";
            this.showTicketsListBtn.Size = new System.Drawing.Size(161, 44);
            this.showTicketsListBtn.TabIndex = 30;
            this.showTicketsListBtn.Text = "SHOW LIST";
            this.showTicketsListBtn.UseVisualStyleBackColor = false;
            // 
            // dashboardLabel
            // 
            this.dashboardLabel.AutoSize = true;
            this.dashboardLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dashboardLabel.Location = new System.Drawing.Point(51, 45);
            this.dashboardLabel.Name = "dashboardLabel";
            this.dashboardLabel.Size = new System.Drawing.Size(296, 46);
            this.dashboardLabel.TabIndex = 29;
            this.dashboardLabel.Text = "Current incidents";
            // 
            // unresolvedIncidentsGroupBox
            // 
            this.unresolvedIncidentsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.unresolvedIncidentsGroupBox.Location = new System.Drawing.Point(55, 132);
            this.unresolvedIncidentsGroupBox.Name = "unresolvedIncidentsGroupBox";
            this.unresolvedIncidentsGroupBox.Size = new System.Drawing.Size(427, 439);
            this.unresolvedIncidentsGroupBox.TabIndex = 37;
            this.unresolvedIncidentsGroupBox.TabStop = false;
            // 
            // incidentsPastDeadlineGroupBox
            // 
            this.incidentsPastDeadlineGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.incidentsPastDeadlineGroupBox.Location = new System.Drawing.Point(537, 132);
            this.incidentsPastDeadlineGroupBox.Name = "incidentsPastDeadlineGroupBox";
            this.incidentsPastDeadlineGroupBox.Size = new System.Drawing.Size(427, 439);
            this.incidentsPastDeadlineGroupBox.TabIndex = 38;
            this.incidentsPastDeadlineGroupBox.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 616);
            this.Controls.Add(this.ticketsAttentionLbl);
            this.Controls.Add(this.ticketsOpenLbl);
            this.Controls.Add(this.ticketsPastDeadlineLbl);
            this.Controls.Add(this.unresolvedIncidentsLbl);
            this.Controls.Add(this.incidentsPastDeadlinePictureBox);
            this.Controls.Add(this.unresolvedIncidentsPictureBox);
            this.Controls.Add(this.showTicketsListBtn);
            this.Controls.Add(this.dashboardLabel);
            this.Controls.Add(this.unresolvedIncidentsGroupBox);
            this.Controls.Add(this.incidentsPastDeadlineGroupBox);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.incidentsPastDeadlinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unresolvedIncidentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ticketsAttentionLbl;
        private System.Windows.Forms.Label ticketsOpenLbl;
        private System.Windows.Forms.Label ticketsPastDeadlineLbl;
        private System.Windows.Forms.Label unresolvedIncidentsLbl;
        private System.Windows.Forms.PictureBox incidentsPastDeadlinePictureBox;
        private System.Windows.Forms.PictureBox unresolvedIncidentsPictureBox;
        private System.Windows.Forms.Button showTicketsListBtn;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.GroupBox unresolvedIncidentsGroupBox;
        private System.Windows.Forms.GroupBox incidentsPastDeadlineGroupBox;
    }
}