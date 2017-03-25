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
            lblTitle.Text = tab.Text;
        }
        private void frmQLNHDN_Load(object sender, EventArgs e)
        {
            tabMenu.TabPages.Clear();
            hienMotTab(tabTableMenu, tabBan1);
            lblTitle.Text = "Trang chủ";
        }
        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTinhTien);
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoPhieuNhap);
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
            hienMotTab(tabMenu, tabTKTon);
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
            hienMotTab(tabTableMenu, tabBan1 );
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan3 );
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan4 );
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan5 );
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan6 );
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan7 );
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan8 );
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan9 );
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan10 );
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan11 );
        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan12 );
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

        private void btn_Ban1_ThemMon_Click(object sender, EventArgs e)
        {
            frmThemMon them_mon = new frmThemMon();
            them_mon.ShowDialog();
        }

        private void btn_Ban1_ThemThucUong_Click(object sender, EventArgs e)
        {
            frmThemThucUong them_thuc_uong = new frmThemThucUong();
            them_thuc_uong.ShowDialog();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txt_Ban1_SoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tồnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTKTon);
        }
    }
}
