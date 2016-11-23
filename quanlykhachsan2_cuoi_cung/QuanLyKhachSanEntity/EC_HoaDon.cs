using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEntity
{
    public class EC_HoaDon
    {
        private string _MaHD;

        public string MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
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


        private DateTime _NgayDen;

        public DateTime NgayDen
        {
            get { return _NgayDen; }
            set { _NgayDen = value; }
        }

      
        private string _MaPT;

        public string MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }
        private string _TongSoPhong;

        public string TongSoPhong
        {
            get { return _TongSoPhong; }
            set { _TongSoPhong = value; }
        }
        private string _TongTienDV;

        public string TongTienDV
        {
            get { return _TongTienDV; }
            set { _TongTienDV = value; }
        }
        private string _TongTienPhong;

        public string TongTienPhong
        {
            get { return _TongTienPhong; }
            set { _TongTienPhong = value; }
        }
        private string _TongTien;

        public string TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
    }
}
