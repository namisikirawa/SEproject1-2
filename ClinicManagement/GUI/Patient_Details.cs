using BUS;
using DAL;
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
    public partial class Patient_Details : Form
    {
        private PatientBUS bus;
        private string cmnd;
        public Patient_Details(string cmnd)
        {
            InitializeComponent();
            this.Text = "Tình trạng sức khỏe";
            this.cmnd = cmnd;
        }

        private void Patient_Details_Load(object sender, EventArgs e)
        {
            bus =PatientBUS.Instance;
            HealthStatus status = new HealthStatus();
            status = bus.getHealthStatus(this.cmnd);

            txtCannang.Text = status.Cannang;
            txtChieucao.Text = status.Chieucao;
            txtDiung.Text = status.Diung;
            txtGhichu.Text = status.Ghichu;
            txtNhommau.Text = status.Nhommau;
            txtTiensubenhan.Text = status.Tiensubenhan;

            txtCannang.ReadOnly = true;
            txtChieucao.ReadOnly = true;
            txtDiung.ReadOnly = true;
            txtGhichu.ReadOnly = true;
            txtNhommau.ReadOnly = true;
            txtTiensubenhan.ReadOnly = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
