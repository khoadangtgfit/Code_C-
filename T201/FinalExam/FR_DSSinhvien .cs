using FinalExam.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class FR_DSSinhvien : Form
    {
        public FR_DSSinhvien()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        private void FR_DSSinhvien_Load(object sender, EventArgs e)
        {
            List<SINHVIEN> listsinhvien = context.SINHVIENs.ToList();
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", listsinhvien);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
