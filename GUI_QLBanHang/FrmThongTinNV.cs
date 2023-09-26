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
    public partial class FrmThongTinNV : Form
    {
        private BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        public FrmThongTinNV(string mail)
        {
            InitializeComponent();
            txtEmail.Text = mail;
            txtEmail.Enabled = false;
        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldpass.Text))
            {
                MessageBox.Show("Bạn phải nhập vào mật khẩu cũ");
                txtOldpass.Focus();
                return;
            }
            if (txtNewpass.Text != txtNewpassRepeat.Text)
            {
                MessageBox.Show("Mật khẩu được nhập lại không đúng");
                txtNewpass.Text = "";
                txtNewpassRepeat.Text = "";
                txtNewpass.Focus();
                return;
            }
            if (bus_nhanvien.UpdateMatKhau(txtEmail.Text, txtOldpass.Text.Trim(), txtNewpass.Text.Trim()))
            {
                FrmMainn.profile = 1; // cập nhật thành công
                FrmMainn.session = 0; // tự đăng xuất
                MessageBox.Show(bus_nhanvien.SendMail(txtEmail.Text, txtNewpass.Text, "Update Password Successfully!"));
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
