using System.Data.SqlClient;

namespace DAL_QLBanHang
{
    public class DBConnect
    {
        
        protected SqlConnection _conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = QLBanHang1; Integrated Security = True");
    }
}
