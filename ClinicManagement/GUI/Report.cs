using BUS;
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
    public partial class Report : Form
    {
        private ReportBUS bus;
        private int rowIndex = -1;
        public Report()
        {
            InitializeComponent();
        }

        

        private void btn_Themmoi(object sender, EventArgs e)
        {

        }

        private void btn_Refresh(object sender, EventArgs e)
        {

        }

        //load dữ liệu lên gridview
        void createColumnForGridView()
        {
            var colTieude = new DataGridViewTextBoxColumn();
            var colNgaybaocao = new DataGridViewTextBoxColumn();
            var colNguoibaocao = new DataGridViewTextBoxColumn();

            colTieude.DataPropertyName = "Tieude";
            colNgaybaocao.DataPropertyName = "NgayBaoCao";
            colNguoibaocao.DataPropertyName = "NguoiBaoCao";

            colTieude.HeaderText = "Tiêu đề";
            colNgaybaocao.HeaderText = "Ngày báo cáo";
            colNguoibaocao.HeaderText = "Người báo cáo";

            colTieude.Name = "TieuDe";
            colNgaybaocao.Name = "NgayBaoCao";
            colNguoibaocao.Name = "NguoiBaoCao";



            colTieude.Width = 280;
            colNgaybaocao.Width = 150;
            colNguoibaocao.Width = 200;


            dgv_Report.Columns.AddRange(new DataGridViewColumn[] { colTieude, colNgaybaocao, colNguoibaocao });
        }
        //hàm load form
        private void ReportManagement_Load(object sender, EventArgs e)
        {
            createColumnForGridView();
            loadGridView();
        }
        //hàm load gridview
        private void loadGridView()
        {
            bus = ReportBUS.Instance;
            dgv_Report.DataSource = bus.getAllReport();
        }


        private void dgv_Report_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dgv_Report_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgv_Report.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                dgv_Report.CurrentCell = dgv_Report.Rows[rowIndex].Cells[1];
                this.contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
