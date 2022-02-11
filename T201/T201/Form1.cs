using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using T201.Model;

namespace T201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
            List<CONGTY> listcongty = context.CONGTies.ToList();
            BindGrid(listnhanvien);
            FillFalcultyCombobox(listcongty);
            groupBox2.Enabled = false;
        }
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
                dataGridView1.Rows[index].Cells[3].Value = (item.AmTinh==true)?"Âm Tính":"+";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!(int.TryParse(txtSLXN.Text,out int b)) || b < 0)
            {
                MessageBox.Show("Nhập SLXN lỗi rồi, vui lòng nhập lại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NHANVIEN db = context.NHANVIENs.FirstOrDefault(p => p.ID == txtcmnd.Text);
            CONGTY a = context.CONGTies.FirstOrDefault(p => p.TenCty == cbbCongTy.Text);
            var nhanvien = new NHANVIEN { ID = txtcmnd.Text, HoTen = txtHoTen.Text, SoLanXN = int.Parse(txtSLXN.Text), AmTinh = (rdbAmTinh.Checked == true) ? true : false, MaCty = a.MaCty };
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
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtcmnd.Text.Length != 9 && txtcmnd.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập CCCD hoặc CMND", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(int.TryParse(txtcmnd.Text,out int b) == false || b < 0)
            {
                MessageBox.Show("ID chỉ là các kí tự số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NHANVIEN db = context.NHANVIENs.FirstOrDefault(p => p.ID == txtcmnd.Text);
            if (db == null)
            {
                groupBox2.Enabled = true;
                txtHoTen.Text = "";
                rdbAmTinh.Checked = true;
                txtSLXN.Text = "1";
                cbbCongTy.SelectedIndex = 0;
            }
            else
            {
                groupBox2.Enabled = true;
                txtHoTen.Text = db.HoTen;
                txtSLXN.Text = (db.SoLanXN + 1) + "";
                if (db.AmTinh== true)
                {
                    rdbAmTinh.Checked = true;
                }
                else
                {
                    rdbDuongTinh.Checked = true;
                }
                cbbCongTy.Text = db.CONGTY.TenCty;
            }
        }

        private void danhSáchNVDươngTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> listnhanvien = context.NHANVIENs.ToList();
            List<NHANVIEN> listnvduongtinh = new List<NHANVIEN>();
            foreach(NHANVIEN item in listnhanvien)
            {
                if (item.AmTinh == false)
                {
                    listnvduongtinh.Add(item);
                }
            }
            BindGrid(listnvduongtinh);
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
        }
    }
}
