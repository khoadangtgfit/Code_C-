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
    public partial class Xoa : Form
    {
        public Xoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Hỏi Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a==DialogResult.Yes)
                DialogResult = DialogResult.OK;
        }
    }
}
