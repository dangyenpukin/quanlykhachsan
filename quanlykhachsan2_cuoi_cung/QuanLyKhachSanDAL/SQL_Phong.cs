using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;


namespace QuanLyKhachSanDAL
{
    public class SQL_Phong
    {
        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_Phong et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO Phong(LoaiPhong, Gia, MaNV, TrangThai)
            VALUES (N'" + et.LoaiPhong + "',N'" + et.Gia + "',N'" + et.MaNV + "',N'" + et.TrangThai + "')");
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_Phong et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE Phong SET LoaiPhong =N'" + et.LoaiPhong + "', Gia =N'" + et.Gia + "', MaNV =N'" + et.MaNV + "',TrangThai=N'" + et.TrangThai + "' where SoPhong=N'" + et.SoPhong + "'");
        }
        public int UpDate_TrangThaiTrong(EC_Phong et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE Phong SET TrangThai = N'Trống' where SoPhong=N'" + et.SoPhong + "'");
        }
        public int UpDate_TrangThaiDaThue(EC_Phong et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE Phong SET TrangThai = N'Đã Thuê' where SoPhong=N'" + et.SoPhong + "'");
        }
        public int UpDate_TrangThaiDangO(EC_Phong et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE Phong SET TrangThai = N'Đang Ở' where SoPhong=N'" + et.SoPhong + "'");
        }
        //xóa dữ liệu
        public void XoaDuLieu(EC_Phong et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from Phong  where SoPhong=N'" + et.SoPhong + "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from Phong " + DieuKien);
        }
        public DataTable TaoBangP(string DieuKien)
        {
            return cn.GetDataTable("select SoPhong,LoaiPhong,Gia,TrangThai from Phong " + DieuKien);
        }
        public DataTable PhongTrong(string DieuKien)
        {
            return cn.GetDataTable("select * from Phong where TrangThai=N'Trống'" );
        }
        public DataTable LayThongTinNV(string DieuKien)
        {
            return cn.GetDataTable("select MaNV,TenNV from NhanVien " + DieuKien);
        }
        public string TrangThai(EC_Phong et)
        {
            return cn.GetValue("SELECT TrangThai FROM Phong where SoPhong=N'" + et.SoPhong + "'");
        }
        public string GetLastID()
        {
            return cn.GetValue("SELECT TOP 1 SoPhong FROM Phong ORDER BY SoPhong DESC");
        }
        public int CountID()
        {
            if (int.Parse(cn.GetValue("SELECT count( SoPhong) FROM Phong")) > 0)
                return 1;
            else
                return 0;
        }
    }
}
