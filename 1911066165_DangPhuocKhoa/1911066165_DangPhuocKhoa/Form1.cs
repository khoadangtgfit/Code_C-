using _1911066165_DangPhuocKhoa.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911066165_DangPhuocKhoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void FillLoaiXN1()
        {
            cbbLoaiXN1.Items.Add("Chọn loại xét nghiệm");
            cbbLoaiXN1.Items.Add("PCR");
            cbbLoaiXN1.Items.Add("Test nhanh");
        }
        private void FillKQ1()
        {
            cbbKQ1.Items.Add("Lựa chọn kết quả");
            cbbKQ1.Items.Add("Âm tính");
            cbbKQ1.Items.Add("Dương tính");
        }
        private void FillLoaiXN2()
        {
            cbbLoaiXN2.Items.Add("Chọn loại xét nghiệm");
            cbbLoaiXN2.Items.Add("PCR");
            cbbLoaiXN2.Items.Add("Test nhanh");
        }
        private void FillKQ2()
        {
            cbbKQ2.Items.Add("Lựa chọn kết quả");
            cbbKQ2.Items.Add("Âm tính");
            cbbKQ2.Items.Add("Dương tính");
        }
        private void BindGrid(List<NguoiDan> listnguoidan)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listnguoidan)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.CCCD;
                dataGridView1.Rows[index].Cells[1].Value = item.HoTen;
                dataGridView1.Rows[index].Cells[2].Value = item.XNLan1;
                dataGridView1.Rows[index].Cells[3].Value = item.KetQuaLan1;
                dataGridView1.Rows[index].Cells[4].Value = item.XNLan2;
                dataGridView1.Rows[index].Cells[5].Value = item.KetQuaLan2;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<NguoiDan> listnguoidan = context.NguoiDans.ToList();
            List<XetNghiem> listxetnghiem = context.XetNghiems.ToList();
            FillLoaiXN1();
            FillKQ1();
            FillLoaiXN2();
            FillKQ2();
            BindGrid(listnguoidan);
            cbbKQ1.SelectedIndex = 0;
            cbbKQ2.SelectedIndex = 0;
            cbbLoaiXN1.SelectedIndex = 0;
            cbbLoaiXN2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text.Length != 9 && txtCMND.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập CCCD hoặc CMND", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(txtCMND.Text, out int b) == false || b < 0)
            {
                MessageBox.Show("ID chỉ là các kí tự số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NguoiDan db = context.NguoiDans.FirstOrDefault(p => p.CCCD == b);
            List<NguoiDan> list = new List<NguoiDan>();
            list.Add(db);
            BindGrid(list);
            if (db == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            else
            {
                txtHoTen.Text = db.HoTen;
                cbbLoaiXN1.SelectedIndex = (int)db.XNLan1;
                cbbKQ1.Text = db.KetQuaLan1;
                cbbLoaiXN2.SelectedIndex = (int)db.XNLan2;
                cbbKQ2.Text = db.KetQuaLan2;
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == ""||txtCMND.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbKQ1.SelectedIndex == 0 || cbbKQ2.SelectedIndex == 0 || cbbLoaiXN1.SelectedIndex == 0 || cbbLoaiXN2.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn đủ combobox", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int.TryParse(txtCMND.Text, out int b);
            NguoiDan db = context.NguoiDans.FirstOrDefault(p => p.CCCD == b);
            var nguoidan = new NguoiDan { CCCD = b, HoTen = txtHoTen.Text, XNLan1 = cbbLoaiXN1.SelectedIndex, KetQuaLan1 = cbbKQ1.Text, XNLan2 = cbbLoaiXN2.SelectedIndex, KetQuaLan2 = cbbKQ2.Text };
            context.NguoiDans.AddOrUpdate(nguoidan);
            context.SaveChanges();
            List<NguoiDan> listnguoidan = context.NguoiDans.ToList();
            BindGrid(listnguoidan);
            if (db != null)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm thanh công !", "Thông báo", MessageBoxButtons.OK);
            }
            txtCMND.Text = "";
            txtHoTen.Text = "";
            cbbKQ1.SelectedIndex = 0;
            cbbKQ2.SelectedIndex = 0;
            cbbLoaiXN1.SelectedIndex = 0;
            cbbLoaiXN2.SelectedIndex = 0;
        }

        private void thốngKêXétNghiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCMND.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbbLoaiXN1.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
            cbbKQ1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            cbbLoaiXN2.SelectedIndex = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            cbbKQ2.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }
    }
}
