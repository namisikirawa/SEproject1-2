using BUS;
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
    public partial class ClinicManagement : Form
    {
        private ClinicBUS bus;
        public ClinicManagement()
        {
            InitializeComponent();
            if (UserSession.role != "admin")
            {
                btn_Capnhat.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Update_Clinic uc= new Update_Clinic();
            uc.ShowDialog();
        }

        private void ClinicManagement_Load(object sender, EventArgs e)
        {
            bus = ClinicBUS.Instance;
            Clinic info = new Clinic();
            info = bus.getClinicInfo();

            txtNguoidaidien.Text = info.NguoiDaiDien;
            txtNguoidaidien.ReadOnly = true;

            txtDiachi.Text = info.DiaChi;
            txtDiachi.ReadOnly = true;

            txtEmail.Text = info.Email;
            txtEmail.ReadOnly = true;

            txtGioithieu.Text = info.GioiThieu;
            txtGioithieu.ReadOnly= true;

            txtSdt.Text = info.Sdt;
            txtSdt.ReadOnly = true;

            txtSobenhnhan.Text = info.SoBenhNhan;
            txtSobenhnhan.ReadOnly= true;

            txtSophong.Text = info.SoPhong;
            txtSophong.ReadOnly = true;

            txtGiolamviec.Text = info.GioLamViec;
            txtGiolamviec.ReadOnly = true;

            txtNgayCapNhat.Text= info.NgayCapNhat;
            txtNgayCapNhat.ReadOnly= true;

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
