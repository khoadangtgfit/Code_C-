using Lab04_04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_04
{
    public partial class Form1 : Form
    {
        //1911066165_DangPhuocKhoa_lab04
        public Form1()
        {
            InitializeComponent();
        }
        ProductContext productcontext = new ProductContext();
        private void setSTT(List<Invoice> listinvoice)
        {
            for (int i = 0; i < listinvoice.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (i + 1);
            }
        }
        private decimal TinhTien(string t)
        {
            List<Order> listorder = productcontext.Orders.ToList();
            decimal sum=0;
            foreach (var item in listorder)
            {
                if(item.InvoiceNo==t)
                    sum+= item.Price * item.Quantity;
            }
            return sum;
        }
        private void BindGrid(List<Invoice> listinvoice)
        {

            dataGridView1.Rows.Clear();
            foreach (var item in listinvoice)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[1].Value = item.InvoiceNo;
                dataGridView1.Rows[index].Cells[2].Value = item.OrderDate;
                dataGridView1.Rows[index].Cells[3].Value = item.DeliveryDate;
                dataGridView1.Rows[index].Cells[4].Value = TinhTien(item.InvoiceNo);
            }
            setSTT(listinvoice);
            txtTongCong.Text = (dataGridView1.Rows.Count-1)+"";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //addDL();
            List<Invoice> listinvoice = productcontext.Invoices.ToList();
            BindGrid(listinvoice);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Ngày đặt phải nhỏ hơn hoặc bằng ngày giao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                List<Invoice> listinvoice = productcontext.Invoices.ToList();
                List<Invoice> listinvoice1 = listinvoice.Where((p => p.DeliveryDate >= dateTimePicker1.Value.AddDays(-1) && p.DeliveryDate <= dateTimePicker2.Value)).ToList();
                BindGrid(listinvoice1);
            }
        }
        public static DateTime GetFirstDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        public static DateTime GetLastDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Ngày đặt phải nhỏ hơn hoặc bằng ngày giao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                List<Invoice> listinvoice = productcontext.Invoices.ToList();
                List<Invoice> listinvoice1 = listinvoice.Where((p => p.DeliveryDate >= dateTimePicker1.Value.AddDays(-1) && p.DeliveryDate <= dateTimePicker2.Value)).ToList();
                BindGrid(listinvoice1);
            }
        }
        private void addDL()
        {
            var invoice1 = new Invoice { InvoiceNo = "HDX006", OrderDate = new DateTime(2019, 10, 1), DeliveryDate = new DateTime(2021, 10, 20), Note = "Giao trễ trừ lương" };
            productcontext.Invoices.Add(invoice1);
            var order1 = new Order { InvoiceNo = "HDX006", No = 10, ProductID = "Product2", ProductName = "Thuốc", Unit = "Cái", Price = 10, Quantity = 10 };
            productcontext.Orders.Add(order1);
            productcontext.SaveChanges();

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkXemTrongThang.Checked == true)
            {
                List<Invoice> listinvoice = productcontext.Invoices.ToList();
                List<Invoice> listinvoice1 = listinvoice.Where(p => p.DeliveryDate >= GetFirstDayOfMonth(DateTime.Now.Month).AddDays(-1) && p.DeliveryDate <= GetLastDayOfMonth(DateTime.Now.Month)).ToList();
                BindGrid(listinvoice1);
            }
            else
            {
                List<Invoice> listinvoice = productcontext.Invoices.ToList();
                BindGrid(listinvoice);
            }
        }
    }
}
