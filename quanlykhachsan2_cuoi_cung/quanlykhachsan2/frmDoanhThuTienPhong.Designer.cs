﻿namespace quanlykhachsan2
{
    partial class frmDoanhThuTienPhong
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
            this.lblNgayDau = new System.Windows.Forms.Label();
            this.lblNgayCuoi = new System.Windows.Forms.Label();
            this.dtpNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDau = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoanhThuTienPhong = new System.Windows.Forms.Label();
            this.txtTongDoanhThuTienPhong = new System.Windows.Forms.TextBox();
            this.dgvDoanhThuTienPhong = new System.Windows.Forms.DataGridView();
            this.dtcMaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTinh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuTienPhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNgayDau
            // 
            this.lblNgayDau.AutoSize = true;
            this.lblNgayDau.Location = new System.Drawing.Point(21, 27);
            this.lblNgayDau.Name = "lblNgayDau";
            this.lblNgayDau.Size = new System.Drawing.Size(58, 14);
            this.lblNgayDau.TabIndex = 24;
            this.lblNgayDau.Text = "Ngày Đầu ";
            // 
            // lblNgayCuoi
            // 
            this.lblNgayCuoi.AutoSize = true;
            this.lblNgayCuoi.Location = new System.Drawing.Point(21, 97);
            this.lblNgayCuoi.Name = "lblNgayCuoi";
            this.lblNgayCuoi.Size = new System.Drawing.Size(56, 14);
            this.lblNgayCuoi.TabIndex = 25;
            this.lblNgayCuoi.Text = "Ngày Cuối";
            // 
            // dtpNgayCuoi
            // 
            this.dtpNgayCuoi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayCuoi.Location = new System.Drawing.Point(165, 97);
            this.dtpNgayCuoi.Name = "dtpNgayCuoi";
            this.dtpNgayCuoi.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayCuoi.TabIndex = 73;
            // 
            // dtpNgayDau
            // 
            this.dtpNgayDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDau.Location = new System.Drawing.Point(165, 27);
            this.dtpNgayDau.Name = "dtpNgayDau";
            this.dtpNgayDau.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDau.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(542, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Chi Tiết Hóa Đơn Tiền Phòng Đã Thu Tiền";
            // 
            // lblDoanhThuTienPhong
            // 
            this.lblDoanhThuTienPhong.AutoSize = true;
            this.lblDoanhThuTienPhong.Location = new System.Drawing.Point(3, 170);
            this.lblDoanhThuTienPhong.Name = "lblDoanhThuTienPhong";
            this.lblDoanhThuTienPhong.Size = new System.Drawing.Size(142, 14);
            this.lblDoanhThuTienPhong.TabIndex = 76;
            this.lblDoanhThuTienPhong.Text = "Tổng Doanh Thu Tiền Phòng";
            // 
            // txtTongDoanhThuTienPhong
            // 
            this.txtTongDoanhThuTienPhong.Location = new System.Drawing.Point(165, 167);
            this.txtTongDoanhThuTienPhong.Name = "txtTongDoanhThuTienPhong";
            this.txtTongDoanhThuTienPhong.Size = new System.Drawing.Size(164, 20);
            this.txtTongDoanhThuTienPhong.TabIndex = 77;
            // 
            // dgvDoanhThuTienPhong
            // 
            this.dgvDoanhThuTienPhong.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvDoanhThuTienPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuTienPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaCTHD,
            this.dtcMaPT,
            this.dtcSoPhong,
            this.dtcNgayDen,
            this.dtcNgayDi,
            this.dtcTienPhong});
            this.dgvDoanhThuTienPhong.Location = new System.Drawing.Point(345, 58);
            this.dgvDoanhThuTienPhong.Name = "dgvDoanhThuTienPhong";
            this.dgvDoanhThuTienPhong.Size = new System.Drawing.Size(651, 420);
            this.dgvDoanhThuTienPhong.TabIndex = 78;
            // 
            // dtcMaCTHD
            // 
            this.dtcMaCTHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaCTHD.DataPropertyName = "MaCTHD";
            this.dtcMaCTHD.HeaderText = "Mã Chi Tiết Hóa Đơn";
            this.dtcMaCTHD.Name = "dtcMaCTHD";
            // 
            // dtcMaPT
            // 
            this.dtcMaPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaPT.DataPropertyName = "MaPT";
            this.dtcMaPT.HeaderText = "Mã Phiếu Thuê";
            this.dtcMaPT.Name = "dtcMaPT";
            // 
            // dtcSoPhong
            // 
            this.dtcSoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtcSoPhong.DataPropertyName = "SoPhong";
            this.dtcSoPhong.HeaderText = "Số Phòng";
            this.dtcSoPhong.Name = "dtcSoPhong";
            this.dtcSoPhong.Width = 72;
            // 
            // dtcNgayDen
            // 
            this.dtcNgayDen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgayDen.DataPropertyName = "NgayDen";
            this.dtcNgayDen.HeaderText = "Ngày Đến ";
            this.dtcNgayDen.Name = "dtcNgayDen";
            // 
            // dtcNgayDi
            // 
            this.dtcNgayDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgayDi.DataPropertyName = "NgayDi";
            this.dtcNgayDi.HeaderText = "Ngày Đi";
            this.dtcNgayDi.Name = "dtcNgayDi";
            // 
            // dtcTienPhong
            // 
            this.dtcTienPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTienPhong.DataPropertyName = "TienPhong";
            this.dtcTienPhong.HeaderText = "Tiền Phòng";
            this.dtcTienPhong.Name = "dtcTienPhong";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTinh);
            this.panel1.Controls.Add(this.lblNgayDau);
            this.panel1.Controls.Add(this.dtpNgayDau);
            this.panel1.Controls.Add(this.lblDoanhThuTienPhong);
            this.panel1.Controls.Add(this.txtTongDoanhThuTienPhong);
            this.panel1.Controls.Add(this.lblNgayCuoi);
            this.panel1.Controls.Add(this.dtpNgayCuoi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 530);
            this.panel1.TabIndex = 79;
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.Yellow;
            this.btnTinh.Location = new System.Drawing.Point(112, 278);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 38);
            this.btnTinh.TabIndex = 79;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(342, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 54);
            this.panel2.TabIndex = 80;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(286, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 54);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDoanhThuTienPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(996, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDoanhThuTienPhong);
            this.Controls.Add(this.label1);
            this.Name = "frmDoanhThuTienPhong";
            this.Text = "Doanh Thu Tiền Phòng";
            this.Load += new System.EventHandler(this.frmDoanhThuTienPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuTienPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgayDau;
        private System.Windows.Forms.Label lblNgayCuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayCuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoanhThuTienPhong;
        private System.Windows.Forms.TextBox txtTongDoanhThuTienPhong;
        private System.Windows.Forms.DataGridView dgvDoanhThuTienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTienPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinh;
    }
}