using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageScore
{
    public partial class AverageScore : Form
    {
        public AverageScore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a=double.Parse(textBox1.Text);
            double b=double.Parse(textBox2.Text);
            textBox3.Text = averageScore(a, b)+"";
        }
        public static double averageScore(double a,double b)
        {
            double c = (a + b) / 2;
            return c;
        }
    }
}
