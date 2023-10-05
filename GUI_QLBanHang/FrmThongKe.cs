using BUS_BanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class FrmThongKe : Form
    {
        BUS_ThongKe bus_thongke = new BUS_ThongKe();
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void sảnPhẩmNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtView.DataSource = bus_thongke.NhapKho();
        }

        private void sảnPhẩmTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtView.DataSource = bus_thongke.TonKho();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            sảnPhẩmNhậpKhoToolStripMenuItem_Click(sender, e);
        }
    }
}
