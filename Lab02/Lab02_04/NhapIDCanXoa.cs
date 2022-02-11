using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_04
{
    public partial class NhapIDCanXoa : Form
    {
        public NhapIDCanXoa()
        {
            InitializeComponent();
        }
        public string idxoa;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
