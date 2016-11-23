using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachSanDAL
{
    public class KetNoiData
    {
        public static SqlConnection con;

        public void MoKetNoi()
        {
            if (KetNoiData.con == null)
                /*KetNoiData.connect = new SqlConnection("Data Source=192.168.137.201,1433;Network Library=DBMSSOCN;Initial Catalog=QuanLyPhongTN;User ID=sa;Password=linh02041995;");*/
                KetNoiData.con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True");
            /*KetNoiData.connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyPhongTN;Integrated Security=SSPI;");*/

            if (KetNoiData.con.State != ConnectionState.Open)
                KetNoiData.con.Open();
        }
        public void DongKetNoi()
        {
            if (KetNoiData.con != null)
            {
                if (KetNoiData.con.State == ConnectionState.Open)
                {
                    KetNoiData.con.Close();
                }
            }

        }
        //insert ,update ,delete
        public int ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, con);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
                return 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("asfsfsdfs  "+ex.ToString());
                return 0;
            }

        }

        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, con);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }

        }
        public string GetValue(string strSQL)//select
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, con);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }
    }
}
