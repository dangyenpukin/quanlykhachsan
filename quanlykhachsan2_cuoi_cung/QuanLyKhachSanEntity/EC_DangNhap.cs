using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKhachSanEntity
{
    public class EC_DangNhap
    {
        //tạo 2 đối tượng chứa mật khẩu và tên đăng nhập
        //phân quyền là đăng nhập với admin hay user
        private string _TenDangNhap;
        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }

        public string _MatKhau;
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
            
        public string _PhanQuyen;
        public string PhanQuyen
        {
            get { return _PhanQuyen; }
            set { _PhanQuyen = value; }
        }
    }
}
