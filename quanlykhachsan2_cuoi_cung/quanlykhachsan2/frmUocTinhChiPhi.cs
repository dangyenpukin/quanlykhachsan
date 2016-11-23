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
    public partial class frmUocTinhChiPhi : Form
    {
        public frmUocTinhChiPhi()
        {
            InitializeComponent();
        }
        BUS_ChiTietPhieuThue busctpt = new BUS_ChiTietPhieuThue();
        EC_ChiTietPhieuThue ecctpt = new EC_ChiTietPhieuThue();
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

                    btnLoad.Enabled = true;
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
           
        }

        private void frmUocTinhChiPhi_Load(object sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            txtTienDV.Enabled = false;
            txtTienPhong.Enabled = false;
            dtpNgayDen.Enabled = false;
            cbMaPT.DataSource = busctpt.TaoBang("");
            cbMaPT.DisplayMember = "MaPT";
            cbMaPT.ValueMember = "MaPT";
            cbSoPhong.DataSource = busctpt.TaoBang("");
            cbSoPhong.DisplayMember = "SoPhong";
            cbSoPhong.ValueMember = "SoPhong";
        }
    }
}
