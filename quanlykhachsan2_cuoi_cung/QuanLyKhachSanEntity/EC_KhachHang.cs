using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEntity
{
    public class EC_KhachHang
    {
        private string _MaKH;

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        private string _TenKH;

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }
        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        
       
        private string _GT;

        public string GT
        {
            get { return _GT; }
            set { _GT = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _SoCMND;

        public string SoCMND
        {
            get { return _SoCMND; }
            set { _SoCMND = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _NgheNghiep;

        public string NgheNghiep
        {
            get { return _NgheNghiep; }
            set { _NgheNghiep = value; }
        }
        private string _QuocTich;

        public string QuocTich
        {
            get { return _QuocTich; }
            set { _QuocTich = value; }
        }
    }
}
