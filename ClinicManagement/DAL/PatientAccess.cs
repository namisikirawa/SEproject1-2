using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class PatientAccess
    {
        private DatabaseAccess access;
        private SqlConnection conn;
        private HealthStatus status;

        private static PatientAccess instance;

        public static PatientAccess Instance {
            get
            {
                if(instance==null) instance= new PatientAccess();
                return instance;
            }
            set => instance = value; 
        }

        public DataTable getAllPatient()
        {
            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();

            string sql = "select HoTen,CMND,Ngaysinh,Email,SoDienThoai,Diachi from BenhNhan";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public int deletePatient(string cmnd, string sdt)
        {
            access= DatabaseAccess.Instance;
            conn=access.Connect();
            conn.Open();

            string sql = "delete from BenhNhan where CMND=@cmnd and SoDienThoai=@sdt";
            SqlCommand cmd=new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cmnd", cmnd);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            
            int rowAffected=cmd.ExecuteNonQuery();
            conn.Close();
            return rowAffected;
        }
        public HealthStatus getHealthStatus(string cmnd)
        {
            HealthStatus status=new HealthStatus();
            string chieucao, cannang, NhomMau, Tiensuba, diung, ghichu;
         
            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();

            string sql = "select ChieuCao,CanNang, NhomMau,TienSuBenhAn,DiUng,GhiChu from TinhTrangSK inner join BenhNhan on BenhNhan.MaBN=TinhTrangSK.MaBN where CMND=@cmnd ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cmnd",cmnd);
            SqlDataReader reader=cmd.ExecuteReader();
            if (reader.Read())
            {
                chieucao = reader["ChieuCao"].ToString();
                cannang = reader["CanNang"].ToString();
                NhomMau = reader["NhomMau"].ToString();
                Tiensuba = reader["TienSuBenhAn"].ToString();
                diung = reader["DiUng"].ToString();
                ghichu = reader["GhiChu"].ToString();
                status=new HealthStatus(chieucao,cannang,NhomMau,Tiensuba,diung,ghichu);
            }

            conn.Close();
            return status;
        }
        //tìm kiếm
        //trường hợp nhập cả 2 trường họ tên và sdt
        public DataTable findPatient(string hoten,string sdt)
        {
            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();

            string sql = "select HoTen,CMND,Ngaysinh,Email,SoDienThoai,Diachi from BenhNhan where HoTen like @hoten or SoDienThoai like @sdt";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@hoten","%"+hoten+"%");
            cmd.Parameters.AddWithValue("@sdt","%" +sdt+"%");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        //trường hợp để trống họ tên
        public DataTable findPatientPhoneNumber(string sdt)
        {
            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();

            string sql = "select HoTen,CMND,Ngaysinh,Email,SoDienThoai,Diachi from BenhNhan where SoDienThoai like @sdt";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@sdt", "%" + sdt + "%");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }   
        //trường hợp để trống sdt
        public DataTable findPatientName(string hoten)
        {
            access = DatabaseAccess.Instance;
            conn = access.Connect();
            conn.Open();

            string sql = "select HoTen,CMND,Ngaysinh,Email,SoDienThoai,Diachi from BenhNhan where HoTen like @hoten";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@hoten", "%" + hoten + "%");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
