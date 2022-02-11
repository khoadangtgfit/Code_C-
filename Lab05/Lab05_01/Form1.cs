using Lab05_01.Model;
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

namespace Lab05_01
{
    public partial class Form1 : Form
    {
        ProductContext Context = new ProductContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Visible = false;
            rbSanPham.Checked = true;
            comboBox1.Enabled = false;
            this.reportViewer1.RefreshReport();
            List<Invoice> listInvoice = Context.Invoices.ToList();
            foreach (Invoice item in listInvoice)
            {
                comboBox1.Items.Add(item.InvoiceNo);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductContext context = new ProductContext();
            if (rbSanPham.Checked == true)
            {
                List<Product> listProduct = context.Products.ToList();
                this.reportViewer1.LocalReport.ReportPath = "ProductRP.rdlc";
                 var reportDataSource = new ReportDataSource("DataSet1", listProduct);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            else
            {
                Invoice invoice = context.Invoices.FirstOrDefault(p => p.InvoiceNo == comboBox1.Text);
                List<Order> listOrder = context.Orders.Where(p => p.InvoiceNo == comboBox1.Text).ToList();
                if (invoice == null || listOrder.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng");
                    return;
                }
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("invoiceNo", invoice.InvoiceNo);
                param[1] = new ReportParameter("DeliveryDateStr", string.Format("Ngày " + invoice.DeliveryDate.ToString("dd/MM/yyyy")));
                this.reportViewer1.LocalReport.ReportPath = "OrderRP.rdlc"; 
                this.reportViewer1.LocalReport.SetParameters(param);       
                var reportDataSource = new ReportDataSource("DataSet1", listOrder);      
                this.reportViewer1.LocalReport.DataSources.Clear();         
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);       
                this.reportViewer1.LocalReport.DisplayName = "Phi u giao hàng"; 
            }
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.Visible = true;

        }

        private void rbGiaoHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaoHang.Checked == true)
            {
                comboBox1.Enabled = true;
            }
        }

        private void rbSanPham_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSanPham.Checked == true)
            {
                comboBox1.Enabled = false;
            }
        }
    }
}
