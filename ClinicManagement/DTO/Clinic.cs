using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Clinic
    {
        private string nguoiDaiDien, gioiThieu, diaChi, sdt, email, gioLamViec, ngayCapNhat;
        private string soBenhNhan, soPhong;
        public Clinic() { }
        public Clinic(string nguoiDaiDien, string gioiThieu, string diaChi, string sdt, string email, string gioLamViec, string ngayCapNhat, string soBenhNhan, string soPhong)
        {
            this.nguoiDaiDien = nguoiDaiDien;
            this.gioiThieu = gioiThieu;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.email = email;
            this.gioLamViec = gioLamViec;
            this.ngayCapNhat = ngayCapNhat;
            this.soBenhNhan = soBenhNhan;
            this.soPhong = soPhong;
        }

        public string NguoiDaiDien { get => nguoiDaiDien; set => nguoiDaiDien = value; }
        public string GioiThieu { get => gioiThieu; set => gioiThieu = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string GioLamViec { get => gioLamViec; set => gioLamViec = value; }
        public string NgayCapNhat { get => ngayCapNhat; set => ngayCapNhat = value; }
        public string SoBenhNhan { get => soBenhNhan; set => soBenhNhan = value; }
        public string SoPhong { get => soPhong; set => soPhong = value; }
    }
}
