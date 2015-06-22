namespace CSDLPT
{
    partial class frmLop
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
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgLop = new System.Windows.Forms.DataGridView();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbmalop = new System.Windows.Forms.Label();
            this.lbtenlop = new System.Windows.Forms.Label();
            this.lbmakhoa = new System.Windows.Forms.Label();
            this.TxtMaLop = new System.Windows.Forms.TextBox();
            this.TxtTenLop = new System.Windows.Forms.TextBox();
            this.btThemLop = new System.Windows.Forms.Button();
            this.btXoaLop = new System.Windows.Forms.Button();
            this.btSuaLop = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.cbKhoaA = new System.Windows.Forms.ComboBox();
            this.btHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLop)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.IntegralHeight = false;
            this.cbKhoa.Location = new System.Drawing.Point(121, 12);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(233, 21);
            this.cbKhoa.TabIndex = 0;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHOA:";
            // 
            // dgLop
            // 
            this.dgLop.AllowUserToAddRows = false;
            this.dgLop.AllowUserToDeleteRows = false;
            this.dgLop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOP,
            this.TENLOP,
            this.MAKH});
            this.dgLop.Location = new System.Drawing.Point(45, 61);
            this.dgLop.Name = "dgLop";
            this.dgLop.ReadOnly = true;
            this.dgLop.Size = new System.Drawing.Size(410, 185);
            this.dgLop.TabIndex = 2;
            this.dgLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLop_CellContentClick);
            // 
            // MALOP
            // 
            this.MALOP.DataPropertyName = "MALOP";
            this.MALOP.HeaderText = "Mã Lớp";
            this.MALOP.Name = "MALOP";
            this.MALOP.ReadOnly = true;
            this.MALOP.Width = 80;
            // 
            // TENLOP
            // 
            this.TENLOP.DataPropertyName = "TENLOP";
            this.TENLOP.HeaderText = "Tên Lớp";
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.ReadOnly = true;
            this.TENLOP.Width = 180;
            // 
            // MAKH
            // 
            this.MAKH.DataPropertyName = "MAKH";
            this.MAKH.HeaderText = "Mã Khoa";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Width = 80;
            // 
            // lbmalop
            // 
            this.lbmalop.AutoSize = true;
            this.lbmalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmalop.Location = new System.Drawing.Point(502, 80);
            this.lbmalop.Name = "lbmalop";
            this.lbmalop.Size = new System.Drawing.Size(84, 20);
            this.lbmalop.TabIndex = 3;
            this.lbmalop.Text = "MÃ LỚP :";
            // 
            // lbtenlop
            // 
            this.lbtenlop.AutoSize = true;
            this.lbtenlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtenlop.Location = new System.Drawing.Point(494, 140);
            this.lbtenlop.Name = "lbtenlop";
            this.lbtenlop.Size = new System.Drawing.Size(92, 20);
            this.lbtenlop.TabIndex = 4;
            this.lbtenlop.Text = "TÊN LỚP :";
            // 
            // lbmakhoa
            // 
            this.lbmakhoa.AutoSize = true;
            this.lbmakhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmakhoa.Location = new System.Drawing.Point(518, 199);
            this.lbmakhoa.Name = "lbmakhoa";
            this.lbmakhoa.Size = new System.Drawing.Size(68, 20);
            this.lbmakhoa.TabIndex = 5;
            this.lbmakhoa.Text = "KHOA :";
            // 
            // TxtMaLop
            // 
            this.TxtMaLop.Enabled = false;
            this.TxtMaLop.Location = new System.Drawing.Point(601, 80);
            this.TxtMaLop.Name = "TxtMaLop";
            this.TxtMaLop.Size = new System.Drawing.Size(179, 20);
            this.TxtMaLop.TabIndex = 6;
            // 
            // TxtTenLop
            // 
            this.TxtTenLop.Enabled = false;
            this.TxtTenLop.Location = new System.Drawing.Point(601, 142);
            this.TxtTenLop.Name = "TxtTenLop";
            this.TxtTenLop.Size = new System.Drawing.Size(179, 20);
            this.TxtTenLop.TabIndex = 7;
            // 
            // btThemLop
            // 
            this.btThemLop.Location = new System.Drawing.Point(506, 265);
            this.btThemLop.Name = "btThemLop";
            this.btThemLop.Size = new System.Drawing.Size(93, 32);
            this.btThemLop.TabIndex = 9;
            this.btThemLop.Text = "Thêm Lớp";
            this.btThemLop.UseVisualStyleBackColor = true;
            this.btThemLop.Click += new System.EventHandler(this.btThemLop_Click);
            // 
            // btXoaLop
            // 
            this.btXoaLop.Location = new System.Drawing.Point(614, 265);
            this.btXoaLop.Name = "btXoaLop";
            this.btXoaLop.Size = new System.Drawing.Size(93, 32);
            this.btXoaLop.TabIndex = 10;
            this.btXoaLop.Text = "Xóa Lớp";
            this.btXoaLop.UseVisualStyleBackColor = true;
            this.btXoaLop.Click += new System.EventHandler(this.btXoaLop_Click);
            // 
            // btSuaLop
            // 
            this.btSuaLop.Location = new System.Drawing.Point(722, 265);
            this.btSuaLop.Name = "btSuaLop";
            this.btSuaLop.Size = new System.Drawing.Size(93, 32);
            this.btSuaLop.TabIndex = 11;
            this.btSuaLop.Text = "Sửa Lớp";
            this.btSuaLop.UseVisualStyleBackColor = true;
            this.btSuaLop.Click += new System.EventHandler(this.btSuaLop_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(722, 12);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(93, 32);
            this.btThoat.TabIndex = 12;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // cbKhoaA
            // 
            this.cbKhoaA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoaA.FormattingEnabled = true;
            this.cbKhoaA.IntegralHeight = false;
            this.cbKhoaA.Location = new System.Drawing.Point(601, 201);
            this.cbKhoaA.Name = "cbKhoaA";
            this.cbKhoaA.Size = new System.Drawing.Size(179, 21);
            this.cbKhoaA.TabIndex = 13;
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(396, 265);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(93, 32);
            this.btHuy.TabIndex = 14;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 330);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.cbKhoaA);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSuaLop);
            this.Controls.Add(this.btXoaLop);
            this.Controls.Add(this.btThemLop);
            this.Controls.Add(this.TxtTenLop);
            this.Controls.Add(this.TxtMaLop);
            this.Controls.Add(this.lbmakhoa);
            this.Controls.Add(this.lbtenlop);
            this.Controls.Add(this.lbmalop);
            this.Controls.Add(this.dgLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKhoa);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgLop;
        private System.Windows.Forms.Label lbmalop;
        private System.Windows.Forms.Label lbtenlop;
        private System.Windows.Forms.Label lbmakhoa;
        private System.Windows.Forms.TextBox TxtMaLop;
        private System.Windows.Forms.TextBox TxtTenLop;
        private System.Windows.Forms.Button btThemLop;
        private System.Windows.Forms.Button btXoaLop;
        private System.Windows.Forms.Button btSuaLop;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.ComboBox cbKhoaA;
        private System.Windows.Forms.Button btHuy;
    }
}