using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhNhan.DAL
{
    class dalDangKy
    {
        Ketnoi kn;
        public dalDangKy()
        {
            kn = new Ketnoi();
        }
        public void dalDK(String tenDangNhap , String matKhau)
        {
            String sqlThem = "Insert into DANGNHAP values('" + tenDangNhap
                + "', N'" + matKhau +  "')";
            kn.Nonquery(sqlThem);
        }
    }
}
