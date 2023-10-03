using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLBanHang
{
    public class DTO_Hang
    {
        int mahang;
        string tenhang;
        int soluong;
        float dongiaban;
        float dongianhap;
        string hinhanh;
        string ghichu;
        string email;
        public int Mahang
        {
            get { return mahang; }
            set { mahang = value; }
        }
        public string TenHang
        {
            get { return tenhang; }
            set { tenhang = value; }
        }
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public float Dongiaban
        {
            get { return dongiaban; }
            set { dongiaban = value; }
        }
        public float Dongianhap
        {
            get { return dongianhap; }
            set { dongianhap = value; }
        }
        public string Hinhanh
        {
            get { return hinhanh; }
            set { hinhanh = value; }
        }
        public string Ghichu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DTO_Hang(string tenhang, int soluong, float dongiaban, float dongianhap, string hinhanh, string ghichu, string email)
        {
            this.tenhang = tenhang;
            this.soluong = soluong;
            this.dongiaban = dongiaban;
            this.dongianhap = dongianhap;
            this.hinhanh = hinhanh;
            this.ghichu = ghichu;
            this.email = email;
        }

        public DTO_Hang(int mahang, string tenhang, int soluong, float dongiaban, float dongianhap, string hinhanh, string ghichu)
        {
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.soluong = soluong;
            this.dongiaban = dongiaban;
            this.dongianhap = dongianhap;
            this.hinhanh = hinhanh;
            this.ghichu = ghichu;
        }
    }
}
