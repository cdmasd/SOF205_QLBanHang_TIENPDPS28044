using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBanHang;
using DTO_QLBanHang;

namespace BUS_BanHang
{
    public class BUS_Hang
    {
        DAL_Hang dal_hang = new DAL_Hang();
        public bool insertHang(DTO_Hang h)
        {
            return dal_hang.insertHang(h);
        }
        public DataTable getHang()
        {
            return dal_hang.getHang();
        }
        public bool deleteHang(int mahang)
        {
            return dal_hang.deleteHang(mahang);
        }
        public bool updateHang(DTO_Hang h)
        {
            return dal_hang.updateHang(h);
        }
        public DataTable searchHang(string tenhang)
        {
            return dal_hang.SearchHang(tenhang);
        }
    }
}
