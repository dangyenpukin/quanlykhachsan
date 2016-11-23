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
    public partial class frmDichVu : Form
    {
 
       
         public frmDichVu()
        {
            InitializeComponent();
        }
         BUS_DichVu bus = new BUS_DichVu();
         EC_DichVu ec = new EC_DichVu();
         bool themmoi;//lưu giá trị khi nhấn nút lưu thì gán giá trị true,false xác định lưu khi đang sửa hay thêm mới
         private void frmDichVu_Load(object sender, EventArgs e)
        {
            KhoaDieuKien();
            HienThi("");
            cbMaNQL.DataSource = bus.LayThongTinNV("");
            cbMaNQL.DisplayMember = "MaNV";
            cbMaNQL.ValueMember = "TenNV";
            if (_Phanquyen.Phanquyen == 0)
            {
                btnLuu.Enabled = false;
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

       
        void KhoaDieuKien()
        {
            txtMaDV.Enabled = false;
            txtTenDV.Enabled = false;
            txtGia.Enabled = false;
            cbMaNQL.Enabled = false;


            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
  
            btnLuu.Enabled = false;
        }
        void MoDieuKien()
        {
            txtMaDV.Enabled = false;
            txtTenDV.Enabled = true;
            txtGia.Enabled = true;
            cbMaNQL.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        
            btnLuu.Enabled = true;
        }
        void SetNull()
        {
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtGia.Text = "";
            cbMaNQL.Text = "";

        }
        void HienThi(String where)
        {
            dgvDichVu.DataSource = bus.TaoBang(where);
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
            txtMaDV.Text = ma.ToString();
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
                ec.MaDV = txtMaDV.Text;
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

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKien();
            try
            {
                txtMaDV.Text = dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDV.Text = dgvDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGia.Text = dgvDichVu.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbMaNQL.Text = dgvDichVu.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtTenDV.Text == "" || txtGia.Text == "" || cbMaNQL.Text == "" )
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin");
                return;
            }
            if (themmoi == true)
            {
                try
                {

                    ec.MaDV = txtMaDV.Text;
                    ec.TenDV = txtTenDV.Text;
                    ec.Gia = txtGia.Text;
                    ec.MaNQL = cbMaNQL.Text;

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
                    ec.MaDV = txtMaDV.Text;
                    ec.TenDV = txtTenDV.Text;
                    ec.Gia = txtGia.Text;
                    ec.MaNQL = cbMaNQL.Text;
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
    }
}
