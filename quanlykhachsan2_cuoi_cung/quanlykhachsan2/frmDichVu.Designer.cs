namespace quanlykhachsan2
{
    partial class frmDichVu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.dtcMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtcMaNQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMaNQL = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbMaNQL = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcMaDV,
            this.dtcTenDV,
            this.dtcGia,
            this.dtcMaNQL});
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDichVu.Location = new System.Drawing.Point(0, 116);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(818, 299);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
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
            // dtcMaNQL
            // 
            this.dtcMaNQL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dtcMaNQL.DataPropertyName = "MaNQL";
            this.dtcMaNQL.HeaderText = "Mã Người Quản Lý";
            this.dtcMaNQL.Name = "dtcMaNQL";
            this.dtcMaNQL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(132, 9);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(145, 20);
            this.txtMaDV.TabIndex = 1;
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Location = new System.Drawing.Point(9, 9);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(63, 13);
            this.lblMaDV.TabIndex = 2;
            this.lblMaDV.Text = "Mã Dịch Vụ";
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Location = new System.Drawing.Point(351, 16);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(67, 13);
            this.lblTenDV.TabIndex = 3;
            this.lblTenDV.Text = "Tên Dịch Vụ";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(12, 47);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(23, 13);
            this.lblGia.TabIndex = 4;
            this.lblGia.Text = "Giá";
            // 
            // lblMaNQL
            // 
            this.lblMaNQL.AutoSize = true;
            this.lblMaNQL.Location = new System.Drawing.Point(351, 51);
            this.lblMaNQL.Name = "lblMaNQL";
            this.lblMaNQL.Size = new System.Drawing.Size(96, 13);
            this.lblMaNQL.TabIndex = 5;
            this.lblMaNQL.Text = "Mã Người Quản Lý";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(507, 13);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(145, 20);
            this.txtTenDV.TabIndex = 7;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(132, 44);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(145, 20);
            this.txtGia.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThem.ImageIndex = 65;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(225, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 38);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSua.ImageIndex = 13;
            this.btnSua.ImageList = this.imageList1;
            this.btnSua.Location = new System.Drawing.Point(150, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 38);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoa.ImageIndex = 68;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(0, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbMaNQL
            // 
            this.cbMaNQL.FormattingEnabled = true;
            this.cbMaNQL.Location = new System.Drawing.Point(507, 51);
            this.cbMaNQL.Name = "cbMaNQL";
            this.cbMaNQL.Size = new System.Drawing.Size(145, 21);
            this.cbMaNQL.TabIndex = 30;
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuu.ImageIndex = 71;
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(75, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 38);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMaDV);
            this.panel1.Controls.Add(this.txtMaDV);
            this.panel1.Controls.Add(this.cbMaNQL);
            this.panel1.Controls.Add(this.lblTenDV);
            this.panel1.Controls.Add(this.txtTenDV);
            this.panel1.Controls.Add(this.lblGia);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.lblMaNQL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 78);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 38);
            this.panel2.TabIndex = 34;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Oxygen-Icons.org-Oxygen-Actions-media-playback-pause.ico");
            this.imageList1.Images.SetKeyName(1, "Oxygen-Icons.org-Oxygen-Actions-media-playback-start.ico");
            this.imageList1.Images.SetKeyName(2, "Oxygen-Icons.org-Oxygen-Actions-media-playback-stop.ico");
            this.imageList1.Images.SetKeyName(3, "Oxygen-Icons.org-Oxygen-Actions-media-record.ico");
            this.imageList1.Images.SetKeyName(4, "Oxygen-Icons.org-Oxygen-Actions-media-seek-backward.ico");
            this.imageList1.Images.SetKeyName(5, "Oxygen-Icons.org-Oxygen-Actions-media-seek-forward.ico");
            this.imageList1.Images.SetKeyName(6, "Oxygen-Icons.org-Oxygen-Actions-media-skip-backward.ico");
            this.imageList1.Images.SetKeyName(7, "Oxygen-Icons.org-Oxygen-Actions-media-skip-forward.ico");
            this.imageList1.Images.SetKeyName(8, "Oxygen-Icons.org-Oxygen-Actions-page-zoom.ico");
            this.imageList1.Images.SetKeyName(9, "Oxygen-Icons.org-Oxygen-Actions-process-stop.ico");
            this.imageList1.Images.SetKeyName(10, "Oxygen-Icons.org-Oxygen-Actions-resource-group.ico");
            this.imageList1.Images.SetKeyName(11, "Oxygen-Icons.org-Oxygen-Actions-svn-commit.ico");
            this.imageList1.Images.SetKeyName(12, "Oxygen-Icons.org-Oxygen-Actions-system-log-out.ico");
            this.imageList1.Images.SetKeyName(13, "Oxygen-Icons.org-Oxygen-Actions-system-reboot.ico");
            this.imageList1.Images.SetKeyName(14, "Oxygen-Icons.org-Oxygen-Actions-system-run.ico");
            this.imageList1.Images.SetKeyName(15, "Oxygen-Icons.org-Oxygen-Actions-system-shutdown.ico");
            this.imageList1.Images.SetKeyName(16, "Oxygen-Icons.org-Oxygen-Actions-system-suspend.ico");
            this.imageList1.Images.SetKeyName(17, "Oxygen-Icons.org-Oxygen-Actions-system-suspend-hibernate.ico");
            this.imageList1.Images.SetKeyName(18, "Oxygen-Icons.org-Oxygen-Actions-system-switch-user.ico");
            this.imageList1.Images.SetKeyName(19, "Oxygen-Icons.org-Oxygen-Actions-user-group-delete.ico");
            this.imageList1.Images.SetKeyName(20, "Oxygen-Icons.org-Oxygen-Actions-user-group-new.ico");
            this.imageList1.Images.SetKeyName(21, "Oxygen-Icons.org-Oxygen-Actions-view-refresh.ico");
            this.imageList1.Images.SetKeyName(22, "Oxygen-Icons.org-Oxygen-Actions-view-statistics.ico");
            this.imageList1.Images.SetKeyName(23, "Oxygen-Icons.org-Oxygen-Actions-window-close.ico");
            this.imageList1.Images.SetKeyName(24, "Oxygen-Icons.org-Oxygen-Apps-device-notifier.ico");
            this.imageList1.Images.SetKeyName(25, "Oxygen-Icons.org-Oxygen-Apps-kchart.ico");
            this.imageList1.Images.SetKeyName(26, "Oxygen-Icons.org-Oxygen-Apps-office-address-book.ico");
            this.imageList1.Images.SetKeyName(27, "Oxygen-Icons.org-Oxygen-Apps-preferences-contact-list.ico");
            this.imageList1.Images.SetKeyName(28, "Oxygen-Icons.org-Oxygen-Apps-preferences-system-bluetooth.ico");
            this.imageList1.Images.SetKeyName(29, "Oxygen-Icons.org-Oxygen-Apps-preferences-system-bluetooth-inactive.ico");
            this.imageList1.Images.SetKeyName(30, "Oxygen-Icons.org-Oxygen-Emblems-emblem-important.ico");
            this.imageList1.Images.SetKeyName(31, "Oxygen-Icons.org-Oxygen-Status-weather-clear.ico");
            this.imageList1.Images.SetKeyName(32, "Oxygen-Icons.org-Oxygen-Status-weather-clear-night.ico");
            this.imageList1.Images.SetKeyName(33, "Oxygen-Icons.org-Oxygen-Status-weather-clouds.ico");
            this.imageList1.Images.SetKeyName(34, "Oxygen-Icons.org-Oxygen-Status-weather-clouds-night.ico");
            this.imageList1.Images.SetKeyName(35, "Oxygen-Icons.org-Oxygen-Status-weather-few-clouds.ico");
            this.imageList1.Images.SetKeyName(36, "Oxygen-Icons.org-Oxygen-Status-weather-few-clouds-night.ico");
            this.imageList1.Images.SetKeyName(37, "Oxygen-Icons.org-Oxygen-Status-weather-freezing-rain.ico");
            this.imageList1.Images.SetKeyName(38, "Oxygen-Icons.org-Oxygen-Status-weather-hail.ico");
            this.imageList1.Images.SetKeyName(39, "Oxygen-Icons.org-Oxygen-Status-weather-many-clouds.ico");
            this.imageList1.Images.SetKeyName(40, "Oxygen-Icons.org-Oxygen-Status-weather-showers.ico");
            this.imageList1.Images.SetKeyName(41, "Oxygen-Icons.org-Oxygen-Status-weather-showers-day.ico");
            this.imageList1.Images.SetKeyName(42, "Oxygen-Icons.org-Oxygen-Status-weather-showers-night.ico");
            this.imageList1.Images.SetKeyName(43, "Oxygen-Icons.org-Oxygen-Status-weather-showers-scattered.ico");
            this.imageList1.Images.SetKeyName(44, "Oxygen-Icons.org-Oxygen-Status-weather-showers-scattered-night.ico");
            this.imageList1.Images.SetKeyName(45, "Oxygen-Icons.org-Oxygen-Status-weather-snow-rain.ico");
            this.imageList1.Images.SetKeyName(46, "Oxygen-Icons.org-Oxygen-Status-weather-showers-scattered-day.ico");
            this.imageList1.Images.SetKeyName(47, "Oxygen-Icons.org-Oxygen-Status-weather-snow-scattered.ico");
            this.imageList1.Images.SetKeyName(48, "Oxygen-Icons.org-Oxygen-Status-weather-snow-scattered-day.ico");
            this.imageList1.Images.SetKeyName(49, "Oxygen-Icons.org-Oxygen-Status-weather-snow-scattered-night.ico");
            this.imageList1.Images.SetKeyName(50, "Oxygen-Icons.org-Oxygen-Status-weather-storm.ico");
            this.imageList1.Images.SetKeyName(51, "Oxygen-Icons.org-Oxygen-Status-weather-storm-day.ico");
            this.imageList1.Images.SetKeyName(52, "Oxygen-Icons.org-Oxygen-Status-weather-storm-night.ico");
            this.imageList1.Images.SetKeyName(53, "Swathin-Dota-2-Dota-2-3.ico");
            this.imageList1.Images.SetKeyName(54, "Swathin-Dota-2-Dota-2-4.ico");
            this.imageList1.Images.SetKeyName(55, "Treetog-I-Search.ico");
            this.imageList1.Images.SetKeyName(56, "Visualpharm-Must-Have-Log-Out.ico");
            this.imageList1.Images.SetKeyName(57, "Add.ico");
            this.imageList1.Images.SetKeyName(58, "3d bar chart.ico");
            this.imageList1.Images.SetKeyName(59, "accessories_calculator.ico");
            this.imageList1.Images.SetKeyName(60, "Add.ico");
            this.imageList1.Images.SetKeyName(61, "arrow first.ico");
            this.imageList1.Images.SetKeyName(62, "arrow last.ico");
            this.imageList1.Images.SetKeyName(63, "db cancel.ico");
            this.imageList1.Images.SetKeyName(64, "db delete.ico");
            this.imageList1.Images.SetKeyName(65, "db insert.ico");
            this.imageList1.Images.SetKeyName(66, "db post.ico");
            this.imageList1.Images.SetKeyName(67, "delete.ico");
            this.imageList1.Images.SetKeyName(68, "delete_over.ico");
            this.imageList1.Images.SetKeyName(69, "netprof.dll_I0bbe_0409.ico");
            this.imageList1.Images.SetKeyName(70, "refuse.ico");
            this.imageList1.Images.SetKeyName(71, "Save.ico");
            this.imageList1.Images.SetKeyName(72, "Refresh.ico");
            this.imageList1.Images.SetKeyName(73, "Right.ico");
            this.imageList1.Images.SetKeyName(74, "Oxygen-Icons.org-Oxygen-Actions-window-close.ico");
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(818, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDichVu);
            this.Name = "frmDichVu";
            this.Text = "frmDichVu";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMaNQL;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtcMaNQL;
        private System.Windows.Forms.ComboBox cbMaNQL;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
    }
}