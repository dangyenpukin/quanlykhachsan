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
using System.Security.Cryptography;

namespace quanlykhachsan2
{
    public partial class frmAccountManagement : Form
    {
        public frmAccountManagement()
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
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string s = txtUser.Text;
                string x = txtPassword.Text;
                x = x.Trim();
                s = s.Trim();
                string mahoa = GetMD5(x);
                //txthien.Text = mahoa;
                string chuoi;
                    
                int amin;
                if(chbAmin.Checked==true)
                {
                    amin = 1;
                    chuoi = @"insert into DangNhap(Userrr,Password,PhanQuyen) values (N'" + s + "',N'" + mahoa + "',N'"+amin+"')";
                }else
                {
                    amin = 0;
                    chuoi = @"insert into DangNhap(Userrr,Password,PhanQuyen) values (N'" + s + "',N'" + mahoa + "',N'"+amin+"')";
                }

                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand(chuoi, conn);
                cmd.ExecuteNonQuery();

                txtUser.Clear();
                txtPassword.Clear();
                chbAmin.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi '" + ex.Message + "'");
            }
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUser.Text = "";
           
        }

        
    }
}
