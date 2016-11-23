using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;

namespace QuanLyKhachSanDAL
{
    public class SQL_DangNhap
    {
        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public void ThemDuLieu(EC_DangNhap et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO DangNhap(TenTaiKhoan, MatKhau, Quyen))
            VALUES (N'" + et.TenDangNhap + "',N'" + et.MatKhau + "',N'" + et.PhanQuyen + "')");
        }
        //sửa dữ liệu
        public void SuaDuLieu(EC_DangNhap et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE DangNhap SET  MatKhau =N'" + et.MatKhau + "', Quyen =N'" + et.PhanQuyen + "' where TenTaiKhoan=N'" + et.TenDangNhap + "'");
        }

        //xóa dữ liệu
        public void XoaDuLieu(EC_DangNhap et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from DangNhap  where TenTaiKhoan=N'" + et.TenDangNhap + "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from DangNhap " + DieuKien);
        }

           /*//hàm lấy thông tin người dùng trong CSDL sau đó lưu tất cả vào list
           public IList<NguoiDungDTO> LayThongTinNguoiDung()
           {
               var query = (from n in context.DangNhap
                            select new NguoiDungDTO
                            {
                                TenDangNhap = n.TenTaiKhoan,
                                MatKhau = n.MatKhau,
                                PhanQuyen = n.Quyen,
                            });
               return query.ToList<NguoiDungDTO>();
           }
           //hàm đếm số lượng tài khoản có trong hệ thống
           public static int DemSoLuongTK()
           {
               int query = (from n in context.DangNhap
                            select new NguoiDungDTO
                            {

                            }).Count();
               return query;*/
        public int DemSoLuongTK()
        {
            return int.Parse(cn.GetValue("select count(*) from DangNhap"));
        }
       
    }
}
