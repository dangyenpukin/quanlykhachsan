using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSanBUS;
using QuanLyKhachSanEntity;
using PhanQuyen;
namespace quanlykhachsan2
{
    public partial class frmTrangChu : Form
    {
        public static string TenTK=string.Empty;
        public static string PhanQuyen = string.Empty;

        public frmTrangChu()
        {
            InitializeComponent();
        }
        BUS_KhachHang buskh = new BUS_KhachHang();
        EC_KhachHang eckh = new EC_KhachHang();
        BUS_Phong busp = new BUS_Phong();
        EC_Phong ecp = new EC_Phong();
        BUS_PhieuThue buspt = new BUS_PhieuThue();
        EC_PhieuThue ecpt = new EC_PhieuThue();
        EC_ChiTietPhieuThue ecctpt = new EC_ChiTietPhieuThue();
        BUS_ChiTietPhieuThue busctpt = new BUS_ChiTietPhieuThue();
        BUS_ChiTietHoaDon buscthd = new BUS_ChiTietHoaDon();
        EC_ChiTietHoaDon eccthd = new EC_ChiTietHoaDon();
        int KT = 0;
        int KiemTra = 0;
       
  
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if(_Phanquyen.Phanquyen==0)
            {
                btnDoanhThuDV.Enabled = false;
                btnDoanhThuTienPhong.Enabled = false;
            }
            lsvPhong.Clear();
            LoadTTPhong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Khỏi Chương Trình Không?","THOÁT",MessageBoxButtons.YesNo,MessageBoxIcon.Question )== DialogResult.Yes)
            {
                Close();
                System.Windows.Forms.Application.Exit();
            }
        }

      

      

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnDat.Enabled = false;
            KT = 0;
            cbMaPT.Enabled = true;
            txtSoCMND.Enabled = false;
            btnTimKiem.Enabled = false;
            txtSoPhong2.Enabled = false;
            txtTrangThaiPhong.Enabled = false;
            txtMaKH.Enabled = false;
            txtSoPhong.Enabled = false;

            txtTenKH.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbGT.Enabled = false;
            txtQuocTich.Enabled = false;
            txtNgheNghiep.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;

            cbMaPT.Text = "";
            cbMaPT.DataSource = busctpt.LayThongTinPT_ChuaNhan();
            cbMaPT.DisplayMember = "MaPT";
            cbMaPT.ValueMember = "MaPT";
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KT = 1;
            cbMaPT.Enabled = true;
            cbMaPT.Text = "";
            cbMaPT.DataSource = busctpt.LayThongTinPT_TatCaChuaNhan();//chưa có phòng nào ở trạng thái đang ở,chưa có phòng nào trả rồi
            cbMaPT.DisplayMember = "MaPT";
            cbMaPT.ValueMember = "MaPT";
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnTra.Enabled = true;
            cbMaPT.Enabled = true;
            cbMaPT.Text = "";
            cbMaPT.DataSource = busctpt.LayThongTinPT_ChuaTra();
            cbMaPT.DisplayMember = "MaPT";
            cbMaPT.ValueMember = "MaPT";
            KT = 2;
            cbMaNV.DataSource = buscthd.LayThongTinNV("");
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUocTinhChiPhi _frmUocTinhChiPhi = new frmUocTinhChiPhi();
            _frmUocTinhChiPhi.Show();
            Hide();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThanhToanHD.Enabled = true;
            cbMaPT.Enabled = true;
            cbMaPT.Text = "";
            cbMaPT.DataSource = busctpt.LayThongTinPT_TatCaDaTra();
            cbMaPT.DisplayMember = "MaPT";
            cbMaPT.ValueMember = "MaPT";
            KT = 3;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoaDon _frmHoaDon = new frmHoaDon();
            _frmHoaDon.Show();
            Hide();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhieuThue _frmPhieuThue = new frmPhieuThue();
            _frmPhieuThue.Show();
            Hide();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChiTietHoaDon _frmChiTietHoaDon = new frmChiTietHoaDon();
            _frmChiTietHoaDon.Show();
            Hide();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChiTietPhieuThue _frmChiTietPhieuThue = new frmChiTietPhieuThue();
            _frmChiTietPhieuThue.Show();
            Hide();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChiTietDichVu _frmChiTietDichVu = new frmChiTietDichVu();
            _frmChiTietDichVu.Show();
            Hide();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDichVu _frmDichVu = new frmDichVu();
            _frmDichVu.Show();
            Hide();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien _frmNhanVien = new frmNhanVien();
            _frmNhanVien.Show();
           
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang _frmKhachHang = new frmKhachHang();
            _frmKhachHang.Show();
            Hide();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhong _frmPhong = new frmPhong();
            _frmPhong.Show();
            Hide();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cbMaPT.Enabled = true;
            cbMaPT.Text = "";
            KT = 0;
            cbMaPT.DataSource = busctpt.LayThongTinPT_ChuaNhan();
            cbMaPT.DisplayMember = "MaPT";
            cbMaPT.ValueMember = "MaPT";
        }

        private void btnDoanhThuDV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoanhThuDV frm = new frmDoanhThuDV();
            frm.Show();
            Hide();
        }

        private void btnDoanhThuTienPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoanhThuTienPhong frm = new frmDoanhThuTienPhong();
            frm.Show();
            Hide();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAccountManagement frm = new frmAccountManagement();
            frm.Show();
            Hide();
        }

        private void btnGoiDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnGoiDV.Enabled = true;
            cbMaPT.Enabled = true;
            cbMaPT.Text = "";
            cbMaPT.DataSource = busctpt.LayThongTinPT_ChuaTra();
            cbMaPT.DisplayMember = "MaPT";
            cbMaPT.ValueMember = "MaPT";
            KT = 1;
        }

      
        ListViewItem itemSelect;
        private void lsvPhong_Click(object sender, EventArgs e)
        {
            try
            {
                itemSelect = lsvPhong.SelectedItems[0];
                foreach (ListViewItem item in lsvPhong.SelectedItems)
                {
                    ecp.SoPhong = item.SubItems[0].Text;
                    if(busp.TrangThai(ecp)=="Trống")
                        txtSoPhong.Text = item.SubItems[0].Text;
                    else
                    {
                        MessageBox.Show("Phòng Không Ở Trạng Thái Trống, Vui Lòng Chọn Lại " );
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhoaDieuKien();
            btnDat.Enabled = true;
            btnDangKy.Enabled = true;
            btnXoa.Enabled = true;
            btnTimKiem.Enabled = true;
         
            txtSoCMND.Enabled = true;
            dtpNgayDen.Enabled = true;
            dtpNgayDK.Enabled = true;
            numTienDatCoc.Enabled = true;
            btnDat.Enabled = true;
           
            SetNull();
            int mapt;
            if (buspt.CountID() == 1)
            {
                mapt = (int.Parse(buspt.GetLastID()) + 1);
            }
            else
            {
                mapt = 0;
            }
            cbMaPT.Text = mapt.ToString();

        }


        void KhoaDieuKien()
        {
           
            txtSoPhong2.Enabled = false;
          
            cbMaPT.Enabled = false;
            txtMaKH.Enabled = false;
            txtSoPhong.Enabled = false;
           
            txtTenKH.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbGT.Enabled = false;
            txtQuocTich.Enabled = false;
            txtNgheNghiep.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;

           
        }
        private void LoadTTPhong()
        {
            DataTable dt = busp.TaoBangP("");
            lsvPhong.View = View.Details;
            lsvPhong.Columns.Add("Phòng", 50, HorizontalAlignment.Left);
            lsvPhong.Columns.Add("Loại Phòng", 50, HorizontalAlignment.Left);
            lsvPhong.Columns.Add("Giá", 50, HorizontalAlignment.Left);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int t=0;
                if (dt.Rows[i][3].ToString() == "Đang Ở") t = 1;
                if (dt.Rows[i][3].ToString() == "Đã Thuê") t = 2;
                ListViewItem lvi = new ListViewItem(dt.Rows[i][0].ToString(),t);
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
               // ListViewItem.ListViewSubItem sub1 = new ListViewItem.ListViewSubItem(lvi, dt.Rows[i][1].ToString());
               // ListViewItem.ListViewSubItem sub2 = new ListViewItem.ListViewSubItem(lvi, dt.Rows[i][2].ToString());
                //lvi.SubItems.Add(sub1);
               // lvi.SubItems.Add(sub2);
                lsvPhong.Items.Add(lvi);
                //lvi.UseItemStyleForSubItems = true;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbMaPT.Text == "" || dtpNgayDK.Text == "" || dtpNgayDen.Text == "" || txtMaKH.Text == "" || txtTenKH.Text == "" || dtpNgaySinh.Text == "" || cbGT.Text == "" || txtSDT.Text == "" || txtSoCMND.Text == "" || txtDiaChi.Text == "" || txtNgheNghiep.Text == "" || txtNgheNghiep.Text == "" || txtQuocTich.Text == "" || dtpNgayDen.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin");
                return;
            }
            TimeSpan Time = DateTime.ParseExact(dtpNgayDen.Text, "dd/MM/yyyy", null) - DateTime.ParseExact(dtpNgayDK.Text, "dd/MM/yyyy", null);
            int TongSoNgay = Time.Days;
            if (TongSoNgay > 10)
            {
                MessageBox.Show("Khách Sạn Chỉ Cho Đặt Phòng Trước 10 Ngày");
                return;
            }
            if (TongSoNgay < 0)
            {
                MessageBox.Show("Nhập Ngày Đến Không Hợp Lệ");
                return;
            }
            if (KiemTra == 0)
            {
                try
                {
                    eckh.MaKH = txtMaKH.Text;
                    eckh.TenKH = txtTenKH.Text;
                    eckh.NgaySinh = DateTime.ParseExact(dtpNgaySinh.Text, "dd/MM/yyyy", null);
                    eckh.GT = cbGT.Text;
                    eckh.SDT = txtSDT.Text;
                    eckh.SoCMND = txtSoCMND.Text;
                    eckh.DiaChi = txtDiaChi.Text;
                    eckh.NgheNghiep = txtNgheNghiep.Text;
                    eckh.QuocTich = txtQuocTich.Text;
                    ecpt.MaPT = cbMaPT.Text;
                    ecpt.NgayDK = DateTime.ParseExact(dtpNgayDK.Text, "dd/MM/yyyy", null);
                    ecpt.NgayDen = DateTime.ParseExact(dtpNgayDen.Text, "dd/MM/yyyy", null);
                    ecpt.MaKH = txtMaKH.Text;

                    if (buskh.ThemDuLieu(eckh) == 1)
                    {
                        MessageBox.Show("Đã Thêm Khách Hàng Thành Công");

                        if (buspt.ThemDuLieu(ecpt) == 1)
                        {
                            MessageBox.Show("Đã Thêm Phiếu Thuê Thành Công");
                            btnDat.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm Mới Không Thành Công");
                    }

                }
                catch
                {
                    MessageBox.Show("Thêm Mới Không Thành Công");
                    return;
                }
            }
            else
            {
                ecpt.MaPT = cbMaPT.Text;
                ecpt.NgayDK = DateTime.ParseExact(dtpNgayDK.Text, "dd/MM/yyyy", null);
                ecpt.NgayDen = DateTime.ParseExact(dtpNgayDen.Text, "dd/MM/yyyy", null);
                ecpt.MaKH = txtMaKH.Text;
                if (buspt.ThemDuLieu(ecpt) == 1)
                {
                    MessageBox.Show("Đã Thêm Phiếu Thuê Thành Công");
                    btnDat.Enabled = true;
                    
                }
            }

            
        }
        void SetNull()
        {
            dtpNgayDen.Text = "";
            dtpNgayDK.Text = "";
            txtSoCMND.Text = "";
            cbMaPT.Text = "";
            txtMaKH.Text = "";
            btnXoa.Text = "";
            txtSoPhong.Text = "";
            numTienDatCoc.Text = "";
            txtTenKH.Text = "";
            dtpNgaySinh.Text = "";
            cbGT.Text = "";
            txtQuocTich.Text = "";
            txtNgheNghiep.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            if (cbMaPT.Text == "" || numTienDatCoc.Text == "" || txtSoPhong.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Dữ Liệu");
                return;
            }

            try
            {
                ecctpt.SoPhong = txtSoPhong.Text;
                ecctpt.MaPT = cbMaPT.Text;
                ecctpt.TrangThai = "Chưa Trả";
                ecctpt.TienDatCoc = numTienDatCoc.Value.ToString();
                int n = busctpt.ThemDuLieu(ecctpt);
                if (n == 1)
                {
                    ecp.SoPhong = txtSoPhong.Text;
                    busp.UpDate_TrangThaiDaThue(ecp);//update trạng thái của phòng thành đã thuê
                    MessageBox.Show("Đã Thêm Chi Tiết Phiếu Thuê Mới Thành Công");
                   
                }
                else
                {
                    MessageBox.Show("Không Thành Công");
                }

            }
            catch
            {
                MessageBox.Show("Thêm Mới Không Thành Công");
                return;
            }

            LoadDSCTPT();
            SetNull1();
            lsvPhong.Clear();
            LoadTTPhong();
           
        }
        void LoadDSCTPT()
        {
            ecctpt.MaPT = cbMaPT.Text;
            dgvChiTietPhieuThue.DataSource = busctpt.TaoBangCTPT(ecctpt);
        }
        void SetNull1()
        {
            txtSoPhong.Text = "";
            numTienDatCoc.Value.ToString();
        }
     

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSoPhong2.Text=="")
                {
                    MessageBox.Show("Chưa Nhập Số Phòng");
                    return;
                }
                if (txtTrangThaiPhong.Text == "Đang Ở")
                {
                    MessageBox.Show("Phòng Đang Có Người Ở, Bạn Không Có Quyền Hủy");
                    return;
                }
                if (txtTrangThaiPhong.Text == "Trống")
                {
                    MessageBox.Show("Phòng Đã Trả Bạn Không Có Quyền Hủy");
                    return;
                }
                ecp.SoPhong = txtSoPhong2.Text;
                ecctpt.SoPhong = txtSoPhong2.Text;
                ecctpt.MaPT = cbMaPT.Text;
                busctpt.XoaDuLieu(ecctpt);
                busp.UpDate_TrangThaiTrong(ecp);
                LoadDSCTPT();
                lsvPhong.Clear();
                LoadTTPhong();
                MessageBox.Show("Hủy Phòng Thành Công");
                txtSoPhong2.Text = "";
                txtTrangThaiPhong.Text = "";
            }
            catch
            {
                MessageBox.Show("Hủy Phòng Không Thành Công");
                return;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtSoCMND.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Chứng Minh Nhân Dân");
                return;
            }
            KiemTra = 0;
            if (txtSoCMND.Text != "")
            {
                int t = 0;
                DataTable dt = buskh.TaoBang("");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["SoCMND"].ToString() == txtSoCMND.Text)
                    {
                        MessageBox.Show("Đã Có Sẵn Thông Tin Của Khách Hàng");
                        t = 1;
                        txtMaKH.Text = dt.Rows[i]["MaKH"].ToString();
                        txtTenKH.Text = dt.Rows[i]["TenKH"].ToString();
                        dtpNgaySinh.Text = dt.Rows[i]["NgaySinh"].ToString();
                        cbGT.Text = dt.Rows[i]["GT"].ToString();
                        txtSDT.Text = dt.Rows[i]["SDT"].ToString();
                        txtDiaChi.Text = dt.Rows[i]["DiaChi"].ToString();
                        txtNgheNghiep.Text = dt.Rows[i]["NgheNghiep"].ToString();
                        txtQuocTich.Text = dt.Rows[i]["QuocTich"].ToString();
                        KiemTra = 1;
                        break;
                    }
                }
                if (t == 0)
                {
                    txtTenKH.Enabled = true;
                    dtpNgaySinh.Enabled = true;
                    cbGT.Enabled = true;
                    txtQuocTich.Enabled = true;
                    txtNgheNghiep.Enabled = true;
                    txtDiaChi.Enabled = true;
                    txtSDT.Enabled = true;
                    MessageBox.Show("Đây Là Khách Hàng Đến Lần Đầu,Bạn Cần Nhập Thông Tin Đầy Đủ Của Khách Hàng Đó");
                    int makh;
                    if (buskh.CountID() == 1)
                    {
                        makh = (int.Parse(buskh.GetLastID()) + 1);
                    }
                    else
                    {
                        makh = 0;
                    }
                    txtMaKH.Text = makh.ToString();

                }
            }
        }

     

      

       
        void LoadTT_PT()
        {
            DataTable dt;
            string MaPT = cbMaPT.Text;
           
            dt = buspt.TaoBang("where MaPT=N'" + MaPT + "'");
            dtpNgayDK.Text=dt.Rows[0]["NgayDK"].ToString();
            dtpNgayDen.Text = dt.Rows[0]["NgayDen"].ToString();
            txtMaKH.Text = dt.Rows[0]["MaKH"].ToString();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            int kt = 0;
            if(cbMaPT.Text=="")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Phiếu Thuê");
                return;
            }
            if (KT == 0)
            {
                ecctpt.MaPT = cbMaPT.Text;
                if (int.Parse(busctpt.SoLuongCTPT(ecctpt)) == 0)
                {
                    MessageBox.Show("Phiếu Thuê Chưa Có Phòng Thuê");
                    return;
                }
                if (int.Parse(busctpt.SoLuongCTPT_ChuaNhan(ecctpt)) == 0)
                {
                    MessageBox.Show("Phiếu Thuê Đã Nhận Hết Phòng");
                    LoadDSCTPT();
                    return;
                }
                LoadTT_PT();
                LoadDSCTPT();
                if (dgvChiTietPhieuThue.Rows.Count == 0)
                {
                    MessageBox.Show("Phiếu Thuê Không Có Phòng Nào Được Thuê");
                    return;
                }
                for (int i = 0; i < dgvChiTietPhieuThue.Rows.Count; i++)
                {
                    if (dgvChiTietPhieuThue.Rows[i].Cells[4].Value.ToString() == "Đã Thuê")
                    {
                        MessageBox.Show("Phiếu Thuê Chưa Nhận Phòng Hết, Bạn Có Quyền Hủy Phòng Hoặc Nhận Phòng");
                        kt = 1;
                        btnXoa.Enabled = true;
                        break;
                    }
                }
                if (kt == 0)
                {
                    MessageBox.Show("Phiếu Thuê Đã Nhận Phòng Hết, Bạn Không Có Quyền Hủy Phòng Hoặc Nhận Phòng");
                   
                    return;
                }
            }
            if(KT==1)
            {
                LoadTT_PT();
                LoadDSCTPT();
                btnDat.Enabled = true;
            }
            if (KT == 3)
            {
                LoadTT_PT();
                LoadDSCTPT();
                btnThanhToanHD.Enabled = true;
            }
            if(KT==2)//Trả Phòng
            {
                ecctpt.MaPT = cbMaPT.Text;
                if (int.Parse(busctpt.SoLuongCTPT(ecctpt)) == 0)
                {
                    MessageBox.Show("Phiếu Thuê Chưa Có Phòng Thuê");
                    LoadDSCTPT();
                    return;
                }
                if (int.Parse(busctpt.SoLuongCTPT_DaNhan(ecctpt)) == 0)
                {
                    MessageBox.Show("Phiếu Thuê Chưa Có Phòng Được Nhận");
                    LoadDSCTPT();
                    return;
                }
                LoadTT_PT();
                LoadDSCTPT();
                btnTra.Enabled = true;
            
            }
           // SetNull();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (cbMaPT.Text == "" || txtSoPhong2.Text == "" )
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin");
                return;
            }

            if (txtTrangThaiPhong.Text == "Đang Ở" )
            {
                MessageBox.Show("Phòng Đã Được Nhận");
                return;
            }
            if ( txtTrangThaiPhong.Text == "Trống")
            {
                MessageBox.Show("Phòng Đã Được Trả");
                return;
            }
                try
                {

                        ecctpt.MaPT = cbMaPT.Text;
                        ecctpt.SoPhong = txtSoPhong2.Text;
                        ecp.SoPhong = txtSoPhong2.Text;
                        busp.UpDate_TrangThaiDangO(ecp);
                        MessageBox.Show("Nhận Phòng Thành Công");
                        LoadDSCTPT();
                        lsvPhong.Clear();
                        LoadTTPhong();
                }
                catch
                {
                    MessageBox.Show("Thêm Mới Không Thành Công");
                    return;
                }
            
            //SetNull();
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if(cbMaPT.Text == "" || txtSoPhong2.Text == "" ||txtTrangThaiPhong.Text==""||cbMaNV.Text==""||dtpNgayDi.Text==""||dtpNgayLap.Text=="")
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin");
                return;
            }
            if(txtTrangThaiPhong.Text=="Đã Thuê")
            {
                MessageBox.Show("Phòng Chưa Được Nhận");
                return;
            }
            if (txtTrangThaiPhong.Text == "Trống")
            {
                MessageBox.Show("Phòng Đã Được Trả Trước Đó");
                return;
            }
            int ma;
            if (buscthd.CountID() == 1)
            {
                ma = (int.Parse(buscthd.GetLastID()) + 1);
            }
            else
            {
                ma = 0;
            }
            ecp.SoPhong = txtSoPhong2.Text;
            busp.UpDate_TrangThaiTrong(ecp);//trả lại trạng thái phòng trống của phòng sau khi trả
            ecctpt.SoPhong = txtSoPhong2.Text;
            ecctpt.MaPT = cbMaPT.Text;
            busctpt.UpDate_DaTra(ecctpt);//tích đã trả phòng vào chi tiết phiếu thuê
         
            eccthd.MaCTHD = ma.ToString();
            eccthd.MaNV = cbMaNV.Text;
            eccthd.MaPT = cbMaPT.Text;
            eccthd.SoPhong = txtSoPhong2.Text;
            eccthd.NgayLap = DateTime.ParseExact(dtpNgayLap.Text, "dd/MM/yyyy", null);
            eccthd.NgayDi = DateTime.ParseExact(dtpNgayDi.Text, "dd/MM/yyyy", null);
            buscthd.ThemDuLieu(eccthd);
            MessageBox.Show("Trả Phòng Thành Công");
            LoadDSCTPT();
            lsvPhong.Clear();
            LoadTTPhong();
            frmTraPhong frmTraPhong = new frmTraPhong(ma.ToString());
            frmTraPhong.Show();
           
                
        }

        private void btnGoiDV_Click(object sender, EventArgs e)
        {
            if (cbMaPT.Text == "" || txtSoPhong2.Text == "" )
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin");
                return;
            }
            if (txtTrangThaiPhong.Text=="Trống")
            {
                MessageBox.Show("Phòng Đã Được Trả");
                return;
            }
            if (txtTrangThaiPhong.Text == "Đã Thuê")
            {
                MessageBox.Show("Phòng Chưa Được Nhận");
                return;
            }
            frmGoiDichVu frmGoiDichVu = new frmGoiDichVu(txtSoPhong2.Text,cbMaPT.Text);
            frmGoiDichVu.Show();
        }

        private void btnThanhToanHD_Click(object sender, EventArgs e)
        {
            frmHoaDonTong _frmHoaDonTong = new frmHoaDonTong(cbMaPT.Text);
            _frmHoaDonTong.Show();
        }

        private void dgvChiTietPhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSoPhong2.Text = dgvChiTietPhieuThue.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTrangThaiPhong.Text = dgvChiTietPhieuThue.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        
    }
}
