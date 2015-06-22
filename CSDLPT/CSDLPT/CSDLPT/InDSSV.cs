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
    public partial class InDSSV : Form
    {
        Dictionary<int, string> KhoaDict;

        public InDSSV()
        {
            KhoaDict = new Dictionary<int, string>();
            InitializeComponent();
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

        private void InDSSV_Load(object sender, EventArgs e)
        {
            loadKhoa();
            if (cbTenLop.SelectedIndex >= 0)
            {
                txtMaLop.Text = cbTenLop.SelectedValue.ToString();
            }
            this.reportViewer1.RefreshReport();
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
        }

        private void btManHinh_Click(object sender, EventArgs e)
        {
           
            string malop = txtMaLop.Text;

            this.SP_inDSSV_2KhoaTableAdapter.Fill(this.InDDSVDataSet.SP_inDSSV_2Khoa,malop.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
        }
    }
}
