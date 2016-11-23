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
    public partial class frmChiTietDichVu : Form
    {
        private SqlConnection con;
        private SqlDataAdapter adap;
        private DataSet ds= new DataSet();

        public frmChiTietDichVu()
        {
            InitializeComponent();
        }

        private void frmChiTietDichVu_Load(object sender, EventArgs e)
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
            String str = "select * from ChiTiet_DichVu";
            try
            {
                SqlCommand com = new SqlCommand(str, con);
                adap = new SqlDataAdapter(com);
                adap.Fill(ds, "ChiTiet_DichVu");
                dgvChiTietDichVu.DataSource = ds.Tables["ChiTiet_DichVu"];
            }
        catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
        private void binding()
        {
            txtMaCTDV.DataBindings.Clear();
            txtMaCTDV.DataBindings.Add("Text", dgvChiTietDichVu.DataSource, "MaCTDV");
            txtMaDV.DataBindings.Clear();
            txtMaDV.DataBindings.Add("Text", dgvChiTietDichVu.DataSource, "MaDV");
            txtMaPT.DataBindings.Clear();
            txtMaPT.DataBindings.Add("Text", dgvChiTietDichVu.DataSource, "MaPT");
            txtSoPhong.DataBindings.Clear();
            txtSoPhong.DataBindings.Add("Text", dgvChiTietDichVu.DataSource, "SoPhong");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvChiTietDichVu.DataSource, "Gia");
            dtpNgaySuDung.DataBindings.Clear();
            dtpNgaySuDung.DataBindings.Add("Text", dgvChiTietDichVu.DataSource, "NgaySuDung");
        }
       
       
    }
}
