using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiGheLenGiaoDien();
        }
        int ghe = 1;
        private void HienThiGheLenGiaoDien()
        {
            pnGhe.Controls.Clear();
            for (int i = 0; i < pnGhe.RowCount; i++)
            {
                for (int j = 0; j < pnGhe.ColumnCount; j++)
                {
                    Label lblghe = new Label();
                    lblghe.Text = ghe + "";
                    pnGhe.Controls.Add(lblghe, j, i);
                    ghe++;
                    lblghe.AutoSize = false;
                    lblghe.Dock = DockStyle.Fill;
                    lblghe.BackColor = Color.White;
                    lblghe.Width = lblghe.Width = 50;
                    lblghe.TextAlign = ContentAlignment.MiddleCenter;
                    lblghe.Click += lblghe_Click;
                }
            }
                
        }

        private void lblghe_Click(object sender, EventArgs e)
        {
            Label lblGhe = sender as Label;
            if (lblGhe.BackColor == Color.White)
                lblGhe.BackColor = Color.Blue;
            else if (lblGhe.BackColor == Color.Blue)
                lblGhe.BackColor = Color.White;
            else if (lblGhe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vị trí này đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int dem1=0, dem2=0, dem3 = 0;
            for(int i = 0; i < pnGhe.Controls.Count; i++)
            {
                Label lblghe = pnGhe.Controls[i] as Label;
                if (lblghe.BackColor == Color.Blue)
                {
                    lblghe.BackColor = Color.Yellow;
                }
                if (lblghe.BackColor == Color.Yellow && i < 5)
                {
                    dem1++;
                }
                if (lblghe.BackColor == Color.Yellow && (i>=5&&i < 10))
                {
                    dem2++;
                }
                if (lblghe.BackColor == Color.Yellow && (i>=10 &&i < 15))
                {
                    dem3++;
                }
            }
            lblThanhTien.Text = dem1 * 8000 + dem2 * 6500 + dem3 * 5000 + " VND";
        }

        private void ptnHuyBo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pnGhe.Controls.Count; i++)
            {
                Label lblghe = pnGhe.Controls[i] as Label;
                if (lblghe.BackColor == Color.Blue)
                {
                    lblghe.BackColor = Color.White;
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult a=MessageBox.Show("Bạn có thực sự muốn kết thúc?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
