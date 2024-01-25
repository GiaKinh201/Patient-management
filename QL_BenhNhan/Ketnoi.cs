using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhNhan
{

    class Ketnoi
    {
        String ketNoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DoAnCaNhan\QL_BenhNhan\QL_BenhNhan\SQL_BenhNhan.mdf;Integrated Security=True";
        SqlConnection con;
        public Ketnoi()
        {
            con = new SqlConnection(ketNoi);
        }
        public DataTable LoadData(String sql)
        {
            SqlCommand comm = new SqlCommand(sql,con);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void Nonquery(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, con);
            con.Open();
            //try
            //{
                int kq;
                kq = comm.ExecuteNonQuery();
                if (kq >= 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Lỗi try, nếu Xoá hoặc Sửa thì chưa có mã ...");
            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi catch, trùng mã, SQL ...");
            //}
            con.Close();
        }
        public object Scalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, con);
            con.Open();
            int kq = (int)comm.ExecuteScalar();
            con.Close();
            return kq;
        }
    }
}
