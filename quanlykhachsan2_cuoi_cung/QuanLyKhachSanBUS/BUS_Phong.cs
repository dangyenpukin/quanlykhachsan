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
    public class BUS_Phong
    {
        SQL_Phong sql = new SQL_Phong();
        public int ThemDuLieu(EC_Phong et)
        {
             return sql.ThemDuLieu(et);
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_Phong et)
        {
            return sql.SuaDuLieu(et);
        }
        //xóa dữ liệu
        public void XoaDuLieu(EC_Phong et)
        {
            sql.XoaDuLieu(et);
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public DataTable TaoBangP(string DieuKien)
        {
            return sql.TaoBangP(DieuKien);
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
        public int UpDate_TrangThaiTrong(EC_Phong et)
        {
            return sql.UpDate_TrangThaiTrong(et);
        }
        public int UpDate_TrangThaiDaThue(EC_Phong et)
        {
            return sql.UpDate_TrangThaiDaThue(et);
        }
        public int UpDate_TrangThaiDangO(EC_Phong et)
        {
            return sql.UpDate_TrangThaiDangO(et);
        }
        public DataTable PhongTrong(string DieuKien)
        {
            return sql.PhongTrong(DieuKien);
        }
        public string TrangThai(EC_Phong et)
        {
            return sql.TrangThai(et);
        }
    }
}
