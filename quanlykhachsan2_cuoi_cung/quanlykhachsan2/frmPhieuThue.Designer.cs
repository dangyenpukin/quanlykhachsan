namespace quanlykhachsan2
{
    partial class frmPhieuThue
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
            this.dgvPhieuThue = new System.Windows.Forms.DataGridView();
            this.dtcMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcNgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtcTongSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongSoPhong = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.lblNgayDK = new System.Windows.Forms.Label();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.txtTongSoPhong = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThue)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhieuThue
            // 
            this.dgvPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaPT,
            this.dtcNgayDK,
            this.dtcNgayDen,
            this.dtcMaKH,
            this.dtcTongSoPhong});
            this.dgvPhieuThue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieuThue.Location = new System.Drawing.Point(0, 106);
            this.dgvPhieuThue.Name = "dgvPhieuThue";
            this.dgvPhieuThue.Size = new System.Drawing.Size(1073, 378);
            this.dgvPhieuThue.TabIndex = 0;
            // 
            // dtcMaPT
            // 
            this.dtcMaPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaPT.DataPropertyName = "MaPT";
            this.dtcMaPT.HeaderText = "Mã Phiếu Thuê";
            this.dtcMaPT.Name = "dtcMaPT";
            // 
            // dtcNgayDK
            // 
            this.dtcNgayDK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgayDK.DataPropertyName = "NgayDK";
            this.dtcNgayDK.HeaderText = "Ngày Đăng Ký";
            this.dtcNgayDK.Name = "dtcNgayDK";
            // 
            // dtcNgayDen
            // 
            this.dtcNgayDen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcNgayDen.DataPropertyName = "NgayDen";
            this.dtcNgayDen.HeaderText = "Ngày Đến";
            this.dtcNgayDen.Name = "dtcNgayDen";
            // 
            // dtcMaKH
            // 
            this.dtcMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaKH.DataPropertyName = "MaKH";
            this.dtcMaKH.HeaderText = "Mã Khách Hàng";
            this.dtcMaKH.Name = "dtcMaKH";
            this.dtcMaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcMaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtcTongSoPhong
            // 
            this.dtcTongSoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTongSoPhong.DataPropertyName = "TongSoPhong";
            this.dtcTongSoPhong.HeaderText = "Tổng Số Phòng";
            this.dtcTongSoPhong.Name = "dtcTongSoPhong";
            // 
            // lblTongSoPhong
            // 
            this.lblTongSoPhong.AutoSize = true;
            this.lblTongSoPhong.Location = new System.Drawing.Point(364, 66);
            this.lblTongSoPhong.Name = "lblTongSoPhong";
            this.lblTongSoPhong.Size = new System.Drawing.Size(82, 13);
            this.lblTongSoPhong.TabIndex = 11;
            this.lblTongSoPhong.Text = "Tổng Số Phòng";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(12, 66);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(85, 13);
            this.lblMaKH.TabIndex = 12;
            this.lblMaKH.Text = "Mã Khách Hàng";
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.Location = new System.Drawing.Point(766, 19);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(55, 13);
            this.lblNgayDen.TabIndex = 13;
            this.lblNgayDen.Text = "Ngày Đến";
            // 
            // lblNgayDK
            // 
            this.lblNgayDK.AutoSize = true;
            this.lblNgayDK.Location = new System.Drawing.Point(364, 12);
            this.lblNgayDK.Name = "lblNgayDK";
            this.lblNgayDK.Size = new System.Drawing.Size(76, 13);
            this.lblNgayDK.TabIndex = 14;
            this.lblNgayDK.Text = "Ngày Đăng Ký";
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(12, 9);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(80, 13);
            this.lblMaPT.TabIndex = 15;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDK.Location = new System.Drawing.Point(498, 12);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDK.TabIndex = 52;
            // 
            // txtTongSoPhong
            // 
            this.txtTongSoPhong.Location = new System.Drawing.Point(498, 63);
            this.txtTongSoPhong.Name = "txtTongSoPhong";
            this.txtTongSoPhong.Size = new System.Drawing.Size(164, 20);
            this.txtTongSoPhong.TabIndex = 53;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(122, 66);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(164, 20);
            this.txtMaKH.TabIndex = 54;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(122, 9);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(164, 20);
            this.txtMaPT.TabIndex = 56;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen.Location = new System.Drawing.Point(866, 13);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDen.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaPT);
            this.panel1.Controls.Add(this.txtTongSoPhong);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.lblTongSoPhong);
            this.panel1.Controls.Add(this.dtpNgayDen);
            this.panel1.Controls.Add(this.txtMaPT);
            this.panel1.Controls.Add(this.lblMaKH);
            this.panel1.Controls.Add(this.lblNgayDK);
            this.panel1.Controls.Add(this.dtpNgayDK);
            this.panel1.Controls.Add(this.lblNgayDen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 100);
            this.panel1.TabIndex = 62;
            // 
            // frmPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPhieuThue);
            this.Name = "frmPhieuThue";
            this.Text = "PhieuThue";
            this.Load += new System.EventHandler(this.frmPhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgayDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcNgayDen;
        private System.Windows.Forms.DataGridViewComboBoxColumn dtcMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTongSoPhong;
        private System.Windows.Forms.Label lblTongSoPhong;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Label lblNgayDK;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.TextBox txtTongSoPhong;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Panel panel1;
    }
}