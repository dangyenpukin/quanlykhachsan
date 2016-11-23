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
    public partial class frmHuyPhong : Form
    {
        public frmHuyPhong()
        {
            InitializeComponent();
        }
        BUS_ChiTietPhieuThue busctpt = new BUS_ChiTietPhieuThue();
        EC_ChiTietPhieuThue ecctpt = new EC_ChiTietPhieuThue();
        BUS_Phong busp = new BUS_Phong();
        EC_Phong ecp = new EC_Phong();

        private void frmHuyPhong_Load(object sender, EventArgs e)
        {
            btnHuyPhong.Enabled = false;
            txtTienDatCoc.Enabled = false;
            dtpNgayDK.Enabled = false;
            cbMaPT.DataSource = busctpt.LayThongTinPT("where TrangThai=N'Chưa Trả'");
            cbMaPT.DisplayMember = "MaPT";
            cbMaPT.ValueMember = "MaPT";
            cbSoPhong.DataSource = busctpt.LayThongTinP("where TrangThai=N'Đã Thuê'");
            cbSoPhong.DisplayMember = "SoPhong";
            cbSoPhong.ValueMember = "LoaiPhong"; 
            
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

        private void btnHuyPhong_Click(object sender, EventArgs e)
        {

            ecctpt.MaPT = cbMaPT.Text;
            ecctpt.SoPhong = cbSoPhong.Text;
            busctpt.XoaDuLieu(ecctpt);
            ecp.SoPhong = cbSoPhong.Text;
            busp.UpDate_TrangThaiTrong(ecp);
            MessageBox.Show("Hủy Phòng Thành Công");
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (cbSoPhong.Text == "" || cbMaPT.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Dữ Liệu Số Phòng Và Mã Phiếu Thuê");
                return;
            }
            int kt = 0;
            DataTable dt2 = busctpt.TaoBang("");
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i]["SoPhong"].ToString() == cbSoPhong.Text && dt2.Rows[i]["MaPT"].ToString() == cbMaPT.Text)
                {
                    MessageBox.Show("Số Phòng Hợp Lệ");

                    btnHuyPhong.Enabled = true;
                    kt = 1;
                    break;
                }

            }
            if (kt == 0)
            {
                MessageBox.Show("Số Phòng Không Hợp Lệ");
                return;
            }
        }
    }
}
