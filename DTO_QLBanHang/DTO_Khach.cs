using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    public class DTO_Khach
    {
        private string dienthoai;
        private string tenkhach;
        private string diachi;
        private string phai;
        private string email;
        public string DienThoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        public string Tenkhach
        {
            get { return tenkhach; }
            set { tenkhach = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Phai
        {
            get { return phai; }
            set { phai = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DTO_Khach() { }
        public DTO_Khach(string dienthoai, string tenkhach, string diachi, string phai, string email)
        {
            this.dienthoai = dienthoai;
            this.tenkhach = tenkhach;
            this.diachi = diachi;
            this.phai = phai;
            this.email = email;
        }
    }

}
