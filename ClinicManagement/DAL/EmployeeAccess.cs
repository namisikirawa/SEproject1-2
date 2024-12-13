using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeAccess
    {
        private static EmployeeAccess instance;
        private DatabaseAccess access;
        private SqlConnection conn;

        public static EmployeeAccess Instance {
            get
            {
                if (instance == null) instance=new EmployeeAccess();
                return instance;
            } 
            set => instance = value; 
        }
        public DataTable getAllEmployee()
        {
            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();
            string sql = "select HoTen,NgaySinh,Email,SDT,Diachi,ChucVu,BangCap,KNLamViec,GioLamViec from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public int deleteEmployee(string ngaysinh, string sdt)
        {
            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();

            string sql = "delete from NhanVien where NgaySinh=@ngaysinh and SDT=@sdt";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@sdt", sdt);

            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowAffected;
        }
    }
}
