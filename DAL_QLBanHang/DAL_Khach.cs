using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    public class DAL_Khach : DBConnect
    {
        // Thêm khách hàng
        public bool InsertKhach(DTO_Khach kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDataIntotblKhach";
                cmd.Parameters.AddWithValue("@dienthoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("@tenkhach", kh.Tenkhach);
                cmd.Parameters.AddWithValue("@diachi", kh.Diachi);
                cmd.Parameters.AddWithValue("@phai", kh.Phai);
                cmd.Parameters.AddWithValue("@email", kh.Email);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        // Cập nhật thông tin khách
        public bool UpdateKhach(DTO_Khach kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataIntotblKhach";
                cmd.Parameters.AddWithValue("@dienthoai", kh.DienThoai);
                cmd.Parameters.AddWithValue("@tenkhach", kh.Tenkhach);
                cmd.Parameters.AddWithValue("@diachi", kh.Diachi);
                cmd.Parameters.AddWithValue("@phai", kh.Phai);
                cmd.Parameters.AddWithValue("@email", kh.Email);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        // Xoá khách hàng
        public bool DeleteKhach(string Phone)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataFromtblKhach";
                cmd.Parameters.AddWithValue("@dienthoai", Phone);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        // Hiển thị thông tin của tất cả khách hàng
        public DataTable getKhach()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getKhach";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        // Tìm kiếm khách hàng bằng số điện thoại
        public DataTable SearchKhach(string Phone)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SearchKhach";
                cmd.Parameters.AddWithValue("@dienthoai", Phone);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
    }
}
