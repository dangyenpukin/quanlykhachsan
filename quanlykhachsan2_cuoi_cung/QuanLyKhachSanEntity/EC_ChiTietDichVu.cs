using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEntity
{
    public class EC_ChiTietDichVu
    {
        private string _MaCTDV;

        public string MaCTDV
        {
            get { return _MaCTDV; }
            set { _MaCTDV = value; }
        }
        private string _MaDV;

        public string MaDV
        {
            get { return _MaDV; }
            set { _MaDV = value; }
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
        private string _Gia;

        public string Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        private DateTime _NgaySuDung;

        public DateTime NgaySuDung
        {
            get { return _NgaySuDung; }
            set { _NgaySuDung = value; }
        }


      
    }
}
