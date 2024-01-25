using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhNhan.DAL
{
    class dalBacSi
    {
        Ketnoi kn;
        public dalBacSi()
        {
            kn = new Ketnoi();
        }
        public DataTable dalLoad()
        {
            String sqlLoadGrid = "Select * from BACSI";
            return kn.LoadData(sqlLoadGrid);
        }
        public DataTable dalKhoa()
        {
            String sqlLoadGrid = "Select * from KHOA";
            return kn.LoadData(sqlLoadGrid);
        }
        public void dalThem(String maBS, String hoTen, DateTime ngaySinh,  String maKhoa, String tenHinhAnh)
        {
            String sqlThem = "Insert into BACSI values('" + maBS
                + "', N'" + hoTen
                + "', Convert(DateTime, '"
                + ngaySinh + "', 103), '" + maKhoa + "', '" + tenHinhAnh + "')";
            kn.Nonquery(sqlThem);
        }
        public void dalXoa(String maBS)
        {
            String sqlXoa = "delete from BACSI where MaBS = '" + maBS + "'";
            kn.Nonquery(sqlXoa);
        }
        public void dalSua(String maBS, String hoTen, DateTime ngaySinh, String maKhoa, String tenHinhAnh)
        {
            String sqlSua = "update BACSI set HoTen = N'" + hoTen
                + "', NgaySinh = Convert(DateTime, '" + ngaySinh
                + "', 103),  MaKhoa = '" + maKhoa
                + "', TenHinhAnh = '" + tenHinhAnh
                + "' where MaBS = '" + maBS + "'";
            kn.Nonquery(sqlSua);
        }
        public DataTable dalCbBaoHiem(String maBS)
        {
            String sqlLoadGrid = "select * from BACSI where MaBS = '" + maBS + "'";
            if (maBS == "ALL")
                sqlLoadGrid = "Select * from BACSI";
            return kn.LoadData(sqlLoadGrid);
        }
        public DataTable dalTim(String tim)
        {
            String sqlTimKiem = "select * from BACSI where MaBS like '%" + tim + "%' or HoTen like N'%" + tim + "%'";
            return kn.LoadData(sqlTimKiem);
        }
    }
}
