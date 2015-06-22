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
    public partial class frmDiem : Form
    {
        Dictionary<int, string> KhoaDict;

        public frmDiem()
        {
            InitializeComponent();
            KhoaDict = new Dictionary<int, string>();
        }

        public void loadKhoa()
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
        }
        public void Load_Lop_Edit()
        {
            string load;
            load = "exec SP_Load_MonHoc "; // gọi sp
            DataTable dtMH = Program.ExecSqlQuery(load, Program.connstr); // thực hiện câu lệnh truy vấn
            cbMaKhoa.DataSource = dtMH;
            cbMaKhoa.DisplayMember = "TENMH";//thành phần sẽ hiển thị lên combobox
            cbMaKhoa.ValueMember = "MAMH";//khi chon 1 item se se su dụng ma ẩn để lọc dl 
        }
        public void loadMH()
        {
            string load;
            load = "exec SP_Load_MonHoc "; // gọi sp
            DataTable dtMH = Program.ExecSqlQuery(load, Program.connstr); // thực hiện câu lệnh truy vấn
            cbTenMH.DataSource = dtMH;
            cbTenMH.DisplayMember = "TENMH";//thành phần sẽ hiển thị lên combobox
            cbTenMH.ValueMember = "MAMH";//khi chon 1 item se se su dụng ma ẩn để lọc dl 
            cbTenMH.SelectedIndex = 0;
            txtMaMH.Text = "";
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            loadKhoa();
            loadMH();


            if (cbTenLop.SelectedIndex >= 0)
            {
                txtMaLop.Text = cbTenLop.SelectedValue.ToString();
            }
            String malop = cbTenLop.Text;

            if (cbTenMH.SelectedIndex >= 0)
            {
                txtMaMH.Text = cbTenMH.SelectedValue.ToString();
            }
            String mamh = cbTenMH.Text;

            
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lenh;
            string makhoa = KhoaDict[cbKhoa.SelectedIndex]; // mấy mã khoa theo số thứ tự của combobox khoa
            if (Program.mGroup.CompareTo("PGV") == 0)
                lenh = "exec SP_LoadDSLop " + "'" + makhoa + "'"; // gọi sp
            else lenh = "exec SP_LoadDSLop_1Khoa " + "'" + makhoa + "'"; // gọi sp
            DataTable dtLop = Program.ExecSqlQuery(lenh, Program.connstr); // thực hiện câu lệnh truy vấn
            cbTenLop.DataSource = dtLop;
            cbTenLop.DisplayMember = "TENLOP";//thành phần sẽ hiển thị lên combobox
            cbTenLop.ValueMember = "MALOP";//khi chon 1 item se se su dụng ma ẩn để lọc dl 
            txtMaLop.Text = "";

        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenLop.SelectedIndex >= 0)
            {
                txtMaLop.Text = cbTenLop.SelectedValue.ToString();
            }
            String malop = cbTenLop.Text;
        }
        public void LOADDG()
        {
            String malop = txtMaLop.Text;
            String mamh = txtMaMH.Text;
            String lan = cbLanThi.Text;
            if (malop == "" || mamh == "" || lan == "")
                MessageBox.Show("Vui lòng nhập dữ liệu đầy đủ!", "THÔNG BÁO", MessageBoxButtons.OK);
            else
            {
                String lenh;
                if (Program.mGroup.CompareTo("PGV") == 0)
                    lenh = "exec SP_BangDiem_2Khoa" + "'" + malop + "','" + mamh + "','" + lan + "'";
                else lenh = "exec SP_BangDiem_1Khoa" + "'" + malop + "','" + mamh + "','" + lan + "'";
                DataTable dt = Program.ExecSqlQuery(lenh, Program.connstr);
                dgBangDiem.DataSource = dt;
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            LOADDG();
        }

        private void cbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenMH.SelectedIndex >= 0)
            {
                txtMaMH.Text = cbTenMH.SelectedValue.ToString();
            }
            String mamh = cbTenMH.Text;
        }

        private void dgBangDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Lop_Edit();
            txtMaSV.Text = dgBangDiem.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDiem.Text = dgBangDiem.Rows[e.RowIndex].Cells[5].Value.ToString();        
            cbLan.Text = cbLanThi.Text;
            cbMaKhoa.Text = cbTenLop.Text;

            
        }

        private void btNhapDiem_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string mamh = cbMaKhoa.SelectedValue.ToString();
            string lan = cbLanThi.Text;
            string diemt = txtDiem.Text;
            int diem = Convert.ToInt32(diemt);
            if( diem >= 0 || diem <= 10)
            {
                try
                { 
                String lenh;
                if (Program.mGroup.CompareTo("PGV") == 0)
                    lenh = "exec SP_ThemDiem_2Khoa " + "'" + masv + "','" + mamh + "','" + lan + "','" + diem +"'";
                else lenh = "exec SP_ThemDiem_1Khoa " + "'" + masv + "','" + mamh + "','" + lan + "','" + diem + "'";
                Program.ExecSqlNonQuery(lenh, Program.connstr);
                LOADDG();
                }
                catch
                { 
                    MessageBox.Show("Không được!\n", "Thông báo", MessageBoxButtons.OK);
                }
            }



        }

        private void btSua_Click(object sender, EventArgs e)
        {

            string masv = txtMaSV.Text;
            string mamh = cbMaKhoa.SelectedValue.ToString();
            string lan = cbLanThi.Text;
            string diemt = txtDiem.Text;
            int diem = Convert.ToInt32(diemt);
            if (diem >= 0 || diem <= 10)
            {
                try
                {
                    String lenh;
                    if (Program.mGroup.CompareTo("PGV") == 0)
                        lenh = "exec SP_SuaDiem_2Khoa " + "'" + masv + "','" + mamh + "','" + lan + "','" + diem + "'";
                    else lenh = "exec SP_SuaDiem_1Khoa " + "'" + masv + "','" + mamh + "','" + lan + "','" + diem + "'";


                    MessageBox.Show(lenh);
                    Program.ExecSqlNonQuery(lenh, Program.connstr);
                    LOADDG();
                }
                catch
                {
                    MessageBox.Show("Không được!\n", "Thông báo", MessageBoxButtons.OK);
                }
            }


        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string mamh = cbMaKhoa.SelectedValue.ToString();
            string lan = cbLanThi.Text;
            
                //try
                //{
                    String lenh;
                    if (Program.mGroup.CompareTo("PGV") == 0)
                        lenh = "exec SP_XoaDiem_2Khoa " + "'" + masv + "','" + mamh + "','" + lan + "'";
                    else lenh = "exec SP_XoaDiem_1Khoa " + "'" + masv + "','" + mamh + "','" + lan + "'";


                    MessageBox.Show(lenh);
                    Program.ExecSqlQuery(lenh, Program.connstr);
                    LOADDG();
                //}
                //catch
                //{
                //    MessageBox.Show("Không được!\n", "Thông báo", MessageBoxButtons.OK);
                //}
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            frmMain Main = new frmMain();
            Main.Show();
            this.Close();
        }


    }
}
