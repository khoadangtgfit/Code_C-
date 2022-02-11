using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Lab04_01_02.Models;
using Lab04_01_02;

namespace Lab04_1
{
    public partial class Form1 : Form
    {
        //1911066165_DangPhuocKhoa_lab04
        public Form1()
        {
            InitializeComponent();
        }
        StudentContextDB context = new StudentContextDB();
        #region method
        private List<Student> LaySinhVien()
        {
            return context.Students.ToList();
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalcultys = context.Faculties.ToList();
                List<Student> listStudent = context.Students.ToList();
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {

            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cbbKhoa.DataSource = listFalcultys;
            this.cbbKhoa.DisplayMember = "FacultyName";
            this.cbbKhoa.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {

            dataGridView1.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[index].Cells[1].Value = item.FullName;
                dataGridView1.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dataGridView1.Rows[index].Cells[3].Value = item.AvarageScore;
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtDiemTB.Text == "" || txtHoTen.Text == "" || txtMaSo.Text == "")
            {
                MessageBox.Show("Ôi bạn ơi, bạn phải nhập đầy đủ thông tin chứ!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMaSo.Text.ToString().Length != 10)
            {
                MessageBox.Show("Ôi bạn ơi, mã số phải có độ dài bằng 10!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            bool flag1 = double.TryParse(txtDiemTB.Text, out double a);
            if (!flag1)
            {
                MessageBox.Show("Ôi bạn ơi, điểm trung bình bạn phải nhập số chứ!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            int t = (cbbKhoa.Text == "Công Nghệ Thông Tin") ? 1 : (cbbKhoa.Text == "Ngôn Ngữ Anh") ? 2 : 3;
            Student db = context.Students.FirstOrDefault(p => p.StudentID == txtMaSo.Text);
            var student = new Student { StudentID = txtMaSo.Text, FullName = txtHoTen.Text, FacultyID = t, AvarageScore = a };
            context.Students.AddOrUpdate(student);
            context.SaveChanges();
            BindGrid(LaySinhVien());
            if (db != null)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm thanh công !", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public string str;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhapIDCanxoa frm = new NhapIDCanxoa();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                str = frm.txtID.Text;
            }
            Student db = context.Students.FirstOrDefault(p => p.StudentID == str);
            if (db != null)
            {
                context.Students.Remove(db);
                context.SaveChanges();
                BindGrid(LaySinhVien());
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Sinh Viên có mã cần xóa trong danh sách vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn thoát", "Hỏi thoát", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dataGridView1.Rows[e.RowIndex];
            txtMaSo.Text = a.Cells[0].Value+"";
            txtHoTen.Text = a.Cells[1].Value + "";
            cbbKhoa.SelectedIndex = (a.Cells[2].Value+""=="1") ? 0 : (a.Cells[2].Value+""=="2")?1:2;
            txtDiemTB.Text = a.Cells[3].Value + "";
        }

        

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoa a = new frmQuanLyKhoa();
            a.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem a = new frmTimKiem();
            a.ShowDialog();
        }
    }
}
