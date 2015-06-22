using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            sttHoTen.Text = "Họ tên nhân viên: " + frmDangNhap.tennv;
            sttNhom.Text = " Nhóm: " + frmDangNhap.nhomnv;

            //Phân quyền

            if (Program.mGroup == "PGV")
            {
                lbThongBao.Text = "Xin chào Nhân viên PGV :" + frmDangNhap.tennv;
            }
            else if (Program.mGroup == "KHOA")
            {
                lbThongBao.Text = "   Xin chào giảng viên :" + frmDangNhap.tennv;
            }
            else
            {
                lbThongBao.Text = "          Xin chào bạn :" + frmDangNhap.tennv;
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            frmDangNhap DangNhap = new frmDangNhap();
            DangNhap.Show();
            this.Close();
        }

        private void btdanhsachlop_Click(object sender, EventArgs e)
        {
            frmLop Lop = new frmLop();
            Lop.Show();
            this.Close();
        }

        private void btmonhoc_Click(object sender, EventArgs e)
        {
            frmMonHoc MonHoc = new frmMonHoc();
            MonHoc.Show();
            this.Close();
        }

        private void btdanhsachsinhvien_Click(object sender, EventArgs e)
        {
            frmSinhVien SinhVien = new frmSinhVien();
            SinhVien.Show();
            this.Close();
        }

        private void btdiem_Click(object sender, EventArgs e)
        {
            frmDiem Diem = new frmDiem();
            Diem.Show();
            this.Close();
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            frmUser User = new frmUser();
            User.Show();
            this.Close();
        }

        private void btbaocao_Click(object sender, EventArgs e)
        {
            InDSSV InDSSV = new InDSSV();
            InDSSV.Show();
            this.Close();
        }
    }
}
