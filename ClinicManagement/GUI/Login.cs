using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class Login_form : Form
    {
        private Account taikhoan;
        private AccountBUS tkBUS;

        public Login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string tk = txtTaikhoan.Text;
            string mk=txtMatkhau.Text;
            taikhoan=new Account(tk,mk);

            tkBUS = AccountBUS.Instance;
            string check=tkBUS.checkAccount(taikhoan);
            if(check.Split(' ').Length > 1)
            {
                UserSession.user = check.Split(' ')[0];
                UserSession.role= check.Split(' ')[1];
                MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công!");
              
                Menu_form form = new Menu_form();
                form.Show();
                this.Hide();
              
            }
            switch (check)
            {
                case "invalid_account":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");break;
                case "required_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");break;
                case "required_matkhau":
                    MessageBox.Show("Mật khẩu không được để trống");break;
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Application.Exit();
            }
           
        }
    }
}
