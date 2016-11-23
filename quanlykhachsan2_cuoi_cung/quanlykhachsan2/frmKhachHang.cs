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
using PhanQuyen;
namespace quanlykhachsan2
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        BUS_KhachHang bus = new BUS_KhachHang();
        EC_KhachHang ec = new EC_KhachHang();
        bool themmoi;//lưu giá trị khi nhấn nút lưu thì gán giá trị true,false xác định lưu khi đang sửa hay thêm mới
       

    
        private void KhachHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            HienThi("");
            if(_Phanquyen.Phanquyen==0)
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }

        }
        void KhoaDieuKien()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            dtpNgaySinh.Enabled = false;
            cbGT.Enabled = false;
            txtSDT.Enabled = false;
            txtSoCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            txtNgheNghiep.Enabled = false;
            txtQuocTich.Enabled = false;
      
          
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
           
            btnLuu.Enabled = false;
        }
        void MoDieuKien()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = true;
            dtpNgaySinh.Enabled = true;
            cbGT.Enabled = true;
            txtSDT.Enabled = true;
            txtSoCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            txtNgheNghiep.Enabled = true;
            txtQuocTich.Enabled = true;
      

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        
            btnLuu.Enabled = true;
        }
        void SetNull()
        {
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
        void HienThi(String where)
        {
            dgvKhachHang.DataSource = bus.TaoBang(where);
        }
   
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            SetNull();
            themmoi = true;
            int ma;
            if (bus.CountID() == 1)
            {
                ma = (int.Parse(bus.GetLastID()) + 1);
            }
            else
            {
                ma = 0;
            }
            txtMaKH.Text = ma.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKien();
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaKH = txtMaKH.Text;
                bus.XoaDuLieu(ec);
                MessageBox.Show("Xóa Dữ Liệu Thành Công");
                KhoaDieuKien();
                SetNull();
                HienThi("");
            }
            catch
            {
                MessageBox.Show("Lỗi Không Thể Xóa");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || dtpNgaySinh.Text == "" || cbGT.Text == "" || txtNgheNghiep.Text == "" || txtQuocTich.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtSoCMND.Text == "" )
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin");
                return;
            }
            if (themmoi == true)
            {
                try
                {

                    ec.MaKH = txtMaKH.Text;
                    ec.TenKH = txtTenKH.Text;
                    ec.NgaySinh = DateTime.ParseExact(dtpNgaySinh.Text, "dd/MM/yyyy", null);
                    ec.GT = cbGT.Text;
                    ec.NgheNghiep = txtNgheNghiep.Text;
                    ec.QuocTich = txtQuocTich.Text;
                    ec.DiaChi = txtDiaChi.Text;
                    ec.SDT = txtSDT.Text;
                    ec.SoCMND = txtSoCMND.Text;
                    if (bus.ThemDuLieu(ec) == 1)
                        MessageBox.Show("Đã Thêm Mới Thành Công");
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

            }
            else
            {
                try
                {
                    ec.MaKH = txtMaKH.Text;
                    ec.TenKH = txtTenKH.Text;
                    ec.NgaySinh = DateTime.ParseExact(dtpNgaySinh.Text, "dd/MM/yyyy", null);
                    ec.GT = cbGT.Text;
                    ec.NgheNghiep = txtNgheNghiep.Text;
                    ec.QuocTich = txtQuocTich.Text;
                    ec.DiaChi = txtDiaChi.Text;
                    ec.SDT = txtSDT.Text;
                    ec.SoCMND = txtSoCMND.Text;
                    bus.SuaDuLieu(ec);
                    MessageBox.Show("Đã Sửa Thành Công");
                }
                catch
                {
                    MessageBox.Show("Sửa Không Thành Công");
                    return;
                }
            }

            SetNull();
            KhoaDieuKien();
            HienThi("");
           
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            KhoaDieuKien();
            try
            {
                txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtSoCMND.Text = dgvKhachHang.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtQuocTich.Text = dgvKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtNgheNghiep.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch
            {

            }
        }
    }
}
