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
using T201.Model;

namespace T201
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        private void FillFalcultyCombobox(List<CONGTY> listcongty)
        {
            this.cbbCongTy.DataSource = listcongty;
            this.cbbCongTy.DisplayMember = "TenCty";
            this.cbbCongTy.ValueMember = "TenCty";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            List<CONGTY> listcongty = context.CONGTies.ToList();
            FillFalcultyCombobox(listcongty);
            this.reportViewer1.RefreshReport();
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            CONGTY a = context.CONGTies.FirstOrDefault(p => p.TenCty == cbbCongTy.Text);
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
            List<Class1> listclass1 = new List<Class1>();
            foreach(NHANVIEN item in listnhanvien)
            {
                if (item.CONGTY.TenCty == cbbCongTy.Text)
                {
                    Class1 class1 = new Class1();
                    class1.ID = item.ID;
                    class1.HoTen = item.HoTen;
                    class1.KetQua = (item.AmTinh == true) ? "Âm Tính" : "Dương Tính";
                    listclass1.Add(class1);
                }
            }
            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("ReportParameter1", cbbCongTy.Text);
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            this.reportViewer1.LocalReport.SetParameters(param);
            var reportDataSource = new ReportDataSource("DataSet1", listclass1);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
