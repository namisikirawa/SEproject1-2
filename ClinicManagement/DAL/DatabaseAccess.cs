using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseAccess
    {
        private static DatabaseAccess instance;

        public static DatabaseAccess Instance { 
            get
            {
                if (instance == null)
                {
                    instance= new DatabaseAccess();
                }
                return instance;
            }  
            set => instance = value; 
        }

        public SqlConnection Connect()
        {
            string strcon = @"Data Source=LAPTOP-ITMNS7GB\SQLEXPRESS02;Initial Catalog=ClinicManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
}
