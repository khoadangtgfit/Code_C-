using FinalExam.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        ModelContext context = new ModelContext();
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            List<SINHVIEN> listsinhvien = context.SINHVIENs.ToList();
            List<LOP> listlop = context.LOPs.ToList();
            BindGrid(listsinhvien);
            FillFalcultyCombobox(listlop);
        }
        private void FillFalcultyCombobox(List<LOP> listlop)
        {
            this.cbbLopHoc.DataSource = listlop;
            this.cbbLopHoc.DisplayMember = "TENLOP";
            this.cbbLopHoc.ValueMember = "TENLOP";
        }
        private void BindGrid(List<SINHVIEN> listsinhvien)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listsinhvien)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MASV;
                dataGridView1.Rows[index].Cells[1].Value = item.HOTENSV;
                dataGridView1.Rows[index].Cells[2].Value = item.NGAYSINH;
                dataGridView1.Rows[index].Cells[3].Value = item.LOP.TENLOP;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (e.RowIndex == -1) return;
            DataGridViewRow row=dataGridView1.Rows[e.RowIndex];
            
                txtMa.Text = row.Cells[0].Value+"";
                txtTen.Text = row.Cells[1].Value + "";
                DateTime dt = Convert.ToDateTime(row.Cells[2].Value + "");
                dateTimePicker1.Value = dt;
                cbbLopHoc.Text = row.Cells[3].Value + "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                SINHVIEN db = context.SINHVIENs.FirstOrDefault(p => p.MASV == txtMa.Text);
                LOP lop= context.LOPs.FirstOrDefault(p => p.TENLOP == cbbLopHoc.Text);
            var sinhvien = new SINHVIEN { MASV = txtMa.Text, HOTENSV = txtTen.Text, 
                    NGAYSINH =dateTimePicker1.Text, MALOP = lop.MALOP};
                context.SINHVIENs.AddOrUpdate(sinhvien);
            context.SaveChanges();
            List<SINHVIEN> listsinhvien = context.SINHVIENs.ToList();
                BindGrid(listsinhvien);
                if (db != null)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Thêm thanh công !", "Thông báo", MessageBoxButtons.OK);
                }
            
        }
        
        public string MaCanTim;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa hm = new Xoa();
            if (hm.ShowDialog() == DialogResult.OK)
            {
                MaCanTim = hm.txtID.Text;
            }
            SINHVIEN db = context.SINHVIENs.FirstOrDefault(p => p.MASV == MaCanTim);
            if (db == null)
            {
                MessageBox.Show("Không tìm thấy mã sinh viên nhập vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                context.SINHVIENs.Remove(db); 
                context.SaveChanges();
                List<SINHVIEN> listsinhvien = context.SINHVIENs.ToList();
                BindGrid(listsinhvien);
                txtMa.Text = "";
                txtTen.Text = "";
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
