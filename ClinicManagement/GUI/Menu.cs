using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DTO;
namespace GUI
{
    public partial class Menu_form : Form
    {
        private bool isThoat=true;
        public Menu_form()
        {
            InitializeComponent();
            this.Text = "Menu";
        }
        

        private void mnu_Management_Patient_Click(object sender, EventArgs e)
        {
            PatientManagement cm=new PatientManagement();
            cm.TopLevel = false;
            panel_content.Controls.Add(cm);
            cm.BringToFront();
            cm.Show();

        }

        private void mnu_System_AccountManagement_Click(object sender, EventArgs e)
        {
            AccountManagement am=new AccountManagement();
            am.TopLevel= false;
            panel_content.Controls.Add(am);
            am.BringToFront();
            am.Show();
        }

        private void mnu_System_Logout_Click(object sender, EventArgs e)
        {
            isThoat=false;
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                this.Close();
                Login_form login = new Login_form();
                login.Show();
                UserSession.user = "";
                UserSession.role = "";
            }
            else
            {
                isThoat=true;
            }
        }
        


        private void mnu_Mangament_Employee_Click(object sender, EventArgs e)
        {
            EmployeeManagemenet em = new EmployeeManagemenet();
            em.TopLevel = false;
            panel_content.Controls.Add(em);
            em.BringToFront();
            em.Show();
        }

        private void mnu_Management_Clinic_Click(object sender, EventArgs e)
        {
            ClinicManagement cm = new ClinicManagement();
            cm.TopLevel = false;
            panel_content.Controls.Add(cm);
            cm.BringToFront();
            cm.Show();
        }

        private void mnu_Management_Supplies_Click(object sender, EventArgs e)
        {
            SuppliesManagement sm = new SuppliesManagement();
            sm.TopLevel = false;
            panel_content.Controls.Add(sm);
            sm.BringToFront();
            sm.Show();
        }

        private void mnu_Statistic_Report_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.TopLevel = false;
            panel_content.Controls.Add(rp);
            rp.BringToFront();
            rp.Show();
        }

        private void mnu_System_Click(object sender, EventArgs e)
        {

        }

        private void Menu_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isThoat)
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    isThoat= false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {
            PatientManagement cm = new PatientManagement();
            cm.TopLevel = false;
            panel_content.Controls.Add(cm);
            cm.BringToFront();
            cm.Show();
        }

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
