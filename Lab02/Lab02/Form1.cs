using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double kq = double.Parse(txtNumber1.Text) + double.Parse(txtNumber2.Text);
                txtAnswer.Text = kq+"";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Thông báo lỗi" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
               
            
            
        }
        
        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double kq = double.Parse(txtNumber1.Text) - double.Parse(txtNumber2.Text);
                txtAnswer.Text = kq + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double kq = double.Parse(txtNumber1.Text) * double.Parse(txtNumber2.Text);
                txtAnswer.Text = kq + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double kq = double.Parse(txtNumber1.Text) / double.Parse(txtNumber2.Text);
                txtAnswer.Text = kq + "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNumber2.Text = "";
            txtNumber1.Text = "";
            txtAnswer.Text = "";
            txtNumber1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
