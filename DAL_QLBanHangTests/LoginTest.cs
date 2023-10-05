using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBanHang;

namespace DAL_QLBanHang.Tests
{
    [TestClass()]
    public class LoginTest
    {
        [TestMethod()]
        public void LG01() // Case email rỗng | có 2 tham số email và password
        {
            DAL_NhanVien login = new DAL_NhanVien();
            string email = string.Empty;
            string password = "abc";
            bool result = login.NhanVienDangNhap(email,password);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void LG02() // Case password rỗng | có 2 tham số email và password
        {
            DAL_NhanVien login = new DAL_NhanVien();
            string email = "tienphan00116@gmail.com";
            string password = string.Empty;
            bool result = login.NhanVienDangNhap(email, password);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void LG03() // Case sai email hoặc password | có 2 tham số email và password
        {
            DAL_NhanVien login = new DAL_NhanVien();
            string email = "tienphan00116@gmail.com";
            string password = "vdc";
            bool result = login.NhanVienDangNhap(email, password);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void LG04() // Case login thành công | có 2 tham số email và password
        {
            DAL_NhanVien login = new DAL_NhanVien();
            string email = "tienphan00116@gmail.com";
            string password = "14418015260210791762141506312540225127114";
            bool result = login.NhanVienDangNhap(email, password);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void LG06() // Case lấy lại mật khẩu không nhập email | có 2 tham số email và password tạo tự động
        {
            DAL_NhanVien login = new DAL_NhanVien();
            string email = string.Empty;
            string Newpassword = "Mật khẩu ngẫu nhiên";
            bool result = login.TaoMatKhau(email, Newpassword);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void LG07() // Case lấy lại mật khẩu nhập email không tồn tại | có 2 tham số email và password tạo tự động
        {
            DAL_NhanVien login = new DAL_NhanVien();
            string email = "abc@gmail.com";
            string Newpassword = "Mật khẩu ngẫu nhiên";
            bool result = login.TaoMatKhau(email, Newpassword);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void LG08() // Case lấy lại mật khẩu thành công | có 2 tham số email và password tạo tự động
        {
            DAL_NhanVien login = new DAL_NhanVien();
            string email = "testcase@gmail.com";
            string Newpassword = "after change";
            bool result = login.TaoMatKhau(email, Newpassword);
            Assert.IsTrue(result);
        }
    }
}