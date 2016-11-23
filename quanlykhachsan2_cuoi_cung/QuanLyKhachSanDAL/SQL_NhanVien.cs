using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSanDAL
{
    public class SQL_NhanVien
    {
        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_NhanVien et)
        {
            return cn.ThucThiCauLenhSQL(@" INSERT INTO NhanVien(MaNV,TenNV,NgaySinh,GT,Luong,QuocTich,DiaChi,SDT,SoCMND,MaDV)
            VALUES (N'" + et.MaNV + "',N'" + et.TenNV + "','" + et.NgaySinh + "',N'" + et.GT + "',N'" + et.Luong + "',N'" + et.QuocTich + "',N'" + et.DiaChi + "',N'" + et.SDT + "',N'" + et.SoCMND + "',N'" + et.MaDV + "')");
        }
        //sửa dữ liệu
        public void SuaDuLieu(EC_NhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE NhanVien SET TenNV =N'" + et.TenNV + "', NgaySinh =N'" + et.NgaySinh + "', GT =N'" + et.GT + "',Luong=N'" + et.Luong + "', QuocTich =N'" + et.QuocTich + "', DiaChi =N'" + et.DiaChi + "', SDT =N'" + et.SDT + "', SoCMND =N'" + et.SoCMND + "', MaDV =N'" + et.MaDV + "' where MaNV=N'" + et.MaNV + "'");
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_NhanVien et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from NhanVien  where MaNV=N'" + et.MaNV + "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from NhanVien " + DieuKien);
        }
        public DataTable LayThongTinDV(string DieuKien)
        {
            return cn.GetDataTable("select MaDV,TenDV from DichVu " + DieuKien);
        }
        //hàm trà về giá tị cuối cùng của mã tự tăng vừa thêm vào
        public string GetLastID()
        {
            return cn.GetValue("SELECT TOP 1 MaNV FROM NhanVien ORDER BY MaNV DESC");
        }
        public int CountID()
        {
            if (int.Parse(cn.GetValue("SELECT count( MaNV) FROM NhanVien")) > 0)
                return 1;
            else
                return 0;
        }
    }
}
