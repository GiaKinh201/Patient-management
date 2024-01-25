using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhNhan.BLL
{
    class bllBenhNhan
    {
        DAL.dalBenhNhan dalBN;
        GUI.Frm_BenhNhan BN;
        public bllBenhNhan(GUI.Frm_BenhNhan fBN)
        {
            dalBN = new DAL.dalBenhNhan();
            BN = fBN;
        }
        public void bllLoad()
        {
            BN.dataGridView1.DataSource = dalBN.dalLoad();
        }
        public void bllBaoHiem()
        {
            BN.cb_BaoHiem.DataSource = dalBN.dalBaoHiem();
            BN.cb_BaoHiem.DisplayMember = "TenBH";
            BN.cb_BaoHiem.ValueMember = "MaBH";
        }
        public void bllThem()
        {
            dalBN.dalThem(BN.txt_MaBenhNhan.Text, BN.txt_HoVaTen.Text, BN.dateTimePicker1.Value, BN.txt_DiaChi.Text,
                BN.cb_BaoHiem.SelectedValue.ToString(), BN.txt_TenHinh.Text);
        }
        public void bllXoa()
        {
            dalBN.dalXoa(BN.txt_MaBenhNhan.Text);
        }
        public void bllSua()
        {
            dalBN.dalSua(BN.txt_MaBenhNhan.Text, BN.txt_HoVaTen.Text, BN.dateTimePicker1.Value, BN.txt_DiaChi.Text,
                BN.cb_BaoHiem.SelectedValue.ToString(), BN.txt_TenHinh.Text);
        }
        public void bllCbBaoHiem()
        {
            BN.dataGridView1.DataSource = dalBN.dalCbBaoHiem(BN.cb_BaoHiem.SelectedValue.ToString());
        }
        public void bllTim()
        {
            BN.dataGridView1.DataSource = dalBN.dalTim(BN.txt_TimKiem.Text);
        }
    }
}
