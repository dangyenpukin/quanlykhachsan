namespace quanlykhachsan2
{
    partial class frmGoiDichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDongY = new System.Windows.Forms.Button();
            this.dtpNgaySuDung = new System.Windows.Forms.DateTimePicker();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.cbMaPT = new System.Windows.Forms.ComboBox();
            this.cbMaDV = new System.Windows.Forms.ComboBox();
            this.lblNgaySuDung = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.txtMaCTDV = new System.Windows.Forms.TextBox();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.lblMaCTDV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.dtcMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachDV = new System.Windows.Forms.DataGridView();
            this.MaCTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDongY);
            this.panel1.Controls.Add(this.dtpNgaySuDung);
            this.panel1.Controls.Add(this.cbSoPhong);
            this.panel1.Controls.Add(this.cbMaPT);
            this.panel1.Controls.Add(this.cbMaDV);
            this.panel1.Controls.Add(this.lblNgaySuDung);
            this.panel1.Controls.Add(this.lblSoPhong);
            this.panel1.Controls.Add(this.lblMaPT);
            this.panel1.Controls.Add(this.txtMaCTDV);
            this.panel1.Controls.Add(this.lblMaDV);
            this.panel1.Controls.Add(this.lblMaCTDV);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 223);
            this.panel1.TabIndex = 1;
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.Yellow;
            this.btnDongY.Location = new System.Drawing.Point(291, 87);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(77, 44);
            this.btnDongY.TabIndex = 69;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // dtpNgaySuDung
            // 
            this.dtpNgaySuDung.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySuDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySuDung.Location = new System.Drawing.Point(128, 184);
            this.dtpNgaySuDung.Name = "dtpNgaySuDung";
            this.dtpNgaySuDung.Size = new System.Drawing.Size(145, 20);
            this.dtpNgaySuDung.TabIndex = 80;
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Location = new System.Drawing.Point(128, 136);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(145, 21);
            this.cbSoPhong.TabIndex = 71;
            // 
            // cbMaPT
            // 
            this.cbMaPT.FormattingEnabled = true;
            this.cbMaPT.Location = new System.Drawing.Point(128, 95);
            this.cbMaPT.Name = "cbMaPT";
            this.cbMaPT.Size = new System.Drawing.Size(145, 21);
            this.cbMaPT.TabIndex = 70;
            // 
            // cbMaDV
            // 
            this.cbMaDV.FormattingEnabled = true;
            this.cbMaDV.Location = new System.Drawing.Point(128, 59);
            this.cbMaDV.Name = "cbMaDV";
            this.cbMaDV.Size = new System.Drawing.Size(145, 21);
            this.cbMaDV.TabIndex = 69;
            // 
            // lblNgaySuDung
            // 
            this.lblNgaySuDung.AutoSize = true;
            this.lblNgaySuDung.Location = new System.Drawing.Point(11, 185);
            this.lblNgaySuDung.Name = "lblNgaySuDung";
            this.lblNgaySuDung.Size = new System.Drawing.Size(77, 13);
            this.lblNgaySuDung.TabIndex = 67;
            this.lblNgaySuDung.Text = "Ngày Sử Dụng";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(11, 144);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(54, 13);
            this.lblSoPhong.TabIndex = 62;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(11, 103);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(80, 13);
            this.lblMaPT.TabIndex = 20;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // txtMaCTDV
            // 
            this.txtMaCTDV.Location = new System.Drawing.Point(128, 20);
            this.txtMaCTDV.Name = "txtMaCTDV";
            this.txtMaCTDV.Size = new System.Drawing.Size(145, 20);
            this.txtMaCTDV.TabIndex = 4;
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Location = new System.Drawing.Point(11, 60);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(63, 13);
            this.lblMaDV.TabIndex = 3;
            this.lblMaDV.Text = "Mã Dịch Vụ";
            // 
            // lblMaCTDV
            // 
            this.lblMaCTDV.AutoSize = true;
            this.lblMaCTDV.Location = new System.Drawing.Point(11, 20);
            this.lblMaCTDV.Name = "lblMaCTDV";
            this.lblMaCTDV.Size = new System.Drawing.Size(102, 13);
            this.lblMaCTDV.TabIndex = 0;
            this.lblMaCTDV.Text = "Mã Chi Tiết Dịch Vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDichVu);
            this.groupBox1.Location = new System.Drawing.Point(398, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 223);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các Dịch Vụ Của Khách Sạn";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaDV,
            this.dtcTenDV,
            this.dtcGia});
            this.dgvDichVu.Location = new System.Drawing.Point(6, 32);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(334, 191);
            this.dgvDichVu.TabIndex = 1;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick_1);
            // 
            // dtcMaDV
            // 
            this.dtcMaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaDV.DataPropertyName = "MaDV";
            this.dtcMaDV.HeaderText = "Mã Dịch Vụ";
            this.dtcMaDV.Name = "dtcMaDV";
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
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 174);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Các Dịch Vụ Mã Phòng Đã Sử Dụng";
            // 
            // dgvDanhSachDV
            // 
            this.dgvDanhSachDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTDV,
            this.MaDV,
            this.TenDV,
            this.Gia,
            this.NgaySuDung});
            this.dgvDanhSachDV.Location = new System.Drawing.Point(-6, 249);
            this.dgvDanhSachDV.Name = "dgvDanhSachDV";
            this.dgvDanhSachDV.Size = new System.Drawing.Size(747, 152);
            this.dgvDanhSachDV.TabIndex = 3;
            // 
            // MaCTDV
            // 
            this.MaCTDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCTDV.DataPropertyName = "MaCTDV";
            this.MaCTDV.HeaderText = "Mã Chi Tiết Dịch Vụ";
            this.MaCTDV.Name = "MaCTDV";
            // 
            // MaDV
            // 
            this.MaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDV.DataPropertyName = "MaDV";
            this.MaDV.HeaderText = "Mã Dịch Vụ";
            this.MaDV.Name = "MaDV";
            // 
            // TenDV
            // 
            this.TenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDV.DataPropertyName = "TenDV";
            this.TenDV.HeaderText = "Tên Dịch Vụ";
            this.TenDV.Name = "TenDV";
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // NgaySuDung
            // 
            this.NgaySuDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySuDung.DataPropertyName = "NgaySuDung";
            this.NgaySuDung.HeaderText = "Ngày Sử Dụng";
            this.NgaySuDung.Name = "NgaySuDung";
            // 
            // frmGoiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(750, 406);
            this.Controls.Add(this.dgvDanhSachDV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGoiDichVu";
            this.Text = "frmGoiDichVu";
            this.Load += new System.EventHandler(this.frmGoiDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMaCTDV;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.TextBox txtMaCTDV;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblNgaySuDung;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.ComboBox cbMaDV;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.ComboBox cbMaPT;
        private System.Windows.Forms.DateTimePicker dtpNgaySuDung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcGia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySuDung;


    }
}