using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void BtnDangnhap_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
