namespace quanlykhachsan2
{
    partial class frmChiTietPhieuThue
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
            this.dgvChiTietPhieuThue = new System.Windows.Forms.DataGridView();
            this.dtcSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTienDatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtxTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblTienDatCoc = new System.Windows.Forms.Label();
            this.lblMaPT = new System.Windows.Forms.Label();
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuThue)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChiTietPhieuThue
            // 
            this.dgvChiTietPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcSoPhong,
            this.dtcMaPT,
            this.dtcTienDatCoc,
            this.dtxTrangThai});
            this.dgvChiTietPhieuThue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChiTietPhieuThue.Location = new System.Drawing.Point(0, 106);
            this.dgvChiTietPhieuThue.Name = "dgvChiTietPhieuThue";
            this.dgvChiTietPhieuThue.Size = new System.Drawing.Size(805, 397);
            this.dgvChiTietPhieuThue.TabIndex = 0;
            // 
            // dtcSoPhong
            // 
            this.dtcSoPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcSoPhong.DataPropertyName = "SoPhong";
            this.dtcSoPhong.HeaderText = "Số Phòng";
            this.dtcSoPhong.Name = "dtcSoPhong";
            this.dtcSoPhong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtcMaPT
            // 
            this.dtcMaPT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaPT.DataPropertyName = "MaPT";
            this.dtcMaPT.HeaderText = "Mã phiếu thuê";
            this.dtcMaPT.Name = "dtcMaPT";
            this.dtcMaPT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcMaPT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtcTienDatCoc
            // 
            this.dtcTienDatCoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcTienDatCoc.DataPropertyName = "TienDatCoc";
            this.dtcTienDatCoc.HeaderText = "Tiền Đặt Cọc";
            this.dtcTienDatCoc.Name = "dtcTienDatCoc";
            this.dtcTienDatCoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcTienDatCoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dtxTrangThai
            // 
            this.dtxTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtxTrangThai.DataPropertyName = "TrangThai";
            this.dtxTrangThai.HeaderText = "Trạng Thái";
            this.dtxTrangThai.Name = "dtxTrangThai";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(429, 70);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(59, 13);
            this.lblTrangThai.TabIndex = 16;
            this.lblTrangThai.Text = "Trạng Thái";
            // 
            // lblTienDatCoc
            // 
            this.lblTienDatCoc.AutoSize = true;
            this.lblTienDatCoc.Location = new System.Drawing.Point(43, 70);
            this.lblTienDatCoc.Name = "lblTienDatCoc";
            this.lblTienDatCoc.Size = new System.Drawing.Size(70, 13);
            this.lblTienDatCoc.TabIndex = 18;
            this.lblTienDatCoc.Text = "Tiền Đặt Cọc";
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(429, 22);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(80, 13);
            this.lblMaPT.TabIndex = 19;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(43, 18);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(54, 13);
            this.lblSoPhong.TabIndex = 20;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(613, 70);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(164, 20);
            this.txtTrangThai.TabIndex = 57;
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Location = new System.Drawing.Point(181, 63);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(164, 20);
            this.txtTienDatCoc.TabIndex = 59;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(613, 22);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(164, 20);
            this.txtMaPT.TabIndex = 60;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(181, 15);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(164, 20);
            this.txtSoPhong.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSoPhong);
            this.panel1.Controls.Add(this.txtTrangThai);
            this.panel1.Controls.Add(this.txtTienDatCoc);
            this.panel1.Controls.Add(this.lblTrangThai);
            this.panel1.Controls.Add(this.txtMaPT);
            this.panel1.Controls.Add(this.txtSoPhong);
            this.panel1.Controls.Add(this.lblTienDatCoc);
            this.panel1.Controls.Add(this.lblMaPT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 100);
            this.panel1.TabIndex = 62;
            // 
            // frmChiTietPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvChiTietPhieuThue);
            this.Name = "frmChiTietPhieuThue";
            this.Text = "frmChiTietPhieuThue";
            this.Load += new System.EventHandler(this.frmChiTietPhieuThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPhieuThue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietPhieuThue;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblTienDatCoc;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTienDatCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtxTrangThai;
        private System.Windows.Forms.Panel panel1;
    }
}