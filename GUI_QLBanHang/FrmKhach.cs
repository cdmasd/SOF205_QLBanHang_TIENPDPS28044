using BUS_BanHang;
using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_QLBanHang
{
    public partial class FrmKhach : Form
    {
        BUS_Khach bus_khach = new BUS_Khach();
        string stremail = FrmMainn.mail; // nhận email từ main
        public FrmKhach()
        {
            InitializeComponent();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            string sex = "Nữ";
            if (rbNam.Checked)
                sex = "Nam";
            if (string.IsNullOrEmpty(txtDienthoai.Text))
            {
                MessageBox.Show("Bạn phải nhập số điện thoại");
                txtDienthoai.Focus();
                return;
            }
            else if (txtDienthoai.Text.Trim().Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                txtDienthoai.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                MessageBox.Show("Bạn phải nhập họ tên");
                txtHoten.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                MessageBox.Show("Bạn phải nhập địa chỉ");
                txtDiachi.Focus();
                return;
            }
            if (rbNam.Checked == false && rbNu.Checked == false)
            {
                MessageBox.Show("Chưa chọn giới tính");
                rbNu.Focus();
                return;
            }
            DTO_Khach kh = new DTO_Khach(txtDienthoai.Text.Trim(), txtHoten.Text.Trim(), txtDiachi.Text.Trim(), sex, stremail);
            if (bus_khach.InsertKhach(kh))
            {
                MessageBox.Show("Thêm thành công");
                ResetValues();
                LoadGridView();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
        }
        // chỉ cho phép nhập số và 10 kí tự
        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || txtDienthoai.Text.Length >= 10)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            txtDienthoai.Text = null;
            txtHoten.Text = null;
            txtDiachi.Text = null;
            txtDienthoai.Enabled = true;
            txtHoten.Enabled = true;
            txtDiachi.Enabled = true;
            rbNam.Enabled = true;
            rbNu.Enabled = true;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            rbNam.Checked = false;
            rbNu.Checked = false;
            txtDienthoai.Focus();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xoá nhân viên này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus_khach.DeleteKhach(txtDienthoai.Text.Trim()))
                {
                    MessageBox.Show("Xoá thành công");
                    ResetValues();
                    LoadGridView();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại");
                }
            }
            else
            {
                ResetValues();
            }
        }
        private void FrmKhach_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadGridView();
        }
        private void btndanhsach_Click(object sender, EventArgs e)
        {
            LoadGridView();
            ResetValues();
        }
        private void dtView_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu có tồn tại trên 1 dòng
                if (dtView.Rows.Count > 1)
                {
                    btnluu.Enabled = false;
                    txtHoten.Enabled = true;
                    txtDiachi.Enabled = true;
                    rbNam.Enabled = true;
                    rbNu.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    // hiện dữ liệu khi dòng được chọn
                    txtDienthoai.Text = dtView.CurrentRow.Cells["Điện thoại"].Value.ToString();
                    txtHoten.Text = dtView.CurrentRow.Cells["Họ và tên"].Value.ToString();
                    txtDiachi.Text = dtView.CurrentRow.Cells["Địa chỉ"].Value.ToString();
                    string gioitinh = dtView.CurrentRow.Cells["Giới tính"].Value.ToString();
                    if (gioitinh == "Nam")
                    {
                        rbNam.Checked = true;
                    }
                    else
                    {
                        rbNu.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Bảng không tồn tại dữ liệu");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi phát sinh");
            }
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoten.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtHoten.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtDiachi.Focus();
                return;
            }
            else
            {
                string sex = "Nữ";
                if (rbNam.Checked)
                {
                    sex = "Nam";
                }
                DTO_Khach kh = new DTO_Khach(txtDienthoai.Text.Trim(), txtHoten.Text.Trim(), txtDiachi.Text.Trim(), sex, stremail);
                if (MessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bus_khach.UpdateKhach(kh))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        ResetValues();
                        LoadGridView();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                else
                {
                    ResetValues();
                }
            }
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string Phone = txttimkiem.Text.Trim();
            if (string.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("Vui lòng điền số điện thoại cần tìm");
                return;
            }
            DataTable search = bus_khach.SearchKhach(Phone);
            if (search.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng");
                return;
            }
            else
            {
                dtView.DataSource = search;
            }
            ResetValues();
        }
        private void LoadGridView()
        {
            dtView.DataSource = bus_khach.getKhach();
        }
        private void ResetValues()
        {
            txttimkiem.PlaceholderText = "Nhập số điện thoại";
            txtDienthoai.Text = null;
            txtHoten.Text = null;
            txtDiachi.Text = null;
            txtDienthoai.Enabled = false;
            txtHoten.Enabled = false;
            txtDiachi.Enabled = false;
            rbNam.Enabled = false;
            rbNu.Enabled = false;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btndong.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
    }
}
