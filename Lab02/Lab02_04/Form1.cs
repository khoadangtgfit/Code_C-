using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Lab02_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private int TimKiemID(string ID)
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == ID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void TinhTien()
        {
            double TongTien = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                TongTien += double.Parse(listView1.Items[i].SubItems[4].Text);
            }
            lblTongTien.Text = TongTien + "";
        }
        private void ThemDuLieu()
        {
            ListViewItem a = new ListViewItem((listView1.Items.Count+1).ToString());
            a.SubItems.Add(txtSoTaiKhoan.Text);
            a.SubItems.Add(txtTenKhachHang.Text);
            a.SubItems.Add(txtDiaChiKhachHang.Text);
            try {
                 double.Parse(txtSoTien.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiền nhập không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            a.SubItems.Add(txtSoTien.Text);
            listView1.Items.Add(a);
            TinhTien();
            CapNhatSTT();
        }
        private void UpdateDuLieu(int t)
        {
            listView1.Items[t].SubItems[2].Text = txtTenKhachHang.Text;
            listView1.Items[t].SubItems[3].Text = txtDiaChiKhachHang.Text;
            try
            {
                double.Parse(txtSoTien.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Số tiền nhập không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listView1.Items[t].SubItems[4].Text = txtSoTien.Text;
            TinhTien();
            CapNhatSTT();
        }
        private void CapNhatSTT()
        {
            for(int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[0].Text = (i + 1)+ "";
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool flag = false;
            errorProvider1.SetError(txtSoTaiKhoan, "");
            errorProvider1.SetError(txtTenKhachHang, "");
            errorProvider1.SetError(txtSoTien, "");
            errorProvider1.SetError(txtDiaChiKhachHang, "");
            if (txtSoTaiKhoan.Text == "")
            {
                errorProvider1.SetError(txtSoTaiKhoan, "Vui lòng nhập đủ thông tin!");
                flag = true;
            }
            if (txtTenKhachHang.Text == "")
            {
                errorProvider1.SetError(txtTenKhachHang, "Vui lòng nhập đủ thông tin!");
                flag = true;
            }
            if (txtDiaChiKhachHang.Text == "")
            {
                errorProvider1.SetError(txtDiaChiKhachHang, "Vui lòng nhập đủ thông tin!");
                flag = true;
            }
            if (txtSoTien.Text == "")
            {
                errorProvider1.SetError(txtSoTien, "Vui lòng nhập đủ thông tin!");
                flag = true;
            }
            if (flag == true) return;
            int index = TimKiemID(txtSoTaiKhoan.Text);
            if (index == -1)
            {
                int t = listView1.Items.Count;
                ThemDuLieu();
                MessageBox.Show("Thêm mới dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateDuLieu(index);
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public string MaCanTim;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhapIDCanXoa hm = new NhapIDCanXoa();
            if (hm.ShowDialog() == DialogResult.OK)
            {
                MaCanTim = hm.txtID.Text;
            }
            int index = TimKiemID(MaCanTim);
            if (index == -1)
            {
                MessageBox.Show("Không tìm thấy số tài khoản nhập vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else {
                listView1.Items.RemoveAt(index);
                TinhTien();
                CapNhatSTT();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                txtSoTaiKhoan.Text = lvi.SubItems[1].Text;
                txtTenKhachHang.Text = lvi.SubItems[2].Text;
                txtDiaChiKhachHang.Text = lvi.SubItems[3].Text;
                txtSoTien.Text = lvi.SubItems[4].Text;
            }
        }
    }
}
