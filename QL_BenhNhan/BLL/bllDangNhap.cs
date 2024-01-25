using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhNhan.BLL
{
    class bllDangNhap
    {
        DAL.dalDangNhap dalDN;
        GUI.Frm_DangNhap dn;
        public bllDangNhap(GUI.Frm_DangNhap fDN)
        {
            dalDN = new DAL.dalDangNhap();
            dn = fDN;
        }
        public void bllLogin()
        {
            int kq = dalDN.dalLogin(dn.txt_TenDangNhap.Text,dn.txt_MatKhau.Text);
            if (kq >= 1)
            {
                GUI.Frm_TrangChu frm1 = new GUI.Frm_TrangChu();
                dn.Visible = false;
                frm1.ShowDialog();
                dn.Visible = true;
            }
            else
                MessageBox.Show("Sai ten dang nhap hoac mat khau");
        }
    }
}
