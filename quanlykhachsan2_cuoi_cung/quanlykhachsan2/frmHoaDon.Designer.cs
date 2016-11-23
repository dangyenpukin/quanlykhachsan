namespace quanlykhachsan2
{
    partial class frmHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dtcMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTongSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTongTienDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTongTienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTienphong = new System.Windows.Forms.Label();
            this.lblTongSoPhong = new System.Windows.Forms.Label();
            this.lblTongTienDV = new System.Windows.Forms.Label();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTongTienPhong = new System.Windows.Forms.TextBox();
            this.txtTongSoPhong = new System.Windows.Forms.TextBox();
            this.txtTongTienDV = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaHD,
            this.dtcMaNV,
            this.dtcNgayLap,
            this.dtcNgayDen,
            this.dtcMaPT,
            this.dtcTongSoPhong,
            this.dtcTongTienDV,
            this.dtcTongTienPhong,
            this.dtcTongTien});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 171);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(1091, 288);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // dtcMaHD
            // 
            this.dtcMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaHD.DataPropertyName = "MaHD";
            this.dtcMaHD.HeaderText = "Mã Hóa Đơn";
            this.dtcMaHD.Name = "dtcMaHD";
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
            // dtcNgayDen
            // 
            this.dtcNgayDen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgayDen.DataPropertyName = "NgayDen";
            this.dtcNgayDen.HeaderText = "Ngày Đến";
            this.dtcNgayDen.Name = "dtcNgayDen";
            // 
            // dtcMaPT
            // 
            this.dtcMaPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaPT.DataPropertyName = "MaPT";
            this.dtcMaPT.HeaderText = "Mã Phiếu Thuê";
            this.dtcMaPT.Name = "dtcMaPT";
            // 
            // dtcTongSoPhong
            // 
            this.dtcTongSoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTongSoPhong.DataPropertyName = "TongSoPhong";
            this.dtcTongSoPhong.HeaderText = "Tổng Số Phòng";
            this.dtcTongSoPhong.Name = "dtcTongSoPhong";
            // 
            // dtcTongTienDV
            // 
            this.dtcTongTienDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTongTienDV.DataPropertyName = "TongTienDV";
            this.dtcTongTienDV.HeaderText = "Tổng Tiền Dịch Vụ";
            this.dtcTongTienDV.Name = "dtcTongTienDV";
            // 
            // dtcTongTienPhong
            // 
            this.dtcTongTienPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTongTienPhong.DataPropertyName = "TongTienPhong";
            this.dtcTongTienPhong.HeaderText = "Tổng Tiền Phòng";
            this.dtcTongTienPhong.Name = "dtcTongTienPhong";
            // 
            // dtcTongTien
            // 
            this.dtcTongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTongTien.DataPropertyName = "TongTien";
            this.dtcTongTien.HeaderText = "Tổng Tiền";
            this.dtcTongTien.Name = "dtcTongTien";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(658, 106);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(56, 13);
            this.lblTongTien.TabIndex = 21;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // lblTongTienphong
            // 
            this.lblTongTienphong.AutoSize = true;
            this.lblTongTienphong.Location = new System.Drawing.Point(324, 99);
            this.lblTongTienphong.Name = "lblTongTienphong";
            this.lblTongTienphong.Size = new System.Drawing.Size(90, 13);
            this.lblTongTienphong.TabIndex = 22;
            this.lblTongTienphong.Text = "Tổng Tiền Phòng";
            // 
            // lblTongSoPhong
            // 
            this.lblTongSoPhong.AutoSize = true;
            this.lblTongSoPhong.Location = new System.Drawing.Point(648, 64);
            this.lblTongSoPhong.Name = "lblTongSoPhong";
            this.lblTongSoPhong.Size = new System.Drawing.Size(82, 13);
            this.lblTongSoPhong.TabIndex = 23;
            this.lblTongSoPhong.Text = "Tổng Số Phòng";
            // 
            // lblTongTienDV
            // 
            this.lblTongTienDV.AutoSize = true;
            this.lblTongTienDV.Location = new System.Drawing.Point(12, 99);
            this.lblTongTienDV.Name = "lblTongTienDV";
            this.lblTongTienDV.Size = new System.Drawing.Size(97, 13);
            this.lblTongTienDV.TabIndex = 24;
            this.lblTongTienDV.Text = "Tổng Tiền Dịch Vụ";
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(324, 9);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(80, 13);
            this.lblMaPT.TabIndex = 28;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Location = new System.Drawing.Point(324, 61);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(55, 13);
            this.lblNgayDen.TabIndex = 29;
            this.lblNgayDen.Text = "Ngày Đến";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(12, 54);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(53, 13);
            this.lblNgayLap.TabIndex = 30;
            this.lblNgayLap.Text = "Ngày Lập";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(648, 9);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 31;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(12, 9);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(68, 13);
            this.lblMaHD.TabIndex = 32;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(120, 54);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayLap.TabIndex = 53;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(444, 57);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDen.TabIndex = 54;
            this.dtpNgayDen.TabStop = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(765, 99);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(164, 20);
            this.txtTongTien.TabIndex = 57;
            // 
            // txtTongTienPhong
            // 
            this.txtTongTienPhong.Location = new System.Drawing.Point(444, 99);
            this.txtTongTienPhong.Name = "txtTongTienPhong";
            this.txtTongTienPhong.Size = new System.Drawing.Size(164, 20);
            this.txtTongTienPhong.TabIndex = 58;
            // 
            // txtTongSoPhong
            // 
            this.txtTongSoPhong.Location = new System.Drawing.Point(765, 58);
            this.txtTongSoPhong.Name = "txtTongSoPhong";
            this.txtTongSoPhong.Size = new System.Drawing.Size(164, 20);
            this.txtTongSoPhong.TabIndex = 59;
            // 
            // txtTongTienDV
            // 
            this.txtTongTienDV.Location = new System.Drawing.Point(120, 96);
            this.txtTongTienDV.Name = "txtTongTienDV";
            this.txtTongTienDV.Size = new System.Drawing.Size(164, 20);
            this.txtTongTienDV.TabIndex = 60;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(444, 9);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(164, 20);
            this.txtMaPT.TabIndex = 64;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(763, 9);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(164, 20);
            this.txtMaNV.TabIndex = 65;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(120, 9);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(164, 20);
            this.txtMaHD.TabIndex = 66;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 67;
            this.button1.Text = "InHoaDon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtTongTienPhong);
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.txtTongTienDV);
            this.panel1.Controls.Add(this.txtMaPT);
            this.panel1.Controls.Add(this.lblTongTienphong);
            this.panel1.Controls.Add(this.txtTongSoPhong);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.lblTongTienDV);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Controls.Add(this.lblMaPT);
            this.panel1.Controls.Add(this.dtpNgayDen);
            this.panel1.Controls.Add(this.lblTongSoPhong);
            this.panel1.Controls.Add(this.lblNgayLap);
            this.panel1.Controls.Add(this.lblNgayDen);
            this.panel1.Controls.Add(this.dtpNgayLap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 135);
            this.panel1.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 38);
            this.panel2.TabIndex = 69;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1091, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHoaDon);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongTienphong;
        private System.Windows.Forms.Label lblTongSoPhong;
        private System.Windows.Forms.Label lblTongTienDV;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTongTienPhong;
        private System.Windows.Forms.TextBox txtTongSoPhong;
        private System.Windows.Forms.TextBox txtTongTienDV;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTongSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTongTienDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTongTienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTongTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}