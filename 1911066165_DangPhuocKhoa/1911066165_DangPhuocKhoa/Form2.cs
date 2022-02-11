using _1911066165_DangPhuocKhoa.Model;
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

namespace _1911066165_DangPhuocKhoa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportParameter[] param = new ReportParameter[2];
            List<NguoiDan> listnguoidan = context.NguoiDans.ToList();
            List<Class1> listclass1 = new List<Class1>();
            foreach (NguoiDan item in listnguoidan)
            {
                Class1 a = new Class1();
                a.CCCD = item.CCCD;
                a.HoTen = item.HoTen;
                a.XNLan1 = ((int)item.XNLan1 == 1) ? "PCR" : "Test nhanh";
                a.XNLan2 = ((int)item.XNLan2 == 1) ? "PCR" : "Test nhanh";
                a.KetQuaLan1 = item.KetQuaLan1;
                a.KetQuaLan2 = item.KetQuaLan2;
                listclass1.Add(a);
            }
            if (radioButton1.Checked == true)
            {
                List<Class1> listcl1 = new List<Class1>();
                foreach(Class1 item in listclass1)
                {
                    if(item.KetQuaLan1=="Dương tính"|| item.KetQuaLan2 == "Dương tính")
                    {
                        listcl1.Add(item);
                    }
                }
                this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
                param[0] = new ReportParameter("ReportParameter1", DateTime.Now.ToShortDateString());
                param[1] = new ReportParameter("ReportParameter2",listcl1.Count+"" );
                this.reportViewer1.LocalReport.SetParameters(param);
                var reportDataSource = new ReportDataSource("DataSet1", listcl1);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();

            }
            if(radioButton2.Checked == true)
            {
                List<Class1> listcl2 = new List<Class1>();
                foreach (Class1 item in listclass1)
                {
                    if (item.KetQuaLan1 !=null || item.KetQuaLan2 != null)
                    {
                        listcl2.Add(item);
                    }
                }
                param[0] = new ReportParameter("ReportParameter1", DateTime.Now.ToShortDateString());
                param[1] = new ReportParameter("ReportParameter2", listcl2.Count + "");
                this.reportViewer1.LocalReport.SetParameters(param);
                this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
                var reportDataSource = new ReportDataSource("DataSet1", listcl2);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
