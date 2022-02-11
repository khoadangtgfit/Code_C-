
namespace T201_1_
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtSLXN = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.rbDuongTinh = new System.Windows.Forms.RadioButton();
            this.rbAmTinh = new System.Windows.Forms.RadioButton();
            this.cbbCongTy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSáchNVDươngTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNVDươngTínhToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchCtyĐãTestYCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(369, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Xét Nghiệm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(125, 52);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(173, 24);
            this.txtCMND.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "CCCD/CMND";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.txtSLXN);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.rbDuongTinh);
            this.groupBox2.Controls.Add(this.rbAmTinh);
            this.groupBox2.Controls.Add(this.cbbCongTy);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xét nghiệm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(168, 286);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 33);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtSLXN
            // 
            this.txtSLXN.Location = new System.Drawing.Point(125, 88);
            this.txtSLXN.Name = "txtSLXN";
            this.txtSLXN.Size = new System.Drawing.Size(67, 24);
            this.txtSLXN.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(125, 45);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(233, 24);
            this.txtHoTen.TabIndex = 3;
            // 
            // rbDuongTinh
            // 
            this.rbDuongTinh.AutoSize = true;
            this.rbDuongTinh.Location = new System.Drawing.Point(145, 167);
            this.rbDuongTinh.Name = "rbDuongTinh";
            this.rbDuongTinh.Size = new System.Drawing.Size(100, 22);
            this.rbDuongTinh.TabIndex = 2;
            this.rbDuongTinh.TabStop = true;
            this.rbDuongTinh.Text = "Dương tính";
            this.rbDuongTinh.UseVisualStyleBackColor = true;
            // 
            // rbAmTinh
            // 
            this.rbAmTinh.AutoSize = true;
            this.rbAmTinh.Location = new System.Drawing.Point(145, 139);
            this.rbAmTinh.Name = "rbAmTinh";
            this.rbAmTinh.Size = new System.Drawing.Size(78, 22);
            this.rbAmTinh.TabIndex = 2;
            this.rbAmTinh.TabStop = true;
            this.rbAmTinh.Text = "Âm tính";
            this.rbAmTinh.UseVisualStyleBackColor = true;
            // 
            // cbbCongTy
            // 
            this.cbbCongTy.FormattingEnabled = true;
            this.cbbCongTy.Location = new System.Drawing.Point(125, 219);
            this.cbbCongTy.Name = "cbbCongTy";
            this.cbbCongTy.Size = new System.Drawing.Size(233, 26);
            this.cbbCongTy.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Công ty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "KQ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "SLXN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(450, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 480);
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
            this.Column2.HeaderText = "Họ Và Tên";
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNVDươngTínhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchNVDươngTínhToolStripMenuItem
            // 
            this.danhSáchNVDươngTínhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNVDươngTínhToolStripMenuItem1,
            this.danhSáchCtyĐãTestYCToolStripMenuItem,
            this.xuấtBáoToolStripMenuItem});
            this.danhSáchNVDươngTínhToolStripMenuItem.Name = "danhSáchNVDươngTínhToolStripMenuItem";
            this.danhSáchNVDươngTínhToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.danhSáchNVDươngTínhToolStripMenuItem.Text = "Chức Năng";
            // 
            // danhSáchNVDươngTínhToolStripMenuItem1
            // 
            this.danhSáchNVDươngTínhToolStripMenuItem1.Name = "danhSáchNVDươngTínhToolStripMenuItem1";
            this.danhSáchNVDươngTínhToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.danhSáchNVDươngTínhToolStripMenuItem1.Size = new System.Drawing.Size(292, 26);
            this.danhSáchNVDươngTínhToolStripMenuItem1.Text = "Danh Sách NV Dương Tính";
            this.danhSáchNVDươngTínhToolStripMenuItem1.Click += new System.EventHandler(this.danhSáchNVDươngTínhToolStripMenuItem1_Click);
            // 
            // danhSáchCtyĐãTestYCToolStripMenuItem
            // 
            this.danhSáchCtyĐãTestYCToolStripMenuItem.Name = "danhSáchCtyĐãTestYCToolStripMenuItem";
            this.danhSáchCtyĐãTestYCToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.danhSáchCtyĐãTestYCToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.danhSáchCtyĐãTestYCToolStripMenuItem.Text = "Danh Sách Cty đã Test Y/C";
            this.danhSáchCtyĐãTestYCToolStripMenuItem.Click += new System.EventHandler(this.danhSáchCtyĐãTestYCToolStripMenuItem_Click);
            // 
            // xuấtBáoToolStripMenuItem
            // 
            this.xuấtBáoToolStripMenuItem.Name = "xuấtBáoToolStripMenuItem";
            this.xuấtBáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.xuấtBáoToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.xuấtBáoToolStripMenuItem.Text = "Xuất Báo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 591);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtSLXN;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton rbDuongTinh;
        private System.Windows.Forms.RadioButton rbAmTinh;
        private System.Windows.Forms.ComboBox cbbCongTy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNVDươngTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNVDươngTínhToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchCtyĐãTestYCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoToolStripMenuItem;
    }
}

