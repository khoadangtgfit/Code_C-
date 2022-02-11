using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void HienThiKhoaLenCombobox()
        {
            cboChuyenNganh.Items.Clear();
            cboChuyenNganh.Items.Add("QTKD");
            cboChuyenNganh.Items.Add("CNTT");
            cboChuyenNganh.Items.Add("NNA");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiKhoaLenCombobox();
            cboChuyenNganh.SelectedIndex = 0;
            rbNu.Checked = true;
        }
        private void ThemDuLieu(int t)
        {
            dataGridView1[0, t].Value = txtMaSV.Text;
            dataGridView1[1, t].Value = txtHoTen.Text;
            dataGridView1[3, t].Value = float.Parse(txtDiemTB.Text).ToString();
            dataGridView1[4, t].Value = (cboChuyenNganh.Text=="QTKD"?"Quản Trị Kinh Doanh": cboChuyenNganh.Text == "CNTT"?"Công Nghệ Thông Tin":"Ngôn Ngữ Anh");
            dataGridView1[2, t].Value = rbNu.Checked ? "Nữ" : "Nam";
            
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[0,i].Value?.ToString()== studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            bool flag = false;
            errorProvider1.SetError(txtMaSV, "");
            errorProvider1.SetError(txtDiemTB, "");
            errorProvider1.SetError(txtHoTen, "");
            if (txtMaSV.Text == "" )
            {
                errorProvider1.SetError(txtMaSV,"Vui lòng nhập đủ thông tin");
                flag = true;
            }
            if(txtDiemTB.Text == "")
            {
                errorProvider1.SetError(txtDiemTB, "Vui lòng nhập đủ thông tin");
                flag = true;
            }
            if (txtHoTen.Text=="")
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập đủ thông tin");
                flag = true;
            }
            if (flag == true) return;
            int selectedRow = GetSelectedRow(txtMaSV.Text);
            if (selectedRow == -1)
            {
                selectedRow= dataGridView1.Rows.Add();
                ThemDuLieu(selectedRow);
                Dem();
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                ThemDuLieu(selectedRow);
                Dem();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void Dem()
        {
            int demnam = 0;
            int demnu = 0;
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                if (dataGridView1.Rows[i].Cells[2].Value?.ToString() == "Nữ")
                {
                    demnu++;
                }
                else
                {
                    demnam++;
                }
            }
            txtNam.Text = demnam.ToString();
            txtNu.Text = demnu.ToString();
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            Dem();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtMaSV.Text = dataGridView1[0, rowIndex].Value.ToString();
            txtHoTen.Text = dataGridView1[1, rowIndex].Value.ToString();
            if (dataGridView1[2, rowIndex].Value == "Nữ")
            {
                rbNu.Checked = true;
            }
            else
            {
                rbNam.Checked = true;
            }
            txtMaSV.Text = dataGridView1[3, rowIndex].Value.ToString();
            if(dataGridView1[4, rowIndex].Value== "Quản Trị Kinh Doanh")
            {
                cboChuyenNganh.SelectedIndex = 0;
            }
            else if(dataGridView1[4, rowIndex].Value == "Công Nghệ Thông Tin")
            {
                cboChuyenNganh.SelectedIndex = 1;
            }
            else
            {
                cboChuyenNganh.SelectedIndex = 2;
            }
        }
    }
}
