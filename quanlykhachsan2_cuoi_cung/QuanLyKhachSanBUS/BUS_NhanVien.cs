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
    public class BUS_NhanVien
    {
        SQL_NhanVien sql = new SQL_NhanVien();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_NhanVien et)
        {
            return sql.ThemDuLieu(et);
        }
        //sửa dữ liệu
        public void SuaDuLieu(EC_NhanVien et)
        {
            sql.SuaDuLieu(et);
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_NhanVien et)
        {
            sql.XoaDuLieu(et);
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable LayThongTinDV(string DieuKien)
        {
            return sql.LayThongTinDV(DieuKien);
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
