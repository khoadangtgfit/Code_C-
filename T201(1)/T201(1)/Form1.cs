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
using T201_1_.Model;

namespace T201_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        private void FillFalcultyCombobox(List<CONGTY> listcongty)
        {
            this.cbbCongTy.DataSource = listcongty;
            this.cbbCongTy.DisplayMember = "TenCty";
            this.cbbCongTy.ValueMember = "TenCty";
        }
        private void BindGrid(List<NHANVIEN> listnhanvien)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listnhanvien)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.ID;
                dataGridView1.Rows[index].Cells[1].Value = item.HoTen;
                dataGridView1.Rows[index].Cells[2].Value = item.SoLanXN;
                dataGridView1.Rows[index].Cells[3].Value = (item.AmTinh == true) ? "Âm Tính" : "+";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
            List<CONGTY> listcongty = context.CONGTies.ToList();
            FillFalcultyCombobox(listcongty);
            BindGrid(listnhanvien);
            txtHoTen.Text = "";
            txtSLXN.Text = 1 + "";
            rbAmTinh.Checked = true;
            groupBox2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text.Length != 9 && txtCMND.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập CCCD hoặc CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NHANVIEN db = context.NHANVIENs.FirstOrDefault(p => p.ID == txtCMND.Text);
            if (db == null)
            {
                txtHoTen.Text = "";
                txtSLXN.Text = 1 + "";
                rbAmTinh.Checked = true;
                cbbCongTy.SelectedIndex = 0;
                groupBox2.Enabled = true;
            }
            else
            {
                txtHoTen.Text = db.HoTen;
                txtSLXN.Text = (db.SoLanXN + 1) + "";
                if (db.AmTinh == true)
                {
                    rbAmTinh.Checked = true;
                }
                else
                {
                    rbDuongTinh.Checked = true;
                }
                
                CONGTY t = context.CONGTies.FirstOrDefault(p => p.MaCty == db.MaCty);
                cbbCongTy.Text = t.TenCty;
                groupBox2.Enabled = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(int.TryParse(txtSLXN.Text, out int b)) || b < 0)
            {
                MessageBox.Show("Nhập SLXN lỗi rồi, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NHANVIEN db = context.NHANVIENs.FirstOrDefault(p => p.ID == txtCMND.Text);
            CONGTY a = context.CONGTies.FirstOrDefault(p => p.TenCty == cbbCongTy.Text);
            var nhanvien = new NHANVIEN { ID = txtCMND.Text, HoTen = txtHoTen.Text, SoLanXN = int.Parse(txtSLXN.Text), AmTinh = (rbAmTinh.Checked == true) ? true : false, MaCty = a.MaCty };
            context.NHANVIENs.AddOrUpdate(nhanvien);
            context.SaveChanges();
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
            BindGrid(listnhanvien);
            if (db != null)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm thanh công !", "Thông báo", MessageBoxButtons.OK);
            }
            txtHoTen.Text = "";
            txtSLXN.Text = 1 + "";
            rbAmTinh.Checked = true;
            groupBox2.Enabled = false;
        }

        private void danhSáchNVDươngTínhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
            List<NHANVIEN> listnhanvien1 = new List<NHANVIEN>();
            foreach(NHANVIEN item in listnhanvien)
            {
                if (!item.AmTinh)
                {
                    listnhanvien1.Add(item);
                }
            }
            BindGrid(listnhanvien1);
        }
        private int DemSoNVDaTest(CONGTY a)
        {
            int dem = 0;
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
            foreach (NHANVIEN item in listnhanvien)
            {
                if (item.MaCty == a.MaCty)
                {
                    dem++;
                }
            }
            return dem;
        }
        private void danhSáchCtyĐãTestYCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = "Các công ty đã test đủ yêu cầu: ";
            int dem = 0;
            bool flag = false;
            List<CONGTY> listcongty = context.CONGTies.ToList();
            foreach(CONGTY item in listcongty)
            {
                if (DemSoNVDaTest(item) >= item.SLNV)
                {
                    a += "\n" + (++dem)+item.TenCty;
                    flag = true;
                }
            }
            if (!flag)
            {
                a += "\n-Không có Công Ty nào đủ yc";
            }
            MessageBox.Show(a, "Thông báo", MessageBoxButtons.OK);
            a = "";

        }
    }
}
