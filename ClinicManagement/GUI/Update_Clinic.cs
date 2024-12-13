using BUS;
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
namespace GUI
{
    public partial class Update_Clinic : Form
    {
        private ClinicBUS bus;
        public Update_Clinic()
        {
            InitializeComponent();
            this.Text = "Cập nhật thông tin";
        }

        private void txtSophong_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Clinic_Load(object sender, EventArgs e)
        {
            bus=ClinicBUS.Instance;
            Clinic info=new Clinic();
            info=bus.getClinicInfo();

            txtNguoidaidien.Text = info.NguoiDaiDien;

            txtDiachi.Text = info.DiaChi;

            txtEmail.Text = info.Email;

            txtGioithieu.Text = info.GioiThieu;

            txtSdt.Text = info.Sdt;

            txtSobenhnhan.Text = info.SoBenhNhan;

            txtSophong.Text = info.SoPhong;

            txtGiolamviec.Text = info.GioLamViec;

            txtNgaycapnhat.Text = info.NgayCapNhat;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
