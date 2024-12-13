using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TaiKhoanAccess
    {
        private DatabaseAccess databaseAccess;
        private SqlConnection conn;

        private static TaiKhoanAccess instance;

        public static TaiKhoanAccess Instance {
            get {
                if (instance == null) instance= new TaiKhoanAccess();
                return instance;
            }
            set => instance = value; 
        }

        public string checkAccount(Account tk)
        {
            databaseAccess =DatabaseAccess.Instance;
            conn = databaseAccess.Connect();
            conn.Open();
            string sql = "select TaiKhoan, TenQuyen from PhanQuyen,TaiKhoan where PhanQuyen.MaQuyen=TaiKhoan.MaQuyen and TaiKhoan.TaiKhoan=@taikhoan and TaiKhoan.MatKhau=@matkhau";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@taikhoan", tk.Taikhoan);
            cmd.Parameters.AddWithValue("@matkhau", tk.Matkhau);
            
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string user = reader.GetString(0);
                    string role = reader.GetString(1);
                    return user + " " + role;
                }
                reader.Close();
                conn.Close();
            }
            return "invalid_account";
        }
    }
}
