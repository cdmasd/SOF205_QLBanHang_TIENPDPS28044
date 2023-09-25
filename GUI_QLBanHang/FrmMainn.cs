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
        public static int session = 0;
        public static int profile = 0;
        public static string mail;
        dynamic dn = new FrmDangNhap();
        public FrmMainn()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
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
        // Check isOpen form
        private bool CheckExistForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            var check = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // Show form lên trên cùng của form cha
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
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

        public void FrmMainn_Load(object sender, EventArgs e)
        {
            ResetValue();
        }
        void FrmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            FrmMainn_Load(sender, e);
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
                if(int.Parse(dn.vaitro) == 0)
                {
                    VaiTroNV();
                }
            } else
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
