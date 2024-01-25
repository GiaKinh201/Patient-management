using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhNhan.BLL
{
    class bllDangKy
    {
        public bllDangKy(GUI.Frm_DangKy fDK)
        {
            dalDk = new DAL.dalDangKy();
            frmDk = fDK;
        }
        DAL.dalDangKy dalDk;
        GUI.Frm_DangKy frmDk;
        public void bllDk()
        {
            if (frmDk.txt_TenDangNhap.Text == "" || frmDk.txt_MatKhau.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else if (frmDk.txt_XacNhan.Text != frmDk.txt_MatKhau.Text)
            {
                MessageBox.Show("Mat khau xac nhan phai giong mat khau");
            }
            else
            {
                dalDk.dalDK(frmDk.txt_TenDangNhap.Text, frmDk.txt_MatKhau.Text);
            }
        }
    }
}
