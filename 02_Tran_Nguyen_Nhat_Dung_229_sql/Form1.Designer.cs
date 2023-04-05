
namespace _02_Tran_Nguyen_Nhat_Dung_229_sql
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
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtHoSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.chkPhai = new System.Windows.Forms.CheckBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHocBong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(143, 182);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(290, 28);
            this.txtNoiSinh.TabIndex = 3;
            // 
            // txtHoSV
            // 
            this.txtHoSV.Location = new System.Drawing.Point(143, 96);
            this.txtHoSV.Name = "txtHoSV";
            this.txtHoSV.Size = new System.Drawing.Size(429, 28);
            this.txtHoSV.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(143, 55);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(637, 28);
            this.txtMaSV.TabIndex = 0;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(594, 139);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(186, 28);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // chkPhai
            // 
            this.chkPhai.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPhai.Location = new System.Drawing.Point(29, 140);
            this.chkPhai.Name = "chkPhai";
            this.chkPhai.Size = new System.Drawing.Size(126, 36);
            this.chkPhai.TabIndex = 17;
            this.chkPhai.Text = "Phái";
            this.chkPhai.UseVisualStyleBackColor = true;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(594, 182);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(186, 29);
            this.cboMaKH.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Học Bỗng";
            // 
            // btnTruoc
            // 
            this.btnTruoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTruoc.Location = new System.Drawing.Point(29, 267);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(94, 34);
            this.btnTruoc.TabIndex = 8;
            this.btnTruoc.Text = "Trước";
            this.btnTruoc.UseVisualStyleBackColor = false;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Họ Tên SV";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(826, 52);
            this.label2.TabIndex = 23;
            this.label2.Text = "Quản Lý Sinh Viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã SV";
            // 
            // lblSTT
            // 
            this.lblSTT.Location = new System.Drawing.Point(141, 270);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(76, 28);
            this.lblSTT.TabIndex = 9;
            this.lblSTT.Text = "label1";
            this.lblSTT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(594, 96);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(186, 28);
            this.txtTenSV.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nơi Sinh";
            // 
            // txtHocBong
            // 
            this.txtHocBong.Location = new System.Drawing.Point(143, 223);
            this.txtHocBong.Name = "txtHocBong";
            this.txtHocBong.Size = new System.Drawing.Size(290, 28);
            this.txtHocBong.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tổng Điểm";
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(594, 223);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new System.Drawing.Size(186, 28);
            this.txtTongDiem.TabIndex = 7;
            // 
            // btnSau
            // 
            this.btnSau.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSau.Location = new System.Drawing.Point(235, 267);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(94, 34);
            this.btnSau.TabIndex = 10;
            this.btnSau.Text = "Sau";
            this.btnSau.UseVisualStyleBackColor = false;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Location = new System.Drawing.Point(347, 267);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 34);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHuy.Location = new System.Drawing.Point(459, 267);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 34);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKhong.Location = new System.Drawing.Point(683, 267);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(94, 34);
            this.btnKhong.TabIndex = 14;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGhi.Location = new System.Drawing.Point(571, 267);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(94, 34);
            this.btnGhi.TabIndex = 13;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Khoa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ngày Sinh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(826, 334);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtHocBong);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtHoSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkPhai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSTT);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtHoSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox chkPhai;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHocBong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

