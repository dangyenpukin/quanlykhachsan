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
    public partial class frmNhanVien : Form
    {
       
            public frmNhanVien()
            {

                InitializeComponent();
            }

            BUS_NhanVien bus = new BUS_NhanVien();
            EC_NhanVien ec = new EC_NhanVien();
            bool themmoi;//lưu giá trị khi nhấn nút lưu thì gán giá trị true,false xác định lưu khi đang sửa hay thêm mới
            void KhoaDieuKien()
            {
                txtMaNV.Enabled = false;
                txtTenNV.Enabled = false;
                dtpNgaySinh.Enabled = false;
                cbGT.Enabled = false;
                txtLuong.Enabled = false;
                txtQuocTich.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSDT.Enabled = false;
                txtSoCMND.Enabled = false;
                cbMaDV.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
               
                btnLuu.Enabled = false;
            }
            void MoDieuKien()
            {
                txtMaNV.Enabled = false;
                txtTenNV.Enabled = true;
                dtpNgaySinh.Enabled = true;
                cbGT.Enabled = true;
                txtLuong.Enabled = true;
                txtQuocTich.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSDT.Enabled = true;
                txtSoCMND.Enabled = true;
                cbMaDV.Enabled = true;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
          
                btnLuu.Enabled = true;
            }
            void SetNull()
            {
                txtMaNV.Text = "";
                txtTenNV.Text = "";
                dtpNgaySinh.Text = "";
                cbGT.Text = "";
                txtLuong.Text = "";
                txtQuocTich.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtSoCMND.Text = "";
                cbMaDV.Text = "";
            }
            void HienThi(String where)
            {
                dgvNhanVien.DataSource = bus.TaoBang(where);
            }
            private void Form1_Load(object sender, EventArgs e)
            {
                
                KhoaDieuKien();
                HienThi("");
                cbMaDV.DataSource=bus.LayThongTinDV("");
                cbMaDV.DisplayMember = "MaDV";
                cbMaDV.ValueMember = "TenDV";
                if (_Phanquyen.Phanquyen == 0)
                {
                    btnLuu.Enabled = false;
                    btnSua.Enabled = false;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    //MessageBox.Show("nhanvien");
                } 
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
                    txtMaNV.Text = ma.ToString();
            }

            private void btnSua_Click(object sender, EventArgs e)
            {
                MoDieuKien();
                themmoi = false;
            }

            private void btnLuu_Click(object sender, EventArgs e)
            {
                if(txtTenNV.Text == ""||dtpNgaySinh.Text == ""||cbGT.Text == ""||txtLuong.Text == ""||txtQuocTich.Text == ""|| txtDiaChi.Text ==""||txtSDT.Text ==""||txtSoCMND.Text ==""||cbMaDV.Text =="")
                {
                    MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin");
                    return;
                }
                if(themmoi==true)
                {
                    try
                    {
                        
                        ec.MaNV = txtMaNV.Text;
                        ec.TenNV = txtTenNV.Text;
                        ec.NgaySinh = DateTime.ParseExact(dtpNgaySinh.Text, "dd/MM/yyyy", null);
                        ec.GT = cbGT.Text;
                        ec.Luong = txtLuong.Text;
                        ec.QuocTich = txtQuocTich.Text;
                        ec.DiaChi = txtDiaChi.Text;
                        ec.SDT = txtSDT.Text;
                        ec.SoCMND = txtSoCMND.Text;
                        ec.MaDV = cbMaDV.Text;
                        if (bus.ThemDuLieu(ec) == 1)
                        {
                            MessageBox.Show("Đã Thêm Mới Thành Công");
                            HienThi("");
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

                }
                else
                {
                    try
                    {
                        ec.MaNV =txtMaNV.Text;
                        ec.TenNV = txtTenNV.Text;
                        ec.NgaySinh = DateTime.ParseExact(dtpNgaySinh.Text, "dd/MM/yyyy", null);
                        ec.GT = cbGT.Text;
                        ec.Luong = txtLuong.Text;
                        ec.QuocTich = txtQuocTich.Text;
                        ec.DiaChi = txtDiaChi.Text;
                        ec.SDT = txtSDT.Text;
                        ec.SoCMND = txtSoCMND.Text;
                        ec.MaDV = cbMaDV.Text;
                        bus.SuaDuLieu(ec);
                        MessageBox.Show("Đã Sửa Thành Công");
                        //HienThi("");
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

            private void btnXoa_Click(object sender, EventArgs e)
            {
                try
                {
                    ec.MaNV = txtMaNV.Text;
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

            private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                KhoaDieuKien();
                try 
                {
                    txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                    dtpNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbGT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtLuong.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtQuocTich.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtSoCMND.Text = dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                    cbMaDV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
                }
                catch
                {

                }
            }

        }
}
