using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEntity
{
    public class EC_ChiTietHoaDon
    {
        private string _MaCTHD;

        public string MaCTHD
        {
            get { return _MaCTHD; }
            set { _MaCTHD = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }

     
        private string _MaKH;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private DateTime _NgayDen;

        public DateTime NgayDen
        {
            get { return _NgayDen; }
            set { _NgayDen = value; }
        }


        private DateTime _NgayDi;

        public DateTime NgayDi
        {
            get { return _NgayDi; }
            set { _NgayDi = value; }
        }

   
        private string _TongNgay;

        public string TongNgay
        {
            get { return _TongNgay; }
            set { _TongNgay = value; }
        }
        private string _MaPT;

        public string MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }
        private string _SoPhong;

        public string SoPhong
        {
            get { return _SoPhong; }
            set { _SoPhong = value; }
        }
        private string _TienPhong;

        public string TienPhong
        {
            get { return _TienPhong; }
            set { _TienPhong = value; }
        }
        private string _TienDV;

        public string TienDV
        {
            get { return _TienDV; }
            set { _TienDV = value; }
        }
        private string _Tien;

        public string Tien
        {
            get { return _Tien; }
            set { _Tien = value; }
        }
    }
}
