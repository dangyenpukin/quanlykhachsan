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


namespace quanlykhachsan2
{
    public partial class frmGoiDichVu : Form
    {
        public frmGoiDichVu(string sophong,string mapt)
        {
            InitializeComponent();
            cbMaPT.Text = mapt;
            cbSoPhong.Text = sophong;
        }

        BUS_DichVu busdv = new BUS_DichVu();
        EC_DichVu ecdv = new EC_DichVu();
        BUS_ChiTietDichVu busctdv = new BUS_ChiTietDichVu();
        EC_ChiTietDichVu ecctdv = new EC_ChiTietDichVu();
        BUS_ChiTietPhieuThue busctpt = new BUS_ChiTietPhieuThue();
        EC_ChiTietPhieuThue ecctpt = new EC_ChiTietPhieuThue();
        private void frmGoiDichVu_Load(object sender, EventArgs e)
        {
         txtMaCTDV.Enabled=false;
        
         cbSoPhong.Enabled = false;
         cbMaPT.Enabled = false;
         cbMaDV.DataSource = busdv.TaoBang("");
         cbMaDV.DisplayMember = "MaDV";
         cbMaDV.ValueMember = "MaDV";
         HienThi("");
         int mactdv;
         if (busctdv.CountID() == 1)
         {
             mactdv = (int.Parse(busctdv.GetLastID()) + 1);
         }
         else
         {
             mactdv = 0;
         }
         txtMaCTDV.Text = mactdv.ToString();
        }
        void HienThi(String where)
        {

            dgvDichVu.DataSource = busdv.TaoBangChon(where);
        }
        void DS_DV()
        {
            dgvDanhSachDV.DataSource = busctdv.TaoBang_CTDV(" and SoPhong=N'" + cbSoPhong.Text + "' and MaPT=N'" + cbMaPT.Text + "' ");
        }
        void SetNull()
        {
            cbMaDV.Text = "";
          
            dtpNgaySuDung.Text = "";


        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (cbMaDV.Text == "" || cbMaPT.Text == "" || cbSoPhong.Text == "" || dtpNgaySuDung.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin");
                return;
            }

            try
            {

                ecctdv.MaDV = cbMaDV.Text;
                ecctdv.MaCTDV = txtMaCTDV.Text;
                ecctdv.SoPhong = cbSoPhong.Text;
                ecctdv.MaPT = cbMaPT.Text;
                ecctdv.NgaySuDung = DateTime.ParseExact(dtpNgaySuDung.Text, "dd/MM/yyyy", null);
                busctdv.ThemDuLieu(ecctdv);
                MessageBox.Show("Thêm Chi Tiết Dịch Vụ Thành Công");
            }
            catch
            {
                MessageBox.Show("Thêm Mới Không Thành Công");
                return;
            }

            DS_DV();
            SetNull();
            int mactdv2;
               if (busctdv.CountID() == 1)
                {
                    mactdv2 = (int.Parse(busctdv.GetLastID()) + 1);
                }
                else
                {
                    mactdv2 = 0;
                }
                txtMaCTDV.Text = mactdv2.ToString();
            
        }

    
       

        private void dgvDichVu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbMaDV.Text = dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

       
        
    }
}
