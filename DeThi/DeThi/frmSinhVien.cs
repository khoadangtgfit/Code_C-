using DeThi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeThi
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        ClassContext context = new ClassContext();
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            List<SINHVIEN> liststudent = context.SINHVIENs.ToList();
            foreach(SINHVIEN item in liststudent)
            {

            }
        }
    }
}
