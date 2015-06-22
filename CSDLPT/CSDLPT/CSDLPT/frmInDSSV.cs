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
    public partial class frmInDSSV : Form
    {
        public frmInDSSV()
        {
            InitializeComponent();
        }

        private void frmInDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDSVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter.Fill(this.QLDSVDataSet.SINHVIEN);
            string malop = "D09THA1";
            // TODO: This line of code loads data into the 'QLDSVDataSet.SP_LoadSV_1Khoa' table. You can move, or remove it, as needed.
//            this.SP_LoadSV_1KhoaTableAdapter.Fill(this.QLDSVDataSet.SP_LoadSV_1Khoa, malop.ToString());

            this.SP_LoadSV_1KhoaTableAdapter.Fill(this.QLDSVDataSet.SP_LoadSV_1Khoa, malop.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
