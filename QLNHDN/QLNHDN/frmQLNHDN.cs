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

        #region Refresh
        void refreshInventoryList()
        {
            dgvNguyenLieu_TPKH.Rows.Clear();

            BUS.InventoryList bus = new BUS.InventoryList();
            DataTable dt = new DataTable();
            dt = bus.loadIngredient();

            dt.Columns.RemoveAt(6);
            dt.Columns.RemoveAt(5);

            foreach (DataRow dr in dt.Rows)
            {
                dgvNguyenLieu_TPKH.Rows.Add(dr.ItemArray);
            }
        }
        #endregion

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
            hienMotTab(tabTableMenu, tabHD1);
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
            refreshInventoryList();
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
            hienMotTab(tabTableMenu, tabHD2);
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD1 );
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD3 );
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD4 );
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD5 );
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD6 );
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD7 );
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD8 );
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD9 );
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD10 );
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD11 );
        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD12 );
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
                menuStripTuyChonBan.Show(btnHD1, 0, 0);
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

        private void btnHD2_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD2);
        }

        private void btnHD3_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD3);
        }

        private void btnHD4_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD4);
        }

        private void btnHD5_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD5);
        }

        private void btnHD6_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD6);
        }

        private void btnHD7_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD7);
        }

        private void btnHD8_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD8);
        }

        private void btnHD9_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD9);
        }

        private void btnHD10_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD10);
        }

        private void btnHD11_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD11);
        }

        private void btnHD12_Click(object sender, EventArgs e)
        {
            hienMotTab(tabTableMenu, tabHD12);
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void contextBillStatus_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem == itemStartBilling)
            {
                grpBill1.Visible = true;
                ContextMenuStrip menu = (ContextMenuStrip)sender;
                Console.WriteLine(menu.TopLevelControl.ToString());
            }
        }

        void showBill(GroupBox grpBill)
        {
            grpBill.Visible = true;
        }
        private void btnStart_Bill1_Click(object sender, EventArgs e)
        {
            showBill(grpBill1);
        }

        private void btnStart_Bill2_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill3_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill4_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill5_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill6_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill7_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill8_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill9_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill10_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill11_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Bill12_Click(object sender, EventArgs e)
        {

        }

        private void btnFoodSearching_Click(object sender, EventArgs e)
        {

        }

        private void btnLamLai_TPKH_Click(object sender, EventArgs e)
        {
            txtTimKiem_TPKH.Text = "";

            refreshInventoryList();

            btnLamMoi_TPKH.PerformClick();
        }

        private void btnLamMoi_TPKH_Click(object sender, EventArgs e)
        {
            dgvThongTinPhieu_TPKH.Rows.Clear();
        }

        private void btnXoaNL_TPKH_Click(object sender, EventArgs e)
        {
            if (dgvThongTinPhieu_TPKH.Rows.Count <= 0)
            {
                MessageBox.Show("Không có nguyên liệu để xoá! Vui lòng nhập nguyên liệu!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dgvThongTinPhieu_TPKH.SelectedRows.Count == 0)
                    dgvThongTinPhieu_TPKH.Rows.RemoveAt(dgvThongTinPhieu_TPKH.Rows.Count - 1);
                else dgvThongTinPhieu_TPKH.Rows.RemoveAt(dgvThongTinPhieu_TPKH.SelectedRows[0].Index);
            }
        }

        private void btnThemNL_TPKH_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (DataGridViewRow row in dgvThongTinPhieu_TPKH.Rows)
            {
                if (dgvNguyenLieu_TPKH.SelectedRows[0].Cells[1].Value == row.Cells[1].Value)
                {
                    MessageBox.Show("Nguyên liệu này đã được thêm. Hãy xoá để thêm lại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    check = 1;
                    break;
                }
            }
            if (check == 0)
            {
                dgvThongTinPhieu_TPKH.Rows.Add(dgvNguyenLieu_TPKH.SelectedRows[0].Cells[0].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[1].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[2].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[4].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[2].Value.ToString(), txtSLTon_TPKH.Text, txtSLHu_TPKH.Text);
            }
        }

        private void txtTimKiem_TPKH_TextChanged(object sender, EventArgs e)
        {
            dgvNguyenLieu_TPKH.Rows.Clear();

            BUS.InventoryList bus = new BUS.InventoryList();
            DataTable dt = new DataTable();
            dt = bus.searchIngredient(txtTimKiem_TPKH.Text);

            dt.Columns.RemoveAt(6);
            dt.Columns.RemoveAt(5);

            foreach (DataRow dr in dt.Rows)
            {
                dgvNguyenLieu_TPKH.Rows.Add(dr.ItemArray);
            }
        }

        private void dgvNguyenLieu_TPKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNguyenLieu_TPKH.SelectedRows.Count > 0 & dgvNguyenLieu_TPKH.Rows.Count > 0)
            {
                txtTenNL_TPKH.Text = dgvNguyenLieu_TPKH.SelectedRows[0].Cells[1].Value.ToString();
                txtDVT_TPKH.Text = dgvNguyenLieu_TPKH.SelectedRows[0].Cells[4].Value.ToString();
                txtSLHu_TPKH.Text = "0";
                txtSLTon_TPKH.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGioHienTai.Text = DateTime.Now.ToLongTimeString();
            lbNgayHienTai.Text = DateTime.Now.ToShortDateString();
        }
    }
}
