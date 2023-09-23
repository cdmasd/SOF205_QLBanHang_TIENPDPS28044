using BUS_BanHang;

namespace GUI_QLBanHang
{
    public partial class FrmDangNhap : Form
    {
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        #region Btn Thoát
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        #endregion

        // Btn Login
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtemail.Text) || string.IsNullOrWhiteSpace(txtmatkhau.Text))
            {
                MessageBox.Show("Các trường không được rỗng", "Thông báo");
                return;
            }
            if (bus_nhanvien.NhanVienDangNhap(txtemail.Text, bus_nhanvien.encrytion(txtmatkhau.Text)))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                Properties.Settings.Default.isSave = chkghinhotk.Checked;
                if (chkghinhotk.Checked)
                {
                    Properties.Settings.Default.email = txtemail.Text;
                    Properties.Settings.Default.matkhau = txtmatkhau.Text;

                }
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu", "Thông báo");
                txtemail.Text = "";
                txtmatkhau.Text = "";
                txtemail.Focus();
            }
        }

        // Btn Forgot Password
        private void btnquenmatkhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Nhập email cần lấy lại mật khẩu", "Thông báo");
                return;
            }
            if (bus_nhanvien.NhanVienQuenMatKhau(txtemail.Text))
            {
                string newpass = bus_nhanvien.RandomString();
                bus_nhanvien.TaoMatKhau(txtemail.Text, newpass);
                MessageBox.Show(bus_nhanvien.SendMail(txtemail.Text, newpass), "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tồn tại email", "Thông báo");
                txtemail.Text = "";
                txtmatkhau.Text = "";
                txtemail.Focus();
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isSave)
            {
                txtemail.Text = Properties.Settings.Default.email;
                txtmatkhau.Text = Properties.Settings.Default.matkhau;
                chkghinhotk.Checked = true;
                btndangnhap.Focus();
            }
        }

    }
}
