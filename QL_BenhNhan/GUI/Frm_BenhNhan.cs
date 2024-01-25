using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BenhNhan.GUI
{
    public partial class Frm_BenhNhan : Form
    {
        public Frm_BenhNhan()
        {
            InitializeComponent();
            kn = new Ketnoi();
            bllBN = new BLL.bllBenhNhan(this);
        }
        Ketnoi kn;
        BLL.bllBenhNhan bllBN;
        private void Frm_BenhNhan_Load(object sender, EventArgs e)
        {
            loadBaoHiem();
            loadData();
        }
        public void loadData()
        {
            bllBN.bllLoad();
        }
        public void loadBaoHiem()
        {
            bllBN.bllBaoHiem();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";

        private void btn_Them_Click(object sender, EventArgs e)
        {
            bllBN.bllThem();
            pictureBox1.Image.Save(duongdan + txt_TenHinh.Text);
            loadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bllBN.bllXoa();
            File.Delete(duongdan + txt_TenHinh.Text);
            loadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            bllBN.bllSua();
            pictureBox1.Image.Save(duongdan + txt_TenHinh.Text);
            loadData();
        }
        int check = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaBenhNhan.Text = dataGridView1.CurrentRow.Cells["MaBN"].Value.ToString();
            txt_HoVaTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            check = 1;
            cb_BaoHiem.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            check = 0;
            txt_TenHinh.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_TenHinh.Text;
        }

        private void cb_BaoHiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0)
            {
                bllBN.bllCbBaoHiem();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn ảnh";
            OFD.Filter = "Tất cả đuôi ảnh|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bllBN.bllTim();
        }

        private void Frm_BenhNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban chac chan muon thoat Form khong", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
