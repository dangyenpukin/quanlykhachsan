using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;

namespace QuanLyKhachSanDAL
{
    public class SQL_KhachHang
    {
        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_KhachHang et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO KhachHang(MaKH,TenKH, NgaySinh, GT, SDT, SoCMND, DiaChi, NgheNghiep, QuocTich)
            VALUES (N'" + et.MaKH + "',N'" + et.TenKH + "',N'" + et.NgaySinh + "',N'" + et.GT + "',N'" + et.SDT + "',N'" + et.SoCMND + "',N'" + et.DiaChi + "',N'" + et.NgheNghiep + "',N'" + et.QuocTich + "')");
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_KhachHang et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE KhachHang SET TenKH =N'" + et.TenKH + "', NgaySinh =N'" + et.NgaySinh + "', GT =N'" + et.GT + "', SDT =N'" + et.SDT + "', SoCMND =N'" + et.SoCMND + "', DiaChi =N'" + et.DiaChi + "', NgheNgiep =N'" + et.NgheNghiep + "', QuocTich =N'" + et.QuocTich + "' where MaKH=N'" + et.MaKH + "'");
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_KhachHang et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from KhachHang  where MaKH=N'" + et.MaKH + "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from KhachHang "+DieuKien);
        }
        public string GetLastID()
        {
            return cn.GetValue("SELECT TOP 1 MaKH FROM KhachHang ORDER BY MaKH DESC");
        }
        public int CountID()
        {
            if (int.Parse(cn.GetValue("SELECT count( MaKH) FROM KhachHang")) > 0)
                return 1;
            else
                return 0;
        }
    }
}
