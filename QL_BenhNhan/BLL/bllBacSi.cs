using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhNhan.BLL
{
    class bllBacSi
    {
        DAL.dalBacSi dalBS;
        GUI.Frm_BacSi BS;
        public bllBacSi(GUI.Frm_BacSi fBS)
        {
            dalBS = new DAL.dalBacSi();
            BS = fBS;
        }
        public void bllLoad()
        {
            BS.dataGridView1.DataSource = dalBS.dalLoad();
        }
        public void bllKhoa()
        {
            BS.cb_Khoa.DataSource = dalBS.dalKhoa();
            BS.cb_Khoa.DisplayMember = "TenKhoa";
            BS.cb_Khoa.ValueMember = "MaKhoa";
        }
        public void bllThem()
        {
            dalBS.dalThem(BS.txt_MaBacSi.Text, BS.txt_HoVaTen.Text, BS.dateTimePicker1.Value,
                BS.cb_Khoa.SelectedValue.ToString(), BS.txt_TenHinh.Text);
        }
        public void bllXoa()
        {
            dalBS.dalXoa(BS.txt_MaBacSi.Text);
        }
        public void bllSua()
        {
            dalBS.dalSua(BS.txt_MaBacSi.Text, BS.txt_HoVaTen.Text, BS.dateTimePicker1.Value,
                BS.cb_Khoa.SelectedValue.ToString(), BS.txt_TenHinh.Text);
        }
        public void bllCbKhoa()
        {
            BS.dataGridView1.DataSource = dalBS.dalCbBaoHiem(BS.cb_Khoa.SelectedValue.ToString());
        }
        public void bllTim()
        {
            BS.dataGridView1.DataSource = dalBS.dalTim(BS.txt_TimKiem.Text);
        }
    }
}
