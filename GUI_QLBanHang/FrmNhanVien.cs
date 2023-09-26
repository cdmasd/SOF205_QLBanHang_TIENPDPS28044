using BUS_BanHang;
using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLBanHang
{
    public partial class FrmNhanVien : Form
    {
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView();
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        private bool IsValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void LoadGridView()
        {
            dtView.DataSource = bus_NhanVien.getNhanVien();
        }
        private void ResetValues()
        {
            txttimkiem.PlaceholderText = "Nhập tên nhân viên";
            txtemail.Text = null;
            txttennv.Text = null;
            txtdiachi.Text = null;
            txtemail.Enabled = false;
            txttennv.Enabled = false;
            txtdiachi.Enabled = false;
            rbnhanvien.Enabled = false;
            rbquantri.Enabled = false;
            rbhoatdong.Enabled = false;
            rbngung.Enabled = false;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btndong.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtemail.Text = null;
            txttennv.Text = null;
            txtdiachi.Text = null;
            txtemail.Enabled = true;
            txttennv.Enabled = true;
            txtdiachi.Enabled = true;
            rbnhanvien.Enabled = true;
            rbquantri.Enabled = true;
            rbhoatdong.Enabled = true;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            rbnhanvien.Checked = false;
            rbngung.Checked = false;
            rbquantri.Checked = false;
            rbhoatdong.Checked = false;
            txtemail.Focus();

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            int role = 0; //vai trò nhân viên
            if (rbquantri.Checked)
                role = 1;
            int tinhtrang = 0; //ngưng hoạt động
            if (rbhoatdong.Checked)
                tinhtrang = 1;
            if (string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Bạn phải nhập email");
                txtemail.Focus();
                return;
            }
            else if (!IsValid(txtemail.Text.Trim()))
            {
                MessageBox.Show("Sai định dạng email");
                txtemail.Focus();
                return;
            } else if (bus_NhanVien.NhanVienQuenMatKhau(txtemail.Text.Trim())) // phương thức này sẽ trả về true nếu đã tồn tại email
            {
                MessageBox.Show("email đã tồn tại");
                txtemail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txttennv.Text))
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên");
                txttennv.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtdiachi.Text))
            {
                MessageBox.Show("Bạn phải nhập địa chỉ");
                txtdiachi.Focus();
                return;
            }
            if (rbquantri.Checked == false && rbnhanvien.Checked == false)
            {
                MessageBox.Show("Chưa chọn vai trò");
                rbnhanvien.Focus();
                return;
            }
            if (rbhoatdong.Checked == false && rbngung.Checked == false)
            {
                MessageBox.Show("Chưa chọn tình trạng nhân viên");
                rbhoatdong.Focus();
                return;
            }
            string Rpass = bus_NhanVien.RandomString();
            DTO_NhanVien nv = new DTO_NhanVien(txtemail.Text.Trim(), txttennv.Text.Trim(), txtdiachi.Text.Trim(), role, tinhtrang, bus_NhanVien.encrytion(Rpass));
            if (bus_NhanVien.InsertNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công");
                ResetValues();
                LoadGridView();
                MessageBox.Show(bus_NhanVien.SendMail(txtemail.Text.Trim(), Rpass, "Tạo tài khoản thành công"));
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
        }
    }
}
