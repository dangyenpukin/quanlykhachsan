using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;

namespace QuanLyKhachSanDAL
{
    public class SQL_HoaDon
    {
        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_HoaDon et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO HoaDon(MaHD, MaNV, NgayLap, MaPT)
            VALUES (N'" + et.MaHD + "',N'" + et.MaNV + "',N'" + et.NgayLap + "',N'" + et.MaPT + "')");
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_HoaDon et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE HoaDon SET MaNV =N'" + et.MaNV + "', NgayLap =N'" + et.NgayLap + "', MaPT =N'" + et.MaPT + "' where MaHD=N'" + et.MaHD + "'");
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_HoaDon et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from HoaDon  where MaHD=N'" + et.MaHD + "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from HoaDon " + DieuKien);
        }
        public DataTable LayThongTinNV(string DieuKien)
        {
            return cn.GetDataTable("select MaNV,TenNV from NhanVien " + DieuKien);
        }
        public DataTable LayThongTinPT(string DieuKien)
        {
            return cn.GetDataTable("select MaPT from PhieuThue " + DieuKien);
        }
        public string GetLastID()
        {
            return cn.GetValue("SELECT TOP 1 MaHD FROM HoaDon ORDER BY MaHD DESC");
        }
        public int CountID()
        {
            if (int.Parse(cn.GetValue("SELECT count( MaHD) FROM HoaDon")) > 0)
                return 1;
            else
                return 0;
        }
    }
}
