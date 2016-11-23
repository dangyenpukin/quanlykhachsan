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
 
        public partial class frmPhong : Form
        {
            public frmPhong()
            {
                InitializeComponent();
            }
            BUS_Phong bus = new BUS_Phong();
            EC_Phong ec = new EC_Phong();
            bool themmoi;//lưu giá trị khi nhấn nút lưu thì gán giá trị true,false xác định lưu khi đang sửa hay thêm mới

            private void frmPhong_Load(object sender, EventArgs e)
            {
                KhoaDieuKien();
                HienThi("");
                cbMaNV.DataSource = bus.LayThongTinNV("");
                cbMaNV.DisplayMember = "MaNV";
                cbMaNV.ValueMember = "TenNV";
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
                txtSoPhong.Enabled = false;
                cbLoaiPhong.Enabled = false;
                txtGia.Enabled = false;
                cbMaNV.Enabled = false;
                cbTrangThai.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
             
                btnLuu.Enabled = false;
            }
            void MoDieuKien()
            {
                txtSoPhong.Enabled = false;
                cbLoaiPhong.Enabled = true;
                txtGia.Enabled = true;
                cbMaNV.Enabled = true;
                cbTrangThai.Enabled = true;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
              
                btnLuu.Enabled = true;
            }
            void SetNull()
            {
                txtSoPhong.Text = "";
                cbLoaiPhong.Text = "";
                txtGia.Text = "";
                cbMaNV.Text = "";
                cbTrangThai.Text = "";
            }
            void HienThi(String where)
            {
                dgvPhong.DataSource = bus.TaoBang(where);
            }


            private void btnThem_Click_1(object sender, EventArgs e)
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
                txtSoPhong.Text = ma.ToString();
            }

            private void btnSua_Click_1(object sender, EventArgs e)
            {
                MoDieuKien();
                themmoi = false;
            }

            private void btnXoa_Click_1(object sender, EventArgs e)
            {
                try
                {
                    ec.SoPhong = txtSoPhong.Text;
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

            private void btnLuu_Click_1(object sender, EventArgs e)
            {
                if (cbLoaiPhong.Text == "" || txtGia.Text == "" || cbMaNV.Text == "" || cbTrangThai.Text == "" )
                {
                    MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin");
                    return;
                }
                if (themmoi == true)
                {
                    try
                    {

                        ec.SoPhong = txtSoPhong.Text;
                        ec.LoaiPhong = cbLoaiPhong.Text;
                        ec.Gia = txtGia.Text;
                        ec.MaNV = cbMaNV.Text;
                        ec.TrangThai = cbTrangThai.Text;
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
                        ec.SoPhong = txtSoPhong.Text;
                        ec.LoaiPhong = cbLoaiPhong.Text;
                        ec.Gia = txtGia.Text;
                        ec.MaNV = cbMaNV.Text;
                        ec.TrangThai = cbTrangThai.Text;
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

            private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                KhoaDieuKien();
                try
                {

                    txtSoPhong.Text = dgvPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cbLoaiPhong.Text = dgvPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtGia.Text = dgvPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbMaNV.Text = dgvPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cbTrangThai.Text = dgvPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                catch
                {

                }
            }

          

        }
}
