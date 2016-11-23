using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSanBUS;
using QuanLyKhachSanEntity;

namespace quanlykhachsan2
{
    public partial class frmDatPhong : Form
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }
        BUS_PhieuThue buspt = new BUS_PhieuThue();
        EC_PhieuThue ecpt = new EC_PhieuThue();
        BUS_KhachHang buskh = new BUS_KhachHang();
        EC_KhachHang eckh = new EC_KhachHang();
        int KiemTra=0;
        private void btnChonPhong_Click(object sender, EventArgs e)
        {
            frmChonPhong _frmChonPhong = new frmChonPhong();
            _frmChonPhong.ShowDialog();
            Hide();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            btnChonPhong.Enabled = false;
            txtMaPT.Enabled = false;
            txtMaKH.Enabled = false;

            int mapt;
            if (buspt.CountID() == 1)
            {
                mapt = (int.Parse(buspt.GetLastID()) + 1);
            }
            else
            {
                mapt = 0;
            }
            txtMaPT.Text = mapt.ToString();
 
           
        }
       
        void KhoaDieuKien()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbGT.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtNgheNghiep.Enabled = false;
            txtQuocTich.Enabled = false;
        }
        void MoDieuKien()
        {
            txtTenKH.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbGT.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            txtNgheNghiep.Enabled = true;
            txtQuocTich.Enabled = true;
        }

        void SetNull()
        {
            txtMaPT.Text = "";
            dtpNgayDK.Text = "";
            dtpNgayDen.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            dtpNgaySinh.Text = "";
            cbGT.Text = "";
            txtSDT.Text = "";
            txtSoCMND.Text = "";
            txtDiaChi.Text = "";
            txtNgheNghiep.Text = "";
            txtQuocTich.Text = "";

        }
     

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmTrangChu f = new frmTrangChu();
                f.Show();
                Hide();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //dtpNgayDK.Text = DateTime.Now.ToString(" dd/MM/yyyy");
            if (txtMaPT.Text == "" || dtpNgayDK.Text == "" || dtpNgayDen.Text == "" || txtMaKH.Text == "" || txtTenKH.Text == "" || dtpNgaySinh.Text =="" || cbGT.Text == "" || txtSDT.Text == "" || txtSoCMND.Text == "" || txtDiaChi.Text == "" || txtNgheNghiep.Text == "" || txtNgheNghiep.Text == "" || txtQuocTich.Text == "" || dtpNgayDen.Text == "" )
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
                    ecpt.MaPT = txtMaPT.Text;
                    ecpt.NgayDK = DateTime.ParseExact(dtpNgayDK.Text, "dd/MM/yyyy", null);
                    ecpt.NgayDen = DateTime.ParseExact(dtpNgayDen.Text, "dd/MM/yyyy", null);
                    ecpt.MaKH = txtMaKH.Text;

                    if (buskh.ThemDuLieu(eckh) == 1)
                    {
                        MessageBox.Show("Đã Thêm Khách Hàng Thành Công");

                        if (buspt.ThemDuLieu(ecpt) == 1)
                        {
                            MessageBox.Show("Đã Thêm Phiếu Thuê Thành Công");
                            btnChonPhong.Enabled = true;
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
                ecpt.MaPT = txtMaPT.Text;
                ecpt.NgayDK = DateTime.ParseExact(dtpNgayDK.Text, "dd/MM/yyyy", null);
                ecpt.NgayDen = DateTime.ParseExact(dtpNgayDen.Text, "dd/MM/yyyy", null);
                ecpt.MaKH = txtMaKH.Text;
                if (buspt.ThemDuLieu(ecpt) == 1)
                {
                    MessageBox.Show("Đã Thêm Phiếu Thuê Thành Công");
                    btnChonPhong.Enabled = true;
                }
            }
            SetNull();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtSoCMND.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Chứng Minh Nhân Dân");
                return;
            }
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
                    MoDieuKien();
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
    }
}
