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
    public partial class frmSinhVien : Form
    {
        Dictionary<int, string> KhoaDict;
        public frmSinhVien()
        {
            InitializeComponent();
            KhoaDict = new Dictionary<int, string>();
        }
        public void LoadLop()
        {
            string lenh;
            string makhoa = KhoaDict[cbKhoa.SelectedIndex]; // Mấy mã khoa
            if (Program.mGroup.CompareTo("PGV") == 0)
                lenh = "exec SP_LoadDSLop " + "'" + makhoa + "'";
            else lenh = "exec SP_LoadDSLop_1Khoa " + "'" + makhoa + "'";
            DataTable dtLop = Program.ExecSqlQuery(lenh, Program.connstr); // Câu lệnh truy vấn
            cbLopNhap.DataSource = dtLop;
            cbLopNhap.DisplayMember = "TENLOP";// Thành phần sẽ hiển thị
            cbLopNhap.ValueMember = "MALOP";// Thành Phần Giá Trị sau khi chọn

        }
        public void LoadNghiHoc()
        {
            Dictionary<string, string> NghiHocA = new Dictionary<string, string>();
            NghiHocA.Add("true", "Nghỉ Học");
            NghiHocA.Add("false", "Còn Học");
            cbNghiHoc.DataSource = new BindingSource(NghiHocA, null);
            cbNghiHoc.DisplayMember = "Value";
            cbNghiHoc.ValueMember = "Key";

        }
        public void LoadKhoa()
        {
            String lenh;
            if (Program.mGroup.CompareTo("PGV") == 0)
                lenh = "exec SP_Load_Khoa";
            else lenh = "exec SP_Load_1Khoa";
            DataTable dt = Program.ExecSqlQuery(lenh, Program.connstr);
            int index = 0;
            foreach (DataRow drKhoa in dt.Rows)
            {
                // thêm vào KhoaMapping theo thứ tự: số thứ tự - mã khoa
                KhoaDict.Add(index, drKhoa[0].ToString()); // dr[0] là cột mã khoa, dr[1] là cột tên khoa
                cbKhoa.Items.Add(drKhoa[1].ToString()); // thêm cột tên khoa vào combobox
                index++;
            }
            cbKhoa.SelectedIndex = 0;
            cbLop.SelectedIndex = 0;
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {

            LoadKhoa();
            Dictionary<string, string>GioiTinh = new Dictionary<string, string>();
            GioiTinh.Add("true", "Nam");
            GioiTinh.Add("false", "Nữ");
            cbGioiTinh.DataSource = new BindingSource(GioiTinh, null);
            cbGioiTinh.DisplayMember = "Value";
            cbGioiTinh.ValueMember = "Key";
            LoadNghiHoc();
            LOADDS();
            clock();
            LoadLop();

            
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lenh;
            string makhoa = KhoaDict[cbKhoa.SelectedIndex]; // Mấy mã khoa
            if (Program.mGroup.CompareTo("PGV") == 0) 
                lenh = "exec SP_LoadDSLop " + "'" + makhoa + "'"; 
            else lenh = "exec SP_LoadDSLop_1Khoa " + "'" + makhoa + "'"; 
            DataTable dtLop = Program.ExecSqlQuery(lenh, Program.connstr); // Câu lệnh truy vấn
            cbLop.DataSource = dtLop;
            cbLop.DisplayMember = "TENLOP";// Thành phần sẽ hiển thị
            cbLop.ValueMember = "MALOP";// Thành Phần Giá Trị sau khi chọn

        }

        public void LOADDS()
        {
            String lenh;
            if (cbLop.SelectedIndex >= 0)
            {
                String malop = cbLop.SelectedValue.ToString();
                if (Program.mGroup.CompareTo("PGV") == 0)
                    lenh = "exec SP_LoadSV " + "'" + malop + "'";
                else lenh = "exec SP_LoadSV_1Khoa " + "'" + malop + "'";
                DataTable dtSV = Program.ExecSqlQuery(lenh, Program.connstr); // Câu lệnh truy vấn
                dgSinhVien.DataSource = dtSV; // Đưa vào gridview hiện lên màn hình
            }
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            String lenh;
            if (cbLop.SelectedIndex >= 0)
            {
                String malop = cbLop.SelectedValue.ToString();
                if (Program.mGroup.CompareTo("PGV") == 0)
                    lenh = "exec SP_LoadSV " + "'" + malop + "'"; 
                else lenh = "exec SP_LoadSV_1Khoa " + "'" + malop + "'"; 
                DataTable dtSV = Program.ExecSqlQuery(lenh, Program.connstr); // Câu lệnh truy vấn
                dgSinhVien.DataSource = dtSV; // Đưa vào gridview hiện lên màn hình
            }
        }

        private void dgSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgSinhVien.CurrentRow.Cells["MASV"].Value.ToString();
            txtHo.Text = dgSinhVien.CurrentRow.Cells["HO"].Value.ToString();
            txtTen.Text = dgSinhVien.CurrentRow.Cells["TEN"].Value.ToString();
            string LOL = dgSinhVien.CurrentRow.Cells["PHAI"].Value.ToString();
            //cbGioiTinh.Text = dgSinhVien.CurrentRow.Cells["PHAI"].Value.ToString();
            if (LOL.ToString() == "True")
            {
                cbGioiTinh.Text = "Nam";

            }
            else
            {
                cbGioiTinh.Text = "Nữ";

            }
            txtDiaChi.Text = dgSinhVien.CurrentRow.Cells["DIACHI"].Value.ToString();
            String dNgaySinh = dgSinhVien.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            dateNgaySinh.Text = dNgaySinh;
            dateNgaySinh.Format = DateTimePickerFormat.Custom;
            dateNgaySinh.CustomFormat = "yyyy/MM/dd";



            txtNoiSinh.Text = dgSinhVien.CurrentRow.Cells["NOISINH"].Value.ToString();
            txtGhiChu.Text = dgSinhVien.CurrentRow.Cells["GHICHU"].Value.ToString();
            string nghihoc = dgSinhVien.CurrentRow.Cells["NGHIHOC"].Value.ToString();

            if(nghihoc.ToString() == "True")
            {
                cbNghiHoc.Text = "Nghỉ Học";

            }
            else
            {
                cbNghiHoc.Text = "Còn Học";
            }
            //string lol = dgSinhVien.CurrentRow.Cells["MALOP"].Value.ToString();

            cbLopNhap.Text = cbLop.Text;

            
        }

        //public void LoadGiaTri()
        //{
        //    string masv = txtMaSV.Text;
        //    string ho = txtHo.Text;
        //    string ten = txtTen.Text;
        //    string phai = cbGioiTinh.SelectedValue.ToString();
        //    string diachi = txtDiaChi.Text;
        //    string ngaysinh = dateNgaySinh.Text;
        //    string noisinh = txtNoiSinh.Text;
        //    string ghichu = txtGhiChu.Text;
        //    string nghihoc = txtNghiHoc.Text;
        //    string malop = cbLopNhap.SelectedValue.ToString();
        //}

        private void btXoa_Click(object sender, EventArgs e)
        {
            //LoadGiaTri();
            string masv = txtMaSV.Text;
            if (masv.ToString() == "" || malop.ToString() == "")
                MessageBox.Show("Vui lòng nhập mã sinh viên và mã lớp để load dữ liệu kiểm tra, trước khi xóa dữ liệu!", "THÔNG BÁO", MessageBoxButtons.OK);
            else
            {
                try
                {
                    String lenh;
                    if (Program.mGroup.CompareTo("PGV") == 0)
                        lenh = "exec SP_XoaSV_2Khoa " + "'" + masv + "'";
                    else lenh = "exec SP_XoaSV_1Khoa " + "'" + masv + "'";
                    Program.ExecSqlNonQuery(lenh, Program.connstr);
                    MessageBox.Show(lenh);
                    LOADDS();
                    //MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text.Trim();
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();
            string phai = cbGioiTinh.SelectedValue.ToString().Trim();
            string diachi = txtDiaChi.Text.Trim();
            string ngaysinh = dateNgaySinh.Text.Trim();
            string noisinh = txtNoiSinh.Text.Trim();
            string ghichu = txtGhiChu.Text.Trim();
            string nghihoc = cbNghiHoc.SelectedValue.ToString().Trim();
            string malop = cbLopNhap.SelectedValue.ToString().Trim();
            unclock();
            btXoa.Visible = false;
            btSua.Visible = false;
            if (btThem.Text == "Cập Nhật")
            {
                try
                {
                    String lenh;
                    if (Program.mGroup.CompareTo("PGV") == 0)
                        //lenh = "exec SP_ThemSV_2Khoa '09THA400','a','a','C10THA1','false','1976/08/10','true','saaa','true','True'";
                        lenh = "exec SP_ThemSV_2Khoa " + "'" + masv + "','" + ho + "','" + ten + "','" + malop + "','" + phai + "','" + ngaysinh + "','" + noisinh + "','" + diachi + "','" + ghichu + "','" + nghihoc + "'";
                    //lenh = "exec SP_ThemSV_2Khoa " + "'" + masv + "','" + ho + "','" + ten + "','" + malop + "','" + phai + "','1976/08/10','true','saaa','true','True'";
                    //else lenh = "exec SP_ThemSV " + "'" + masv + "','" + ho + "','" + ten + "','" + malop + "','" + phai + "','" + ngaysinh + "','" + noisinh + "','" + diachi + "','" + ghichu + "','" + nghihoc + "'";
                    else lenh = "exec SP_ThemSV '08THA195','a','a','D08-HTTT','true','2015/08/08','true','true','true','true'";

                    Program.ExecSqlNonQuery(lenh, Program.connstr);
                    MessageBox.Show(lenh);
                    LOADDS();
                    clock();
                    btThem.Text = "THÊM";
                    btXoa.Visible = true;
                    btSua.Visible = true;
                    //MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            else
            { 
                btThem.Text = "Cập Nhật";
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            string masv = txtMaSV.Text.Trim();
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();
            string phai = cbGioiTinh.SelectedValue.ToString().Trim();
            string diachi = txtDiaChi.Text.Trim();
            string ngaysinh = dateNgaySinh.Text.Trim();
            string noisinh = txtNoiSinh.Text.Trim();
            string ghichu = txtGhiChu.Text.Trim();
            string nghihoc = cbNghiHoc.SelectedValue.ToString().Trim();
            string malop = cbLopNhap.SelectedValue.ToString().Trim();
            


            if (masv.ToString() == "")
            {
                MessageBox.Show("Phiền bạn hãy chọn sinh viên để sửa", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                unclock();
                txtMaSV.Enabled = false;
                btXoa.Visible = false;
                btThem.Visible = false;
                if(btSua.Text == "Cập Nhật")
                { 
                try
                {
                    String lenh;
                    if (Program.mGroup.CompareTo("PGV") == 0)
                        lenh = "exec SP_SuaSV_2Khoa " + "'" + masv + "','" + ho + "','" + ten + "','" + malop + "','" + phai + "','" + ngaysinh + "','" + noisinh + "','" + diachi + "','" + ghichu + "','" + nghihoc + "'";
                    else lenh = "exec SP_SuaSV_1Khoa " + "'" + masv + "','" + ho + "','" + ten + "','" + malop + "','" + phai + "','" + ngaysinh + "','" + noisinh + "','" + diachi + "','" + ghichu + "','" + nghihoc + "'";
                    Program.ExecSqlNonQuery(lenh, Program.connstr);
                    MessageBox.Show(lenh);
                    LOADDS();
                    clock();
                    btSua.Text = "Sửa";
                    btXoa.Visible = true;
                    btThem.Visible = true;
                    //MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại" + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK);
                }
                }
                else
                {
                    btSua.Text = "Cập Nhật";
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            frmMain Main = new frmMain();
            Main.Show();
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            dateNgaySinh.Text = "";
            txtNoiSinh.Text = "";
            txtGhiChu.Text = "";            
        }

        public void clock()
        {
            txtMaSV.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            dateNgaySinh.Enabled = false;
            txtNoiSinh.Enabled = false;
            txtGhiChu.Enabled = false;            
        }
        public void unclock()
        {
            txtMaSV.Enabled = true;
            txtHo.Enabled = true;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            dateNgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtGhiChu.Enabled = true;
        }
    }
}
