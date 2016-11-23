namespace quanlykhachsan2
{
    partial class frmKhachHang
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
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.dtcMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcSoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcQuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblQuocTich = new System.Windows.Forms.Label();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.txtNgheNghiep = new System.Windows.Forms.TextBox();
            this.lblNgheNghiep = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaKH,
            this.dtcTenKH,
            this.dtcNgaySinh,
            this.dtcGT,
            this.dtcSDT,
            this.dtcSoCMND,
            this.dtcDiaChi,
            this.dtcNgheNghiep,
            this.dtcQuocTich});
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 158);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.Size = new System.Drawing.Size(1103, 337);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // dtcMaKH
            // 
            this.dtcMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaKH.DataPropertyName = "MaKH";
            this.dtcMaKH.HeaderText = "Mã Khách Hàng ";
            this.dtcMaKH.Name = "dtcMaKH";
            // 
            // dtcTenKH
            // 
            this.dtcTenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTenKH.DataPropertyName = "TenKH";
            this.dtcTenKH.HeaderText = "Tên Khách Hàng";
            this.dtcTenKH.Name = "dtcTenKH";
            // 
            // dtcNgaySinh
            // 
            this.dtcNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgaySinh.DataPropertyName = "NgaySinh";
            this.dtcNgaySinh.HeaderText = "Ngày Sinh";
            this.dtcNgaySinh.Name = "dtcNgaySinh";
            // 
            // dtcGT
            // 
            this.dtcGT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcGT.DataPropertyName = "GT";
            this.dtcGT.HeaderText = "Giới Tính";
            this.dtcGT.Name = "dtcGT";
            // 
            // dtcSDT
            // 
            this.dtcSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcSDT.DataPropertyName = "SDT";
            this.dtcSDT.HeaderText = "SĐT";
            this.dtcSDT.Name = "dtcSDT";
            // 
            // dtcSoCMND
            // 
            this.dtcSoCMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcSoCMND.DataPropertyName = "SoCMND";
            this.dtcSoCMND.HeaderText = "Số CMND";
            this.dtcSoCMND.Name = "dtcSoCMND";
            // 
            // dtcDiaChi
            // 
            this.dtcDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dtcDiaChi.DataPropertyName = "DiaChi";
            this.dtcDiaChi.HeaderText = "Địa Chỉ";
            this.dtcDiaChi.Name = "dtcDiaChi";
            this.dtcDiaChi.Width = 48;
            // 
            // dtcNgheNghiep
            // 
            this.dtcNgheNghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgheNghiep.DataPropertyName = "NgheNghiep";
            this.dtcNgheNghiep.HeaderText = "Nghề Nghiệp";
            this.dtcNgheNghiep.Name = "dtcNgheNghiep";
            // 
            // dtcQuocTich
            // 
            this.dtcQuocTich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcQuocTich.DataPropertyName = "QuocTich";
            this.dtcQuocTich.HeaderText = "Quốc Tịch";
            this.dtcQuocTich.Name = "dtcQuocTich";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(3, 15);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(85, 13);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã Khách Hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(110, 8);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.Location = new System.Drawing.Point(232, 11);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(104, 17);
            this.lblTenKH.TabIndex = 14;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(358, 8);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 20);
            this.txtTenKH.TabIndex = 24;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(480, 15);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 25;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(558, 8);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(102, 20);
            this.dtpNgaySinh.TabIndex = 28;
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(682, 15);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(51, 13);
            this.lblGT.TabIndex = 29;
            this.lblGT.Text = "Giới Tính";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(3, 82);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(75, 13);
            this.lblSDT.TabIndex = 31;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(110, 75);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(102, 20);
            this.txtSDT.TabIndex = 32;
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.AutoSize = true;
            this.lblSoCMND.Location = new System.Drawing.Point(232, 82);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(55, 13);
            this.lblSoCMND.TabIndex = 33;
            this.lblSoCMND.Text = "Số CMND";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(356, 75);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(102, 20);
            this.txtSoCMND.TabIndex = 34;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(480, 82);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChi.TabIndex = 35;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(558, 75);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(102, 20);
            this.txtDiaChi.TabIndex = 36;
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.Location = new System.Drawing.Point(682, 82);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(75, 13);
            this.lblQuocTich.TabIndex = 37;
            this.lblQuocTich.Text = "Quốc Tịch";
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Location = new System.Drawing.Point(763, 75);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(121, 20);
            this.txtQuocTich.TabIndex = 38;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.Location = new System.Drawing.Point(990, 8);
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Size = new System.Drawing.Size(102, 20);
            this.txtNgheNghiep.TabIndex = 39;
            // 
            // lblNgheNghiep
            // 
            this.lblNgheNghiep.AutoSize = true;
            this.lblNgheNghiep.Location = new System.Drawing.Point(898, 15);
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(70, 13);
            this.lblNgheNghiep.TabIndex = 40;
            this.lblNgheNghiep.Text = "Nghề Nghiệp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1103, 43);
            this.panel2.TabIndex = 41;
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.Location = new System.Drawing.Point(201, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(61, 43);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.Location = new System.Drawing.Point(124, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 43);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.Location = new System.Drawing.Point(64, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 43);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.Location = new System.Drawing.Point(0, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 43);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbGT);
            this.panel1.Controls.Add(this.lblQuocTich);
            this.panel1.Controls.Add(this.txtQuocTich);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.lblMaKH);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Controls.Add(this.lblNgaySinh);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.lblGT);
            this.panel1.Controls.Add(this.txtSoCMND);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.lblSoCMND);
            this.panel1.Controls.Add(this.txtNgheNghiep);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.lblNgheNghiep);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 117);
            this.panel1.TabIndex = 42;
            // 
            // cbGT
            // 
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGT.Location = new System.Drawing.Point(755, 7);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(121, 21);
            this.cbGT.TabIndex = 41;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1103, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvKhachHang);
            this.Name = "frmKhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.TextBox txtNgheNghiep;
        private System.Windows.Forms.Label lblNgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcQuocTich;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbGT;
    }
}