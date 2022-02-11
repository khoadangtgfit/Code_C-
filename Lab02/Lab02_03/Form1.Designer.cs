
namespace Lab02_03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnGhe = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.ptnHuyBo = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(166, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Màn Ảnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnGhe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 283);
            this.panel2.TabIndex = 1;
            // 
            // pnGhe
            // 
            this.pnGhe.ColumnCount = 5;
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnGhe.Location = new System.Drawing.Point(100, 35);
            this.pnGhe.Name = "pnGhe";
            this.pnGhe.RowCount = 3;
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnGhe.Size = new System.Drawing.Size(380, 217);
            this.pnGhe.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành tiền:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnChon.Location = new System.Drawing.Point(67, 426);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(104, 47);
            this.btnChon.TabIndex = 4;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // ptnHuyBo
            // 
            this.ptnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ptnHuyBo.Location = new System.Drawing.Point(240, 426);
            this.ptnHuyBo.Name = "ptnHuyBo";
            this.ptnHuyBo.Size = new System.Drawing.Size(104, 47);
            this.ptnHuyBo.TabIndex = 4;
            this.ptnHuyBo.Text = "Hủy bỏ";
            this.ptnHuyBo.UseVisualStyleBackColor = false;
            this.ptnHuyBo.Click += new System.EventHandler(this.ptnHuyBo_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKetThuc.Location = new System.Drawing.Point(420, 426);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(104, 47);
            this.btnKetThuc.TabIndex = 4;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThanhTien.Location = new System.Drawing.Point(254, 373);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(241, 33);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(585, 507);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.ptnHuyBo);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel pnGhe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button ptnHuyBo;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label lblThanhTien;
    }
}

