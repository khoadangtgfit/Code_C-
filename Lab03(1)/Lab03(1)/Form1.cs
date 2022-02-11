using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        OpenFileDialog dlg = new OpenFileDialog();
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            dlg.Filter = "Mp3 files,mp4 files(*.mp3,*.mp4)|*.mp*";
            dlg.Multiselect = true;
            dlg.Title = "Open";
            if (dlg.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = dlg.FileName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây gi là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }
    }
}
