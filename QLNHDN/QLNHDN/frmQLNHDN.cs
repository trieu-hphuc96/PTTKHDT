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
        private void hienMotTab(TabControl tab_menu ,TabPage tab)
        {
            //Nguyên tắc DRY (Don't repeat yourself)
            tab_menu.TabPages.Clear();
            tab_menu.TabPages.Add(tab);
        }
        private void frmQLNHDN_Load(object sender, EventArgs e)
        {
            tabMenu.TabPages.Clear();
            hienMotTab(tabTableMenu, tabBan1);
        }
        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoHD);
            lblTitle.Text = "Tạo hoá đơn";
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoPhieuNhap);
        }

        private void phiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoPhieuXuat);
        }

        private void phiếuKiểmKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoPhieuKiemKe);
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTKDoanhThu);
        }

        private void tìnhHìnhNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTKNhap);
        }

        private void tìnhHìnhXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTKXuat);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTTKhachHang);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTTNhanVien);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTTSanPham);
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTTNguyenLieu);
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan2);
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan1);
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan3);
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan4);
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan5);
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan6);
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan7);
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan8);
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan9);
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan10);
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan11);
        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan12);
        }

        private void btnBan13_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan13);
        }

        private void btnBan14_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan14);
        }

        private void btnBan15_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan15);
        }

        private void btnBan16_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan16);
        }

        private void btnBan17_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan17);
        }

        private void btnBan18_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan18);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                menuStripTuyChonBan.Show(btnBan1, 0, 0);
            }
        }
    }
}
