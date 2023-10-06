using DTO_QLBanHang;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void PD03() // Add product 1 hoặc 1 số trường null
        {
            DTO_Hang h = new DTO_Hang();
            DAL_Hang add = new DAL_Hang();
            h.TenHang = null;
            h.SoLuong = 5;
            h.Dongianhap = 10000;
            h.Dongiaban = 15000;
            h.Hinhanh = "abc";
            h.Ghichu = "ghi chu";
            h.Email = "tienphan00116@gmail.com";
            bool result = add.insertHang(h);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void PD04() // Add product thành công
        {
            DTO_Hang h = new DTO_Hang();
            DAL_Hang add = new DAL_Hang();
            h.TenHang = "Coca";
            h.SoLuong = 5;
            h.Dongianhap = 10000;
            h.Dongiaban = 15000;
            h.Hinhanh = "abc";
            h.Ghichu = "ghi chu";
            h.Email = "tienphan00116@gmail.com";
            bool result = add.insertHang(h);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void PD05() // Add product trùng tên
        {
            DTO_Hang h = new DTO_Hang();
            DAL_Hang add = new DAL_Hang();
            h.TenHang = "Coca";
            h.SoLuong = 5;
            h.Dongianhap = 10000;
            h.Dongiaban = 15000;
            h.Hinhanh = "abc";
            h.Ghichu = "ghi chu";
            h.Email = "tienphan00116@gmail.com";
            bool result = add.insertHang(h);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void PD06() // Update product thành công
        {
            DTO_Hang h = new DTO_Hang();
            DAL_Hang update = new DAL_Hang();
            h.Mahang = 7;
            h.TenHang = "Coca";
            h.SoLuong = 10;
            h.Dongianhap = 10000;
            h.Dongiaban = 15000;
            h.Hinhanh = "abc";
            h.Ghichu = "ghi chu";
            bool result = update.updateHang(h);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void PD07() // Update product 1 hoặc 1 số trường null
        {
            DTO_Hang h = new DTO_Hang();
            DAL_Hang update = new DAL_Hang();
            h.Mahang = 7;
            h.TenHang = "Coca";
            h.SoLuong = 10;
            h.Dongianhap = 10000;
            h.Dongiaban = 15000;
            h.Hinhanh = null;
            h.Ghichu = "ghi chu";
            bool result = update.updateHang(h);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void PD08() // Delete product thành công
        {
            DAL_Hang delete = new DAL_Hang();
            int mahang = 7;
            bool result = delete.deleteHang(mahang);
            Assert.IsTrue(result);
        }
    }
}
