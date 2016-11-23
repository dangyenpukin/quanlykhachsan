namespace quanlykhachsan2
{
    partial class frmDoanhThuDV
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
            this.lblDoanhThuDV = new System.Windows.Forms.Label();
            this.txtTongDoanhThuDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCacDichVuDaThuPhi = new System.Windows.Forms.DataGridView();
            this.dtcMaCTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgaySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNgayDau = new System.Windows.Forms.Label();
            this.lblNgayCuoi = new System.Windows.Forms.Label();
            this.dtpNgayDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVuDaThuPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoanhThuDV
            // 
            this.lblDoanhThuDV.AutoSize = true;
            this.lblDoanhThuDV.Location = new System.Drawing.Point(12, 260);
            this.lblDoanhThuDV.Name = "lblDoanhThuDV";
            this.lblDoanhThuDV.Size = new System.Drawing.Size(127, 14);
            this.lblDoanhThuDV.TabIndex = 1;
            this.lblDoanhThuDV.Text = "Tổng Doanh Thu Dịch Vụ";
            // 
            // txtTongDoanhThuDV
            // 
            this.txtTongDoanhThuDV.Location = new System.Drawing.Point(163, 260);
            this.txtTongDoanhThuDV.Name = "txtTongDoanhThuDV";
            this.txtTongDoanhThuDV.Size = new System.Drawing.Size(164, 20);
            this.txtTongDoanhThuDV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(494, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi Tiết Các Dịch Vụ Đã Thu Tiền";
            // 
            // dgvCacDichVuDaThuPhi
            // 
            this.dgvCacDichVuDaThuPhi.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCacDichVuDaThuPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCacDichVuDaThuPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaCTDV,
            this.dtcMaDV,
            this.dtcMaPT,
            this.dtcSoPhong,
            this.dtcGia,
            this.dtcNgaySuDung});
            this.dgvCacDichVuDaThuPhi.Location = new System.Drawing.Point(356, 102);
            this.dgvCacDichVuDaThuPhi.Name = "dgvCacDichVuDaThuPhi";
            this.dgvCacDichVuDaThuPhi.Size = new System.Drawing.Size(587, 422);
            this.dgvCacDichVuDaThuPhi.TabIndex = 23;
            // 
            // dtcMaCTDV
            // 
            this.dtcMaCTDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaCTDV.DataPropertyName = "MaCTDV";
            this.dtcMaCTDV.HeaderText = "Mã Chi Tiết Dịch Vụ";
            this.dtcMaCTDV.Name = "dtcMaCTDV";
            // 
            // dtcMaDV
            // 
            this.dtcMaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtcMaDV.DataPropertyName = "MaDV";
            this.dtcMaDV.HeaderText = "Mã Dịch Vụ";
            this.dtcMaDV.Name = "dtcMaDV";
            this.dtcMaDV.Width = 80;
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
            this.dtcSoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcSoPhong.DataPropertyName = "SoPhong";
            this.dtcSoPhong.HeaderText = "Số Phòng";
            this.dtcSoPhong.Name = "dtcSoPhong";
            // 
            // dtcGia
            // 
            this.dtcGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcGia.DataPropertyName = "Gia";
            this.dtcGia.HeaderText = "Giá";
            this.dtcGia.Name = "dtcGia";
            // 
            // dtcNgaySuDung
            // 
            this.dtcNgaySuDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgaySuDung.DataPropertyName = "NgaySuDung";
            this.dtcNgaySuDung.HeaderText = "Ngày Sử Dụng";
            this.dtcNgaySuDung.Name = "dtcNgaySuDung";
            // 
            // lblNgayDau
            // 
            this.lblNgayDau.AutoSize = true;
            this.lblNgayDau.Location = new System.Drawing.Point(12, 82);
            this.lblNgayDau.Name = "lblNgayDau";
            this.lblNgayDau.Size = new System.Drawing.Size(58, 14);
            this.lblNgayDau.TabIndex = 25;
            this.lblNgayDau.Text = "Ngày Đầu ";
            // 
            // lblNgayCuoi
            // 
            this.lblNgayCuoi.AutoSize = true;
            this.lblNgayCuoi.Location = new System.Drawing.Point(14, 144);
            this.lblNgayCuoi.Name = "lblNgayCuoi";
            this.lblNgayCuoi.Size = new System.Drawing.Size(56, 14);
            this.lblNgayCuoi.TabIndex = 26;
            this.lblNgayCuoi.Text = "Ngày Cuối";
            // 
            // dtpNgayDau
            // 
            this.dtpNgayDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDau.Location = new System.Drawing.Point(163, 82);
            this.dtpNgayDau.Name = "dtpNgayDau";
            this.dtpNgayDau.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDau.TabIndex = 75;
            // 
            // dtpNgayCuoi
            // 
            this.dtpNgayCuoi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayCuoi.Location = new System.Drawing.Point(163, 164);
            this.dtpNgayCuoi.Name = "dtpNgayCuoi";
            this.dtpNgayCuoi.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayCuoi.TabIndex = 76;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(17, 462);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 54);
            this.btnThoat.TabIndex = 77;
            this.btnThoat.Text = "thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.Yellow;
            this.btnTinh.Location = new System.Drawing.Point(140, 339);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 38);
            this.btnTinh.TabIndex = 78;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // frmDoanhThuDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(944, 529);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dtpNgayCuoi);
            this.Controls.Add(this.dtpNgayDau);
            this.Controls.Add(this.lblNgayCuoi);
            this.Controls.Add(this.lblNgayDau);
            this.Controls.Add(this.dgvCacDichVuDaThuPhi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongDoanhThuDV);
            this.Controls.Add(this.lblDoanhThuDV);
            this.Name = "frmDoanhThuDV";
            this.Text = "Doanh Thu Dịch Vụ";
            this.Load += new System.EventHandler(this.frmDoanhThuDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVuDaThuPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoanhThuDV;
        private System.Windows.Forms.TextBox txtTongDoanhThuDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCacDichVuDaThuPhi;
        private System.Windows.Forms.Label lblNgayDau;
        private System.Windows.Forms.Label lblNgayCuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaCTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgaySuDung;
        private System.Windows.Forms.DateTimePicker dtpNgayCuoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTinh;
    }
}