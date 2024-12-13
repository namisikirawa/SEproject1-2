using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class PatientBUS
    {
        private static PatientBUS instance;
        private PatientAccess access;

        public static PatientBUS Instance {
            get
            {
                if(instance == null) instance= new PatientBUS();
                return instance;
            } 
            set => instance = value; 
        }

        public DataTable getAllPatient()
        {
            access=PatientAccess.Instance;
            return access.getAllPatient();
        }
        public int deletePatient(string cmnd,string sdt)
        {
            access=PatientAccess.Instance;
            return access.deletePatient(cmnd,sdt);
        }
        public HealthStatus getHealthStatus(string cmnd)
        {
            access=PatientAccess.Instance;
            return access.getHealthStatus(cmnd);
        }
        public DataTable findPatient(string hoten,string sdt)
        {
            access=PatientAccess.Instance;
            return access.findPatient(hoten,sdt);
        }
        public DataTable findPatientName(string hoten)
        {
            access = PatientAccess.Instance;
            return access.findPatientName(hoten);
        }
        public DataTable findPatientPhoneNumber(string sdt)
        {
            access = PatientAccess.Instance;
            return access.findPatientPhoneNumber(sdt);
        }
    }
}
