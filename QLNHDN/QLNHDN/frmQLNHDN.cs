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
        private void hienMotTab(TabControl tab_menu ,TabPage tab, string title)
        {
            //Nguyên tắc DRY (Don't repeat yourself)
            tab_menu.TabPages.Clear();
            tab_menu.TabPages.Add(tab);
            lblTitle.Text = title;
        }
        private void frmQLNHDN_Load(object sender, EventArgs e)
        {
            tabMenu.TabPages.Clear();
            hienMotTab(tabTableMenu, tabBan1, "Tính tiền");
        }
        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoHD,"Tính tiền");
        }

        private void phiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoPhieuNhap, "Tạo phiếu nhập hàng");
        }

        private void phiếuKiểmKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoPhieuKiemKe, "Tạo phiếu kiểm hàng tồn");
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTKDoanhThu, "Thống kê doanh thu");
        }

        private void tìnhHìnhNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTKNhap, "Thống kê nhập hàng");
        }

        private void tìnhHìnhXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTKTon, "Thống kê tồn hàng");
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTTKhachHang, "Thông tin khách hàng");
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTTNhanVien, "Thông tin nhân viên");
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTTSanPham, "Thông tin sản phẩm");
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTTNguyenLieu, "Thông tin nguyên liệu");
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan2, "Tính tiền");
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan1, "Tính tiền");
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan3, "Tính tiền");
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan4, "Tính tiền");
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan5, "Tính tiền");
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan6, "Tính tiền");
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan7, "Tính tiền");
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan8, "Tính tiền");
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan9, "Tính tiền");
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan10, "Tính tiền");
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan11, "Tính tiền");
        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabBan12, "Tính tiền");
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
    }
}
