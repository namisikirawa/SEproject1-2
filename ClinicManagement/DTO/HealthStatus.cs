using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HealthStatus
    {
        private string chieucao, cannang, nhommau, tiensubenhan, diung, ghichu;
        public HealthStatus() { }

        public HealthStatus(string chieucao, string cannang, string nhommau, string tiensubenhan, string diung, string ghichu)
        {
            this.Chieucao= chieucao;
            this.Cannang = cannang;
            this.Nhommau = nhommau;
            this.Tiensubenhan = tiensubenhan;
            this.Diung = diung;
            this.Ghichu = ghichu;
        }

        public string Chieucao { get => chieucao; set => chieucao = value; }
        public string Cannang { get => cannang; set => cannang = value; }
        public string Nhommau { get => nhommau; set => nhommau = value; }
        public string Tiensubenhan { get => tiensubenhan; set => tiensubenhan = value; }
        public string Diung { get => diung; set => diung = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
