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
    public partial class ThemKhachHang : Form
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        EC_KhachHang eckh = new EC_KhachHang();
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {

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
                   
                        break;
                    }
                }
                if (t == 0)
                {
                   
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
