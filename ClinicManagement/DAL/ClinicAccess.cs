using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClinicAccess
    {
        private static ClinicAccess instance;
        private DatabaseAccess access;
        private SqlConnection conn;

        public static ClinicAccess Instance
        {
            get
            {
                if (instance == null) instance = new ClinicAccess();
                return instance;
            }
            set => instance = value;
        }

        public Clinic getClinicInfo()
        {
            Clinic info = new Clinic();
            string nguoidaidien,gioithieu,diachi,sdt,email,giolamviec, ngaycapnhat,sobenhnhan, sophong;

            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();

            string sql = "select * from PhongKham";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                nguoidaidien = reader["NguoiDaiDien"].ToString();
                gioithieu = reader["GioiThieu"].ToString();
                diachi = reader["DiaChi"].ToString();
                sdt = reader["SoDienThoai"].ToString();
                email = reader["Email"].ToString();
                giolamviec = reader["GioLamViec"].ToString();
                ngaycapnhat = reader["NgayCapNhat"].ToString() ;
                sobenhnhan = reader["SoBenhNhan"].ToString();
                sophong = reader["SoPhong"].ToString();
                info = new Clinic(nguoidaidien,gioithieu,diachi,sdt,email,giolamviec,ngaycapnhat,sobenhnhan,sophong);
            }

            conn.Close();
            return info;
        }
    }
}
