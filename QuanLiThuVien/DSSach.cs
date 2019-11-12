using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLiThuVien
{

    class DSSach
    {
        private List<Sach> ds;
        public List<Sach> danhsachsach
        {
            get { return ds; }
        }

        public DSSach()
        {
            ds = new List<Sach>();
        }

        public Sach Tim(string MaSach)
        {
            foreach (Sach a in ds)
            {
                if (a.MaSach == MaSach)
                    return a;
            }
            return null;
        }
        public void Them(Sach a)
        {
            ds.Add(a);

        }

        public void Sua(Sach a)
        {
            Sach x = Tim(a.MaSach);
            if (x != null)
            {
                x.TenSach = a.TenSach;
                x.LoaiSach = a.LoaiSach;
                x.TacGia = a.TacGia;
                x.NXB = a.NXB;
            }
        }

        public void Xoa(string MaSach)
        {
            Sach a = Tim(MaSach);
            if (a != null)
                ds.Remove(a);

        }

        public bool ghiFile(string tenFile)
        {
            FileStream f = new FileStream(tenFile, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, ds);
            f.Close();
            return true;
        }

        public bool docFile(string tenFile)
        {
            FileStream f = new FileStream(tenFile, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            ds = bf.Deserialize(f) as List<Sach>;
            f.Close();
            return true;
        }
    }
}
