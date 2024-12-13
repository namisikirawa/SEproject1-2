using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EmployeeManagemenet : Form
    {
        private EmployeeBUS bus;
        private int rowIndex = -1;
        public EmployeeManagemenet()
        {
            InitializeComponent();
            if (UserSession.role != "admin")
            {
                btn_Themmoi.Enabled = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Add_Employee_form add_employee = new Add_Employee_form();
            add_employee.ShowDialog();
        }

        //load dữ liệu lên gridview
        void createColumnForGridView()
        {
            var colHoten = new DataGridViewTextBoxColumn();
            var colNgaysinh = new DataGridViewTextBoxColumn();
            var colSdt = new DataGridViewTextBoxColumn();
            var colEmail = new DataGridViewTextBoxColumn();
            var colDiachi = new DataGridViewTextBoxColumn();
            var colChucVu=new DataGridViewTextBoxColumn();
            var colBangCap= new DataGridViewTextBoxColumn();
            var colKNLamViec=new DataGridViewTextBoxColumn();
            var colGioLamViec = new DataGridViewTextBoxColumn();

            colHoten.DataPropertyName = "HoTen";
            colNgaysinh.DataPropertyName = "NgaySinh";
            colSdt.DataPropertyName = "SDT";
            colEmail.DataPropertyName = "Email";
            colDiachi.DataPropertyName = "DiaChi";
            colBangCap.DataPropertyName = "BangCap";
            colChucVu.DataPropertyName = "ChucVu";
            colKNLamViec.DataPropertyName = "KNLamViec";
            colGioLamViec.DataPropertyName = "GioLamViec";

            colHoten.HeaderText = "Họ tên";
            colNgaysinh.HeaderText = "Ngày sinh";
            colSdt.HeaderText = "Số điện thoại";
            colEmail.HeaderText = "Email";
            colDiachi.HeaderText = "Địa chỉ";
            colBangCap.HeaderText = "Bằng cấp";
            colKNLamViec.HeaderText = "Kinh nghiệm làm việc";
            colChucVu.HeaderText = "Chức vụ";
            colGioLamViec.HeaderText = "Giờ làm việc";

            colHoten.Name = "HoTen";
            colNgaysinh.Name = "NgaySinh";
            colSdt.Name = "SoDienThoai";
            colEmail.Name = "Email";
            colDiachi.Name = "DiaChi";
            colBangCap.Name = "BangCap";
            colKNLamViec.Name = "KNLamViec";
            colChucVu.Name = "ChucVu";
            colGioLamViec.Name = "GioLamViec";

            colHoten.Width = 150;
            colNgaysinh.Width = 120;
            colSdt.Width = 120;
            colEmail.Width = 150;
            colDiachi.Width = 220;

            dgv_Employee.Columns.AddRange(new DataGridViewColumn[] { colHoten, colNgaysinh, colSdt, colEmail, colDiachi, colChucVu,colBangCap,colKNLamViec,colGioLamViec });
        }
        //hàm load form
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            createColumnForGridView();
            loadGridView();
        }
        //hàm load gridview
        private void loadGridView()
        {
            bus = EmployeeBUS.Instance;
            dgv_Employee.DataSource = bus.getAllEmployee();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bus=EmployeeBUS.Instance;
            dgv_Employee.DataSource=bus.getAllEmployee();
        }

        private void dgv_Employee_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (UserSession.role == "admin")
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgv_Employee.Rows[e.RowIndex].Selected = true;
                    this.rowIndex = e.RowIndex;
                    dgv_Employee.CurrentCell = dgv_Employee.Rows[rowIndex].Cells[1];
                    this.contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                return;
            }
            string ngaysinh = dgv_Employee.Rows[rowIndex].Cells["NgaySinh"].Value.ToString();
            string sdt = dgv_Employee.Rows[rowIndex].Cells["SoDienThoai"].Value.ToString();
            int rowAffected = bus.deleteEmployee(ngaysinh, sdt);
            if (rowAffected > 0)
            {
                MessageBox.Show("Xóa nhân viên thành công!");
                loadGridView();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, hãy thử lại sau!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
