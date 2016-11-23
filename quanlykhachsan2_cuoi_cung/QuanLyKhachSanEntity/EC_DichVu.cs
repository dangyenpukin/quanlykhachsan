using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEntity
{
    public class EC_DichVu
    {
        private string _MaDV;

        public string MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
        }
        private string _TenDV;

        public string TenDV
        {
            get { return _TenDV; }
            set { _TenDV = value; }
        }
        private string _Gia;

        public string Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        private string _MaNQL;

        public string MaNQL
        {
            get { return _MaNQL; }
            set { _MaNQL = value; }
        }
    }
}
