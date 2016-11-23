using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;

namespace QuanLyKhachSanDAL
{
    public class SQL_ChiTietHoaDon
    {
        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_ChiTietHoaDon et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO ChiTiet_HoaDon (  MaCTHD, MaNV, NgayLap, NgayDi, MaPT, SoPhong)
            VALUES (N'" + et.MaCTHD + "',N'" + et.MaNV + "',N'" + et.NgayLap + "',N'" + et.NgayDi + "',N'" + et.MaPT + "',N'" + et.SoPhong + "')");
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_ChiTietHoaDon et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE ChiTiet_HoaDon SET MaNV =N'" + et.MaNV + "', NgayLap =N'" + et.NgayLap + "', MaKH =N'" + et.NgayDi + "', MaKH =N'" + et.MaPT + "', MaKH =N'" + et.SoPhong + "' where MaCTHD=N'" + et.MaCTHD + "'");
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_ChiTietHoaDon et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from ChiTiet_HoaDon  where MaCTHD=N'" + et.MaCTHD + "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from ChiTiet_HoaDon " + DieuKien);
        }
        public DataTable LayThongTinNV(string DieuKien)
        {
            return cn.GetDataTable("select MaNV,TenNV from NhanVien " + DieuKien);
        }
        public DataTable LayThongTinPT(string DieuKien)
        {
            return cn.GetDataTable("select MaPT from PhieuThue " + DieuKien);
        }
        public DataTable LayThongTinP(string DieuKien)
        {
            return cn.GetDataTable("select SoPhong,LoaiPhong from Phong " + DieuKien);
        }
        public string GetLastID()
        {
            return cn.GetValue("SELECT TOP 1 MaCTHD FROM ChiTiet_HoaDon ORDER BY MaCTHD DESC");
        }
        public int CountID()
        {
            if (int.Parse(cn.GetValue("SELECT count( MaCTHD) FROM ChiTiet_HoaDon")) > 0)
                return 1;
            else
                return 0;
        }
    }
}
