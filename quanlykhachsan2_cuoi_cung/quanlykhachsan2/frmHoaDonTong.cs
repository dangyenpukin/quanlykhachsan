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
using DevExpress.XtraReports.UI;

namespace quanlykhachsan2
{
    public partial class frmHoaDonTong : Form
    {
        public frmHoaDonTong(string mapt)
        {
            InitializeComponent();
            cbMaPT.Text = mapt;
        }
        BUS_HoaDon bushd = new BUS_HoaDon();
        EC_HoaDon echd = new EC_HoaDon();
        BUS_PhieuThue buspt = new BUS_PhieuThue();
        EC_PhieuThue ecpt = new EC_PhieuThue();
        BUS_ChiTietHoaDon buscthd = new BUS_ChiTietHoaDon();
       
   
        private void frmHoaDonTong_Load(object sender, EventArgs e)
        {
         
            txtMaHD.Enabled = false;
            cbMaPT.Enabled = false;
            dtpNgayDen.Enabled = false;
            txtTongSoPhong.Enabled = false;
            txtTongTien.Enabled = false;
            txtTongTienDV.Enabled = false;
            txtTongTienPhong.Enabled = false;
            int mahd;
            if (bushd.CountID() == 1)
            {
                mahd = (int.Parse(bushd.GetLastID()) + 1);
            }
            else
            {
                mahd = 0;
            }
            txtMaHD.Text = mahd.ToString();
            cbMaNV.DataSource = bushd.LayThongTinNV("");
            cbMaNV.DisplayMember = "MaNV";
            cbMaNV.ValueMember = "MaNV";
            
                    int ma;
                    if (bushd.CountID() == 1)
                    {
                        ma = (int.Parse(bushd.GetLastID()) + 1);
                    }
                    else
                    {
                        ma = 0;
                    }
                    txtMaHD.Text = ma.ToString();//tạo mã tự tăng của hóa đơn
        }

       
    
    
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int mahd;
                    mahd = int.Parse(txtMaHD.Text);

              
                string sql = @"Select * from InHoaDon where MaHD = N'" + mahd + "'";
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);

                XtraReport1 report = new XtraReport1();

                report.DataSource = dt;
                report.ShowPreviewDialog();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            if (cbMaNV.Text == "" || dtpNgayLap.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Dữ Liệu");
                return;
            }
            echd.MaHD = txtMaHD.Text;
            echd.MaNV = cbMaNV.Text;
            echd.MaPT = cbMaPT.Text;
            echd.NgayLap = DateTime.ParseExact(dtpNgayLap.Text, "dd/MM/yyyy", null);
            bushd.ThemDuLieu(echd);
            ecpt.MaPT = cbMaPT.Text;
            buspt.Update_TrangThaiDaTra(ecpt);//update trạng thái đã trả cho phiếu thuê
            MessageBox.Show("Thêm Hóa Đơn Thành Công");
            DataTable dt;
            dt = bushd.TaoBang(" where MaHD= N'"+txtMaHD.Text+"'");
            dtpNgayDen.Text = dt.Rows[0]["NgayDen"].ToString();
            txtTongTienPhong.Text = dt.Rows[0]["TongTienPhong"].ToString();
            txtTongSoPhong.Text = dt.Rows[0]["TongSoPhong"].ToString();
            txtTongTien.Text = dt.Rows[0]["TongTien"].ToString();
            txtTongTienDV.Text = dt.Rows[0]["TongTienDV"].ToString();
            

            DS_CTHD();
        }
        void DS_CTHD()
        {
            dgvChiTietHoaDon.DataSource = buscthd.TaoBang(" where MaPT= N'"+cbMaPT.Text+"'"); 
        }
    }
}
