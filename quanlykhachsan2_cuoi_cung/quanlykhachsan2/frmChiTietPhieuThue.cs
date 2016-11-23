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
    public partial class frmChiTietPhieuThue : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adap;
        private DataSet ds= new DataSet();

        public frmChiTietPhieuThue()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuThue_Load(object sender, EventArgs e)
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
            String str = "select * from ChiTiet_PhieuThue";
            try
            {
                SqlCommand com = new SqlCommand(str, con);
                adap = new SqlDataAdapter(com);
                adap.Fill(ds, "ChiTiet_PhieuThue");
                dgvChiTietPhieuThue.DataSource = ds.Tables["ChiTiet_PhieuThue"];
            }
        catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
        private void binding()
        {
            txtSoPhong.DataBindings.Clear();
            txtSoPhong.DataBindings.Add("Text", dgvChiTietPhieuThue.DataSource, "SoPhong");
            txtMaPT.DataBindings.Clear();
            txtMaPT.DataBindings.Add("Text", dgvChiTietPhieuThue.DataSource, "MaPT");
            txtTienDatCoc.DataBindings.Clear();
            txtTienDatCoc.DataBindings.Add("Text", dgvChiTietPhieuThue.DataSource, "TienDatCoc");
            
            txtTrangThai.DataBindings.Clear();
            txtTrangThai.DataBindings.Add("Text", dgvChiTietPhieuThue.DataSource, "TrangThai");
        }
       
 



    }
}
