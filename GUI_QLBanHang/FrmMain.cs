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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        #region Sub Method
        #region Transition
        bool menudanhmuc_Expand = false;
        bool menuthongke_Expand = false;
        bool menuhuongdan_Expand = false;
        bool menuhethong_Expand = false;

        // Transition của menu Danh Mục
        private void Transition_Tick(object sender, EventArgs e)
        {
            if (menudanhmuc_Expand == false)
            {
                menuDanhMuc.Height += 10;
                if (menuDanhMuc.Height >= 136)
                {
                    Transition_DanhMuc.Stop();
                    menudanhmuc_Expand = true;
                }
            }
            else
            {
                menuDanhMuc.Height -= 10;
                if (menuDanhMuc.Height <= 34)
                {
                    Transition_DanhMuc.Stop();
                    menudanhmuc_Expand = false;
                }
            }
        }
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            Transition_DanhMuc.Start();
        }

        //Transition của menu Thống Kê
        private void Transition_ThongKe_Tick(object sender, EventArgs e)
        {
            if (menuthongke_Expand == false)
            {
                menuThongKe.Height += 10;
                if (menuThongKe.Height >= 102)
                {
                    Transition_ThongKe.Stop();
                    menuthongke_Expand = true;
                }
            }
            else
            {
                menuThongKe.Height -= 10;
                if (menuThongKe.Height <= 34)
                {
                    Transition_ThongKe.Stop();
                    menuthongke_Expand = false;
                }
            }
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            Transition_ThongKe.Start();
        }

        //Transition của menu Hướng Dẫn
        private void Transition_HuongDan_Tick(object sender, EventArgs e)
        {
            if (menuhuongdan_Expand == false)
            {
                menuHuongDan.Height += 10;
                if (menuHuongDan.Height >= 102)
                {
                    Transition_HuongDan.Stop();
                    menuhuongdan_Expand = true;
                }
            }
            else
            {
                menuHuongDan.Height -= 10;
                if (menuHuongDan.Height <= 34)
                {
                    Transition_HuongDan.Stop();
                    menuhuongdan_Expand = false;
                }
            }
        }
        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            Transition_HuongDan.Start();
        }

        //Transition của menu Hệ Thống
        private void Transition_HeThong_Tick(object sender, EventArgs e)
        {
            if (menuhethong_Expand == false)
            {
                menuHeThong.Height += 10;
                if (menuHeThong.Height >= 170)
                {
                    Transition_HeThong.Stop();
                    menuhethong_Expand = true;
                }
            }
            else
            {
                menuHeThong.Height -= 10;
                if (menuHeThong.Height <= 34)
                {
                    Transition_HeThong.Stop();
                    menuhethong_Expand = false;
                }
            }
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            Transition_HeThong.Start();
        }
        #endregion
        #endregion
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var dn = new FrmDangNhap();
            if (!CheckExistForm("FrmDangNhap"))
            {
                dn.TopLevel = false;
                dn.MdiParent = this;
                panel18.Controls.Add(dn);
                dn.Location = new Point(panel18.Width / 2 - dn.Width / 2, panel18.Height / 2 - dn.Height / 2);
                dn.Show();
            }
            else
            {
                ActiveChildForm("FrmDangNhap");
            }
        }
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
    }
}
