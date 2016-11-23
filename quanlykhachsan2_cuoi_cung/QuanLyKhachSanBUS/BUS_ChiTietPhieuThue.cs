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
    public class BUS_ChiTietPhieuThue
    {
        SQL_ChiTietPhieuThue sql = new SQL_ChiTietPhieuThue();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_ChiTietPhieuThue et)
        {
            return sql.ThemDuLieu(et);
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_ChiTietPhieuThue et1, EC_ChiTietPhieuThue et2)
        {
            return sql.SuaDuLieu(et1,et2);
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_ChiTietPhieuThue et)
        {
            sql.XoaDuLieu(et);
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
       
        public DataTable LayThongTinPT(string DieuKien)
        {
            return sql.LayThongTinPT(DieuKien);
        }
        public DataTable LayThongTinP(string DieuKien)
        {
            return sql.LayThongTinP(DieuKien);
        }
        public int UpDate_DaTra(EC_ChiTietPhieuThue et)
        {
            return sql.UpDate_DaTra(et);
        }

        public DataTable TaoBangCTPT(EC_ChiTietPhieuThue et)
        {
            return sql.TaoBangCTPT(et);
        }
        public string SoLuongCTPT(EC_ChiTietPhieuThue et)
        {
            return sql.SoLuongCTPT(et);
        }
        public string SoLuongCTPT_ChuaNhan(EC_ChiTietPhieuThue et)
        {
            return sql.SoLuongCTPT_ChuaNhan(et);
        }
        public string SoLuongCTPT_DaNhan(EC_ChiTietPhieuThue et)
        {
            return sql.SoLuongCTPT_DaNhan(et);
        }
        public DataTable LayThongTinPT_ChuaTra()
        {
            return sql.LayThongTinPT_ChuaTra();
        }
        public DataTable LayThongTinPT_ChuaNhan()
        {
            return sql.LayThongTinPT_ChuaNhan();
        }
        public DataTable LayThongTinPT_TatCaChuaNhan()
        {
            return sql.LayThongTinPT_TatCaChuaNhan();
        }
        public DataTable LayThongTinPT_TatCaDaTra()
        {
            return sql.LayThongTinPT_TatCaDaTra();
        }
    }
}
