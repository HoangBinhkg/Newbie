namespace CSDLPT
{
    partial class frmMain
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
            this.lbThongBao = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.btdanhsachlop = new System.Windows.Forms.Button();
            this.btdanhsachsinhvien = new System.Windows.Forms.Button();
            this.btmonhoc = new System.Windows.Forms.Button();
            this.btdiem = new System.Windows.Forms.Button();
            this.btbaocao = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btUser = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongBao.Location = new System.Drawing.Point(12, 28);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(559, 46);
            this.lbThongBao.TabIndex = 0;
            this.lbThongBao.Text = "ĐĂNG NHẬP THÀNH CÔNG";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttHoTen,
            this.sttNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 369);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(925, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttHoTen
            // 
            this.sttHoTen.Name = "sttHoTen";
            this.sttHoTen.Size = new System.Drawing.Size(68, 17);
            this.sttHoTen.Text = "Họ Và Tên: ";
            // 
            // sttNhom
            // 
            this.sttNhom.Name = "sttNhom";
            this.sttNhom.Size = new System.Drawing.Size(47, 17);
            this.sttNhom.Text = "Nhóm: ";
            // 
            // btdanhsachlop
            // 
            this.btdanhsachlop.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdanhsachlop.Location = new System.Drawing.Point(12, 108);
            this.btdanhsachlop.Name = "btdanhsachlop";
            this.btdanhsachlop.Size = new System.Drawing.Size(281, 54);
            this.btdanhsachlop.TabIndex = 2;
            this.btdanhsachlop.Text = "DANH SÁCH LỚP";
            this.btdanhsachlop.UseVisualStyleBackColor = true;
            this.btdanhsachlop.Click += new System.EventHandler(this.btdanhsachlop_Click);
            // 
            // btdanhsachsinhvien
            // 
            this.btdanhsachsinhvien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdanhsachsinhvien.Location = new System.Drawing.Point(317, 108);
            this.btdanhsachsinhvien.Name = "btdanhsachsinhvien";
            this.btdanhsachsinhvien.Size = new System.Drawing.Size(281, 54);
            this.btdanhsachsinhvien.TabIndex = 3;
            this.btdanhsachsinhvien.Text = "DANH SÁCH SINH VIÊN";
            this.btdanhsachsinhvien.UseVisualStyleBackColor = true;
            this.btdanhsachsinhvien.Click += new System.EventHandler(this.btdanhsachsinhvien_Click);
            // 
            // btmonhoc
            // 
            this.btmonhoc.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmonhoc.Location = new System.Drawing.Point(621, 108);
            this.btmonhoc.Name = "btmonhoc";
            this.btmonhoc.Size = new System.Drawing.Size(281, 54);
            this.btmonhoc.TabIndex = 4;
            this.btmonhoc.Text = "QUẢN LÝ MÔN HỌC";
            this.btmonhoc.UseVisualStyleBackColor = true;
            this.btmonhoc.Click += new System.EventHandler(this.btmonhoc_Click);
            // 
            // btdiem
            // 
            this.btdiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiem.Location = new System.Drawing.Point(12, 190);
            this.btdiem.Name = "btdiem";
            this.btdiem.Size = new System.Drawing.Size(281, 54);
            this.btdiem.TabIndex = 5;
            this.btdiem.Text = "QUẢN LÝ ĐIỂM";
            this.btdiem.UseVisualStyleBackColor = true;
            this.btdiem.Click += new System.EventHandler(this.btdiem_Click);
            // 
            // btbaocao
            // 
            this.btbaocao.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbaocao.Location = new System.Drawing.Point(317, 190);
            this.btbaocao.Name = "btbaocao";
            this.btbaocao.Size = new System.Drawing.Size(281, 54);
            this.btbaocao.TabIndex = 6;
            this.btbaocao.Text = "BÁO CÁO";
            this.btbaocao.UseVisualStyleBackColor = true;
            this.btbaocao.Click += new System.EventHandler(this.btbaocao_Click);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(621, 273);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(281, 54);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "ĐĂNG XUẤT";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btUser
            // 
            this.btUser.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUser.Location = new System.Drawing.Point(317, 273);
            this.btUser.Name = "btUser";
            this.btUser.Size = new System.Drawing.Size(281, 54);
            this.btUser.TabIndex = 8;
            this.btUser.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.btUser.UseVisualStyleBackColor = true;
            this.btUser.Click += new System.EventHandler(this.btUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 391);
            this.Controls.Add(this.btUser);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btbaocao);
            this.Controls.Add(this.btdiem);
            this.Controls.Add(this.btmonhoc);
            this.Controls.Add(this.btdanhsachsinhvien);
            this.Controls.Add(this.btdanhsachlop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbThongBao);
            this.Name = "frmMain";
            this.Text = "Bảng Điều Khiển Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThongBao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttHoTen;
        private System.Windows.Forms.ToolStripStatusLabel sttNhom;
        private System.Windows.Forms.Button btdanhsachlop;
        private System.Windows.Forms.Button btdanhsachsinhvien;
        private System.Windows.Forms.Button btmonhoc;
        private System.Windows.Forms.Button btdiem;
        private System.Windows.Forms.Button btbaocao;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btUser;
    }
}