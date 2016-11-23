using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using PhanQuyen;
namespace quanlykhachsan2
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }
        public DataTable KetNoi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from DangNhap ", conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;

        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            int ktra = 0;
            try
            {
                string user = txtUser.Text;
                string password = txtPassword.Text;
                user = user.Trim();
                password = password.Trim();
                string mahoa = GetMD5(password);

                DataTable dt = KetNoi();
                foreach (DataRow dr in dt.Rows)
                {
                    string User = dr["Userrr"].ToString();
                    string MaHoa = dr["Password"].ToString();
                    _Phanquyen.Phanquyen = Convert.ToInt16(dr["PhanQuyen"]);
                    //if()
                    MaHoa = MaHoa.Trim();
                    User = User.Trim();
                    if (string.Compare(user, User, true) == 0 & mahoa == MaHoa)
                    {
                        ktra = 1;
                        MessageBox.Show("Dang Nhap Thanh Cong.");
                        Hide();
                        frmTrangChu frm = new frmTrangChu();
                        frm.ShowDialog();
                       frm.Close();
                        Hide();
                    }
                }
                if (ktra == 0)
                {
                    MessageBox.Show("Đăng Nhập Không Thành Công!");
                    txtPassword.Clear();
                    txtUser.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi '" + ex.Message + "'");
            }
        }

        

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
