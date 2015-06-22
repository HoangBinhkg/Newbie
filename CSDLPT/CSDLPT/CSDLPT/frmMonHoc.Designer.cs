namespace CSDLPT
{
    partial class frmMonHoc
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
            this.dgMonHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaMH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.btThemMH = new System.Windows.Forms.Button();
            this.btXoaMH = new System.Windows.Forms.Button();
            this.btSuaMH = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMonHoc
            // 
            this.dgMonHoc.AllowUserToAddRows = false;
            this.dgMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgMonHoc.Location = new System.Drawing.Point(74, 73);
            this.dgMonHoc.Name = "dgMonHoc";
            this.dgMonHoc.ReadOnly = true;
            this.dgMonHoc.Size = new System.Drawing.Size(601, 174);
            this.dgMonHoc.TabIndex = 0;
            this.dgMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMonHoc_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAMH";
            this.Column1.HeaderText = "MÃ MÔN HỌC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENMH";
            this.Column2.HeaderText = "TÊN MÔN HỌC";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 350;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMH.Location = new System.Drawing.Point(71, 288);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(112, 20);
            this.lbMaMH.TabIndex = 2;
            this.lbMaMH.Text = "MÃ MÔN HỌC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÊN MÔN HỌC";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(189, 288);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(137, 20);
            this.txtMaMH.TabIndex = 4;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Enabled = false;
            this.txtTenMH.Location = new System.Drawing.Point(475, 288);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(200, 20);
            this.txtTenMH.TabIndex = 5;
            // 
            // btThemMH
            // 
            this.btThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMH.Location = new System.Drawing.Point(74, 341);
            this.btThemMH.Name = "btThemMH";
            this.btThemMH.Size = new System.Drawing.Size(135, 35);
            this.btThemMH.TabIndex = 6;
            this.btThemMH.Text = "Thêm Môn Học";
            this.btThemMH.UseVisualStyleBackColor = true;
            this.btThemMH.Click += new System.EventHandler(this.btThemMH_Click);
            // 
            // btXoaMH
            // 
            this.btXoaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaMH.Location = new System.Drawing.Point(231, 341);
            this.btXoaMH.Name = "btXoaMH";
            this.btXoaMH.Size = new System.Drawing.Size(135, 35);
            this.btXoaMH.TabIndex = 7;
            this.btXoaMH.Text = "Xóa Môn Học";
            this.btXoaMH.UseVisualStyleBackColor = true;
            this.btXoaMH.Click += new System.EventHandler(this.btXoaMH_Click);
            // 
            // btSuaMH
            // 
            this.btSuaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaMH.Location = new System.Drawing.Point(392, 341);
            this.btSuaMH.Name = "btSuaMH";
            this.btSuaMH.Size = new System.Drawing.Size(135, 35);
            this.btSuaMH.TabIndex = 8;
            this.btSuaMH.Text = "Sửa Môn Học";
            this.btSuaMH.UseVisualStyleBackColor = true;
            this.btSuaMH.Click += new System.EventHandler(this.btSuaMH_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(621, 22);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(135, 35);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.Location = new System.Drawing.Point(583, 341);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(135, 35);
            this.btHuy.TabIndex = 10;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Visible = false;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 399);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSuaMH);
            this.Controls.Add(this.btXoaMH);
            this.Controls.Add(this.btThemMH);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMaMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMonHoc);
            this.Name = "frmMonHoc";
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Button btThemMH;
        private System.Windows.Forms.Button btXoaMH;
        private System.Windows.Forms.Button btSuaMH;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btHuy;
    }
}