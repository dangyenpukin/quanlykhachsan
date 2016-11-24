namespace quanlykhachsan2
{
    partial class frmHuyPhong
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
            this.lblNgayDK = new System.Windows.Forms.Label();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.lblTienDatCoc = new System.Windows.Forms.Label();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.cbMaPT = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuyPhong = new System.Windows.Forms.Button();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(12, 41);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(53, 14);
            this.lblSoPhong.TabIndex = 22;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblMaPT
            // 
            this.lblMaPT.AutoSize = true;
            this.lblMaPT.Location = new System.Drawing.Point(12, 101);
            this.lblMaPT.Name = "lblMaPT";
            this.lblMaPT.Size = new System.Drawing.Size(77, 14);
            this.lblMaPT.TabIndex = 64;
            this.lblMaPT.Text = "Mã Phiếu Thuê";
            // 
            // lblNgayDK
            // 
            this.lblNgayDK.AutoSize = true;
            this.lblNgayDK.Location = new System.Drawing.Point(12, 179);
            this.lblNgayDK.Name = "lblNgayDK";
            this.lblNgayDK.Size = new System.Drawing.Size(77, 14);
            this.lblNgayDK.TabIndex = 66;
            this.lblNgayDK.Text = "Ngày Đăng Ký";
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDK.Location = new System.Drawing.Point(163, 171);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(164, 20);
            this.dtpNgayDK.TabIndex = 78;
            // 
            // lblTienDatCoc
            // 
            this.lblTienDatCoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTienDatCoc.Location = new System.Drawing.Point(12, 252);
            this.lblTienDatCoc.Name = "lblTienDatCoc";
            this.lblTienDatCoc.Size = new System.Drawing.Size(100, 25);
            this.lblTienDatCoc.TabIndex = 79;
            this.lblTienDatCoc.Text = "Tiền Đặt Cọc";
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.Location = new System.Drawing.Point(163, 251);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(164, 20);
            this.txtTienDatCoc.TabIndex = 80;
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Location = new System.Drawing.Point(163, 41);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(164, 22);
            this.cbSoPhong.TabIndex = 81;
            // 
            // cbMaPT
            // 
            this.cbMaPT.FormattingEnabled = true;
            this.cbMaPT.Location = new System.Drawing.Point(163, 98);
            this.cbMaPT.Name = "cbMaPT";
            this.cbMaPT.Size = new System.Drawing.Size(164, 22);
            this.cbMaPT.TabIndex = 82;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(339, 416);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 52);
            this.btnThoat.TabIndex = 83;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuyPhong
            // 
            this.btnHuyPhong.BackColor = System.Drawing.Color.Yellow;
            this.btnHuyPhong.Location = new System.Drawing.Point(89, 354);
            this.btnHuyPhong.Name = "btnHuyPhong";
            this.btnHuyPhong.Size = new System.Drawing.Size(75, 54);
            this.btnHuyPhong.TabIndex = 84;
            this.btnHuyPhong.Text = "Hủy Phòng";
            this.btnHuyPhong.UseVisualStyleBackColor = false;
            this.btnHuyPhong.Click += new System.EventHandler(this.btnHuyPhong_Click);
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(426, 88);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(77, 32);
            this.btnKiemTra.TabIndex = 85;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // frmHuyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(590, 495);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnHuyPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbMaPT);
            this.Controls.Add(this.cbSoPhong);
            this.Controls.Add(this.txtTienDatCoc);
            this.Controls.Add(this.lblTienDatCoc);
            this.Controls.Add(this.dtpNgayDK);
            this.Controls.Add(this.lblNgayDK);
            this.Controls.Add(this.lblMaPT);
            this.Controls.Add(this.lblSoPhong);
            this.Name = "frmHuyPhong";
            this.Text = "frmHuyPhong";
            this.Load += new System.EventHandler(this.frmHuyPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblMaPT;
        private System.Windows.Forms.Label lblNgayDK;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.Label lblTienDatCoc;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.ComboBox cbMaPT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuyPhong;
        private System.Windows.Forms.Button btnKiemTra;
    }
}