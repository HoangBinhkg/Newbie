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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        public void UnLock()
        {
            txtMaMH.Enabled = true;
            txtTenMH.Enabled = true;
        }
        public void Lock()
        {
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
        }

        public void loadMH()
        {
            string lenh;
            lenh = "exec SP_Load_MonHoc "; // gọi sp
            DataTable dtMH = Program.ExecSqlQuery(lenh, Program.connstr); // thực hiện câu lệnh truy vấn
            dgMonHoc.DataSource = dtMH; // đem vào gridview hiện lên màn hình
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            loadMH();
        }

        private void dgMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dgMonHoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenMH.Text = dgMonHoc.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btThemMH_Click(object sender, EventArgs e)
        {
            UnLock();
            string mamh = txtMaMH.Text;
            string tenmh = txtTenMH.Text;
            btHuy.Visible = true;
            btSuaMH.Visible = false;
            btXoaMH.Visible = false;

            if (btThemMH.Text == "Cập Nhật")
            { 
                if (mamh == "" || tenmh == "")
                    MessageBox.Show("Vui lòng nhập dữ liệu trước khi thêm!", "THÔNG BÁO", MessageBoxButtons.OK);
                else
                {
                    try
                    {
                        String lenh;
                        lenh = "exec SP_ThemMonHoc " + "'" + mamh + "','" + tenmh + "'";
                        Program.ExecSqlNonQuery(lenh, Program.connstr);
                        MessageBox.Show(lenh);
                        MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                        loadMH();
                        Lock();
                        btSuaMH.Visible = true;
                        btXoaMH.Visible = true;
                        btHuy.Visible = false;
                        btThemMH.Text = "Thêm Môn Học";
                    }
                    catch
                    {
                        MessageBox.Show("Thêm thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                  
                    }
                }
            }
            else
            {
                btThemMH.Text = "Cập Nhật";
            }
            
        }

        private void btXoaMH_Click(object sender, EventArgs e)
        {
            string mamh = txtMaMH.Text;
            try
            {
                String lenh;
                lenh = "exec SP_XoaMonHoc " + "'" + mamh + "'";
                Program.ExecSqlNonQuery(lenh, Program.connstr);
                MessageBox.Show("Xóa thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                loadMH();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btSuaMH_Click(object sender, EventArgs e)
        {

            string mamh = txtMaMH.Text;
            string tenmh = txtTenMH.Text;

            if (mamh.ToString() == "")
            {
                MessageBox.Show("Phiền bạn hãy chọn môn học để sửa", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                btThemMH.Visible = false;
                btXoaMH.Visible = false;
                btHuy.Visible = true;
                txtTenMH.Enabled = true;
                if (btSuaMH.Text == "Cập Nhật")
                {
                    if (tenmh == "")
                        MessageBox.Show("Bạn chưa nhập dữ liệu chỉnh sửa!", "THÔNG BÁO", MessageBoxButtons.OK);
                    else
                    {
                        try
                        {
                            String lenh;
                            lenh = "exec SP_SuaMonHoc " + "'" + mamh + "','" + tenmh + "'";
                            Program.ExecSqlNonQuery(lenh, Program.connstr);
                            MessageBox.Show("Sửa thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                            loadMH();
                            btThemMH.Visible = true;
                            btXoaMH.Visible = true;
                            btHuy.Visible = false;
                            btSuaMH.Text = "Sửa Môn Học";
                            Lock();

                        }
                        catch
                        {
                            MessageBox.Show("Sửa thất bại", "THÔNG BÁO", MessageBoxButtons.OK);
                        }

                    }
                }
                else
                {
                    btSuaMH.Text = "Cập Nhật";

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
            Lock();
            btThemMH.Visible = true;
            btXoaMH.Visible = true;
            btSuaMH.Visible = true;
            btSuaMH.Text = "Sửa Môn Học";
            btThemMH.Text = "Thêm Môn Học";

        }
    }
}
