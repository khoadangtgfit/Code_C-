using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuDoc.Width == 175)
            {
                MenuDoc.Width = 70;
            }
            else
            {
                MenuDoc.Width = 175;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMin.Visible = true;
            btnMax.Visible = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMin.Visible = false;
            btnMax.Visible = true;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Button a = new Button();
            a.Text = "khoa";
            a.Width = a.Height = 50;
        }
    }
}
