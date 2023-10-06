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
    }
}