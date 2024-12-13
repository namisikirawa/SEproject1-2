using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }

        public Account(string tk, string mk) { 
            this.Taikhoan= tk;
            this.Matkhau= mk;
        }

    }
}
