using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;

namespace QuanLyKhachSanDAL
{
    public class SQL_PhieuThue
    {
        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_PhieuThue et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO PhieuThue(MaPT, NgayDK, NgayDen, MaKH,TrangThai)
            VALUES (N'" + et.MaPT + "',N'" + et.NgayDK + "',N'" + et.NgayDen + "',N'" + et.MaKH + "',N'Chưa Trả')");
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_PhieuThue et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE PhieuThue SET NgayDK =N'" + et.NgayDK + "', NgayDen =N'" + et.NgayDen + "', MaKH =N'" + et.MaKH + "' where MaPT=N'" + et.MaPT + "'");
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_PhieuThue et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from PhieuThue  where MaPT=N'" + et.MaPT + "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from PhieuThue " + DieuKien);
        }
        public DataTable LayThongTinKH(string DieuKien)
        {
            return cn.GetDataTable("select MaKH,TenKH from KhachHang " + DieuKien);
        }
        public string GetLastID()
        {
            return cn.GetValue("SELECT TOP 1 MaPT FROM PhieuThue ORDER BY MaPT DESC");
        }
        public int CountID()
        {
            if (int.Parse(cn.GetValue("SELECT count( MaPT) FROM PhieuThue")) > 0)
                return 1;
            else
                return 0;
        }
        public DataTable LayThongTinPT(string DieuKien)
        {
            return cn.GetDataTable("select MaPT from PhieuThue " + DieuKien);
        }
        public int Update_TrangThaiDaTra(EC_PhieuThue et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE PhieuThue SET TrangThai=N'Đã Trả' where MaPT=N'" + et.MaPT + "'");
        }
    }
}
