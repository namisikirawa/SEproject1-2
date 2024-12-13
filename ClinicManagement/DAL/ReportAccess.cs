using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReportAccess
    {
        private static ReportAccess instance;
        private DatabaseAccess access;
        private SqlConnection conn;

        public static ReportAccess Instance {
            get { 
                if(instance==null) instance=new ReportAccess();
                return instance;
            }
            set => instance = value; 
        }
        public DataTable getAllReport()
        {
            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();

            string sql = "select Tieude,NgayBaoCao,NguoiBaoCao from BaoCao";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
            return dt;
        }
    }
}
