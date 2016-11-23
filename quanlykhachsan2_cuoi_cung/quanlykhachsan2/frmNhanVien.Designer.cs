namespace quanlykhachsan2
{
    partial class frmNhanVien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.dtcMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcQuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcSoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblQuocTich = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtQuocTich = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.cbMaDV = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaNV,
            this.dtcTenNV,
            this.dtcNgaySinh,
            this.dtcGT,
            this.dtcLuong,
            this.dtcQuocTich,
            this.dtcDiaChi,
            this.dtcSDT,
            this.dtcSoCMND,
            this.dtcMaDV});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 226);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(1102, 250);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // dtcMaNV
            // 
            this.dtcMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaNV.DataPropertyName = "MaNV";
            this.dtcMaNV.HeaderText = "Mã Nhân Viên";
            this.dtcMaNV.Name = "dtcMaNV";
            // 
            // dtcTenNV
            // 
            this.dtcTenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTenNV.DataPropertyName = "TenNV";
            this.dtcTenNV.HeaderText = "Tên Nhân Viên";
            this.dtcTenNV.Name = "dtcTenNV";
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
            // dtcLuong
            // 
            this.dtcLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcLuong.DataPropertyName = "Luong";
            this.dtcLuong.HeaderText = "Lương";
            this.dtcLuong.Name = "dtcLuong";
            // 
            // dtcQuocTich
            // 
            this.dtcQuocTich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcQuocTich.DataPropertyName = "QuocTich";
            this.dtcQuocTich.HeaderText = "Quốc Tịch";
            this.dtcQuocTich.Name = "dtcQuocTich";
            // 
            // dtcDiaChi
            // 
            this.dtcDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcDiaChi.DataPropertyName = "DiaChi";
            this.dtcDiaChi.HeaderText = "Địa Chỉ";
            this.dtcDiaChi.Name = "dtcDiaChi";
            // 
            // dtcSDT
            // 
            this.dtcSDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcSDT.DataPropertyName = "SDT";
            this.dtcSDT.HeaderText = "Số Điện Thoại";
            this.dtcSDT.Name = "dtcSDT";
            // 
            // dtcSoCMND
            // 
            this.dtcSoCMND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcSoCMND.DataPropertyName = "SoCMND";
            this.dtcSoCMND.HeaderText = "Số CMND";
            this.dtcSoCMND.Name = "dtcSoCMND";
            // 
            // dtcMaDV
            // 
            this.dtcMaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaDV.DataPropertyName = "MaDV";
            this.dtcMaDV.HeaderText = "Mã Dịch Vụ";
            this.dtcMaDV.Name = "dtcMaDV";
            this.dtcMaDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(114, 33);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(141, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(16, 40);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Location = new System.Drawing.Point(282, 151);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(63, 13);
            this.lblMaDV.TabIndex = 3;
            this.lblMaDV.Text = "Mã Dịch Vụ";
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.AutoSize = true;
            this.lblSoCMND.Location = new System.Drawing.Point(16, 142);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(55, 13);
            this.lblSoCMND.TabIndex = 4;
            this.lblSoCMND.Text = "Số CMND";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(544, 99);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.Location = new System.Drawing.Point(282, 96);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(75, 13);
            this.lblQuocTich.TabIndex = 6;
            this.lblQuocTich.Text = "Quốc Tịch";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(16, 96);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(37, 13);
            this.lblLuong.TabIndex = 7;
            this.lblLuong.Text = "Lương";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(787, 40);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(51, 13);
            this.lblGT.TabIndex = 8;
            this.lblGT.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(544, 40);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 9;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(278, 40);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(79, 13);
            this.lblTenNV.TabIndex = 10;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(782, 96);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(75, 13);
            this.lblSDT.TabIndex = 12;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(114, 142);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(141, 20);
            this.txtSoCMND.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(863, 89);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(141, 20);
            this.txtSDT.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(623, 89);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(141, 23);
            this.txtDiaChi.TabIndex = 17;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.Location = new System.Drawing.Point(380, 89);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.Size = new System.Drawing.Size(141, 20);
            this.txtQuocTich.TabIndex = 18;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(114, 86);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(141, 20);
            this.txtLuong.TabIndex = 19;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(380, 33);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(141, 20);
            this.txtTenNV.TabIndex = 22;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Yellow;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.Location = new System.Drawing.Point(150, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 42);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Yellow;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.Location = new System.Drawing.Point(75, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 42);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.Location = new System.Drawing.Point(0, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 42);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(623, 33);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(141, 20);
            this.dtpNgaySinh.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbGT);
            this.panel1.Controls.Add(this.cbMaDV);
            this.panel1.Controls.Add(this.lblMaNV);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.lblTenNV);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtSoCMND);
            this.panel1.Controls.Add(this.lblMaDV);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.lblSoCMND);
            this.panel1.Controls.Add(this.txtQuocTich);
            this.panel1.Controls.Add(this.txtLuong);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.lblNgaySinh);
            this.panel1.Controls.Add(this.lblGT);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.lblLuong);
            this.panel1.Controls.Add(this.lblQuocTich);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 184);
            this.panel1.TabIndex = 28;
            // 
            // cbGT
            // 
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGT.Location = new System.Drawing.Point(861, 32);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(141, 21);
            this.cbGT.TabIndex = 29;
            // 
            // cbMaDV
            // 
            this.cbMaDV.FormattingEnabled = true;
            this.cbMaDV.Location = new System.Drawing.Point(380, 143);
            this.cbMaDV.Name = "cbMaDV";
            this.cbMaDV.Size = new System.Drawing.Size(141, 21);
            this.cbMaDV.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 42);
            this.panel2.TabIndex = 29;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Yellow;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.Location = new System.Drawing.Point(225, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 42);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1102, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNhanVien);
            this.Name = "frmNhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcQuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaDV;
        private System.Windows.Forms.ComboBox cbMaDV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cbGT;
    }
}

