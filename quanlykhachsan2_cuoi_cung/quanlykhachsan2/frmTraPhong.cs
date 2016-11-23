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
    public partial class frmTraPhong : Form
    {
        public frmTraPhong(string macthd)
        {
            InitializeComponent();
            txtMaCTHD.Text = macthd;
        }
        private SqlConnection con;
        private SqlDataAdapter adap;
        private DataTable dt = new DataTable();
       

        BUS_ChiTietHoaDon buscthd = new BUS_ChiTietHoaDon();
        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            string ma=txtMaCTHD.Text;
            txtMaCTHD.Enabled = false;
         
            txtTien.Enabled = false;
            txtTienDV.Enabled = false;
            txtTienPhong.Enabled = false;
            txtTongNgay.Enabled = false;
            DataTable dt2;
           
            dt2=buscthd.TaoBang("where MaCTHD=N'"+ma+"'");
            cbMaNV.Text = dt2.Rows[0]["MaNV"].ToString();
            cbMaPT.Text=dt2.Rows[0]["MaPT"].ToString();
            cbSoPhong.Text = dt2.Rows[0]["SoPhong"].ToString();
            dtpNgayLap.Text = dt2.Rows[0]["NgayLap"].ToString();
            dtpNgayDi.Text = dt2.Rows[0]["NgayDi"].ToString();
            dtpNgayDen.Text = dt2.Rows[0]["NgayDen"].ToString();
          
            txtTien.Text = dt2.Rows[0]["Tien"].ToString();
            txtTienDV.Text = dt2.Rows[0]["TienDV"].ToString();
            txtTienPhong.Text = dt2.Rows[0]["TienPhong"].ToString();
            txtTongNgay.Text = dt2.Rows[0]["TongNgay"].ToString();
            HienThi();

        }
    
        void HienThi()
        {
            try
            {
                connect();
                SqlCommand queryCM = new SqlCommand("DV_Phong", con);
                queryCM.CommandType = CommandType.StoredProcedure;
                queryCM.Parameters.Add(new SqlParameter("@SoPhong", SqlDbType.Int, 0, "SoPhong"));
                queryCM.Parameters.Add(new SqlParameter("@MaPT", SqlDbType.Int, 0, "MaPT"));
                queryCM.Parameters["@SoPhong"].Value = cbSoPhong.Text;
                queryCM.Parameters["@MaPT"].Value = cbMaPT.Text;
                queryCM.ExecuteNonQuery();

                adap = new SqlDataAdapter(queryCM);
                adap.Fill(dt);

                dgvCacDichVuDaDung.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        
   

     

       
         


    }
}
