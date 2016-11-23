namespace quanlykhachsan2
{
    partial class frmUocTinhChiPhi
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
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.lblTienDV = new System.Windows.Forms.Label();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.txtTienPhong = new System.Windows.Forms.TextBox();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.dgvCacDichVuDaDung = new System.Windows.Forms.DataGridView();
            this.dtcMaCTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgaySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.lblNgayHienTai = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHienTai = new System.Windows.Forms.DateTimePicker();
            this.lblCacDichVuDaDung = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.cbMaPT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVuDaDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(32, 23);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(54, 13);
            this.lblSoPhong.TabIndex = 0;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(24, 88);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(80, 13);
            this.lblMaPT.TabIndex = 16;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // lblTienDV
            // 
            this.lblTienDV.AutoSize = true;
            this.lblTienDV.Location = new System.Drawing.Point(24, 164);
            this.lblTienDV.Name = "lblTienDV";
            this.lblTienDV.Size = new System.Drawing.Size(69, 13);
            this.lblTienDV.TabIndex = 18;
            this.lblTienDV.Text = "Tiền Dịch Vụ";
            // 
            // txtTienDV
            // 
            this.txtTienDV.Location = new System.Drawing.Point(167, 160);
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.Size = new System.Drawing.Size(164, 20);
            this.txtTienDV.TabIndex = 19;
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.Location = new System.Drawing.Point(170, 234);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.Size = new System.Drawing.Size(164, 20);
            this.txtTienPhong.TabIndex = 20;
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Location = new System.Drawing.Point(24, 240);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(62, 13);
            this.lblTienPhong.TabIndex = 21;
            this.lblTienPhong.Text = "Tiền Phòng";
            // 
            // dgvCacDichVuDaDung
            // 
            this.dgvCacDichVuDaDung.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCacDichVuDaDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCacDichVuDaDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaCTDV,
            this.dtcMaDV,
            this.dtcGia,
            this.dtcNgaySuDung});
            this.dgvCacDichVuDaDung.Location = new System.Drawing.Point(486, 68);
            this.dgvCacDichVuDaDung.Name = "dgvCacDichVuDaDung";
            this.dgvCacDichVuDaDung.Size = new System.Drawing.Size(484, 392);
            this.dgvCacDichVuDaDung.TabIndex = 22;
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
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Location = new System.Drawing.Point(24, 316);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(55, 13);
            this.lblNgayDen.TabIndex = 23;
            this.lblNgayDen.Text = "Ngày Đến";
            // 
            // lblNgayHienTai
            // 
            this.lblNgayHienTai.AutoSize = true;
            this.lblNgayHienTai.Location = new System.Drawing.Point(24, 392);
            this.lblNgayHienTai.Name = "lblNgayHienTai";
            this.lblNgayHienTai.Size = new System.Drawing.Size(75, 13);
            this.lblNgayHienTai.TabIndex = 24;
            this.lblNgayHienTai.Text = "Ngày Hiện Tại";
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(170, 308);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDen.TabIndex = 72;
            // 
            // dtpNgayHienTai
            // 
            this.dtpNgayHienTai.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHienTai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHienTai.Location = new System.Drawing.Point(167, 382);
            this.dtpNgayHienTai.Name = "dtpNgayHienTai";
            this.dtpNgayHienTai.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayHienTai.TabIndex = 73;
            // 
            // lblCacDichVuDaDung
            // 
            this.lblCacDichVuDaDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCacDichVuDaDung.Location = new System.Drawing.Point(525, 12);
            this.lblCacDichVuDaDung.Name = "lblCacDichVuDaDung";
            this.lblCacDichVuDaDung.Size = new System.Drawing.Size(223, 25);
            this.lblCacDichVuDaDung.TabIndex = 74;
            this.lblCacDichVuDaDung.Text = "Các Dịch Vụ Đã Dùng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMaPT);
            this.panel1.Controls.Add(this.cbSoPhong);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnKiemTra);
            this.panel1.Controls.Add(this.lblSoPhong);
            this.panel1.Controls.Add(this.lblNgayDen);
            this.panel1.Controls.Add(this.dtpNgayHienTai);
            this.panel1.Controls.Add(this.lblNgayHienTai);
            this.panel1.Controls.Add(this.lblMaPT);
            this.panel1.Controls.Add(this.dtpNgayDen);
            this.panel1.Controls.Add(this.lblTienDV);
            this.panel1.Controls.Add(this.txtTienDV);
            this.panel1.Controls.Add(this.lblTienPhong);
            this.panel1.Controls.Add(this.txtTienPhong);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 459);
            this.panel1.TabIndex = 75;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(387, 57);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(77, 30);
            this.btnKiemTra.TabIndex = 82;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(195, 418);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(77, 30);
            this.btnLoad.TabIndex = 83;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Location = new System.Drawing.Point(170, 20);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(161, 21);
            this.cbSoPhong.TabIndex = 84;
            // 
            // cbMaPT
            // 
            this.cbMaPT.FormattingEnabled = true;
            this.cbMaPT.Location = new System.Drawing.Point(170, 88);
            this.cbMaPT.Name = "cbMaPT";
            this.cbMaPT.Size = new System.Drawing.Size(161, 21);
            this.cbMaPT.TabIndex = 85;
            // 
            // frmUocTinhChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(971, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCacDichVuDaDung);
            this.Controls.Add(this.dgvCacDichVuDaDung);
            this.Name = "frmUocTinhChiPhi";
            this.Text = "Ước Tính Chi Phí";
            this.Load += new System.EventHandler(this.frmUocTinhChiPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacDichVuDaDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblTienDV;
        private System.Windows.Forms.TextBox txtTienDV;
        private System.Windows.Forms.TextBox txtTienPhong;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.DataGridView dgvCacDichVuDaDung;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Label lblNgayHienTai;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.DateTimePicker dtpNgayHienTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaCTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgaySuDung;
        private System.Windows.Forms.Label lblCacDichVuDaDung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.ComboBox cbMaPT;
    }
}