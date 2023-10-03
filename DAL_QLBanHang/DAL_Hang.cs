using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    public class DAL_Hang : DBConnect
    {
        public bool insertHang(DTO_Hang h)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.CommandText = "InsertDataIntotblHang";
                cmd.Parameters.AddWithValue("@tenhang", h.TenHang);
                cmd.Parameters.AddWithValue("@soluong", h.SoLuong);
                cmd.Parameters.AddWithValue("@dongiaban", h.Dongiaban);
                cmd.Parameters.AddWithValue("@dongianhap", h.Dongianhap);
                cmd.Parameters.AddWithValue("@hinhanh", h.Hinhanh);
                cmd.Parameters.AddWithValue("@ghichu", h.Ghichu);
                cmd.Parameters.AddWithValue("@email", h.Email);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool deleteHang(int mahang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.CommandText = "DeleteDataFromtblHang";
                cmd.Parameters.AddWithValue("@mahang", mahang);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool updateHang(DTO_Hang h)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = _conn;
                cmd.CommandText = "UpdateDataIntotblHang";
                cmd.Parameters.AddWithValue("@mahang", h.Mahang);
                cmd.Parameters.AddWithValue("@tenhang", h.TenHang);
                cmd.Parameters.AddWithValue("@soluong", h.SoLuong);
                cmd.Parameters.AddWithValue("@dongiaban", h.Dongiaban);
                cmd.Parameters.AddWithValue("@dongianhap", h.Dongianhap);
                cmd.Parameters.AddWithValue("@hinhanh", h.Hinhanh);
                cmd.Parameters.AddWithValue("@ghichu", h.Ghichu);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        // Hiển thị thông tin của sản phẩm
        public DataTable getHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getHang";
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public DataTable SearchHang(string tenhang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "searchHang";
                cmd.Parameters.AddWithValue("@tenhang", tenhang);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
    }
}
