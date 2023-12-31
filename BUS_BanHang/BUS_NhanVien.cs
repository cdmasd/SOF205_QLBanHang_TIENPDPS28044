﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBanHang;
using DTO_QLBanHang;
using PasswordGenerator;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace BUS_BanHang
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        // Kiểm tra thông tin đăng nhập
        public bool NhanVienDangNhap(string email, string password)
        {
            return dalNhanVien.NhanVienDangNhap(email, password);
        }

        // Kiểm tra email đã tồn tại
        public bool NhanVienQuenMatKhau(string email)
        {
            return dalNhanVien.NhanVienQuenMatKhau(email);
        }

        // Cập nhật mật khẩu khi quên 
        public bool TaoMatKhau(string email, string newpass)
        {
            return dalNhanVien.TaoMatKhau(email, encrytion(newpass));
        }

        // Truy xuất vai trò của nhân viên
        public DataTable VaiTroNhanVien(string email)
        {
            return dalNhanVien.VaiTroNhanVien(email);
        }

        // Cập nhật mật khẩu mới
        public bool UpdateMatKhau(string email, string matkhaucu, string matkhaumoi)
        {
            return dalNhanVien.UpdateMatKhau(email, encrytion(matkhaucu), encrytion(matkhaumoi));
        }

        // Thêm nhân viên
        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.InsertNhanVien(nv);
        }

        // Cập nhật thông tin nhân viên
        public bool UpdateNhanVien(DTO_NhanVien nv)
        {
            return dalNhanVien.UpdateNhanVien(nv);
        }

        // Xoá nhân viên
        public bool DeleteNhanVien(string email)
        {
            return dalNhanVien.DeleteNhanVien(email);
        }

        // Tìm kiếm nhân viên
        public DataTable SearchNhanVien(string tennv)
        {
            return dalNhanVien.SearchNhanVien(tennv);
        }

        // Truy xuất nhân viên
        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }

        // Mã hoá mật khẩu
        public string encrytion(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (var item in encrypt)
            {
                builder.Append(item.ToString());
            }
            return builder.ToString();
        }

        // Send mail
        public string SendMail(string email, string matkhau, string action)
        {
            try
            {
                // Khởi tạo đối tượng MailMessage để tạo email.
                MailMessage Msg = new MailMessage();

                // Đặt người gửi email.
                Msg.From = new MailAddress("tienphanps28044@gmail.com");

                // Đặt người nhận email, thường là địa chỉ email của người dùng muốn khôi phục mật khẩu.
                Msg.To.Add(email);

                // Đặt tiêu đề của email.
                Msg.Subject = action;

                // Đặt nội dung (body) của email và chèn mật khẩu mới vào nội dung email.
                Msg.Body = $"Mật khẩu mới của bạn là : {matkhau}.";

                using (SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("tienphanps28044@gmail.com", "oxap pttt nkmb yvuu");
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    client.Send(Msg);
                }
                if(!TaoMatKhau(email, matkhau))
                {
                    return $"Lỗi phát sinh không thể tạo được mật khẩu mới";
                }
                return $"Đã gửi mật khẩu mới vào địa chỉ : {email}";
            }
            catch (Exception ex)
            {
                // Nếu lỗi là do lỗi khác, hãy hiển thị thông báo lỗi.
                return ex.Message;
            }
        }

        // Tạo chuỗi ngẫu nhiên
        public string RandomString()
        {
            var pass = new Password(8); // khởi tạo mật khẩu gồm 8 kí tự
            var passGenerate = pass.Next();
            return passGenerate;
        }
    }
}
