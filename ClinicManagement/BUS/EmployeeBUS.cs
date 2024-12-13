using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EmployeeBUS
    {
        private static EmployeeBUS instance;
        private EmployeeAccess access;
        public static EmployeeBUS Instance {
            get
            {
                if (instance == null) instance= new EmployeeBUS();
                return instance;
            }
            set => instance = value; 
        }
        public DataTable getAllEmployee()
        {
            access = EmployeeAccess.Instance;
            return access.getAllEmployee();
        }
        public int deleteEmployee(string ngaysinh,string sdt)
        {
            access = EmployeeAccess.Instance;
            return access.deleteEmployee(ngaysinh,sdt);
        }
    }
}
