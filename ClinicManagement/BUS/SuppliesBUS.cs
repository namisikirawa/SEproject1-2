using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class SuppliesBUS
    {
        private static SuppliesBUS instance;
        private static SuppliesAccess access;

        public static SuppliesBUS Instance {
            get
            {
                if (instance == null) instance= new SuppliesBUS();
                return instance;
            }
            set => instance = value; 
        }
        public DataTable getAllSupplies()
        {
            access = SuppliesAccess.Instance;
            return access.getAllSupplies();
        }
        public int deleteSupplies(string tenvattu, string ngaynhap,string ngayhethan)
        {
            access = SuppliesAccess.Instance;
            return access.deleteSupplies(tenvattu,ngaynhap, ngayhethan);
        }
    }
}
