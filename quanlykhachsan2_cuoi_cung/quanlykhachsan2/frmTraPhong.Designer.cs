namespace quanlykhachsan2
{
    partial class frmTraPhong
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
            this.lblMaCTHD = new System.Windows.Forms.Label();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblTongNgay = new System.Windows.Forms.Label();
            this.txtTongNgay = new System.Windows.Forms.TextBox();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.lblTienDV = new System.Windows.Forms.Label();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.lblTien = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.lblCacDichVuDaDung = new System.Windows.Forms.Label();
            this.dgvCacDichVuDaDung = new System.Windows.Forms.DataGridView();
            this.dtcMaCTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgaySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.cbMaPT = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVuDaDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaCTHD
            // 
            this.lblMaCTHD.AutoSize = true;
            this.lblMaCTHD.Location = new System.Drawing.Point(10, 10);
            this.lblMaCTHD.Name = "lblMaCTHD";
            this.lblMaCTHD.Size = new System.Drawing.Size(107, 13);
            this.lblMaCTHD.TabIndex = 5;
            this.lblMaCTHD.Text = "Mã Chi Tiết Hóa Đơn";
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(133, 5);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(164, 20);
            this.txtMaCTHD.TabIndex = 6;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(12, 42);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 40;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(17, 80);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(53, 13);
            this.lblNgayLap.TabIndex = 49;
            this.lblNgayLap.Text = "Ngày Lập";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(133, 80);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayLap.TabIndex = 50;
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Location = new System.Drawing.Point(17, 232);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(55, 13);
            this.lblNgayDen.TabIndex = 53;
            this.lblNgayDen.Text = "Ngày Đến";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(133, 232);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDen.TabIndex = 54;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(12, 273);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(45, 13);
            this.lblNgayDi.TabIndex = 55;
            this.lblNgayDi.Text = "Ngày Đi";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(133, 273);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDi.TabIndex = 56;
            // 
            // lblTongNgay
            // 
            this.lblTongNgay.AutoSize = true;
            this.lblTongNgay.Location = new System.Drawing.Point(12, 324);
            this.lblTongNgay.Name = "lblTongNgay";
            this.lblTongNgay.Size = new System.Drawing.Size(60, 13);
            this.lblTongNgay.TabIndex = 57;
            this.lblTongNgay.Text = "Tổng Ngày";
            // 
            // txtTongNgay
            // 
            this.txtTongNgay.Location = new System.Drawing.Point(133, 321);
            this.txtTongNgay.Name = "txtTongNgay";
            this.txtTongNgay.Size = new System.Drawing.Size(164, 20);
            this.txtTongNgay.TabIndex = 58;
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(10, 122);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(80, 13);
            this.lblMaPT.TabIndex = 59;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(10, 158);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(54, 13);
            this.lblSoPhong.TabIndex = 61;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Location = new System.Drawing.Point(10, 373);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(62, 13);
            this.lblTienPhong.TabIndex = 63;
            this.lblTienPhong.Text = "Tiền Phòng";
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Location = new System.Drawing.Point(133, 356);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.Size = new System.Drawing.Size(164, 20);
            this.txtTienPhong.TabIndex = 64;
            // 
            // lblTienDV
            // 
            this.lblTienDV.AutoSize = true;
            this.lblTienDV.Location = new System.Drawing.Point(21, 405);
            this.lblTienDV.Name = "lblTienDV";
            this.lblTienDV.Size = new System.Drawing.Size(69, 13);
            this.lblTienDV.TabIndex = 65;
            this.lblTienDV.Text = "Tiền Dịch Vụ";
            // 
            // txtTienDV
            // 
            this.txtTienDV.Location = new System.Drawing.Point(133, 395);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.Size = new System.Drawing.Size(164, 20);
            this.txtTienDV.TabIndex = 66;
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(44, 438);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(28, 13);
            this.lblTien.TabIndex = 67;
            this.lblTien.Text = "Tiền";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(133, 438);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(164, 20);
            this.txtTien.TabIndex = 68;
            // 
            // lblCacDichVuDaDung
            // 
            this.lblCacDichVuDaDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCacDichVuDaDung.Location = new System.Drawing.Point(576, 17);
            this.lblCacDichVuDaDung.Name = "lblCacDichVuDaDung";
            this.lblCacDichVuDaDung.Size = new System.Drawing.Size(223, 36);
            this.lblCacDichVuDaDung.TabIndex = 75;
            this.lblCacDichVuDaDung.Text = "Các Dịch Vụ Đã Dùng";
            // 
            // dgvCacDichVuDaDung
            // 
            this.dgvCacDichVuDaDung.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCacDichVuDaDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCacDichVuDaDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaCTDV,
            this.dtcMaDV,
            this.dtcTenDV,
            this.dtcGia,
            this.dtcNgaySuDung});
            this.dgvCacDichVuDaDung.Location = new System.Drawing.Point(392, 80);
            this.dgvCacDichVuDaDung.Name = "dgvCacDichVuDaDung";
            this.dgvCacDichVuDaDung.Size = new System.Drawing.Size(528, 433);
            this.dgvCacDichVuDaDung.TabIndex = 76;
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
            this.dtcMaDV.Width = 81;
            // 
            // dtcTenDV
            // 
            this.dtcTenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTenDV.DataPropertyName = "TenDV";
            this.dtcTenDV.HeaderText = "Tên Dịch Vụ";
            this.dtcTenDV.Name = "dtcTenDV";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSoPhong);
            this.panel1.Controls.Add(this.cbMaPT);
            this.panel1.Controls.Add(this.cbMaNV);
            this.panel1.Controls.Add(this.lblTien);
            this.panel1.Controls.Add(this.txtTien);
            this.panel1.Controls.Add(this.lblTienDV);
            this.panel1.Controls.Add(this.txtMaCTHD);
            this.panel1.Controls.Add(this.lblMaCTHD);
            this.panel1.Controls.Add(this.dtpNgayLap);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Controls.Add(this.lblNgayLap);
            this.panel1.Controls.Add(this.lblMaPT);
            this.panel1.Controls.Add(this.txtTienPhong);
            this.panel1.Controls.Add(this.lblSoPhong);
            this.panel1.Controls.Add(this.txtTienDV);
            this.panel1.Controls.Add(this.lblTienPhong);
            this.panel1.Controls.Add(this.lblTongNgay);
            this.panel1.Controls.Add(this.dtpNgayDen);
            this.panel1.Controls.Add(this.dtpNgayDi);
            this.panel1.Controls.Add(this.lblNgayDen);
            this.panel1.Controls.Add(this.txtTongNgay);
            this.panel1.Controls.Add(this.lblNgayDi);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 467);
            this.panel1.TabIndex = 77;
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Location = new System.Drawing.Point(133, 158);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(164, 21);
            this.cbSoPhong.TabIndex = 71;
            // 
            // cbMaPT
            // 
            this.cbMaPT.FormattingEnabled = true;
            this.cbMaPT.Location = new System.Drawing.Point(133, 122);
            this.cbMaPT.Name = "cbMaPT";
            this.cbMaPT.Size = new System.Drawing.Size(164, 21);
            this.cbMaPT.TabIndex = 70;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(133, 39);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(164, 21);
            this.cbMaNV.TabIndex = 69;
            // 
            // frmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(921, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCacDichVuDaDung);
            this.Controls.Add(this.lblCacDichVuDaDung);
            this.Name = "frmTraPhong";
            this.Text = "frmTraPhong";
            this.Load += new System.EventHandler(this.frmTraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVuDaDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaCTHD;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblTongNgay;
        private System.Windows.Forms.TextBox txtTongNgay;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.Label lblTienDV;
        private System.Windows.Forms.TextBox txtTienDV;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label lblCacDichVuDaDung;
        private System.Windows.Forms.DataGridView dgvCacDichVuDaDung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.ComboBox cbMaPT;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaCTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgaySuDung;
    }
}