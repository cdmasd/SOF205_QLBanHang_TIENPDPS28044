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

namespace GUI_QLBanHang
{
    public partial class FrmHang : Form
    {
        BUS_Hang bus_hang = new BUS_Hang();
        string stremail = FrmMainn.mail;
        string checkUrlImage;
        string fileName;
        string fileSavePath;
        string fileAddress;
        public FrmHang()
        {
            InitializeComponent();
        }

        private void FrmHang_Load(object sender, EventArgs e)
        {
            LoadGridView();
            ResetValues();
        }

        private void btnmo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                fileAddress = dlgOpen.FileName;
                pichinh.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(dlgOpen.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                fileSavePath = saveDirectory + "\\ImagesSP\\" + fileName;
                txthinh.Text = "\\ImagesSP\\" + fileName;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            int intSoluong;
            bool isInt = int.TryParse(txtsoluong.Text.Trim().ToString(), out intSoluong);
            float floatDongiaNhap;
            bool isFloatNhap = float.TryParse(txtdongianhap.Text.Trim().ToString(), out floatDongiaNhap);
            float floatDongiaBan;
            bool isFloatBan = float.TryParse(txtdongiaban.Text.Trim().ToString(), out floatDongiaBan);
            if (string.IsNullOrEmpty(txttenhang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                txttenhang.Focus();
                return;
            }
            else if (!isInt || int.Parse(txtsoluong.Text) < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                txtsoluong.Focus();
                return;
            }
            else if (!isFloatBan || float.Parse(txtdongiaban.Text) < 0)
            {
                MessageBox.Show("Đơn giá bán không hợp lệ");
                txtdongiaban.Focus();
                return;
            }
            else if (!isFloatNhap || float.Parse(txtdongianhap.Text) < 0)
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ");
                txtdongianhap.Focus();
                return;
            }
            else if (txthinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Phải upload hình sản phẩm");
                btnmo.Focus();
                return;
            }
            else
            {
                DTO_Hang h = new DTO_Hang(txttenhang.Text.Trim(), intSoluong, floatDongiaBan, floatDongiaNhap, "\\ImagesSP\\" + fileName, txtghichu.Text.Trim(), stremail);
                if (bus_hang.insertHang(h))
                {
                    try
                    {
                        File.Copy(fileAddress, fileSavePath, true);
                    }
                    catch
                    {

                    }
                    FrmHang_Load(sender, e);
                    MessageBox.Show("Thêm sản phẩm thành công");
                }
            }
        }
        private void LoadGridView()
        {
            dtView.DataSource = bus_hang.getHang();
        }
        private void ResetValues()
        {
            txttimkiem.PlaceholderText = "Nhập tên sản phẩm";
            txttenhang.Text = null;
            txtmahang.Text = null;
            txtsoluong.Text = null;
            txtdongiaban.Text = null;
            txtdongianhap.Text = null;
            pichinh.Image = null;
            txthinh.Text = null;
            txtghichu.Text = null;
            txttenhang.Enabled = false;
            txtmahang.Enabled = false;
            txtsoluong.Enabled = false;
            txtdongiaban.Enabled = false;
            txtdongianhap.Enabled = false;
            txthinh.Enabled = false;
            txtghichu.Enabled = false;
            btnmo.Enabled = false;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btndong.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            pichinh.Image = null;
            txttenhang.Text = null;
            txtmahang.Text = null;
            txtsoluong.Text = null;
            txtdongiaban.Text = null;
            txtdongianhap.Text = null;
            txthinh.Text = null;
            txtghichu.Text = null;
            txttenhang.Enabled = true;
            txtsoluong.Enabled = true;
            txtdongiaban.Enabled = true;
            txtdongianhap.Enabled = true;
            txthinh.Enabled = true;
            txtghichu.Enabled = true;
            btnmo.Enabled = true;
            btnluu.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            txttenhang.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xoá sản phẩm này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus_hang.deleteHang(int.Parse(txtmahang.Text.Trim())))
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

        private void dtView_Click(object sender, EventArgs e)
        {
            try
            {
                string saveDirectory = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                // Nếu có tồn tại trên 1 dòng
                if (dtView.Rows.Count > 1)
                {
                    btnluu.Enabled = false;
                    txttenhang.Enabled = true;
                    txtsoluong.Enabled = true;
                    txtdongiaban.Enabled = true;
                    txtdongianhap.Enabled = true;
                    txthinh.Enabled = true;
                    txtghichu.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnmo.Enabled = true;
                    // hiện dữ liệu khi dòng được chọn
                    txtmahang.Text = dtView.CurrentRow.Cells["Mã sản phẩm"].Value.ToString();
                    txttenhang.Text = dtView.CurrentRow.Cells["Tên sản phẩm"].Value.ToString();
                    txtsoluong.Text = dtView.CurrentRow.Cells["Số lượng"].Value.ToString();
                    txtdongiaban.Text = dtView.CurrentRow.Cells["Đơn giá bán"].Value.ToString();
                    txtdongianhap.Text = dtView.CurrentRow.Cells["Đơn giá nhập"].Value.ToString();
                    txthinh.Text = dtView.CurrentRow.Cells["Hình ảnh"].Value.ToString();
                    txtghichu.Text = dtView.CurrentRow.Cells["Ghi chú"].Value.ToString();
                    checkUrlImage = txthinh.Text;
                    pichinh.Image = Image.FromFile(saveDirectory + checkUrlImage);
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            int intSoluong;
            bool isInt = int.TryParse(txtsoluong.Text.Trim().ToString(), out intSoluong);
            float floatDongiaNhap;
            bool isFloatNhap = float.TryParse(txtdongianhap.Text.Trim().ToString(), out floatDongiaNhap);
            float floatDongiaBan;
            bool isFloatBan = float.TryParse(txtdongiaban.Text.Trim().ToString(), out floatDongiaBan);
            if (string.IsNullOrEmpty(txttenhang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                txttenhang.Focus();
                return;
            }
            else if (!isInt || int.Parse(txtsoluong.Text) < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
                txtsoluong.Focus();
                return;
            }
            else if (!isFloatBan || float.Parse(txtdongiaban.Text) < 0)
            {
                MessageBox.Show("Đơn giá bán không hợp lệ");
                txtdongiaban.Focus();
                return;
            }
            else if (!isFloatNhap || float.Parse(txtdongianhap.Text) < 0)
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ");
                txtdongianhap.Focus();
                return;
            }
            else if (txthinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Phải upload hình sản phẩm");
                btnmo.Focus();
                return;
            }
            else
            {
                DTO_Hang h = new DTO_Hang(int.Parse(txtmahang.Text.Trim()), txttenhang.Text.Trim(), intSoluong, floatDongiaBan, floatDongiaNhap, "\\ImagesSP\\" + fileName, txtghichu.Text.Trim());
                if (MessageBox.Show("Bạn có chắc chắn chỉnh sửa không", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus_hang.updateHang(h))
                    {
                        if (txthinh.Text != checkUrlImage)
                        {
                            try
                            {
                                File.Copy(fileAddress, fileSavePath, true);
                            }
                            catch { }
                            FrmHang_Load(sender, e);
                            MessageBox.Show("Chỉnh sửa thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa thất bại");
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
            string tensp = txttimkiem.Text.Trim();
            if (string.IsNullOrEmpty(tensp))
            {
                MessageBox.Show("Vui lòng điền tên sản phẩm cần tìm");
                return;
            }
            DataTable search = bus_hang.searchHang(tensp);
            if (search.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
                return;
            }
            else
            {
                dtView.DataSource = search;
            }
            ResetValues();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn thoát ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
