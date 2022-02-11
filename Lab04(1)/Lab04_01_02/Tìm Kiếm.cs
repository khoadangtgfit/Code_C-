using Lab04_01_02.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_01_02
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        StudentContextDB context = new StudentContextDB();
        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            List<Faculty> listFalcultys = context.Faculties.ToList();
            FillFalcultyCombobox(listFalcultys);
            cbbKhoa.SelectedIndex = -1;
        }
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cbbKhoa.DataSource = listFalcultys;
            this.cbbKhoa.DisplayMember = "FacultyName";
            this.cbbKhoa.ValueMember = "FacultyID";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            cbbKhoa.SelectedIndex = -1;
            dtgrview.Rows.Clear();
        }
        private void BindGrid(List<Student> listStudent)
        {

            dtgrview.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dtgrview.Rows.Add();
                dtgrview.Rows[index].Cells[0].Value = item.StudentID;
                dtgrview.Rows[index].Cells[1].Value = item.FullName;
                dtgrview.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dtgrview.Rows[index].Cells[3].Value = item.AvarageScore;
            }
        }
        private bool TimKiem(Student item)
        {
            bool flag = false;
            if (item.StudentID.ToString() == txtMaSV.Text && item.FullName.ToString() == txtHoTen.Text && item.Faculty.FacultyName.ToString() == cbbKhoa.Text)
            {
                flag = true;
            }
            else if(item.StudentID.ToString() == txtMaSV.Text && item.FullName.ToString() == txtHoTen.Text&& cbbKhoa.Text == "")
            {
                flag = true;
            }
            else if(item.FullName.ToString() == txtHoTen.Text && item.Faculty.FacultyName.ToString() == cbbKhoa.Text&& txtMaSV.Text == "")
            {
                flag = true;
            }
            else if(item.StudentID.ToString() == txtMaSV.Text && item.Faculty.FacultyName.ToString() == cbbKhoa.Text && txtHoTen.Text == "")
            {
                flag = true;
            }
            else if(item.StudentID.ToString() == txtMaSV.Text && txtHoTen.Text==""&&cbbKhoa.Text=="")
            {
                flag = true;
            }
            else if(txtMaSV.Text=="" && item.FullName.ToString() == txtHoTen.Text && cbbKhoa.Text == "")
            {
                flag = true;
            }
            else if (txtMaSV.Text=="" && txtHoTen.Text == "" && item.Faculty.FacultyName.ToString() == cbbKhoa.Text)
            {
                flag = true;
            }
            return flag;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            List<Student> listStudent = context.Students.ToList();
            List<Student> a = new List<Student>();
            foreach (Student item in listStudent)
            {
                if (TimKiem(item) == true)
                {
                    a.Add(item);
                }          
            }
            txtKetQuaTimKiem.Text = a.Count() + "";
            BindGrid(a);
            if (a.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
