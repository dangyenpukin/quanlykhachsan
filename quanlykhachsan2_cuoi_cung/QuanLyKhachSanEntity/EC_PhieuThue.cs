using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEntity
{
    public class EC_PhieuThue
    {
        private string _MaPT;

        public string MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }
        private DateTime _NgayDK;

        public DateTime NgayDK
        {
            get { return _NgayDK; }
            set { _NgayDK = value; }
        }
        private DateTime _NgayDen;

        public DateTime NgayDen
        {
            get { return _NgayDen; }
            set { _NgayDen = value; }
        }
        private string _MaKH;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private string _TongSoPhong;

        public string TongSoPhong
        {
            get { return _TongSoPhong; }
            set { _TongSoPhong = value; }
        }
        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
