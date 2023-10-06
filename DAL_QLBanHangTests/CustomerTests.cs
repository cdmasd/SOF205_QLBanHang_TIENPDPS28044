using DAL_QLBanHang;
using DTO_QLBanHang;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CTM01() // Add customer số điện thoại null
        {
            DTO_Khach kh = new DTO_Khach();
            DAL_Khach add = new DAL_Khach();
            kh.DienThoai = null;
            kh.Tenkhach = "Khách số 1";
            kh.Diachi = "Địa chỉ số 1";
            kh.Phai = "Nam";
            kh.Email = "tienphan00116@gmail.com";
            bool result = add.InsertKhach(kh);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CTM03() // Add customer với 1 hoặc 1 số trường null
        {
            DTO_Khach kh = new DTO_Khach();
            DAL_Khach add = new DAL_Khach();
            kh.DienThoai = "0928391723";
            kh.Tenkhach = null;
            kh.Diachi = "Địa chỉ số 1";
            kh.Phai = "Nam";
            kh.Email = "tienphan00116@gmail.com";
            bool result = add.InsertKhach(kh);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CTM04() // Add customer thành công
        {
            DTO_Khach kh = new DTO_Khach();
            DAL_Khach add = new DAL_Khach();
            kh.DienThoai = "0928391723";
            kh.Tenkhach = "Khách số 1";
            kh.Diachi = "Địa chỉ số 1";
            kh.Phai = "Nam";
            kh.Email = "tienphan00116@gmail.com";
            bool result = add.InsertKhach(kh);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CTM05() // Add customer thất bại (Trùng số điện thoại)
        {
            DTO_Khach kh = new DTO_Khach();
            DAL_Khach add = new DAL_Khach();
            kh.DienThoai = "0928391723";
            kh.Tenkhach = "Khách số 1";
            kh.Diachi = "Địa chỉ số 1";
            kh.Phai = "Nam";
            kh.Email = "tienphan00116@gmail.com";
            bool result = add.InsertKhach(kh);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CTM06() // Update customer thành công
        {
            DTO_Khach kh = new DTO_Khach();
            DAL_Khach update = new DAL_Khach();
            kh.DienThoai = "0928391723";
            kh.Tenkhach = "Khách update";
            kh.Diachi = "Địa chỉ update";
            kh.Phai = "Nam";
            kh.Email = "tienphan00116@gmail.com";
            bool result = update.UpdateKhach(kh);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CTM07() // Update customer 1 hoặc 1 số trường null
        {
            DTO_Khach kh = new DTO_Khach();
            DAL_Khach update = new DAL_Khach();
            kh.DienThoai = "0928391723";
            kh.Tenkhach = null;
            kh.Diachi = "Địa chỉ update";
            kh.Phai = "Nam";
            kh.Email = "tienphan00116@gmail.com";
            bool result = update.UpdateKhach(kh);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CTM08() // Xoá customer thành công
        {
            DAL_Khach delete = new DAL_Khach();
            string phone = "0928391723";
            bool result = delete.DeleteKhach(phone);
            Assert.IsTrue(result);
        }
    }
}
