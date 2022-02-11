using Lab05_02.Model;
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

namespace Lab05_02
{
    public partial class Form1 : Form
    {
        ProductContext context = new ProductContext();
        public Form1()
        {
            InitializeComponent();
        }
        private decimal ThanhTien(string invoice)
        {
            decimal sum = 0;
            List<Order> listorder = context.Orders.ToList();
            foreach(Order item in listorder)
            {
                if (item.InvoiceNo == invoice)
                {
                    sum += item.Price * item.Quantity;
                }
            }
            return sum;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = false;
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                dateTimePicker2.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker3.Enabled = false;
                dateTimePicker4.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                dateTimePicker2.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker3.Enabled = true;
                dateTimePicker4.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Invoice> listinvoice = context.Invoices.ToList();
            List<Class1> listclass1 = new List<Class1>();
            foreach (Invoice item in listinvoice)
            {
                Class1 a = new Class1();
                a.InvoiceNo = item.InvoiceNo;
                a.DeliveryDate = item.DeliveryDate;
                a.ThanhTien = ThanhTien(item.InvoiceNo);
                listclass1.Add(a);
            }
            ReportParameter[] param = new ReportParameter[1];
            List<Class1> listresult = new List<Class1>();
            if (radioButton1.Checked == true)
            {
                listresult = listclass1.Where(p => p.DeliveryDate.ToString("dd/MM/yyyy") == dateTimePicker1.Value.ToString("dd/MM/yyyy")).ToList();
                param[0] = new ReportParameter("DeliveryDate1", string.Format("Ngày "+dateTimePicker1.Value.ToString("dd/MM/yyyy")));
            }
            if (radioButton2.Checked == true)
            {
                listresult = listclass1.Where(p => p.DeliveryDate.ToString("MM/yyyy") == dateTimePicker2.Value.ToString("MM/yyyy")).ToList();
                param[0] = new ReportParameter("DeliveryDate1", string.Format("Tháng " + dateTimePicker2.Value.ToString("MM/yyyy")));
            }
            if (radioButton3.Checked == true)
            {

                listresult = listclass1.Where(p => p.DeliveryDate >= dateTimePicker3.Value&&p.DeliveryDate<=dateTimePicker4.Value).ToList();
                param[0] = new ReportParameter("DeliveryDate1", string.Format(" Từ ngày " + dateTimePicker3.Value.ToString("dd/MM/yyyy")+" Đến"+ dateTimePicker4.Value.ToString("dd/MM/yyyy")));
            }
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", listresult);
            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
