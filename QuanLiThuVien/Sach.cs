using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLiThuVien
{   
    [Serializable]
    public class Sach
    {
        protected string ma;
        protected string ten;
        protected string loai;
        protected string tacgia;
        protected string nxb;
        public Sach()
        {
            ma = "";
            ten = "";
            loai = "";
            tacgia = "";
            nxb = "";
        }
        public Sach(string Ma,string Ten, string Loai, string Tacgia, string Nxb)
        {
            ma = Ma;
            ten = Ten;
            loai = Loai;
            tacgia = Tacgia;
            nxb = Nxb;
        }

        public string MaSach
        {
            get { return ma; }
            set { ma = value; }
        }
        public string TenSach
        {
            get { return ten; }
            set { ten = value; }
        }
        public string LoaiSach
        {
            get { return loai; }
            set { loai = value; }
        }
        public string TacGia
        {
            get { return tacgia; }
            set { tacgia = value; }
        }
        public string NXB
        {
            get { return nxb; }
            set { nxb = value; }
        }
    }
}
