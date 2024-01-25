using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhNhan.DAL
{
    class dalBenhNhan
    {
        Ketnoi kn;
        public dalBenhNhan()
        {
            kn = new Ketnoi();
        }
        public DataTable dalLoad()
        {
            String sqlLoadGrid = "Select * from BENHNHAN";
            return kn.LoadData(sqlLoadGrid);
        }
        public DataTable dalBaoHiem()
        {
            String sqlLoadGrid = "Select * from BAOHIEM";
            return kn.LoadData(sqlLoadGrid);
        }
        public void dalThem(String maBN, String hoTen, DateTime ngaySinh, String diaChi,String maBH, String tenHinhAnh)
        {
            String sqlThem = "Insert into BENHNHAN values('" + maBN
                + "', N'" + hoTen
                + "', Convert(DateTime, '"
                + ngaySinh + "', 103), '"
                + diaChi + "', '" + maBH + "', '" + tenHinhAnh + "')";
            kn.Nonquery(sqlThem);
        }
        public void dalXoa(String maBN)
        {
            String sqlXoa = "delete from BENHNHAN where MaBN = '" + maBN + "'";
            kn.Nonquery(sqlXoa);
        }
        public void dalSua(String maBN, String hoTen, DateTime ngaySinh, String diaChi, String maBH, String tenHinhAnh)
        {
            String sqlSua = "update BENHNHAN set HoTen = N'" + hoTen
                + "', NgaySinh = Convert(DateTime, '" + ngaySinh
                + "', 103), DiaChi = '" + diaChi
                + "', MaBH = '" + maBH 
                + "', TenHinhAnh ='" + tenHinhAnh
                + "' where MaBN = '" + maBN + "'";
            kn.Nonquery(sqlSua);
        }
        public DataTable dalCbBaoHiem(String maBH)
        {
            String sqlLoadGrid = "select * from BENHNHAN where MaBH = '" + maBH + "'";
            if (maBH == "ALL")
                sqlLoadGrid = "Select * from BENHNHAN";
            return kn.LoadData(sqlLoadGrid);
        }
        public DataTable dalTim(String tim)
        {
            String sqlTimKiem = "select * from BENHNHAN where MaBN like '%" + tim + "%' or HoTen like N'%" + tim + "%'";
            return kn.LoadData(sqlTimKiem);
        }
    }
}
