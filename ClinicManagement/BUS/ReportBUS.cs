using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ReportBUS
    {
        private static ReportBUS instance;
        private ReportAccess access;
        public static ReportBUS Instance
        {
            get {
                if (instance == null) instance= new ReportBUS();    
                return instance; }
            set { instance = value; }
        }
        public DataTable getAllReport()
        {
            access = ReportAccess.Instance;
            return access.getAllReport();
        }
    }
}
