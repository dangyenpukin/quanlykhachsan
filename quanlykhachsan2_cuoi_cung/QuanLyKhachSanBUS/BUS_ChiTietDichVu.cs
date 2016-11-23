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
    public class BUS_ChiTietDichVu
    {
        SQL_ChiTietDichVu sql = new SQL_ChiTietDichVu();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_ChiTietDichVu et)
        {
            return sql.ThemDuLieu(et);
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_ChiTietDichVu et)
        {
            return sql.SuaDuLieu(et);
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_ChiTietDichVu et)
        {
            sql.XoaDuLieu(et);
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable LayThongTinP(string DieuKien)
        {
            return sql.LayThongTinP(DieuKien);
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
        public DataTable TaoBang_CTDV(string DieuKien)
        {
            return sql.TaoBang_CTDV(DieuKien);
        }
    }
}
