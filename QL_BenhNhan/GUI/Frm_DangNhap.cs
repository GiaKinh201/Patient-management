using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhNhan.GUI
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
            bllDN = new BLL.bllDangNhap(this);
        }
        BLL.bllDangNhap bllDN;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            bllDN.bllLogin();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban chac chan muon thoat", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                thoat = 1;
                Application.Exit();
            }
        }
        int thoat = 0;
        private void Frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thoat == 0)
            {
                DialogResult r = MessageBox.Show("Ban chac chan muon thoat Form khong", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            Frm_DangKy frm = new Frm_DangKy();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
