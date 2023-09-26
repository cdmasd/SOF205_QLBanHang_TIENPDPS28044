using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLBanHang;
using System.Data.SqlClient;
using System.Data;

namespace DAL_QLBanHang
{
    public class DAL_NhanVien : DBConnect
    {
        public bool NhanVienDangNhap(string email, string password)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@matkhau", password);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool NhanVienQuenMatKhau(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("@email", email);
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool TaoMatKhau(string email, string newpass)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TaoMatKhau";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@matkhau", newpass);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool UpdateMatKhau(string email, string oldpass, string newpass)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateMatKhau";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@oldPass", oldpass);
                cmd.Parameters.AddWithValue("@newPass", newpass);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable getNhanVien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachNV";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public DataTable VaiTroNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "LayVaiTroNV";
                cmd.Parameters.AddWithValue("@email", email);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public bool InsertNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataIntotblNhanVien";
                cmd.Parameters.AddWithValue("@email",nv.Email);
                cmd.Parameters.AddWithValue("@tennv",nv.TenNV);
                cmd.Parameters.AddWithValue("@diachi",nv.DiaChi);
                cmd.Parameters.AddWithValue("@vaitro",nv.VaiTro);
                cmd.Parameters.AddWithValue("@tinhtrang",nv.TinhTrang);
                cmd.Parameters.AddWithValue("@matkhau",nv.MatKhau);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
    }
}
