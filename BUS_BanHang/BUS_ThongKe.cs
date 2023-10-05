using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLBanHang;

namespace BUS_BanHang
{
    public class BUS_ThongKe
    {
        DAL_ThongKe DAL_ThongKe = new DAL_ThongKe();
        public DataTable NhapKho()
        {
            return DAL_ThongKe.NhapKho();
        }
        public DataTable TonKho()
        {
            return DAL_ThongKe.TonKho();
        }
    }
}
