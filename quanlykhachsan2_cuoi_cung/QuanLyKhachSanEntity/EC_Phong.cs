using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEntity
{
    public class EC_Phong
    {
        private string _SoPhong;
        public string SoPhong
        {
            get { return _SoPhong; }
            set { _SoPhong = value; }
        }

        private string _LoaiPhong;

        public string LoaiPhong
        {
            get { return _LoaiPhong; }
            set { _LoaiPhong = value; }
        }
        private string _Gia;

        public string Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
