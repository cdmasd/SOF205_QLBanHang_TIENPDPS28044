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
    }
}
