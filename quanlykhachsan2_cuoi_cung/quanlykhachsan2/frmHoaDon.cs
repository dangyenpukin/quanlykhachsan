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
using DevExpress.XtraReports.UI;
namespace quanlykhachsan2
{
    public partial class frmHoaDon : Form
    {
      private SqlConnection con;
        private SqlDataAdapter adap;
        private DataSet ds= new DataSet();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
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
            String str = "select * from HoaDon";
            try
            {
                SqlCommand com = new SqlCommand(str, con);
                adap = new SqlDataAdapter(com);
                adap.Fill(ds, "HoaDon");
                dgvHoaDon.DataSource = ds.Tables["HoaDon"];
            }
        catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
        private void binding()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", dgvHoaDon.DataSource, "MaHD");
            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvHoaDon.DataSource, "MaNV");
            dtpNgayLap.DataBindings.Clear();
            dtpNgayLap.DataBindings.Add("Text", dgvHoaDon.DataSource, "NgayLap");
            dtpNgayDen.DataBindings.Clear();
            dtpNgayDen.DataBindings.Add("Text", dgvHoaDon.DataSource, "NgayDen");
            txtMaPT.DataBindings.Clear();
            txtMaPT.DataBindings.Add("Text", dgvHoaDon.DataSource, "MaPT");
            txtTongSoPhong.DataBindings.Clear();
            txtTongSoPhong.DataBindings.Add("Text", dgvHoaDon.DataSource, "TongSoPhong");
            txtTongTienDV.DataBindings.Clear();
            txtTongTienDV.DataBindings.Add("Text", dgvHoaDon.DataSource, "TongTienDV");
            txtTongTienPhong.DataBindings.Clear();
            txtTongTienPhong.DataBindings.Add("Text", dgvHoaDon.DataSource, "TongTienPhong");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dgvHoaDon.DataSource, "TongTien");
        }
       
        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int dong;
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int maPT;
                try
                {
                    maPT = int.Parse(txtMaHD.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chua chon Hoa Don can in");
                    return;
                }
                string sql = @"Select * from InHoaDon where MaPT = N'" + maPT + "'";
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(sql,conn);

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

     
    }
}
