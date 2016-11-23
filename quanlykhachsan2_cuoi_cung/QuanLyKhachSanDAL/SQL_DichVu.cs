using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;

namespace QuanLyKhachSanDAL
{
    public class SQL_DichVu
    {
        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_DichVu et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO DichVu(TenDV, Gia, MaNQL)
            VALUES (N'" + et.TenDV + "',N'" + et.Gia + "',N'" + et.MaNQL + "')");
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_DichVu et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE DichVu SET TenDV =N'" + et.TenDV + "', Gia =N'" + et.Gia + "', MaNQL =N'" + et.MaNQL + "' where MaDV=N'" + et.MaDV + "'");
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_DichVu et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from DichVu  where MaDV=N'" + et.MaDV+ "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from DichVu " + DieuKien);
        }
        public DataTable TaoBangChon(string DieuKien)
        {
            return cn.GetDataTable("select MaDV,TenDV,Gia from DichVu " + DieuKien);
        }
        public DataTable LayThongTinNV(string DieuKien)
        {
            return cn.GetDataTable("select MaNV,TenNV from NhanVien " + DieuKien);
        }
        public string GetLastID()
        {
            return cn.GetValue("SELECT TOP 1 MaDV FROM DichVu ORDER BY MaDV DESC");
        }
        public int CountID()
        {
            if (int.Parse(cn.GetValue("SELECT count( MaDV) FROM DichVu")) > 0)
                return 1;
            else
                return 0;
        }
    }
}
