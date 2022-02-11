
namespace Lab05_01
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbGiaoHang = new System.Windows.Forms.RadioButton();
            this.rbSanPham = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.rbGiaoHang);
            this.groupBox1.Controls.Add(this.rbSanPham);
            this.groupBox1.Location = new System.Drawing.Point(116, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // rbGiaoHang
            // 
            this.rbGiaoHang.AutoSize = true;
            this.rbGiaoHang.Location = new System.Drawing.Point(39, 49);
            this.rbGiaoHang.Name = "rbGiaoHang";
            this.rbGiaoHang.Size = new System.Drawing.Size(169, 21);
            this.rbGiaoHang.TabIndex = 0;
            this.rbGiaoHang.TabStop = true;
            this.rbGiaoHang.Text = "Xem Phiếu Giao Hàng";
            this.rbGiaoHang.UseVisualStyleBackColor = true;
            this.rbGiaoHang.CheckedChanged += new System.EventHandler(this.rbGiaoHang_CheckedChanged);
            // 
            // rbSanPham
            // 
            this.rbSanPham.AutoSize = true;
            this.rbSanPham.Location = new System.Drawing.Point(39, 22);
            this.rbSanPham.Name = "rbSanPham";
            this.rbSanPham.Size = new System.Drawing.Size(218, 21);
            this.rbSanPham.TabIndex = 0;
            this.rbSanPham.TabStop = true;
            this.rbSanPham.Text = "Xem Bảng Báo Giá Sản Phẩm";
            this.rbSanPham.UseVisualStyleBackColor = true;
            this.rbSanPham.CheckedChanged += new System.EventHandler(this.rbSanPham_CheckedChanged);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lab05_01.OrderRP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 173);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(958, 406);
            this.reportViewer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xuất Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(Lab05_01.Model.Order);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbGiaoHang;
        private System.Windows.Forms.RadioButton rbSanPham;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource OrderBindingSource;
    }
}

