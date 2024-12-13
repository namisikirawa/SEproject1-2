using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Patient
    {
        private string diachi;
        private bool gioitinh;
        private string hoten;
        private string cMND;
        private string ngaysinh;
        private string email;
        private string sdt;

        public string Hoten { get => hoten; set => hoten = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
    }
}
