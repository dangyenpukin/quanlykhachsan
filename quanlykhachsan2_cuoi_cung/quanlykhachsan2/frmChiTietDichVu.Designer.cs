namespace quanlykhachsan2
{
    partial class frmChiTietDichVu
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
            this.dgvChiTietDichVu = new System.Windows.Forms.DataGridView();
            this.dtcMaCTDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgaySuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNgaySuDung = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.lblMaCTDV = new System.Windows.Forms.Label();
            this.txtMaCTDV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.dtpNgaySuDung = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChiTietDichVu
            // 
            this.dgvChiTietDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaCTDV,
            this.dtcMaDV,
            this.dtcMaPT,
            this.dtcSoPhong,
            this.dtcGia,
            this.dtcNgaySuDung});
            this.dgvChiTietDichVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChiTietDichVu.Location = new System.Drawing.Point(0, 100);
            this.dgvChiTietDichVu.Name = "dgvChiTietDichVu";
            this.dgvChiTietDichVu.Size = new System.Drawing.Size(1104, 391);
            this.dgvChiTietDichVu.TabIndex = 0;
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
            this.dtcMaDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaDV.DataPropertyName = "MaDV";
            this.dtcMaDV.HeaderText = "Mã Dịch Vụ";
            this.dtcMaDV.Name = "dtcMaDV";
            this.dtcMaDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtcMaPT
            // 
            this.dtcMaPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaPT.DataPropertyName = "MaPT";
            this.dtcMaPT.HeaderText = "Mã Phiếu Thuê";
            this.dtcMaPT.Name = "dtcMaPT";
            this.dtcMaPT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcMaPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtcSoPhong
            // 
            this.dtcSoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcSoPhong.DataPropertyName = "SoPhong";
            this.dtcSoPhong.HeaderText = "Số Phòng";
            this.dtcSoPhong.Name = "dtcSoPhong";
            this.dtcSoPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcSoPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // lblNgaySuDung
            // 
            this.lblNgaySuDung.AutoSize = true;
            this.lblNgaySuDung.Location = new System.Drawing.Point(393, 61);
            this.lblNgaySuDung.Name = "lblNgaySuDung";
            this.lblNgaySuDung.Size = new System.Drawing.Size(77, 13);
            this.lblNgaySuDung.TabIndex = 5;
            this.lblNgaySuDung.Text = "Ngày Sử Dụng";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(46, 61);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(23, 13);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Giá";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(757, 9);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(54, 13);
            this.lblSoPhong.TabIndex = 7;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(393, 9);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(80, 13);
            this.lblMaPT.TabIndex = 8;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Location = new System.Drawing.Point(46, 9);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(63, 13);
            this.lblMaDV.TabIndex = 9;
            this.lblMaDV.Text = "Mã Dịch Vụ";
            // 
            // lblMaCTDV
            // 
            this.lblMaCTDV.AutoSize = true;
            this.lblMaCTDV.Location = new System.Drawing.Point(776, 74);
            this.lblMaCTDV.Name = "lblMaCTDV";
            this.lblMaCTDV.Size = new System.Drawing.Size(102, 13);
            this.lblMaCTDV.TabIndex = 10;
            this.lblMaCTDV.Text = "Mã Chi Tiết Dịch Vụ";
            // 
            // txtMaCTDV
            // 
            this.txtMaCTDV.Location = new System.Drawing.Point(928, 74);
            this.txtMaCTDV.Name = "txtMaCTDV";
            this.txtMaCTDV.Size = new System.Drawing.Size(164, 20);
            this.txtMaCTDV.TabIndex = 11;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(169, 9);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(164, 20);
            this.txtMaDV.TabIndex = 12;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(533, 9);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(164, 20);
            this.txtMaPT.TabIndex = 13;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(871, 9);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(164, 20);
            this.txtSoPhong.TabIndex = 14;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(169, 54);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(164, 20);
            this.txtGia.TabIndex = 15;
            // 
            // dtpNgaySuDung
            // 
            this.dtpNgaySuDung.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySuDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySuDung.Location = new System.Drawing.Point(533, 54);
            this.dtpNgaySuDung.Name = "dtpNgaySuDung";
            this.dtpNgaySuDung.Size = new System.Drawing.Size(164, 20);
            this.dtpNgaySuDung.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaDV);
            this.panel1.Controls.Add(this.dtpNgaySuDung);
            this.panel1.Controls.Add(this.txtMaDV);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.lblMaPT);
            this.panel1.Controls.Add(this.lblNgaySuDung);
            this.panel1.Controls.Add(this.txtSoPhong);
            this.panel1.Controls.Add(this.txtMaPT);
            this.panel1.Controls.Add(this.lblGia);
            this.panel1.Controls.Add(this.lblSoPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 94);
            this.panel1.TabIndex = 52;
            // 
            // frmChiTietDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1104, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMaCTDV);
            this.Controls.Add(this.lblMaCTDV);
            this.Controls.Add(this.dgvChiTietDichVu);
            this.Name = "frmChiTietDichVu";
            this.Text = "ChiTietDichVu";
            this.Load += new System.EventHandler(this.frmChiTietDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDichVu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietDichVu;
        private System.Windows.Forms.Label lblNgaySuDung;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.Label lblMaCTDV;
        private System.Windows.Forms.TextBox txtMaCTDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DateTimePicker dtpNgaySuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaCTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgaySuDung;
        private System.Windows.Forms.Panel panel1;
    }
}