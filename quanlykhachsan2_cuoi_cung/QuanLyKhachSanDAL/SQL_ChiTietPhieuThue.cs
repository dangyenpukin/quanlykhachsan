using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSanEntity;
using System.Data;

namespace QuanLyKhachSanDAL
{
    public class SQL_ChiTietPhieuThue
    {

        KetNoiData cn = new KetNoiData();
        //Hàm thêm dữ liệu
        public int ThemDuLieu(EC_ChiTietPhieuThue et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO ChiTiet_PhieuThue(SoPhong, MaPT, TienDatCoc, TrangThai)
            VALUES (N'" + et.SoPhong + "',N'" + et.MaPT + "',N'" + et.TienDatCoc + "',N'" + et.TrangThai + "')");
        }
        //sửa dữ liệu
        public int SuaDuLieu(EC_ChiTietPhieuThue et1, EC_ChiTietPhieuThue et2)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE ChiTiet_PhieuThue 
                                          SET  SoPhong =N'" + et2.SoPhong + "', MaPT =N'" + et2.MaPT + "',TienDatCoc =N'" + et2.TienDatCoc + "', TrangThai =N'" + et2.TrangThai + "' Where MaPT=N'" + et1.MaPT + "' and SoPhong=N'" + et1.SoPhong + "'" );
        }
        public int UpDate_DaTra(EC_ChiTietPhieuThue et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE ChiTiet_PhieuThue 
                                          SET  TrangThai =N'Đã Trả' Where MaPT=N'" + et.MaPT + "' and SoPhong=N'" + et.SoPhong + "'");
        }
        //xóa dữ liệu
        public void XoaDuLieu(EC_ChiTietPhieuThue et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from ChiTiet_PhieuThue  where MaPT=N'" + et.MaPT + "' and SoPhong=N'" + et.SoPhong + "'");
        }
        //lấy dữ liệu
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("select * from ChiTiet_PhieuThue " + DieuKien);
        }
        public DataTable TaoBangCTPT(EC_ChiTietPhieuThue et)
        {
            return cn.GetDataTable("select c.SoPhong,MaPT,TienDatCoc,p.Gia,p.TrangThai from ChiTiet_PhieuThue c,Phong p where c.SoPhong=p.SoPhong and c.MaPT=N'" + et.MaPT + "'");
        }
   
        public DataTable LayThongTinPT(string DieuKien)
        {
            return cn.GetDataTable("select MaPT from PhieuThue " + DieuKien);
        }
        public DataTable LayThongTinP(string DieuKien)
        {
            return cn.GetDataTable("select SoPhong,LoaiPhong from Phong " + DieuKien);
        }
        
     //lấy số lượng ctpt theo 1 mã phiếu thuê
        public string SoLuongCTPT(EC_ChiTietPhieuThue et)
        {
            return cn.GetValue("select count(SoPhong) from ChiTiet_PhieuThue where MaPT=N'" + et.MaPT + "'");
        }
        //lấy số lượng phòng chưa được Nhận theo mã phiếu thuê
        public string SoLuongCTPT_ChuaNhan(EC_ChiTietPhieuThue et)
        {
            return cn.GetValue("select count(c.SoPhong) from ChiTiet_PhieuThue c,Phong p where MaPT=N'" + et.MaPT + "' and p.SoPhong=c.SoPhong and p.TrangThai=N'Đã Thuê'");
        }
        //lấy số lượng phòng Đã được Nhận theo mã phiếu thuê
        public string SoLuongCTPT_DaNhan(EC_ChiTietPhieuThue et)
        {
            return cn.GetValue("select count(c.SoPhong) from ChiTiet_PhieuThue c,Phong p where MaPT=N'" + et.MaPT + "' and p.SoPhong=c.SoPhong and p.TrangThai=N'Đang Ở'");
        }
        //trả về các mã phiếu thuê có phòng chưa trả
        public DataTable LayThongTinPT_ChuaTra()
        {
            return cn.GetDataTable("select distinct MaPT from ChiTiet_PhieuThue c,Phong p where c.TrangThai=N'Chưa Trả' and p.SoPhong= c.SoPhong and p.TrangThai=N'Đang Ở'");
        }
        //trả về các mã phiếu thuê có phòng chưa nhận
        public DataTable LayThongTinPT_ChuaNhan()
        {
            return cn.GetDataTable("select distinct MaPT from ChiTiet_PhieuThue c,Phong p where c.TrangThai=N'Chưa Trả' and p.SoPhong= c.SoPhong and p.TrangThai=N'Đã Thuê'");
        }
        //trả về các mã phiếu thuê chưa có phòng nào ở trạng thái đang ở,chưa có phòng nào trả rồi
        public DataTable LayThongTinPT_TatCaChuaNhan()
        {
            return cn.GetDataTable(@"	select MaPT from PhieuThue where MaPT not in (select distinct MaPT from ChiTiet_PhieuThue c,Phong p where c.TrangThai=N'Chưa Trả' and p.SoPhong= c.SoPhong and p.TrangThai=N'Đang Ở')
                                     and MaPT not in (select distinct MaPT from ChiTiet_PhieuThue c,Phong p where c.TrangThai=N'Đã Trả')");
        }
        //trả về các mã phiếu thuê có tất cả các phòng trả rồi
        public DataTable LayThongTinPT_TatCaDaTra()
        {
            return cn.GetDataTable(@"select MaPT from PhieuThue where TrangThai=N'Chưa Trả' and MaPT not in (select distinct MaPT from ChiTiet_PhieuThue where TrangThai=N'Chưa Trả') 
                                      and MaPT in (select distinct MaPT from ChiTiet_PhieuThue )");
        }
    }
}
