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
    public partial class frmDoanhThuDV : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adap;
        private DataTable dt = new DataTable();
        public frmDoanhThuDV()
        {
            InitializeComponent();
        }

        private void frmDoanhThuDV_Load(object sender, EventArgs e)
        {
            //connect();
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
            String str = "DoanhThuDV";
            if (dtpNgayDau.Text == "" || dtpNgayCuoi.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Ngày Đầu Ngày Cuối");
                return;
            }
            TimeSpan Time = DateTime.ParseExact(dtpNgayCuoi.Text, "dd/MM/yyyy", null) - DateTime.ParseExact(dtpNgayDau.Text, "dd/MM/yyyy", null);
            int TongSoNgay = Time.Days;
            if (TongSoNgay <=0)
            {
                MessageBox.Show("Bạn Nhập Ngày Không Hợp Lệ");
                return;
            }
                try
                {
                    connect();
                    SqlCommand com = new SqlCommand(str, con);
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.Add(new SqlParameter("@NgayDau", SqlDbType.Date,0,"NgayDau"));
                    com.Parameters.Add(new SqlParameter("@NgayCuoi", SqlDbType.Date,0,"NgayCuoi"));
                    com.Parameters.Add(new SqlParameter("@DoanhThuDV", SqlDbType.Int,0,ParameterDirection.Output,false,0,0,"DoanhThuDV",DataRowVersion.Default,null));
     
                    com.UpdatedRowSource=UpdateRowSource.OutputParameters;
                    com.Parameters["@NgayDau"].Value = DateTime.ParseExact(dtpNgayDau.Text, "dd/MM/yyyy", null);
                    com.Parameters["@NgayCuoi"].Value = DateTime.ParseExact(dtpNgayCuoi.Text, "dd/MM/yyyy", null);
                    com.ExecuteNonQuery();
                   // int i = (int)com.Parameters["@DoanhThuDV"].Value;
                    txtTongDoanhThuDV.Text = com.Parameters["@DoanhThuDV"].Value.ToString();

                    com.CommandType = CommandType.Text;


                    adap = new SqlDataAdapter(com);

                    adap.SelectCommand.CommandText = @"select MaCTDV,MaDV,c.MaPT,c.SoPhong,Gia,convert(varchar,NgaySuDung,103)
                                                 from ChiTiet_DichVu c,HoaDon h
                                                 where c.MaPT=h.MaPT and h.NgayLap<=@NgayCuoi and h.NgayLap>=@NgayDau";
                    adap.Fill(dt);
                  
                    dgvCacDichVuDaThuPhi.DataSource = dt;
                  
                    disconnect();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            
        }
       

   
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmTrangChu f = new frmTrangChu();
                f.Show();
                Hide();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            getdata();
            
        }
    }
}
