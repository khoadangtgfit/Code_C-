
namespace T201
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSLXN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbAmTinh = new System.Windows.Forms.RadioButton();
            this.rdbDuongTinh = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCongTy = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNVDươngTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtcmnd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCCD/CMND";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(121, 25);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(129, 24);
            this.txtcmnd.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(259, 19);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(91, 30);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.cbbCongTy);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rdbDuongTinh);
            this.groupBox2.Controls.Add(this.rdbAmTinh);
            this.groupBox2.Controls.Add(this.txtSLXN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 342);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xét nghiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(101, 56);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 24);
            this.txtHoTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "SLXN";
            // 
            // txtSLXN
            // 
            this.txtSLXN.Location = new System.Drawing.Point(101, 93);
            this.txtSLXN.Name = "txtSLXN";
            this.txtSLXN.Size = new System.Drawing.Size(62, 24);
            this.txtSLXN.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "KQ";
            // 
            // rdbAmTinh
            // 
            this.rdbAmTinh.AutoSize = true;
            this.rdbAmTinh.Location = new System.Drawing.Point(101, 133);
            this.rdbAmTinh.Name = "rdbAmTinh";
            this.rdbAmTinh.Size = new System.Drawing.Size(83, 22);
            this.rdbAmTinh.TabIndex = 2;
            this.rdbAmTinh.TabStop = true;
            this.rdbAmTinh.Text = "Âm Tính";
            this.rdbAmTinh.UseVisualStyleBackColor = true;
            // 
            // rdbDuongTinh
            // 
            this.rdbDuongTinh.AutoSize = true;
            this.rdbDuongTinh.Location = new System.Drawing.Point(101, 160);
            this.rdbDuongTinh.Name = "rdbDuongTinh";
            this.rdbDuongTinh.Size = new System.Drawing.Size(105, 22);
            this.rdbDuongTinh.TabIndex = 2;
            this.rdbDuongTinh.TabStop = true;
            this.rdbDuongTinh.Text = "Dương Tính";
            this.rdbDuongTinh.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Công Ty";
            // 
            // cbbCongTy
            // 
            this.cbbCongTy.FormattingEnabled = true;
            this.cbbCongTy.Location = new System.Drawing.Point(101, 222);
            this.cbbCongTy.Name = "cbbCongTy";
            this.cbbCongTy.Size = new System.Drawing.Size(271, 26);
            this.cbbCongTy.TabIndex = 4;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(121, 279);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 33);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(410, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 428);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CCCD/CMND";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ và Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lần XN";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Kết Quả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNVDươngTínhToolStripMenuItem,
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem,
            this.xuấtBáoCáoToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // danhSáchNVDươngTínhToolStripMenuItem
            // 
            this.danhSáchNVDươngTínhToolStripMenuItem.Name = "danhSáchNVDươngTínhToolStripMenuItem";
            this.danhSáchNVDươngTínhToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.danhSáchNVDươngTínhToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.danhSáchNVDươngTínhToolStripMenuItem.Text = "Danh Sách NV Dương Tính";
            this.danhSáchNVDươngTínhToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNVDươngTínhToolStripMenuItem_Click);
            // 
            // danhSáchCtyĐãTestTheoYCToolStripMenuItem
            // 
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Name = "danhSáchCtyĐãTestTheoYCToolStripMenuItem";
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.danhSáchCtyĐãTestTheoYCToolStripMenuItem.Text = "Danh Sách Cty đã Test theo Y/C";
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất Báo Cáo";
            this.xuấtBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoCáoToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(336, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thông Tin Xét Nghiệm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 586);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản lý xét nghiệm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cbbCongTy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbDuongTinh;
        private System.Windows.Forms.RadioButton rdbAmTinh;
        private System.Windows.Forms.TextBox txtSLXN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNVDươngTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchCtyĐãTestTheoYCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.Label label6;
    }
}

