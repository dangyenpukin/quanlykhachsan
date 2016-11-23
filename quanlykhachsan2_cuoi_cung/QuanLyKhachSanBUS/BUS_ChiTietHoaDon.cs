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
    public class BUS_ChiTietHoaDon
    {
        SQL_ChiTietHoaDon sql = new SQL_ChiTietHoaDon();
        public int ThemDuLieu(EC_ChiTietHoaDon et)
        {
            return sql.ThemDuLieu(et);
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_ChiTietHoaDon et)
        {
            return sql.SuaDuLieu(et);
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_ChiTietHoaDon et)
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
        public string GetLastID()
        {
            return sql.GetLastID();
        }
        public int CountID()
        {
            return sql.CountID();
        }
        public DataTable LayThongTinPT(string DieuKien)
        {
            return sql.LayThongTinPT(DieuKien);
        }
        public DataTable LayThongTinP(string DieuKien)
        {
            return sql.LayThongTinP(DieuKien);
        }
    }
}
