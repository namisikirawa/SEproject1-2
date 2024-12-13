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
using BUS;
namespace GUI
{
    public partial class PatientManagement : Form
    {
        private PatientBUS bus;
        private int rowIndex=-1;
        public PatientManagement()
        {
            InitializeComponent();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Add_Patient_form add_patient=new Add_Patient_form();
            add_patient.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bus = PatientBUS.Instance;
            dgv_Patient.DataSource = bus.getAllPatient();
        }
        //load dữ liệu lên gridview
        void createColumnForGridView()
        {
            var colHoten=new DataGridViewTextBoxColumn();
            var colCMND=new DataGridViewTextBoxColumn();
            var colNgaysinh = new DataGridViewTextBoxColumn();
            var colSdt = new DataGridViewTextBoxColumn();
            var colEmail = new DataGridViewTextBoxColumn();
            var colDiachi=new DataGridViewTextBoxColumn();

            colHoten.DataPropertyName = "HoTen";
            colCMND.DataPropertyName = "CMND";
            colNgaysinh.DataPropertyName = "Ngaysinh";
            colSdt.DataPropertyName = "SoDienThoai";
            colEmail.DataPropertyName = "Email";
            colDiachi.DataPropertyName = "Diachi";

            colHoten.HeaderText = "Họ tên";
            colCMND.HeaderText = "CMND/CCCD";
            colNgaysinh.HeaderText = "Ngày sinh";
            colSdt.HeaderText = "Số điện thoại";
            colEmail.HeaderText = "Email";
            colDiachi.HeaderText = "Địa chỉ";


            // Đặt Name cho cột để truy cập dữ liệu thông qua cells trong gridview
            colHoten.Name = "HoTen";
            colCMND.Name = "CMND";
            colNgaysinh.Name = "Ngaysinh";
            colSdt.Name = "SoDienThoai";
            colEmail.Name = "Email";
            colDiachi.Name = "Diachi";

            colHoten.Width= 150;
            colCMND.Width = 120;
            colNgaysinh.Width = 120;
            colSdt.Width = 120;
            colEmail.Width = 150;
            colDiachi.Width = 220;

            dgv_Patient.Columns.AddRange(new DataGridViewColumn[] { colHoten,colCMND, colNgaysinh, colEmail, colSdt, colDiachi });
        }
        //hàm load form
        private void PatientManagement_Load(object sender, EventArgs e)
        {
            createColumnForGridView();
            loadGridView();
        }
        //hàm load gridview
        private void loadGridView()
        {
            bus = PatientBUS.Instance;
            dgv_Patient.DataSource = bus.getAllPatient();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                return;
            }
            string cmnd = dgv_Patient.Rows[rowIndex].Cells["CMND"].Value.ToString();
            string sdt = dgv_Patient.Rows[rowIndex].Cells["SoDienThoai"].Value.ToString();
            int rowAffected = bus.deletePatient(cmnd, sdt);
            if (rowAffected > 0)
            {
                MessageBox.Show("Xóa bệnh nhân thành công!");
                loadGridView();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, hãy thử lại sau!");
            }
        }

        private void dgv_Patient_MouseUp(object sender, MouseEventArgs e)
        {

        }
        
        private void dgv_Patient_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                dgv_Patient.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                dgv_Patient.CurrentCell = dgv_Patient.Rows[rowIndex].Cells[1];
                this.contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cmnd = dgv_Patient.Rows[rowIndex].Cells["CMND"].Value.ToString();
            Patient_Details form=new Patient_Details(cmnd);
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string hoten=txtHoTen.Text;
            string sdt=txtSdt.Text;
            bus = PatientBUS.Instance;
            DataTable table;
            if (hoten == "") table = bus.findPatientPhoneNumber(sdt);
            else if (sdt == "") table = bus.findPatientName(hoten);
            else table = bus.findPatient(hoten,sdt);
            dgv_Patient.DataSource = table;
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
