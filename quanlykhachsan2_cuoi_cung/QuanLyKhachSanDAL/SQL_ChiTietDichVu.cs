using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;

namespace QuanLyKhachSanDAL
{
    public class SQL_ChiTietDichVu
    {
        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_ChiTietDichVu et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO ChiTiet_DichVu(MaCTDV, MaDV, MaPT, SoPhong, NgaySuDung)
            VALUES (N'" + et.MaCTDV + "',N'" + et.MaDV + "',N'" + et.MaPT + "',N'" + et.SoPhong + "',N'" + et.NgaySuDung + "')");
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_ChiTietDichVu et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE ChiTiet_DichVu SET MaDV =N'" + et.MaDV + "', MaPT =N'" + et.MaPT + "', SoPhong =N'" + et.SoPhong + "', NgaySuDung =N'" + et.NgaySuDung + "' where MaCTDV=N'" + et.MaCTDV + "'");
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_ChiTietDichVu et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from ChiTiet_DichVu  where MaCTDV=N'" + et.MaCTDV + "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from ChiTiet_DichVu " + DieuKien);
        }
        public DataTable TaoBang_CTDV(string DieuKien)
        {
            return cn.GetDataTable("select MaCTDV,c.MaDV,TenDV,c.Gia,NgaySuDung from ChiTiet_DichVu c,DichVu d where c.MaDV=d.MaDV "+ DieuKien);
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
            return cn.GetValue("SELECT TOP 1 MaCTDV FROM ChiTiet_DichVu ORDER BY MaCTDV DESC");
        }
        public int CountID()
        {
            if (int.Parse(cn.GetValue("SELECT count( MaCTDV) FROM ChiTiet_DichVu")) > 0)
                return 1;
            else
                return 0;
        }
    }
}
