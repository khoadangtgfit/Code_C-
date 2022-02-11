using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDlg.Color;
                richTextBox1.Font = fontDlg.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cboFonts.Items.Add(font.Name);
            }
            string[] a = { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };
            cbSize.Items.AddRange(a);
            richTextBox1.Font = new Font("Tahoma", richTextBox1.Font.Size);
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 14);
            cboFonts.Text = "Tahoma";
            cbSize.Text = 14 + "";
            lastSelectionFont = richTextBox1.SelectionFont;
            lastFont = richTextBox1.Font;

        }
        private void NewFile()
        {
            richTextBox1.Text = "";
            richTextBox1.Font = new Font("Tahoma", richTextBox1.Font.Size);
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 14);
            cboFonts.Text = "Tahoma";
            cbSize.Text = 14 + "";
            lblTenFile.Text="";
            RichTextBox box = new RichTextBox();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewFile();
        }
        public static string tenne = "";
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Luu();
        }
        private void Luu()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Rich Text File (*.rtf)|*.rtf|Plain Text File (*.txt)|*.txt";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.RestoreDirectory=true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                tenne = openFileDialog1.FileName.Trim().ToString();
                lblTenFile.Text = Path.GetFileName(saveFileDialog1.FileName);
                MessageBox.Show("Lưu thành công!");
            }
           


        }
        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Luu();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Rich Text File (*.rtf)|*.rtf|Plain Text File (*.txt)|*.txt";
            openFileDialog1.DefaultExt = "*.rtf";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = openFileDialog1.OpenFile();
                    StreamReader sr = new StreamReader(stream);
                    tenne = openFileDialog1.FileName.Trim().ToString();
                    lblTenFile.Text = Path.GetFileName(openFileDialog1.FileName);
                    if (Path.GetExtension(openFileDialog1.FileName) == ".rtf")
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                      
                        richTextBox1.Text= sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionFont.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style & ~FontStyle.Bold); 
            }else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style & ~FontStyle.Italic); 
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style | FontStyle.Italic); 
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style | FontStyle.Underline);
            }
        }

        private void cboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font Current = richTextBox1.SelectionFont; // Record current Font

            richTextBox1.SuspendLayout();
            Font lastFont = null;
            int selStart = richTextBox1.SelectionStart;
            int selEnd = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
            int currentStart = selStart;

            for (int i = selStart; i <= selEnd; i++)
            {
                richTextBox1.Select(i, 1); 
                lastFont = richTextBox1.SelectionFont; 
                {
                    Font newFont = new Font(this.cboFonts.Text, lastFont.Size, lastFont.Style);
                    richTextBox1.SelectionFont = newFont;
                }

            }

            
        }
        Font lastSelectionFont;
        Font lastFont;
        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSize.SelectedIndex !=-1)
            {
                lastSelectionFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,
                                        Convert.ToInt16(cbSize.Text));
            }
            else
            {
                lastFont = richTextBox1.Font;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily,
                                       Convert.ToInt16(cbSize.Text));
            }

        }
        
       
    }
}
