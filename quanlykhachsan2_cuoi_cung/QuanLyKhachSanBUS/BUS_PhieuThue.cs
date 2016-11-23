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
    public class BUS_PhieuThue
    {
        SQL_PhieuThue sql = new SQL_PhieuThue();
        public int ThemDuLieu(EC_PhieuThue et)
        {
            return sql.ThemDuLieu(et);
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_PhieuThue et)
        {
            return sql.SuaDuLieu(et);
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_PhieuThue et)
        {

            sql.XoaDuLieu(et);
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable LayThongTinKH(string DieuKien)
        {
            return sql.LayThongTinKH(DieuKien);
        }
        public string GetLastID()
        {
            return sql.GetLastID();
        }
        public int CountID()
        {
            return sql.CountID();
        }
        public int Update_TrangThaiDaTra(EC_PhieuThue et)
        {
            return sql.Update_TrangThaiDaTra(et);
        }
    }
}
