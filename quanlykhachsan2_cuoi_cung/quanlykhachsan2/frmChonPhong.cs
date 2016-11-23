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
    public partial class frmChonPhong : Form
    {
        public frmChonPhong()
        {
            InitializeComponent();
        }

        BUS_Phong busp = new BUS_Phong();
        EC_Phong ecp = new EC_Phong();
        BUS_ChiTietPhieuThue busctpt = new BUS_ChiTietPhieuThue();
        EC_ChiTietPhieuThue ecctpt = new EC_ChiTietPhieuThue();
        BUS_PhieuThue buspt = new BUS_PhieuThue();
        EC_PhieuThue ecpt = new EC_PhieuThue();
      

        private void frmChonPhong_Load(object sender, EventArgs e)
        {
            btnDongY.Enabled = false;
            HienThi("");
            cbMaPT.DataSource = busctpt.LayThongTinPT("where TrangThai=N'Chưa Trả'");
            cbMaPT.DisplayMember = "MaPT";
            cbMaPT.ValueMember = "MaPT"; 
        }
     
   
        void SetNull()
        {
            cbMaPT.Text = "";
            txtSoPhong.Text = "";
            numTienDatCoc.Value = 000;

        }
        void HienThi(String where)
        {

            dgvCacPhongConTrong.DataSource = busp.PhongTrong(where);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmTrangChu f = new frmTrangChu();
                f.Show();
                Hide();
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (cbMaPT.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Phiếu Thuê");
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


            SetNull();
            btnKetThuc.Enabled = true;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quá Trình Đặt Phòng Kết Thúc");
            frmTrangChu f = new frmTrangChu();
            f.Show();
            Hide();

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int kt=0;
            if (txtSoPhong.Text=="")
            {
                MessageBox.Show("Bạn Chưa Nhập Số Phòng");
                return;
            }
            for (int i = 0; i < dgvCacPhongConTrong.Rows.Count; i++)
            {
                if(dgvCacPhongConTrong.Rows[i].Cells[0].Value.ToString()==txtSoPhong.Text)
                {
                    MessageBox.Show("Số Phòng Hợp Lệ");
                    btnDongY.Enabled = true;
                    kt = 1;
                    break;
                }
               
            }
            if(kt==0)
            {
                MessageBox.Show("Số Phòng Bạn Nhập Đã Có Khách Thuê, Vui Lòng Nhập Lại Số Phòng");
                return;
            }
        }

        private void dgvCacPhongConTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSoPhong.Text = dgvCacPhongConTrong.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát  Không?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                System.Windows.Forms.Application.Exit();
            }
        }

       

     
    }
}
