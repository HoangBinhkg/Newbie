namespace CSDLPT
{
    partial class frmSinhVien
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
            this.lbkhoa = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.dgSinhVien = new System.Windows.Forms.DataGridView();
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghihoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbHo = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbNoiSinh = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbNghiHoc = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbLopNhap = new System.Windows.Forms.ComboBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.cbNghiHoc = new System.Windows.Forms.ComboBox();
            this.btHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbkhoa
            // 
            this.lbkhoa.AutoSize = true;
            this.lbkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkhoa.Location = new System.Drawing.Point(49, 20);
            this.lbkhoa.Name = "lbkhoa";
            this.lbkhoa.Size = new System.Drawing.Size(54, 20);
            this.lbkhoa.TabIndex = 0;
            this.lbkhoa.Text = "KHOA";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(127, 17);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(197, 21);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(538, 17);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(243, 21);
            this.cbLop.TabIndex = 2;
            this.cbLop.SelectedIndexChanged += new System.EventHandler(this.cbLop_SelectedIndexChanged);
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(477, 20);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(40, 20);
            this.lbLop.TabIndex = 3;
            this.lbLop.Text = "LỚP";
            // 
            // dgSinhVien
            // 
            this.dgSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.ho,
            this.ten,
            this.malop,
            this.phai,
            this.ngaysinh,
            this.noisinh,
            this.diachi,
            this.ghichu,
            this.nghihoc});
            this.dgSinhVien.Location = new System.Drawing.Point(28, 76);
            this.dgSinhVien.MultiSelect = false;
            this.dgSinhVien.Name = "dgSinhVien";
            this.dgSinhVien.ReadOnly = true;
            this.dgSinhVien.Size = new System.Drawing.Size(804, 188);
            this.dgSinhVien.TabIndex = 4;
            this.dgSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSinhVien_CellContentClick);
            // 
            // masv
            // 
            this.masv.DataPropertyName = "masv";
            this.masv.HeaderText = "MÃ SINH VIÊN";
            this.masv.Name = "masv";
            this.masv.ReadOnly = true;
            // 
            // ho
            // 
            this.ho.DataPropertyName = "ho";
            this.ho.HeaderText = "HỌ";
            this.ho.Name = "ho";
            this.ho.ReadOnly = true;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "TÊN";
            this.ten.Name = "ten";
            this.ten.ReadOnly = true;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "MÃ LỚP";
            this.malop.Name = "malop";
            this.malop.ReadOnly = true;
            // 
            // phai
            // 
            this.phai.DataPropertyName = "phai";
            this.phai.HeaderText = "PHÁI";
            this.phai.Name = "phai";
            this.phai.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "NGÀY SINH";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // noisinh
            // 
            this.noisinh.DataPropertyName = "noisinh";
            this.noisinh.HeaderText = "NƠI SINH";
            this.noisinh.Name = "noisinh";
            this.noisinh.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "ĐỊA CHỈ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "GHI CHÚ";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            // 
            // nghihoc
            // 
            this.nghihoc.DataPropertyName = "nghihoc";
            this.nghihoc.HeaderText = "NGHỈ HỌC";
            this.nghihoc.Name = "nghihoc";
            this.nghihoc.ReadOnly = true;
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSV.Location = new System.Drawing.Point(49, 292);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(125, 20);
            this.lbMaSV.TabIndex = 5;
            this.lbMaSV.Text = "Mã Sinh Viên :";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(409, 292);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(78, 20);
            this.lbMaLop.TabIndex = 6;
            this.lbMaLop.Text = "Mã Lớp :";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHo.Location = new System.Drawing.Point(132, 321);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(42, 20);
            this.lbHo.TabIndex = 7;
            this.lbHo.Text = "Họ :";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(438, 321);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(49, 20);
            this.lbTen.TabIndex = 8;
            this.lbTen.Text = "Tên :";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(84, 385);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(90, 20);
            this.lbGioiTinh.TabIndex = 9;
            this.lbGioiTinh.Text = "Giới Tính :";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(74, 354);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.lbNgaySinh.TabIndex = 10;
            this.lbNgaySinh.Text = "Ngày Sinh :";
            // 
            // lbNoiSinh
            // 
            this.lbNoiSinh.AutoSize = true;
            this.lbNoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiSinh.Location = new System.Drawing.Point(401, 354);
            this.lbNoiSinh.Name = "lbNoiSinh";
            this.lbNoiSinh.Size = new System.Drawing.Size(86, 20);
            this.lbNoiSinh.TabIndex = 11;
            this.lbNoiSinh.Text = "Nơi Sinh :";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(97, 422);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(77, 20);
            this.lbDiaChi.TabIndex = 12;
            this.lbDiaChi.Text = "Địa Chỉ :";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhiChu.Location = new System.Drawing.Point(90, 460);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(84, 20);
            this.lbGhiChu.TabIndex = 13;
            this.lbGhiChu.Text = "Ghi Chú :";
            // 
            // lbNghiHoc
            // 
            this.lbNghiHoc.AutoSize = true;
            this.lbNghiHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNghiHoc.Location = new System.Drawing.Point(395, 385);
            this.lbNghiHoc.Name = "lbNghiHoc";
            this.lbNghiHoc.Size = new System.Drawing.Size(92, 20);
            this.lbNghiHoc.TabIndex = 14;
            this.lbNghiHoc.Text = "Nghỉ Học :";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(190, 291);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(183, 20);
            this.txtMaSV.TabIndex = 15;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(190, 321);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(183, 20);
            this.txtHo.TabIndex = 17;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(503, 321);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(183, 20);
            this.txtTen.TabIndex = 18;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(503, 354);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(183, 20);
            this.txtNoiSinh.TabIndex = 19;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "yyy/MM/dd";
            this.dateNgaySinh.Location = new System.Drawing.Point(190, 354);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(183, 20);
            this.dateNgaySinh.TabIndex = 20;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(190, 387);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(183, 21);
            this.cbGioiTinh.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(190, 422);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(496, 20);
            this.txtDiaChi.TabIndex = 23;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(190, 460);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(496, 20);
            this.txtGhiChu.TabIndex = 24;
            // 
            // cbLopNhap
            // 
            this.cbLopNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLopNhap.FormattingEnabled = true;
            this.cbLopNhap.Location = new System.Drawing.Point(503, 291);
            this.cbLopNhap.Name = "cbLopNhap";
            this.cbLopNhap.Size = new System.Drawing.Size(183, 21);
            this.cbLopNhap.TabIndex = 25;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(78, 509);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 31);
            this.btXoa.TabIndex = 26;
            this.btXoa.Text = "XÓA";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(228, 509);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(96, 31);
            this.btThem.TabIndex = 27;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(378, 509);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(96, 31);
            this.btSua.TabIndex = 28;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(736, 509);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(96, 31);
            this.btThoat.TabIndex = 29;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // cbNghiHoc
            // 
            this.cbNghiHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNghiHoc.FormattingEnabled = true;
            this.cbNghiHoc.Location = new System.Drawing.Point(503, 385);
            this.cbNghiHoc.Name = "cbNghiHoc";
            this.cbNghiHoc.Size = new System.Drawing.Size(183, 21);
            this.cbNghiHoc.TabIndex = 30;
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(524, 509);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(96, 31);
            this.btHuy.TabIndex = 31;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 580);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.cbNghiHoc);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.cbLopNhap);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lbNghiHoc);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbNoiSinh);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbHo);
            this.Controls.Add(this.lbMaLop);
            this.Controls.Add(this.lbMaSV);
            this.Controls.Add(this.dgSinhVien);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.lbkhoa);
            this.Name = "frmSinhVien";
            this.Text = "frmSinhVien";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbkhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.DataGridView dgSinhVien;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbNoiSinh;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbNghiHoc;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn phai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn noisinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghihoc;
        private System.Windows.Forms.ComboBox cbLopNhap;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ComboBox cbNghiHoc;
        private System.Windows.Forms.Button btHuy;
    }
}