using DAL_QLBanHang;
using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BanHang
{
    public class BUS_Khach
    {
        DAL_Khach dal_khach = new DAL_Khach();
        // Thêm khách hàng
        public bool InsertKhach(DTO_Khach kh)
        {
            return dal_khach.InsertKhach(kh);
        }
        // Xoá khách hàng
        public bool DeleteKhach(string Dienthoai)
        {
            return dal_khach.DeleteKhach(Dienthoai);
        }
        // Hiển thị thông tin của tất cả khách hàng
        public DataTable getKhach()
        {
            return dal_khach.getKhach();
        }
        // Tìm kiếm khách hàng
        public DataTable SearchKhach(string Dienthoai)
        {
            return dal_khach.SearchKhach(Dienthoai);
        }
        // Cập nhật thông tin khách hàng
        public bool UpdateKhach(DTO_Khach kh)
        {
            return dal_khach.UpdateKhach(kh);
        }
    }
}
