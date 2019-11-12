namespace QuanLiThuVien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbQuanLiThuVien = new System.Windows.Forms.Label();
            this.lbMaSach = new System.Windows.Forms.Label();
            this.lbTenSach = new System.Windows.Forms.Label();
            this.lbLoaiSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtPhanLoai = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lbTim = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.lvwThuVien = new System.Windows.Forms.ListView();
            this.colMaSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTacGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTacGia = new System.Windows.Forms.Label();
            this.lbNXB = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbQuanLiThuVien
            // 
            this.lbQuanLiThuVien.AutoSize = true;
            this.lbQuanLiThuVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLiThuVien.Location = new System.Drawing.Point(399, 28);
            this.lbQuanLiThuVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuanLiThuVien.Name = "lbQuanLiThuVien";
            this.lbQuanLiThuVien.Size = new System.Drawing.Size(214, 29);
            this.lbQuanLiThuVien.TabIndex = 0;
            this.lbQuanLiThuVien.Text = "Quản Lí Thư Viện";
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSach.Location = new System.Drawing.Point(25, 105);
            this.lbMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(70, 17);
            this.lbMaSach.TabIndex = 1;
            this.lbMaSach.Text = "Mã Sách";
            this.lbMaSach.Click += new System.EventHandler(this.LbMaSach_Click);
            // 
            // lbTenSach
            // 
            this.lbTenSach.AutoSize = true;
            this.lbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSach.Location = new System.Drawing.Point(25, 155);
            this.lbTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenSach.Name = "lbTenSach";
            this.lbTenSach.Size = new System.Drawing.Size(77, 17);
            this.lbTenSach.TabIndex = 2;
            this.lbTenSach.Text = "Tên Sách";
            this.lbTenSach.Click += new System.EventHandler(this.LbTenSach_Click);
            // 
            // lbLoaiSach
            // 
            this.lbLoaiSach.AutoSize = true;
            this.lbLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSach.Location = new System.Drawing.Point(25, 202);
            this.lbLoaiSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiSach.Name = "lbLoaiSach";
            this.lbLoaiSach.Size = new System.Drawing.Size(80, 17);
            this.lbLoaiSach.TabIndex = 3;
            this.lbLoaiSach.Text = "Loại Sách";
            this.lbLoaiSach.Click += new System.EventHandler(this.LbLoaiSach_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(138, 99);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(260, 26);
            this.txtMaSach.TabIndex = 4;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(138, 151);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(260, 26);
            this.txtTenSach.TabIndex = 5;
            // 
            // txtPhanLoai
            // 
            this.txtPhanLoai.Location = new System.Drawing.Point(138, 200);
            this.txtPhanLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhanLoai.Name = "txtPhanLoai";
            this.txtPhanLoai.Size = new System.Drawing.Size(260, 26);
            this.txtPhanLoai.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(422, 148);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(422, 198);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(422, 249);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(422, 302);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(733, 106);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(260, 26);
            this.txtTim.TabIndex = 11;
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTim.Location = new System.Drawing.Point(589, 109);
            this.lbTim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(113, 17);
            this.lbTim.TabIndex = 12;
            this.lbTim.Text = "Nhập Mã Sách";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(808, 143);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 29);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.BtnTim_Click);
            // 
            // lvwThuVien
            // 
            this.lvwThuVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaSach,
            this.colTenSach,
            this.colLoaiSach,
            this.colTacGia,
            this.colNXB});
            this.lvwThuVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwThuVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwThuVien.FullRowSelect = true;
            this.lvwThuVien.GridLines = true;
            this.lvwThuVien.HideSelection = false;
            this.lvwThuVien.Location = new System.Drawing.Point(0, 428);
            this.lvwThuVien.Margin = new System.Windows.Forms.Padding(4);
            this.lvwThuVien.MultiSelect = false;
            this.lvwThuVien.Name = "lvwThuVien";
            this.lvwThuVien.Size = new System.Drawing.Size(1022, 274);
            this.lvwThuVien.TabIndex = 14;
            this.lvwThuVien.UseCompatibleStateImageBehavior = false;
            this.lvwThuVien.View = System.Windows.Forms.View.Details;
            this.lvwThuVien.SelectedIndexChanged += new System.EventHandler(this.LvwThuVien_SelectedIndexChanged);
            // 
            // colMaSach
            // 
            this.colMaSach.Text = "Mã Sách";
            this.colMaSach.Width = 150;
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Tên Sách";
            this.colTenSach.Width = 250;
            // 
            // colLoaiSach
            // 
            this.colLoaiSach.Text = "Loại Sách";
            this.colLoaiSach.Width = 130;
            // 
            // colTacGia
            // 
            this.colTacGia.Text = "Tác Giả";
            this.colTacGia.Width = 150;
            // 
            // colNXB
            // 
            this.colNXB.Text = "NXB";
            this.colNXB.Width = 100;
            // 
            // lbTacGia
            // 
            this.lbTacGia.AutoSize = true;
            this.lbTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacGia.Location = new System.Drawing.Point(25, 256);
            this.lbTacGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(65, 17);
            this.lbTacGia.TabIndex = 15;
            this.lbTacGia.Text = "Tác Giả";
            this.lbTacGia.Click += new System.EventHandler(this.LbTacGia_Click);
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNXB.Location = new System.Drawing.Point(25, 310);
            this.lbNXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(39, 17);
            this.lbNXB.TabIndex = 16;
            this.lbNXB.Text = "NXB";
            this.lbNXB.Click += new System.EventHandler(this.LbNXB_Click);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(138, 252);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(260, 26);
            this.txtTacGia.TabIndex = 17;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(138, 304);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(260, 26);
            this.txtNXB.TabIndex = 18;
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Location = new System.Drawing.Point(422, 97);
            this.btnTaomoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(94, 29);
            this.btnTaomoi.TabIndex = 22;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = true;
            this.btnTaomoi.Click += new System.EventHandler(this.TxtTaomoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 702);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.lbNXB);
            this.Controls.Add(this.lbTacGia);
            this.Controls.Add(this.lvwThuVien);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lbTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtPhanLoai);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.lbLoaiSach);
            this.Controls.Add(this.lbTenSach);
            this.Controls.Add(this.lbMaSach);
            this.Controls.Add(this.lbQuanLiThuVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Quản Lí Thư Viện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuanLiThuVien;
        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label lbTenSach;
        private System.Windows.Forms.Label lbLoaiSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtPhanLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lbTacGia;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.ColumnHeader colMaSach;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private System.Windows.Forms.ColumnHeader colLoaiSach;
        private System.Windows.Forms.ColumnHeader colTacGia;
        private System.Windows.Forms.ColumnHeader colNXB;
        private System.Windows.Forms.ListView lvwThuVien;
        private System.Windows.Forms.Button btnTaomoi;
    }
}

