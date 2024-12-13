namespace GUI
{
    partial class Menu_form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_System = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_System_AccountManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_System_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Management = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Management_Patient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Mangament_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Management_Clinic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Management_Supplies = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Statistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Statistic_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_content = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_System,
            this.mnu_Management,
            this.mnu_Statistic});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_System
            // 
            this.mnu_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_System_AccountManagement,
            this.toolStripMenuItem1,
            this.mnu_System_Logout});
            this.mnu_System.Name = "mnu_System";
            this.mnu_System.Size = new System.Drawing.Size(85, 26);
            this.mnu_System.Text = "Hệ thống";
            this.mnu_System.Click += new System.EventHandler(this.mnu_System_Click);
            // 
            // mnu_System_AccountManagement
            // 
            this.mnu_System_AccountManagement.Image = global::GUI.Properties.Resources._14669067;
            this.mnu_System_AccountManagement.Name = "mnu_System_AccountManagement";
            this.mnu_System_AccountManagement.Size = new System.Drawing.Size(213, 26);
            this.mnu_System_AccountManagement.Text = "Quản lý tài khoản";
            this.mnu_System_AccountManagement.Click += new System.EventHandler(this.mnu_System_AccountManagement_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 6);
            // 
            // mnu_System_Logout
            // 
            this.mnu_System_Logout.Image = global::GUI.Properties.Resources._16697253;
            this.mnu_System_Logout.Name = "mnu_System_Logout";
            this.mnu_System_Logout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnu_System_Logout.Size = new System.Drawing.Size(213, 26);
            this.mnu_System_Logout.Text = "Đăng xuất";
            this.mnu_System_Logout.Click += new System.EventHandler(this.mnu_System_Logout_Click);
            // 
            // mnu_Management
            // 
            this.mnu_Management.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Management_Patient,
            this.mnu_Mangament_Employee,
            this.toolStripMenuItem2,
            this.mnu_Management_Clinic,
            this.mnu_Management_Supplies});
            this.mnu_Management.Name = "mnu_Management";
            this.mnu_Management.Size = new System.Drawing.Size(73, 26);
            this.mnu_Management.Text = "Quản lý";
            // 
            // mnu_Management_Patient
            // 
            this.mnu_Management_Patient.Image = global::GUI.Properties.Resources._7031048;
            this.mnu_Management_Patient.Name = "mnu_Management_Patient";
            this.mnu_Management_Patient.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.mnu_Management_Patient.Size = new System.Drawing.Size(208, 26);
            this.mnu_Management_Patient.Text = "Bệnh nhân";
            this.mnu_Management_Patient.Click += new System.EventHandler(this.mnu_Management_Patient_Click);
            // 
            // mnu_Mangament_Employee
            // 
            this.mnu_Mangament_Employee.Image = global::GUI.Properties.Resources._912267;
            this.mnu_Mangament_Employee.Name = "mnu_Mangament_Employee";
            this.mnu_Mangament_Employee.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.mnu_Mangament_Employee.Size = new System.Drawing.Size(208, 26);
            this.mnu_Mangament_Employee.Text = "Nhân viên";
            this.mnu_Mangament_Employee.Click += new System.EventHandler(this.mnu_Mangament_Employee_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // mnu_Management_Clinic
            // 
            this.mnu_Management_Clinic.Image = global::GUI.Properties.Resources._3140365;
            this.mnu_Management_Clinic.Name = "mnu_Management_Clinic";
            this.mnu_Management_Clinic.Size = new System.Drawing.Size(208, 26);
            this.mnu_Management_Clinic.Text = "Phòng khám";
            this.mnu_Management_Clinic.Click += new System.EventHandler(this.mnu_Management_Clinic_Click);
            // 
            // mnu_Management_Supplies
            // 
            this.mnu_Management_Supplies.Image = global::GUI.Properties.Resources._3557325;
            this.mnu_Management_Supplies.Name = "mnu_Management_Supplies";
            this.mnu_Management_Supplies.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.mnu_Management_Supplies.Size = new System.Drawing.Size(208, 26);
            this.mnu_Management_Supplies.Text = "Vật tư";
            this.mnu_Management_Supplies.Click += new System.EventHandler(this.mnu_Management_Supplies_Click);
            // 
            // mnu_Statistic
            // 
            this.mnu_Statistic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Statistic_Report});
            this.mnu_Statistic.Name = "mnu_Statistic";
            this.mnu_Statistic.Size = new System.Drawing.Size(84, 26);
            this.mnu_Statistic.Text = "Thống kê";
            // 
            // mnu_Statistic_Report
            // 
            this.mnu_Statistic_Report.Image = global::GUI.Properties.Resources.call_report_icon_3;
            this.mnu_Statistic_Report.Name = "mnu_Statistic_Report";
            this.mnu_Statistic_Report.Size = new System.Drawing.Size(146, 26);
            this.mnu_Statistic_Report.Text = "Báo cáo";
            this.mnu_Statistic_Report.Click += new System.EventHandler(this.mnu_Statistic_Report_Click);
            // 
            // panel_content
            // 
            this.panel_content.AutoScroll = true;
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 30);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(982, 578);
            this.panel_content.TabIndex = 1;
            this.panel_content.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_content_Paint);
            // 
            // Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 608);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_form";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_form_FormClosing);
            this.Load += new System.EventHandler(this.Menu_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_System;
        private System.Windows.Forms.ToolStripMenuItem mnu_System_AccountManagement;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnu_System_Logout;
        private System.Windows.Forms.ToolStripMenuItem mnu_Management;
        private System.Windows.Forms.ToolStripMenuItem mnu_Management_Patient;
        private System.Windows.Forms.ToolStripMenuItem mnu_Mangament_Employee;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnu_Management_Clinic;
        private System.Windows.Forms.ToolStripMenuItem mnu_Management_Supplies;
        private System.Windows.Forms.ToolStripMenuItem mnu_Statistic;
        private System.Windows.Forms.ToolStripMenuItem mnu_Statistic_Report;
        private System.Windows.Forms.Panel panel_content;
    }
}