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
    public class EmployeeTest
    {
        [TestMethod()]
        public void ST01() // Thêm nhân viên không nhập email
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien add = new DAL_NhanVien();
            nv.Email = null;
            nv.TenNV = "Phan Đức Tiến";
            nv.DiaChi = "Tân Bình";
            nv.TinhTrang = 0;
            nv.VaiTro = 1;
            nv.MatKhau = "abc";
            var result = add.InsertNhanVien(nv);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ST03() // Thêm nhân viên có 1 trường null
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien add = new DAL_NhanVien();
            nv.Email = "testadd@gmail.com";
            nv.TenNV = "test name";
            nv.DiaChi = null;
            nv.TinhTrang = 0;
            nv.VaiTro = 1;
            nv.MatKhau = "abc";
            var result = add.InsertNhanVien(nv);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ST04() // Thêm nhân viên thành công
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien add = new DAL_NhanVien();
            nv.Email = "testadd@gmail.com";
            nv.TenNV = "testname";
            nv.DiaChi = "testaddress";
            nv.TinhTrang = 0;
            nv.VaiTro = 1;
            nv.MatKhau = "abc";
            var result = add.InsertNhanVien(nv);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ST06() // Cập nhật nhân viên thành công
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien update = new DAL_NhanVien();
            nv.Email = "testadd@gmail.com";
            nv.TenNV = "testname";
            nv.DiaChi = "updateadress";
            nv.TinhTrang = 0;
            nv.VaiTro = 1;
            nv.MatKhau = "abc";
            var result = update.UpdateNhanVien(nv);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ST07() // Cập nhật nhân viên có 1 hoặc 1 số trường null
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien update = new DAL_NhanVien();
            nv.Email = "testadd@gmail.com";
            nv.TenNV = null;
            nv.DiaChi = "updateadress";
            nv.TinhTrang = 0;
            nv.VaiTro = 1;
            nv.MatKhau = "abc";
            var result = update.UpdateNhanVien(nv);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ST08() // Xoá nhân viên thành công
        {
            DAL_NhanVien delete = new DAL_NhanVien();
            string Email = "testadd@gmail.com";
            var result = delete.DeleteNhanVien(Email);
            Assert.IsTrue(result);
        }
    }
}