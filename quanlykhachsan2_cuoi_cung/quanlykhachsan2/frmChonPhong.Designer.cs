namespace quanlykhachsan2
{
    partial class frmChonPhong
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
            this.lblThongTinPhong = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.dgvCacPhongConTrong = new System.Windows.Forms.DataGridView();
            this.dtcSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.lblCacPhongConTrong = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaPT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numTienDatCoc = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacPhongConTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienDatCoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongTinPhong
            // 
            this.lblThongTinPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongTinPhong.Location = new System.Drawing.Point(22, 87);
            this.lblThongTinPhong.Name = "lblThongTinPhong";
            this.lblThongTinPhong.Size = new System.Drawing.Size(197, 23);
            this.lblThongTinPhong.TabIndex = 0;
            this.lblThongTinPhong.Text = "Chọn Phòng";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoPhong.Location = new System.Drawing.Point(12, 155);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(100, 23);
            this.lblSoPhong.TabIndex = 1;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(129, 155);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(120, 20);
            this.txtSoPhong.TabIndex = 7;
            // 
            // dgvCacPhongConTrong
            // 
            this.dgvCacPhongConTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCacPhongConTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcSoPhong,
            this.dctLoaiPhong,
            this.dtcGia,
            this.dtcMaNV,
            this.dtcTrangThai});
            this.dgvCacPhongConTrong.Location = new System.Drawing.Point(413, 70);
            this.dgvCacPhongConTrong.Name = "dgvCacPhongConTrong";
            this.dgvCacPhongConTrong.Size = new System.Drawing.Size(623, 548);
            this.dgvCacPhongConTrong.TabIndex = 13;
            this.dgvCacPhongConTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCacPhongConTrong_CellClick);
            // 
            // dtcSoPhong
            // 
            this.dtcSoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcSoPhong.DataPropertyName = "SoPhong";
            this.dtcSoPhong.HeaderText = "Số Phòng";
            this.dtcSoPhong.Name = "dtcSoPhong";
            // 
            // dctLoaiPhong
            // 
            this.dctLoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dctLoaiPhong.DataPropertyName = "LoaiPhong";
            this.dctLoaiPhong.HeaderText = "Loại Phòng";
            this.dctLoaiPhong.Name = "dctLoaiPhong";
            // 
            // dtcGia
            // 
            this.dtcGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcGia.DataPropertyName = "Gia";
            this.dtcGia.HeaderText = "Giá";
            this.dtcGia.Name = "dtcGia";
            // 
            // dtcMaNV
            // 
            this.dtcMaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaNV.DataPropertyName = "MaNV";
            this.dtcMaNV.HeaderText = "Mã Nhân Viên";
            this.dtcMaNV.Name = "dtcMaNV";
            // 
            // dtcTrangThai
            // 
            this.dtcTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTrangThai.DataPropertyName = "TrangThai";
            this.dtcTrangThai.HeaderText = "Trạng Thái";
            this.dtcTrangThai.Name = "dtcTrangThai";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.Yellow;
            this.btnKetThuc.Location = new System.Drawing.Point(231, 337);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(110, 42);
            this.btnKetThuc.TabIndex = 14;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // lblCacPhongConTrong
            // 
            this.lblCacPhongConTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCacPhongConTrong.Location = new System.Drawing.Point(648, 21);
            this.lblCacPhongConTrong.Name = "lblCacPhongConTrong";
            this.lblCacPhongConTrong.Size = new System.Drawing.Size(148, 23);
            this.lblCacPhongConTrong.TabIndex = 15;
            this.lblCacPhongConTrong.Text = "Các Phòng Còn Trống";
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.Yellow;
            this.btnDongY.Location = new System.Drawing.Point(26, 337);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(110, 42);
            this.btnDongY.TabIndex = 18;
            this.btnDongY.Text = "Đồng Ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(282, 139);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(110, 35);
            this.btnKiemTra.TabIndex = 31;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã Phiếu Thuê";
            // 
            // cbMaPT
            // 
            this.cbMaPT.FormattingEnabled = true;
            this.cbMaPT.Location = new System.Drawing.Point(129, 20);
            this.cbMaPT.Name = "cbMaPT";
            this.cbMaPT.Size = new System.Drawing.Size(121, 21);
            this.cbMaPT.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tiền Đặt Cọc";
            // 
            // numTienDatCoc
            // 
            this.numTienDatCoc.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTienDatCoc.Location = new System.Drawing.Point(129, 223);
            this.numTienDatCoc.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTienDatCoc.Name = "numTienDatCoc";
            this.numTienDatCoc.Size = new System.Drawing.Size(120, 20);
            this.numTienDatCoc.TabIndex = 35;
            this.numTienDatCoc.ThousandsSeparator = true;
            this.numTienDatCoc.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(129, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 36;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1038, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numTienDatCoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaPT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.lblCacPhongConTrong);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.dgvCacPhongConTrong);
            this.Controls.Add(this.txtSoPhong);
            this.Controls.Add(this.lblSoPhong);
            this.Controls.Add(this.lblThongTinPhong);
            this.Name = "frmChonPhong";
            this.Text = "Chọn Phòng";
            this.Load += new System.EventHandler(this.frmChonPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCacPhongConTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienDatCoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongTinPhong;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.DataGridView dgvCacPhongConTrong;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label lblCacPhongConTrong;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTienDatCoc;
        private System.Windows.Forms.Button button1;
    }
}