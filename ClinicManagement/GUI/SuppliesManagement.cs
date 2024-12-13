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
    public partial class SuppliesManagement : Form
    {
        private SuppliesBUS bus;
        private int rowIndex = -1;
        public SuppliesManagement()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        //load dữ liệu lên gridview
        void createColumnForGridView()
        {
            var colTenvattu = new DataGridViewTextBoxColumn();
            var colSoluong = new DataGridViewTextBoxColumn();
            var colDvt = new DataGridViewTextBoxColumn();
            var colDongia = new DataGridViewTextBoxColumn();
            var colNgaynhap = new DataGridViewTextBoxColumn();
            var colNgayhethan = new DataGridViewTextBoxColumn();
            var colNhacungcap = new DataGridViewTextBoxColumn();

            colTenvattu.DataPropertyName = "TenVatTu";
            colSoluong.DataPropertyName = "SoLuong";
            colDvt.DataPropertyName = "DVT";
            colDongia.DataPropertyName = "DonGia";
            colNgaynhap.DataPropertyName = "NgayNhap";
            colNgayhethan.DataPropertyName = "NgayHetHan";
            colNhacungcap.DataPropertyName = "NhaCungCap";

            colTenvattu.HeaderText = "Tên vật tư";
            colSoluong.HeaderText = "Số lượng";
            colDvt.HeaderText = "Đơn vị tính";
            colDongia.HeaderText = "Đơn giá";
            colNgaynhap.HeaderText = "Ngày nhập";
            colNgayhethan.HeaderText = "Ngày hết hạn";
            colNhacungcap.HeaderText = "Nhà cung cấp";

            colTenvattu.Name = "TenVatTu";
            colNgaynhap.Name = "NgayNhap";
            colNgayhethan.Name = "NgayHetHan";
            


            colTenvattu.Width = 120;
            colSoluong.Width = 100;
            colDvt.Width = 150;
            colDongia.Width = 80;
            colNgaynhap.Width = 100;
            colNgayhethan.Width = 100;
            colNhacungcap.Width = 180;


            dgv_Supplies.Columns.AddRange(new DataGridViewColumn[] { colTenvattu,colSoluong,colDvt,colDongia,colNgaynhap,colNgayhethan,colNhacungcap});
        }
        //hàm load form
        private void SuppliesManagement_Load(object sender, EventArgs e)
        {
            createColumnForGridView();
            loadGridView();
        }
        //hàm load gridview
        private void loadGridView()
        {
            bus = SuppliesBUS.Instance;
            dgv_Supplies.DataSource = bus.getAllSupplies();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dgv_Supplies.DataSource = bus.getAllSupplies();
        }

        private void dgv_Supplies_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgv_Supplies.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                dgv_Supplies.CurrentCell = dgv_Supplies.Rows[rowIndex].Cells[1];
                this.contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                return;
            }
            string tenvattu = dgv_Supplies.Rows[rowIndex].Cells["TenVatTu"].Value.ToString();
            string ngaynhap = dgv_Supplies.Rows[rowIndex].Cells["NgayNhap"].Value.ToString();
            string ngayhethan = dgv_Supplies.Rows[rowIndex].Cells["NgayHetHan"].Value.ToString();
            int rowAffected = bus.deleteSupplies(tenvattu,ngaynhap,ngayhethan);
            if (rowAffected > 0)
            {
                MessageBox.Show("Đã xóa thành công!");
                loadGridView();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi, hãy thử lại sau!");
            }
        }
    }
}
