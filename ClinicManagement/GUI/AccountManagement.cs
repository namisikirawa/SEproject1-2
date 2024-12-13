using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AccountManagement : Form
    {
        public AccountManagement()
        {
            InitializeComponent();
            if (UserSession.role != "admin")
            {
                btn_ChangePassword.Enabled = false;
            }
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Bạn có chắc muốn đổi mật khẩu không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information))
            {

            }
        }
    }
}
