using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHDN
{
    public partial class frmQLNHDN : Form
    {
        public frmQLNHDN()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        private void menuItemClicked(TabPage tb)
        {
            //Nguyên tắc DRY (Don't repeat yourself)
            tabMenu.TabPages.Clear();
            tabMenu.TabPages.Add(tb);
        }
        private void frmQLNHDN_Load(object sender, EventArgs e)
        {
            tabMenu.TabPages.Clear();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTaoHD);
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTaoPhieuNhap);
        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTaoPhieuXuat);
        }

        private void phiếuKiểmKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTaoPhieuKiemKe);
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTKDoanhThu);
        }

        private void tìnhHìnhNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTKNhap);
        }

        private void tìnhHìnhXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTKXuat);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTTKhachHang);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTTNhanVien);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTTSanPham);
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuItemClicked(tabTTNguyenLieu);
        }
    }
}
