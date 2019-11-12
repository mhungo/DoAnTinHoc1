using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;


namespace QuanLiThuVien
{

    public partial class Form1 : Form
    {
        //Khai báo danh sach & Cờ hiệu
        private DSSach dss;


        public Form1()
        {
            InitializeComponent();
        }

        //Kiểm tra người dùng đã nhập hết dữ liệu chưa
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sách", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSach.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sách", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhanLoai.Text))
            {
                MessageBox.Show("Bạn chưa nhập loại sách", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhanLoai.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTacGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tác giả", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTacGia.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNXB.Text))
            {
                MessageBox.Show("Bạn chưa nhập NXB", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNXB.Focus();
                return false;
            }
            return true;
        }

        //Kiểm tra trùng mã sách
        public bool checkTrungMa()
        {
            string Ma = lvwThuVien.Items[0].Text;
            foreach (Sach s in dss.danhsachsach)
            {
                if (s.MaSach == txtMaSach.Text)
                {
                    MessageBox.Show("Đã Tồn tại Mã này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return true;
        }

        //Khóa giao diện
        public void Lockcontrol()
        {
            btnTaomoi.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            txtMaSach.ReadOnly = true;
            txtTenSach.ReadOnly = true;
            txtPhanLoai.ReadOnly = true;
            txtTacGia.ReadOnly = true;
            txtNXB.ReadOnly = true;

            btnThem.Focus();
        }

        //Mở khóa giao diện
        public void Unlockcontrol()
        {

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;


            txtMaSach.ReadOnly = false;
            txtTenSach.ReadOnly = false;
            txtPhanLoai.ReadOnly = false;
            txtTacGia.ReadOnly = false;
            txtNXB.ReadOnly = false;

            txtMaSach.Focus();
        }

        //Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            Lockcontrol();
            dss = new DSSach();
            dss.docFile("data.dat");
            foreach (Sach s in dss.danhsachsach)
                ShowlistView(s);

        }

        //Hiển thị dữ liệu lên ListView
        private void ShowlistView(Sach s)
        {
            ListViewItem lvi = new ListViewItem(s.MaSach);
            lvi.SubItems.Add(s.TenSach);
            lvi.SubItems.Add(s.LoaiSach);
            lvi.SubItems.Add(s.TacGia);
            lvi.SubItems.Add(s.NXB);

            lvwThuVien.Items.Add(lvi);
        }

        void FormToSach(Sach s)
        {
            s.MaSach = txtMaSach.Text;
            s.TenSach = txtTenSach.Text;
            s.LoaiSach = txtPhanLoai.Text;
            s.TacGia = txtTacGia.Text;
            s.NXB = txtNXB.Text;
        }
        void SachToForm(Sach s)
        {
            txtMaSach.Text = s.MaSach;
            txtTenSach.Text = s.TenSach;
            txtPhanLoai.Text = s.LoaiSach;
            txtTacGia.Text = s.TacGia;
            txtNXB.Text = s.NXB;
        }
        //Nút tạo mới
        private void TxtTaomoi_Click(object sender, EventArgs e)
        {
            Unlockcontrol();
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtPhanLoai.Clear();
            txtTacGia.Clear();
            txtNXB.Clear();
        }

        //Nút thêm nhập liệu mới
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                if (checkTrungMa())
                {
                    Sach s = new Sach();
                    FormToSach(s);

                    dss.Them(s);
                    ShowlistView(s);
                    dss.ghiFile("data.dat");
                }
            }

        }

        //Nút sửa dữ liệu
        private void BtnSua_Click(object sender, EventArgs e)
        {
            Unlockcontrol();
            if (lvwThuVien.SelectedIndices.Count == 0)
                return;
            int pos = lvwThuVien.SelectedIndices[0];
            Sach s = dss.danhsachsach[pos];
            FormToSach(s);
            ListViewItem lvi = lvwThuVien.SelectedItems[0];
            lvi.SubItems[0].Text = s.MaSach;
            lvi.SubItems[1].Text = s.TenSach;
            lvi.SubItems[2].Text = s.LoaiSach;
            lvi.SubItems[3].Text = s.TacGia;
            lvi.SubItems[4].Text = s.NXB;

            dss.ghiFile("data.dat");

            //MessageBox.Show("Đã tồn tại mã này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Nút xóa
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                if (lvwThuVien.SelectedIndices.Count == 0)
                    return;
                int pos = lvwThuVien.SelectedIndices[0];
                dss.danhsachsach.RemoveAt(pos);
                lvwThuVien.Items.RemoveAt(pos);
            }
            dss.ghiFile("data.dat");
        }

        //Nút thoát
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                Close();
        }

        //Tìm kiếm sách trong dữ liệu
        private void BtnTim_Click(object sender, EventArgs e)
        {
            foreach (Sach s in dss.danhsachsach)
            {
                if (s.MaSach == txtTim.Text)
                {
                    lvwThuVien.Items.Clear();
                    ShowlistView(s);

                    btnTaomoi.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    break;

                }
                

            }
        }

        //Đồng bộ dữ liệu ngược lại ô nhập 
        private void LvwThuVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwThuVien.SelectedIndices.Count == 0)
                return;

            int pos = lvwThuVien.SelectedIndices[0];
            Sach s = dss.danhsachsach[pos];
            SachToForm(s);
        }
        //
        private void LbMaSach_Click(object sender, EventArgs e)
        {

        }

        private void LbLoaiSach_Click(object sender, EventArgs e)
        {

        }

        private void LbTenSach_Click(object sender, EventArgs e)
        {

        }

        private void LbNXB_Click(object sender, EventArgs e)
        {

        }

        private void LbTacGia_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lvwThuVien.Items.Clear();
            foreach (Sach s in dss.danhsachsach)
                ShowlistView(s);

            //Unload btn sua xóa
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
