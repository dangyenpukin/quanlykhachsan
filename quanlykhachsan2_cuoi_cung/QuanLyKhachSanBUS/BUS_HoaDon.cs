using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanEntity;
using QuanLyKhachSanDAL;

namespace QuanLyKhachSanBUS
{
    public class BUS_HoaDon
    {
        SQL_HoaDon sql = new SQL_HoaDon();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_HoaDon et)
        {
            return sql.ThemDuLieu(et);
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_HoaDon et)
        {
            return sql.SuaDuLieu(et);
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_HoaDon et)
        {
            sql.XoaDuLieu(et);
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable LayThongTinNV(string DieuKien)
        {
            return sql.LayThongTinNV(DieuKien);
        }
        public DataTable LayThongTinPT(string DieuKien)
        {
            return sql.LayThongTinPT(DieuKien);
        }
        public string GetLastID()
        {
            return sql.GetLastID();
        }
        public int CountID()
        {
            return sql.CountID();
        }
    }
}
