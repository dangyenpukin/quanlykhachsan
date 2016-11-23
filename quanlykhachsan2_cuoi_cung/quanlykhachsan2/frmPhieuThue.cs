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

namespace quanlykhachsan2
{
    public partial class frmPhieuThue : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adap;
        private DataSet ds= new DataSet();

        public frmPhieuThue()
        {
            InitializeComponent();
        }

        private void frmPhieuThue_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
            binding();
            disconnect();
        }
        private void connect()
        {
            try
            {
                con = new SqlConnection(@"Data Source=YEN\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True");
                con.Open();
            }
            catch
            {
                MessageBox.Show("Không Thể Kết Nối CSDL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void disconnect()
        {
            con.Close();
            con.Dispose();
            con = null;
        }
        private void getdata()
        {
            String str = "select * from PhieuThue";
            try
            {
                SqlCommand com = new SqlCommand(str, con);
                adap = new SqlDataAdapter(com);

                adap.SelectCommand.CommandText = "select * from KhachHang";
                adap.Fill(ds, "KhachHang");
                this.dtcMaKH.DataSource = ds.Tables["KhachHang"];
                this.dtcMaKH.DisplayMember = "MaKH";
                this.dtcMaKH.ValueMember = "MaKH";

                adap.SelectCommand.CommandText = "select * from PhieuThue";
                adap.Fill(ds, "PhieuThue");
                dgvPhieuThue.DataSource = ds.Tables["PhieuThue"];
            }
        catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
        private void binding()
        {
            txtMaPT.DataBindings.Clear();
            txtMaPT.DataBindings.Add("Text", dgvPhieuThue.DataSource, "MaPT");
            dtpNgayDK.DataBindings.Clear();
            dtpNgayDK.DataBindings.Add("Text", dgvPhieuThue.DataSource, "NgayDK");
            dtpNgayDen.DataBindings.Clear();
            dtpNgayDen.DataBindings.Add("Text", dgvPhieuThue.DataSource, "NgayDen");
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvPhieuThue.DataSource, "MaKH");
            txtTongSoPhong.DataBindings.Clear();
            txtTongSoPhong.DataBindings.Add("Text", dgvPhieuThue.DataSource, "TongSoPhong");
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Khỏi Dữ Liệu Chi Tiết Dịch Vụ Không?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmTrangChu f = new frmTrangChu();
                f.Show();
                Hide();
            }
        }
    }
}
