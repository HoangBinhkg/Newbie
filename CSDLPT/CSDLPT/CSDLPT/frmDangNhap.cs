using Microsoft.Win32;
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
    public partial class frmDangNhap : Form
    {
        public static string tennv;
        public static string nhomnv;
        private Dictionary<string, string> tenserver;

        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                tenserver = new Dictionary<string, string>();
                var localMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                var rk = localMachine.OpenSubKey("SOFTWARE\\Microsoft\\Microsoft SQL Server");
                var instances = (String[])rk.GetValue("InstalledInstances");

                if (instances.Length > 0)
                {
                    foreach (String element in instances)
                    {
                        if (element == "MSSQLSERVER")
                        {
                            //string khoa = "ZERO";
                            ////cbServer.Items.Add(System.Environment.MachineName);

                            //tenserver.Add(khoa, System.Environment.MachineName);
                            //cbServer.Items.Add(khoa);
                        }
                        else
                        {
                            if (element.CompareTo("SERVER1") == 0)
                            {
                                string khoa = "Công Nghệ Thông Tin";
                                tenserver.Add(khoa, System.Environment.MachineName + @"\" + element);
                                cbServer.Items.Add(khoa);
                            }
                            else if (element.CompareTo("SERVER2") == 0)
                            {
                                string khoa = "Viễn Thông";
                                tenserver.Add(khoa, System.Environment.MachineName + @"\" + element);
                                cbServer.Items.Add(khoa);
                            }
                        }
                    }
                }
                cbServer.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không load được server!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }




        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Program.mlogin = txtUsername.Text;
            Program.password = txtPassword.Text;
            Program.servername = tenserver[cbServer.Text];
            if (Program.KetNoi() == 0) return;

            String strLenh = "SELECT name  from sys.sysusers  where sid = SUSER_sID('" + Program.mlogin + "')";
            Program.myReader = Program.ExecSqlDataReader(strLenh, Program.connstr);
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
                return;
            }
            Program.myReader.Close();

            strLenh = "sp_helpuser '" + Program.username + "'";
            // sp này trả về các fields theo thứ tự:
            //Username Groupname    LoginName    DfDBName  UserID  SID

            try
            {
                Program.myReader = Program.ExecSqlDataReader(strLenh, Program.connstr);

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Mã nhân viên theo Login đăng nhập chưa có quyền truy cập.", "", MessageBoxButtons.OK);
                return;
            }

            // Lấy group name từ username
            if (Program.myReader.Read())
                Program.mGroup = Program.myReader.GetString(1);
            else
            {
                MessageBox.Show("Lỗi xác định quyền của user. ", "", MessageBoxButtons.OK);
                return;
            }

            Program.myReader.Close();

            // Lấy họ tên từ user name

            if (Program.mGroup.CompareTo("SV") == 0)
                strLenh = "Select HO + ' ' + TEN as Hoten From SINHVIEN Where MASV = " + "'" + Program.username + "'";
            else strLenh = "Select HO + ' ' + TEN as Hoten From GIANGVIEN Where MAGV = " + "'" + Program.username + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh, Program.connstr);
            if (Program.myReader.HasRows)
            {
                Program.myReader.Read();
                Program.mHoten = Program.myReader.GetString(0);
            }
            else
            {
                MessageBox.Show("Login bạn nhập chưa có liên kết với một nhân viên  ", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                Program.conn.Close();
                return;
            }

            Program.myReader.Close();
            Program.conn.Close();
            tennv = Program.mHoten;
            nhomnv = Program.mGroup;

            // Đăng nhập thành công sẽ chuyển đến form main
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
    }
    
}
