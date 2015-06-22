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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        public void load_sv()
        {
            string load;
            load = "SP_Load_DSSV"; // gọi sp
            DataTable dtMH1 = Program.ExecSqlQuery(load, Program.connstr); // thực hiện câu lệnh truy vấn
            cbUser.DataSource = dtMH1;
            cbUser.DisplayMember = "HOTEN";//thành phần sẽ hiển thị lên combobox
            cbUser.ValueMember = "MASV";//khi chon 1 item se se su dụng ma ẩn để lọc dl 

        }
        public void load_gv()
        {
            string load;
            load = "SELECT MAGV,HOTEN = HO + ' '+ Ten FROM LINK1.QLDSV.DBO.GIANGVIEN"; // gọi sp
            DataTable dtMH = Program.ExecSqlQuery(load, Program.connstr); // thực hiện câu lệnh truy vấn
            cbUser.DataSource = dtMH;
            cbUser.DisplayMember = "HOTEN";//thành phần sẽ hiển thị lên combobox
            cbUser.ValueMember = "MAGV";//khi chon 1 item se se su dụng ma ẩn để lọc dl 
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> Phong = new Dictionary<string, string>();
            Phong.Add("PGV", "Phòng Giáo Vụ");
            Phong.Add("KHOA", "Giảng Viên");
            Phong.Add("SV", "Sinh Viên");
            cbPhanQuyen.DataSource = new BindingSource(Phong, null);
            cbPhanQuyen.DisplayMember = "Value";
            cbPhanQuyen.ValueMember = "Key";

        }

        private void cbPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhanQuyen.Text == "Sinh Viên")
            {
                load_sv();
            }
            else
                load_gv();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtPass.Text = " ";
            txtUser.Text = " ";
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            string LGNAME = txtUser.Text; 
            string PASS = txtPass.Text;
            string USRNAME = cbUser.SelectedValue.ToString();
            string ROLE = cbPhanQuyen.SelectedValue.ToString();

            String lenh;
                lenh = "exec TAO_LOGIN " + "'" + LGNAME + "','" + PASS + "','" + USRNAME + "','" + ROLE + "'";
            Program.ExecSqlNonQuery(lenh, Program.connstr);
            MessageBox.Show(lenh);
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btKiemTra_Click(object sender, EventArgs e)
        {
            string MaUser = cbUser.SelectedValue.ToString().Trim();
            String lenh = "sp_helpuser '" + MaUser + "'";

            MessageBox.Show(lenh);

                Program.myReader = Program.ExecSqlDataReader(lenh, Program.connstr);
                MessageBox.Show(Program.myReader.GetString(2));

        }







         //     strLenh = "sp_helpuser '" + Program.username + "'";
         //   // sp này trả về các fields theo thứ tự:
         //   //Username Groupname    LoginName    DfDBName  UserID  SID

         //   try
         //   {
         //       Program.myReader = Program.ExecSqlDataReader(strLenh, Program.connstr);

         //   }
         //   catch (InvalidOperationException)
         //   {
         //       MessageBox.Show("Mã nhân viên theo Login đăng nhập chưa có quyền truy cập.", "", MessageBoxButtons.OK);
         //       return;
         //   }

         //   // Lấy group name từ username
         //   if (Program.myReader.Read())
         //       Program.mGroup = Program.myReader.GetString(1);
         //   else
         //   {
         //       MessageBox.Show("Lỗi xác định quyền của user. ", "", MessageBoxButtons.OK);
         //       return;
         //   }

         //   Program.myReader.Close();

         //   // Lấy họ tên từ user name

         //   if (Program.mGroup.CompareTo("SV") == 0)
         //       strLenh = "Select HO + ' ' + TEN as Hoten From SINHVIEN Where MASV = " + "'" + Program.username + "'";
         //   else strLenh = "Select HO + ' ' + TEN as Hoten From GIANGVIEN Where MAGV = " + "'" + Program.username + "'";

         //   Program.myReader = Program.ExecSqlDataReader(strLenh, Program.connstr);
         //   if (Program.myReader.HasRows)
         //   {
         //       Program.myReader.Read();
         //       Program.mHoten = Program.myReader.GetString(0);
         //   }
         //   else
         //   {
         //       MessageBox.Show("Login bạn nhập chưa có liên kết với một nhân viên  ", "", MessageBoxButtons.OK);
         //       Program.myReader.Close();
         //       Program.conn.Close();
         //       return;
         //   }

         //   Program.myReader.Close();
         //   Program.conn.Close();
         //   tennv = Program.mHoten;
         //   nhomnv = Program.mGroup;
    }
}
