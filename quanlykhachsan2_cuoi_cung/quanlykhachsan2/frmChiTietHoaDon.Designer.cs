namespace quanlykhachsan2
{
    partial class frmChiTietHoaDon
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
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.dtcMaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTongNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTienDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaCTHD = new System.Windows.Forms.Label();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.lblTongNgay = new System.Windows.Forms.Label();
            this.lblTien = new System.Windows.Forms.Label();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.txtTongNgay = new System.Windows.Forms.TextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblTienDV = new System.Windows.Forms.Label();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaCTHD,
            this.dtcMaNV,
            this.dtcNgayLap,
            this.dtcMaKH,
            this.dtcNgayDen,
            this.dtcNgayDi,
            this.dtcTongNgay,
            this.dtcMaPT,
            this.dtcSoPhong,
            this.dtcTienPhong,
            this.dtcTienDV,
            this.dtcTien});
            this.dgvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(0, 123);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1096, 381);
            this.dgvChiTietHoaDon.TabIndex = 0;
            // 
            // dtcMaCTHD
            // 
            this.dtcMaCTHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaCTHD.DataPropertyName = "MaCTHD";
            this.dtcMaCTHD.HeaderText = "Mã Chi Tiết Hóa Đơn";
            this.dtcMaCTHD.Name = "dtcMaCTHD";
            this.dtcMaCTHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtcMaNV
            // 
            this.dtcMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaNV.DataPropertyName = "MaNV";
            this.dtcMaNV.HeaderText = "Mã Nhân Viên";
            this.dtcMaNV.Name = "dtcMaNV";
            this.dtcMaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtcNgayLap
            // 
            this.dtcNgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgayLap.DataPropertyName = "NgayLap";
            this.dtcNgayLap.HeaderText = "Ngày Lập";
            this.dtcNgayLap.Name = "dtcNgayLap";
            // 
            // dtcMaKH
            // 
            this.dtcMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaKH.DataPropertyName = "MaKH";
            this.dtcMaKH.HeaderText = "Mã Khách Hàng";
            this.dtcMaKH.Name = "dtcMaKH";
            this.dtcMaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtcNgayDen
            // 
            this.dtcNgayDen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgayDen.DataPropertyName = "NgayDen";
            this.dtcNgayDen.HeaderText = "Ngày Đến";
            this.dtcNgayDen.Name = "dtcNgayDen";
            // 
            // dtcNgayDi
            // 
            this.dtcNgayDi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgayDi.DataPropertyName = "NgayDi";
            this.dtcNgayDi.HeaderText = "Ngày Đi";
            this.dtcNgayDi.Name = "dtcNgayDi";
            // 
            // dtcTongNgay
            // 
            this.dtcTongNgay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTongNgay.DataPropertyName = "TongNgay";
            this.dtcTongNgay.HeaderText = "Tổng Ngày ";
            this.dtcTongNgay.Name = "dtcTongNgay";
            // 
            // dtcMaPT
            // 
            this.dtcMaPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaPT.DataPropertyName = "MaPT";
            this.dtcMaPT.HeaderText = "Mã Phiếu Thuê";
            this.dtcMaPT.Name = "dtcMaPT";
            this.dtcMaPT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtcSoPhong
            // 
            this.dtcSoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcSoPhong.DataPropertyName = "SoPhong";
            this.dtcSoPhong.HeaderText = "Số Phòng";
            this.dtcSoPhong.Name = "dtcSoPhong";
            this.dtcSoPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtcTienPhong
            // 
            this.dtcTienPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTienPhong.DataPropertyName = "TienPhong";
            this.dtcTienPhong.HeaderText = "Tiền Phòng";
            this.dtcTienPhong.Name = "dtcTienPhong";
            // 
            // dtcTienDV
            // 
            this.dtcTienDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTienDV.DataPropertyName = "Tien";
            this.dtcTienDV.HeaderText = "Tiền Dịch Vụ";
            this.dtcTienDV.Name = "dtcTienDV";
            // 
            // dtcTien
            // 
            this.dtcTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTien.DataPropertyName = "Tien";
            this.dtcTien.HeaderText = "Tiền";
            this.dtcTien.Name = "dtcTien";
            // 
            // lblMaCTHD
            // 
            this.lblMaCTHD.AutoSize = true;
            this.lblMaCTHD.Location = new System.Drawing.Point(12, 9);
            this.lblMaCTHD.Name = "lblMaCTHD";
            this.lblMaCTHD.Size = new System.Drawing.Size(107, 13);
            this.lblMaCTHD.TabIndex = 4;
            this.lblMaCTHD.Text = "Mã Chi Tiết Hóa Đơn";
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(132, 9);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(164, 20);
            this.txtMaCTHD.TabIndex = 5;
            // 
            // lblTongNgay
            // 
            this.lblTongNgay.AutoSize = true;
            this.lblTongNgay.Location = new System.Drawing.Point(817, 51);
            this.lblTongNgay.Name = "lblTongNgay";
            this.lblTongNgay.Size = new System.Drawing.Size(60, 13);
            this.lblTongNgay.TabIndex = 32;
            this.lblTongNgay.Text = "Tổng Ngày";
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Location = new System.Drawing.Point(827, 87);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(28, 13);
            this.lblTien.TabIndex = 33;
            this.lblTien.Text = "Tiền";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(572, 51);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(45, 13);
            this.lblNgayDi.TabIndex = 34;
            this.lblNgayDi.Text = "Ngày Đi";
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Location = new System.Drawing.Point(307, 51);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(55, 13);
            this.lblNgayDen.TabIndex = 35;
            this.lblNgayDen.Text = "Ngày Đến";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(12, 51);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(85, 13);
            this.lblMaKH.TabIndex = 36;
            this.lblMaKH.Text = "Mã Khách Hàng";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(12, 87);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(54, 13);
            this.lblSoPhong.TabIndex = 37;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(574, 9);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(53, 13);
            this.lblNgayLap.TabIndex = 38;
            this.lblNgayLap.Text = "Ngày Lập";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(309, 9);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 39;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(132, 84);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(164, 20);
            this.txtSoPhong.TabIndex = 40;
            // 
            // txtTongNgay
            // 
            this.txtTongNgay.Location = new System.Drawing.Point(910, 51);
            this.txtTongNgay.Name = "txtTongNgay";
            this.txtTongNgay.Size = new System.Drawing.Size(164, 20);
            this.txtTongNgay.TabIndex = 41;
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(910, 87);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(164, 20);
            this.txtTien.TabIndex = 42;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(132, 48);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(164, 20);
            this.txtMaKH.TabIndex = 45;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(397, 9);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(164, 20);
            this.txtMaNV.TabIndex = 47;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(640, 9);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayLap.TabIndex = 48;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(397, 48);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDen.TabIndex = 49;
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(640, 51);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDi.TabIndex = 50;
            // 
            // lblTienDV
            // 
            this.lblTienDV.AutoSize = true;
            this.lblTienDV.Location = new System.Drawing.Point(567, 87);
            this.lblTienDV.Name = "lblTienDV";
            this.lblTienDV.Size = new System.Drawing.Size(69, 13);
            this.lblTienDV.TabIndex = 51;
            this.lblTienDV.Text = "Tiền Dịch Vụ";
            // 
            // txtTienDV
            // 
            this.txtTienDV.Location = new System.Drawing.Point(640, 84);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.Size = new System.Drawing.Size(164, 20);
            this.txtTienDV.TabIndex = 52;
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Location = new System.Drawing.Point(397, 87);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.Size = new System.Drawing.Size(164, 20);
            this.txtTienPhong.TabIndex = 53;
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Location = new System.Drawing.Point(309, 87);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(62, 13);
            this.lblTienPhong.TabIndex = 54;
            this.lblTienPhong.Text = "Tiền Phòng";
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(817, 9);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(80, 13);
            this.lblMaPT.TabIndex = 55;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(910, 9);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(164, 20);
            this.txtMaPT.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaCTHD);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.txtTien);
            this.panel1.Controls.Add(this.txtTienDV);
            this.panel1.Controls.Add(this.lblTien);
            this.panel1.Controls.Add(this.txtTienPhong);
            this.panel1.Controls.Add(this.lblTienDV);
            this.panel1.Controls.Add(this.lblTienPhong);
            this.panel1.Controls.Add(this.txtMaPT);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Controls.Add(this.lblMaPT);
            this.panel1.Controls.Add(this.txtMaCTHD);
            this.panel1.Controls.Add(this.lblNgayLap);
            this.panel1.Controls.Add(this.txtSoPhong);
            this.panel1.Controls.Add(this.dtpNgayLap);
            this.panel1.Controls.Add(this.lblSoPhong);
            this.panel1.Controls.Add(this.lblMaKH);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.dtpNgayDi);
            this.panel1.Controls.Add(this.txtTongNgay);
            this.panel1.Controls.Add(this.lblNgayDen);
            this.panel1.Controls.Add(this.dtpNgayDen);
            this.panel1.Controls.Add(this.lblNgayDi);
            this.panel1.Controls.Add(this.lblTongNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 117);
            this.panel1.TabIndex = 58;
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Name = "frmChiTietHoaDon";
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Label lblMaCTHD;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.Label lblTongNgay;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.TextBox txtTongNgay;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblTienDV;
        private System.Windows.Forms.TextBox txtTienDV;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTongNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTienDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTien;
        private System.Windows.Forms.Panel panel1;
    }
}