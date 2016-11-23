namespace quanlykhachsan2
{
    partial class frmHoaDonTong
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
            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.lblTongSoPhong = new System.Windows.Forms.Label();
            this.txtTongSoPhong = new System.Windows.Forms.TextBox();
            this.lblTongTienDV = new System.Windows.Forms.Label();
            this.txtTongTienDV = new System.Windows.Forms.TextBox();
            this.lblTongTienphong = new System.Windows.Forms.Label();
            this.txtTongTienPhong = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.cbMaPT = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(3, 9);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(68, 13);
            this.lblMaHD.TabIndex = 33;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(87, 9);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(164, 20);
            this.txtMaHD.TabIndex = 67;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(581, 12);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 68;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(886, 16);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(53, 13);
            this.lblNgayLap.TabIndex = 70;
            this.lblNgayLap.Text = "Ngày Lập";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(945, 12);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayLap.TabIndex = 71;
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Location = new System.Drawing.Point(3, 46);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(55, 13);
            this.lblNgayDen.TabIndex = 72;
            this.lblNgayDen.Text = "Ngày Đến";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(87, 46);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDen.TabIndex = 73;
            this.dtpNgayDen.TabStop = false;
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(282, 12);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(80, 13);
            this.lblMaPT.TabIndex = 74;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // lblTongSoPhong
            // 
            this.lblTongSoPhong.AutoSize = true;
            this.lblTongSoPhong.Location = new System.Drawing.Point(282, 53);
            this.lblTongSoPhong.Name = "lblTongSoPhong";
            this.lblTongSoPhong.Size = new System.Drawing.Size(82, 13);
            this.lblTongSoPhong.TabIndex = 77;
            this.lblTongSoPhong.Text = "Tổng Số Phòng";
            // 
            // txtTongSoPhong
            // 
            this.txtTongSoPhong.Location = new System.Drawing.Point(388, 53);
            this.txtTongSoPhong.Name = "txtTongSoPhong";
            this.txtTongSoPhong.Size = new System.Drawing.Size(164, 20);
            this.txtTongSoPhong.TabIndex = 78;
            // 
            // lblTongTienDV
            // 
            this.lblTongTienDV.AutoSize = true;
            this.lblTongTienDV.Location = new System.Drawing.Point(3, 91);
            this.lblTongTienDV.Name = "lblTongTienDV";
            this.lblTongTienDV.Size = new System.Drawing.Size(97, 13);
            this.lblTongTienDV.TabIndex = 79;
            this.lblTongTienDV.Text = "Tổng Tiền Dịch Vụ";
            // 
            // txtTongTienDV
            // 
            this.txtTongTienDV.Location = new System.Drawing.Point(121, 88);
            this.txtTongTienDV.Name = "txtTongTienDV";
            this.txtTongTienDV.Size = new System.Drawing.Size(164, 20);
            this.txtTongTienDV.TabIndex = 80;
            // 
            // lblTongTienphong
            // 
            this.lblTongTienphong.AutoSize = true;
            this.lblTongTienphong.Location = new System.Drawing.Point(333, 95);
            this.lblTongTienphong.Name = "lblTongTienphong";
            this.lblTongTienphong.Size = new System.Drawing.Size(90, 13);
            this.lblTongTienphong.TabIndex = 81;
            this.lblTongTienphong.Text = "Tổng Tiền Phòng";
            // 
            // txtTongTienPhong
            // 
            this.txtTongTienPhong.Location = new System.Drawing.Point(472, 91);
            this.txtTongTienPhong.Name = "txtTongTienPhong";
            this.txtTongTienPhong.Size = new System.Drawing.Size(164, 20);
            this.txtTongTienPhong.TabIndex = 82;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(727, 98);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(56, 13);
            this.lblTongTien.TabIndex = 83;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(817, 88);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(164, 20);
            this.txtTongTien.TabIndex = 84;
            // 
            // cbMaPT
            // 
            this.cbMaPT.FormattingEnabled = true;
            this.cbMaPT.Location = new System.Drawing.Point(388, 8);
            this.cbMaPT.Name = "cbMaPT";
            this.cbMaPT.Size = new System.Drawing.Size(164, 21);
            this.cbMaPT.TabIndex = 90;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(677, 9);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(164, 21);
            this.cbMaNV.TabIndex = 92;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 93;
            this.button1.Text = "InHoaDon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Yellow;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoad.Location = new System.Drawing.Point(75, 0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(58, 49);
            this.btnLoad.TabIndex = 94;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvChiTietHoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 333);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Hóa Đơn Các Phòng Bao Gồm";
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
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(3, 19);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(1118, 311);
            this.dgvChiTietHoaDon.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Controls.Add(this.cbMaNV);
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.cbMaPT);
            this.panel1.Controls.Add(this.txtTongTienPhong);
            this.panel1.Controls.Add(this.lblMaPT);
            this.panel1.Controls.Add(this.lblTongTienphong);
            this.panel1.Controls.Add(this.lblNgayLap);
            this.panel1.Controls.Add(this.txtTongTienDV);
            this.panel1.Controls.Add(this.dtpNgayLap);
            this.panel1.Controls.Add(this.lblTongTienDV);
            this.panel1.Controls.Add(this.lblNgayDen);
            this.panel1.Controls.Add(this.txtTongSoPhong);
            this.panel1.Controls.Add(this.dtpNgayDen);
            this.panel1.Controls.Add(this.lblTongSoPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 124);
            this.panel1.TabIndex = 96;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 49);
            this.panel2.TabIndex = 97;
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
            this.dtcTienDV.DataPropertyName = "TienDV";
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
            // frmHoaDonTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1124, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDonTong";
            this.Text = "Hóa Đơn Tổng";
            this.Load += new System.EventHandler(this.frmHoaDonTong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblTongSoPhong;
        private System.Windows.Forms.TextBox txtTongSoPhong;
        private System.Windows.Forms.Label lblTongTienDV;
        private System.Windows.Forms.TextBox txtTongTienDV;
        private System.Windows.Forms.Label lblTongTienphong;
        private System.Windows.Forms.TextBox txtTongTienPhong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbMaPT;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
    }
}