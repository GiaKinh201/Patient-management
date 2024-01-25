using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhNhan.DAL
{
    class dalDangNhap
    {
        Ketnoi kn;
        public dalDangNhap()
        {
            kn = new Ketnoi();
        }
        public int dalLogin(String tenTaiKhoan,String matKhau)
        {
            String sqlDangNhap = "select count (*) from DANGNHAP where TenTaiKhoan = '" + tenTaiKhoan
                + "' and MatKhau = '" + matKhau + "'";
            return (int)kn.Scalar(sqlDangNhap);
        }
    }
}
