namespace CSDLPT
{
    partial class frmInDSSV
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLDSVDataSet = new CSDLPT.QLDSVDataSet();
            this.SP_LoadSV_1KhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_LoadSV_1KhoaTableAdapter = new CSDLPT.QLDSVDataSetTableAdapters.SP_LoadSV_1KhoaTableAdapter();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new CSDLPT.QLDSVDataSetTableAdapters.SINHVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LoadSV_1KhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_LoadSV_1KhoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSDLPT.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(32, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 277);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLDSVDataSet
            // 
            this.QLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.QLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_LoadSV_1KhoaBindingSource
            // 
            this.SP_LoadSV_1KhoaBindingSource.DataMember = "SP_LoadSV_1Khoa";
            this.SP_LoadSV_1KhoaBindingSource.DataSource = this.QLDSVDataSet;
            // 
            // SP_LoadSV_1KhoaTableAdapter
            // 
            this.SP_LoadSV_1KhoaTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.QLDSVDataSet;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmInDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 440);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInDSSV";
            this.Text = "frmInDSSV";
            this.Load += new System.EventHandler(this.frmInDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_LoadSV_1KhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_LoadSV_1KhoaBindingSource;
        private QLDSVDataSet QLDSVDataSet;
        private QLDSVDataSetTableAdapters.SP_LoadSV_1KhoaTableAdapter SP_LoadSV_1KhoaTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QLDSVDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
    }
}