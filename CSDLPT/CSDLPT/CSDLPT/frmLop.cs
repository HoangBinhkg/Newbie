using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmLop : Form
    {
        Dictionary<int, string> KhoaDict;

        public frmLop()
        {
            InitializeComponent();
            KhoaDict = new Dictionary<int, string>();
        }
        public void load_data()
        {
            string lenh;
            string makhoa = KhoaDict[cbKhoa.SelectedIndex]; // mấy mã khoa theo số thứ tự của combobox khoa
            if (Program.mGroup.CompareTo("PGV") == 0)
                lenh = "exec SP_LoadLop " + "'" + makhoa + "'";
            else lenh = "exec SP_LoadLop_1Khoa " + "'" + makhoa + "'";
            DataTable dtLop = Program.ExecSqlQuery(lenh, Program.connstr); // thực hiện câu lệnh truy vấn
            dgLop.DataSource = dtLop; // đem vào gridview hiện lên màn hình
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            String lenh;
            if (Program.mGroup.CompareTo("PGV") == 0)
                lenh = "exec SP_Load_Khoa";
            else lenh = "exec SP_Load_1Khoa";
            DataTable dt = Program.ExecSqlQuery(lenh, Program.connstr);
            int index = 0;
            foreach (DataRow dr in dt.Rows)
            {
                // thêm vào KhoaMapping theo thứ tự: số thứ tự - mã khoa
                KhoaDict.Add(index, dr[0].ToString()); // dr[0] là cột mã khoa, dr[1] là cột tên khoa
                cbKhoa.Items.Add(dr[1].ToString()); // thêm cột tên khoa vào combobox
                index++;
            }
            cbKhoa.SelectedIndex = 0;
            Load_Khoa_Edit();

            if (Program.mGroup.CompareTo("SV") == 0)
            {
                btSuaLop.Visible = false;
                btXoaLop.Visible = false;
                btThemLop.Visible = false;
            }

        }


        public void Load_Khoa_Edit()
        {
            String lenh;
            if (Program.mGroup.CompareTo("PGV") == 0)
                lenh = "exec SP_Load_Khoa";
            else lenh = "exec SP_Load_1Khoa";
            DataTable dtKhoa = Program.ExecSqlQuery(lenh, Program.connstr);
            cbKhoaA.DataSource = dtKhoa;
            cbKhoaA.DisplayMember = "TENKH";//thành phần sẽ hiển thị lên combobox
            cbKhoaA.ValueMember = "MAKH";//khi chon 1 item se se su dụng ma ẩn để lọc dl 
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data();
        }

        private void dgLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
            TxtMaLop.Text = dgLop.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtTenLop.Text = dgLop.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbKhoaA.Text = cbKhoa.Text;
                }
            catch
            {
                MessageBox.Show("Phiền Bạn hãy chọn một lớp dưới đây");
            }
        }
        public void unlock()
        {
            cbKhoaA.Enabled = true;
            TxtMaLop.Enabled = true;
            TxtTenLop.Enabled = true;
        }
        public void Lock()
        {
            cbKhoaA.Enabled = false;
            TxtMaLop.Enabled = false;
            TxtTenLop.Enabled = false;
        }
        private void btThemLop_Click(object sender, EventArgs e)
        {
            unlock();
            string malop = TxtMaLop.Text;
            string tenlop = TxtTenLop.Text;
            string makhoa = cbKhoaA.SelectedValue.ToString();
            btSuaLop.Visible = false;
            btXoaLop.Visible = false;

            if (btThemLop.Text == "Cập Nhật")
            { 
                    try
                    {
                        string lenh;
                        if (Program.mGroup.CompareTo("PGV") == 0)
                            lenh = "exec SP_ThemLop " + "'" + malop + "','" + tenlop + "','" + makhoa + "'";
                        else
                            lenh = "exec SP_ThemLop_1Khoa " + "'" + malop + "','" + tenlop + "','" + makhoa + "'";
                        Program.ExecSqlNonQuery(lenh, Program.connstr);
                        MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                        load_data();
                        btThemLop.Text = "Thêm Lớp";
                        Lock();
                        btSuaLop.Visible = true;
                        btXoaLop.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
            }
            else
            { 
                btThemLop.Text = "Cập Nhật"; 
            }

        }

        private void btXoaLop_Click(object sender, EventArgs e)
        {
            string malop = TxtMaLop.Text;
            try
            {
                string lenh;
                if (Program.mGroup.CompareTo("PGV") == 0)
                    lenh = "exec SP_XoaLop " + "'" + malop + "'";
                else lenh = "exec SP_XoaLop_1Khoa " + "'" + malop + "'";
                Program.ExecSqlNonQuery(lenh, Program.connstr);
                MessageBox.Show(lenh);
                //MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                load_data();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btSuaLop_Click(object sender, EventArgs e)
        {

            string malop = TxtMaLop.Text;
            string tenlop = TxtTenLop.Text;
            string makhoa = cbKhoaA.SelectedValue.ToString();


            if (malop.ToString() == "")
            {
                MessageBox.Show("Phiền bạn hãy chọn Lớp để sửa", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                TxtTenLop.Enabled = true;
                if (btSuaLop.Text == "Cập Nhật")
                {
                    try
                    {
                        string lenh;
                        if (Program.mGroup.CompareTo("PGV") == 0)
                            lenh = "exec SP_SuaLop_2Khoa " + "'" + malop + "','" + tenlop + "'";
                        else lenh = "exec SP_SuaLop_1Khoa " + "'" + malop + "','" + tenlop + "'";
                        //MessageBox.Show(lenh);
                        Program.ExecSqlNonQuery(lenh, Program.connstr);
                        MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                        load_data();
                        Lock();
                        btSuaLop.Text = "Sửa Lớp";

                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    btSuaLop.Text = "Cập Nhật";
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
            TxtMaLop.Text = "";
            TxtTenLop.Text = "";
        }
    }
}
