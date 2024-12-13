using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class AccountBUS
    {
        private TaiKhoanAccess TKaccess;

        private static AccountBUS instance;

        public static AccountBUS Instance {
            get
            {
                if (instance == null) instance= new AccountBUS();
                return instance;
            }
            set => instance = value; 
        }

        public AccountBUS()
        {
            TKaccess= TaiKhoanAccess.Instance;
        }
        public string checkAccount(Account taikhoan)
        {
            if (taikhoan.Taikhoan=="") {
                return "required_taikhoan";
            }
            if (taikhoan.Matkhau == "")
            {
                return "required_matkhau";
            }
            string info= TKaccess.checkAccount(taikhoan);
            return info;
        }
    }
}
