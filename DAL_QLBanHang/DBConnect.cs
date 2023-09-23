using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=TIENPDPS28044\\TIENPDPS28044;Initial Catalog=QLBanHang_SOF205;Integrated Security=True");
    }
}
