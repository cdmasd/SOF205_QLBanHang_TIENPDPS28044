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
    public partial class FrmMainn : Form
    {
        public static int session = 0; // kiểm tra đăng nhập chưa
        public static int profile = 0; // kiểm tra thông tin nhân viên
        public static string mail;
        dynamic dn = new FrmDangNhap();
        public FrmMainn()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public void FrmMainn_Load(object sender, EventArgs e)
        {
            ResetValue();
            if (session == 0)
            {
                thôngTinNvToolStripMenuItem.Text = null;
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmDangNhap"))
            {
                dn.TopLevel = false;
                dn.MdiParent = this;
                Container.Controls.Add(dn);
                dn.Location = new Point(Container.Width / 2 - dn.Width / 2, Container.Height / 2 - dn.Height / 2);
                dn.Show();
                dn.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("FrmDangNhap");
            }
        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmThongTinNV"))
            {
                FrmThongTinNV ttnv = new FrmThongTinNV(mail);
                ttnv.TopLevel = false;
                ttnv.MdiParent = this;
                Container.Controls.Add(ttnv);
                ttnv.Location = new Point(Container.Width / 2 - ttnv.Width / 2, Container.Height / 2 - ttnv.Height / 2);
                ttnv.Show();
                ttnv.FormClosed += new FormClosedEventHandler(FrmDangNhap_FormClosed);
            }
            else
            {
                ActiveChildForm("FrmThongTinNV");
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmHang"))
            {
                FrmHang hang = new FrmHang();
                hang.TopLevel = false;
                hang.MdiParent = this;
                Container.Controls.Add(hang);
                hang.Location = new Point(Container.Width / 2 - hang.Width / 2, Container.Height / 2 - hang.Height / 2);
                hang.Show();
            }
            else
            {
                ActiveChildForm("FrmHang");
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            session = 0;
            FrmMainn_Load(sender, e);
        }

        private void nhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!CheckExistForm("FrmNhanVien"))
            {
                FrmNhanVien nv = new FrmNhanVien();
                nv.TopLevel = false;
                nv.MdiParent = this;
                Container.Controls.Add(nv);
                nv.Location = new Point(Container.Width / 2 - nv.Width / 2, Container.Height / 2 - nv.Height / 2);
                nv.Show();
            }
            else
            {
                ActiveChildForm("FrmNhanVien");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMainn_Load(sender, e);
        }
        void FrmThongTinNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMainn_Load(sender, e);
        }

        // Check isOpen form
        private bool CheckExistForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            var check = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.BringToFront();
                    check = true;
                    break;
                }
            }
            return check;
        }

        // Show form lên trên cùng của form cha
        private void ActiveChildForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.BringToFront();
                    break;
                }
            }
        }
        private void VaiTroNV()
        {
            nhânViênToolStripMenuItem.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
        }
        private void ResetValue()
        {
            if (session == 1)
            {
                thôngTinNvToolStripMenuItem.Text = "Chào " + mail;
                nhânViênToolStripMenuItem.Visible = true;
                danhMụcToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                ThốngKêSPTồnToolStripMenuItem.Visible = true;
                hồSơNhânViênToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Visible = false;
                if (int.Parse(dn.vaitro) == 0)
                {
                    VaiTroNV();
                }
            }
            else
            {
                nhânViênToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                ThốngKêSPTồnToolStripMenuItem.Visible = false;
                hồSơNhânViênToolStripMenuItem.Visible = false;
                đăngNhậpToolStripMenuItem.Visible = true;
            }
        }
    }
}
