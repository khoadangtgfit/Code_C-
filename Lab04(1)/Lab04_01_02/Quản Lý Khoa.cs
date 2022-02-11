using Lab04_01_02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace Lab04_1
{
    public partial class frmQuanLyKhoa : Form
    {
        StudentContextDB context = new StudentContextDB();
        public frmQuanLyKhoa()
        {
            InitializeComponent();
        }
        private void BindGrid(List<Faculty>listfaculty)
        { 
            dtgviewKhoa.Rows.Clear(); 
            foreach (var item in listfaculty) 
            { 
                int index = dtgviewKhoa.Rows.Add();
                dtgviewKhoa.Rows[index].Cells[0].Value = item.FacultyID;
                dtgviewKhoa.Rows[index].Cells[1].Value = item.FacultyName;
                dtgviewKhoa.Rows[index].Cells[2].Value = item.TotalProfessor;
            }
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "" || txtTenKhoa.Text == "")
            {
                MessageBox.Show("Ôi bạn ơi, bạn phải nhập đầy đủ thông tin chứ!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            bool flag1 = int.TryParse(txtMaKhoa.Text, out int a);
            bool flag2 = int.TryParse(txtTongSoGS.Text, out int b);
            if (!flag1)
            {
                MessageBox.Show("Mã khoa phải nhập số nguyên!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Faculty db = context.Faculties.FirstOrDefault(p => p.FacultyID == a);
            var faculty = new Faculty { FacultyID = a, FacultyName = txtTenKhoa.Text, TotalProfessor = b };
            context.Faculties.AddOrUpdate(faculty);
            context.SaveChanges();
            List<Faculty> listFalcultys = context.Faculties.ToList();
            BindGrid(listFalcultys);
            if (db != null)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm thanh công !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void frmQuanLyKhoa_Load(object sender, EventArgs e)
        {
            List<Faculty> listFalcultys = context.Faculties.ToList();
            BindGrid(listFalcultys);
        }
        public int str;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhapIDCanxoa frm = new NhapIDCanxoa();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bool flag1 = int.TryParse(frm.txtID.Text, out int t);
                str = t;
            }
            Faculty db = context.Faculties.Where(p => p.FacultyID == str).SingleOrDefault();
            if (db != null)
            {
                context.Faculties.Remove(db);
                context.SaveChanges();
                List<Faculty> listFalcultys = context.Faculties.ToList();
                BindGrid(listFalcultys);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Sinh Viên có mã cần xóa trong danh sách vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dtgviewKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dtgviewKhoa.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTenKhoa.Text=dtgviewKhoa.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtTongSoGS.Text= dtgviewKhoa.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
