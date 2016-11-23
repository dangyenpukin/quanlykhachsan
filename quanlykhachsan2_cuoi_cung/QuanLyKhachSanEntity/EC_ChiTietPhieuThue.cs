using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEntity
{
    public class EC_ChiTietPhieuThue
    {
        private string _SoPhong;

        public string SoPhong
        {
            get { return _SoPhong; }
            set { _SoPhong = value; }
        }
        private string _MaPT;

        public string MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }
        private string _TienDatCoc;

        public string TienDatCoc
        {
            get { return _TienDatCoc; }
            set { _TienDatCoc = value; }
        }
       
        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
