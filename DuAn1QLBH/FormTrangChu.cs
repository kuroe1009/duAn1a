using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mstr_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void tool_BanHang_MouseHover(object sender, EventArgs e)
        {

        }
        private void tool_BanHang_MouseLeave(object sender, EventArgs e)
        {
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSanPham f = new FormSanPham();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon f = new FormHoaDon();
            f.ShowDialog();
        }

        private void nhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhaCungCap f = new FormNhaCungCap();
            f.ShowDialog();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoaiSP f = new FormLoaiSP();
            f.ShowDialog();
        }

        private void giảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiamGia f = new FormGiamGia();
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKhachHang f = new FormKhachHang();
            f.ShowDialog();
        }

        private void tool_BanHang_Click(object sender, EventArgs e)
        {
            FormBanHang f = new FormBanHang();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
