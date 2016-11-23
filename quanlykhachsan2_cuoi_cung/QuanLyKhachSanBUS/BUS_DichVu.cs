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
    public class BUS_DichVu
    {
        SQL_DichVu sql = new SQL_DichVu();
        public int ThemDuLieu(EC_DichVu et)
        {
            return sql.ThemDuLieu(et);
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_DichVu et)
        {
            return sql.SuaDuLieu(et);
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_DichVu et)
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
        public DataTable TaoBangChon(string DieuKien)
        {
            return sql.TaoBangChon(DieuKien);
        }
    }
}
