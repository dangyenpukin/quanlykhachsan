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
    public partial class frmChiTietHoaDon : Form
    {
      
        private SqlConnection con;
        private SqlDataAdapter adap;
        private DataSet ds= new DataSet();
       
         public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

         private void frmChiTietHoaDon_Load(object sender, EventArgs e)
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
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True");
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
            String str = "select * from ChiTiet_HoaDon";
            try
            {
                SqlCommand com = new SqlCommand(str, con);
                adap = new SqlDataAdapter(com);
                adap.Fill(ds, "ChiTiet_HoaDon");
                dgvChiTietHoaDon.DataSource = ds.Tables["ChiTiet_HoaDon"];
              

            }
        catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
        private void binding()
        {
            txtMaCTHD.DataBindings.Clear();
            txtMaCTHD.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "MaCTHD");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "MaNV");
            dtpNgayLap.DataBindings.Clear();
            dtpNgayLap.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "NgayLap");
            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "MaKH");
            dtpNgayDen.DataBindings.Clear();
            dtpNgayDen.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "NgayDen");
            dtpNgayDi.DataBindings.Clear();
            dtpNgayDi.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "NgayDi");
            txtTongNgay.DataBindings.Clear();
            txtTongNgay.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "TongNgay");
            txtMaPT.DataBindings.Clear();
            txtMaPT.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "MaPT");
            txtSoPhong.DataBindings.Clear();
            txtSoPhong.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "SoPhong");
            txtTienPhong.DataBindings.Clear();
            txtTienPhong.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "TienPhong");
            txtTienDV.DataBindings.Clear();
            txtTienDV.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "TienDV");
            txtTien.DataBindings.Clear();
            txtTien.DataBindings.Add("Text", dgvChiTietHoaDon.DataSource, "Tien");
        }

     
       
   
    }
}
