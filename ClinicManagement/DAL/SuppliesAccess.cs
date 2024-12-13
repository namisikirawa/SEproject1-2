using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuppliesAccess
    {
        private static SuppliesAccess instance;
        private DatabaseAccess access;
        private SqlConnection conn;

        public static SuppliesAccess Instance {
            get
            {
                if (instance == null) instance= new SuppliesAccess();
                return instance;
            }
            set => instance = value; 
        }
        public DataTable getAllSupplies()
        {
            access=DatabaseAccess.Instance;
            conn=access.Connect(); 
            conn.Open();

            string sql = "select TenVatTu,SoLuong,DVT,DonGia,NgayNhap,NgayHetHan,NhaCungCap from VatTu";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();
            return dt;

        }
        public int deleteSupplies(string tenvattu, string ngaynhap, string ngayhethan)
        {
            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();

            string sql = "delete from VatTu where TenVatTu=@tenvattu and NgayNhap=@ngaynhap and NgayHetHan=@ngayhethan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tenvattu",tenvattu);
            cmd.Parameters.AddWithValue("@ngaynhap", ngaynhap);
            cmd.Parameters.AddWithValue("@ngayhethan",ngayhethan);

            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowAffected;
        }
    }
}
