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
    public partial class Frm_TrangChu : Form
    {
        public Frm_TrangChu()
        {
            InitializeComponent();
        }

        private void danhSáchBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BenhNhan frm1 = new Frm_BenhNhan();
            this.Visible = false;
            frm1.ShowDialog();
            this.Visible = true;
        }

        private void danhSáchBácSĩToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BacSi frm1 = new Frm_BacSi();
            this.Visible = false;
            frm1.ShowDialog();
            this.Visible = true;
        }

        private void Frm_TrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban chac chan muon thoat Form khong", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
