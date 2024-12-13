using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BUS
{
    public class ClinicBUS
    {
        private static ClinicBUS instance;
        private ClinicAccess access;

        public static ClinicBUS Instance
        {
            get
            {
                if (instance == null) instance = new ClinicBUS();
                return instance;
            }
            set => instance = value;
        }
        public Clinic getClinicInfo()
        {
            access=ClinicAccess.Instance;
            return access.getClinicInfo();
        }
    }
}
