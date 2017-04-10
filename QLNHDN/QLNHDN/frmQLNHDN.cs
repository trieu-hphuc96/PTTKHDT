using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHDN
{
    public partial class frmQLNHDN : Form
    {
        #region Variable
        DataTable dtThongTinChiTiet_KTTHHT = new DataTable();
        #endregion
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

        void refreshCheckInventoryState()
        {
            dgvThongTinPhieuKiem_KTTHHT.Rows.Clear();
            BUS.InventoryList bus = new BUS.InventoryList();
            DataTable dt = new DataTable();
            dt = bus.loadInventoryList();

            dt.Columns["MaNV"].SetOrdinal(1);

            foreach (DataRow dr in dt.Rows)
            {
                dgvThongTinPhieuKiem_KTTHHT.Rows.Add(dr.ItemArray);
            }
        }
        #endregion

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void hienMotTab(TabControl tab_menu, TabPage tab)
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
            hienMotTab(tabMenu, tabTaoPhieuKiemHangTon);
            refreshInventoryList();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTKDoanhThu);
        }

        private void tìnhHìnhNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabKTTHNhap);
        }

        private void tìnhHìnhXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabKTTHHangTon);
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
            if (e.Button == MouseButtons.Right)
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
            hienMotTab(tabMenu, tabKTTHHangTon);
            refreshCheckInventoryState();
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
                dgvThongTinPhieu_TPKH.Rows.Add(dgvNguyenLieu_TPKH.SelectedRows[0].Cells[0].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[1].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[2].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[4].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[3].Value.ToString(), txtSLTon_TPKH.Text, txtSLHu_TPKH.Text);
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

        private void btnTaoPhieu_TPKH_Click(object sender, EventArgs e)
        {
            if (dgvThongTinPhieu_TPKH.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập nguyên liệu trước khi tạo phiếu!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO.InventoryListDetails[] dto_CT = new DTO.InventoryListDetails[30];
                if (dgvThongTinPhieu_TPKH.Rows.Count > 0)
                    for (int i = 0; i < dgvThongTinPhieu_TPKH.Rows.Count; i++)
                    {
                        dto_CT[i] = new DTO.InventoryListDetails();
                        dto_CT[i].Manl = Convert.ToInt32(dgvThongTinPhieu_TPKH.Rows[i].Cells[0].Value.ToString());
                        dto_CT[i].Gia = Convert.ToInt32(dgvThongTinPhieu_TPKH.Rows[i].Cells[2].Value.ToString());
                        dto_CT[i].Donvi = dgvThongTinPhieu_TPKH.Rows[i].Cells[3].Value.ToString();
                        dto_CT[i].Sltonlt = Convert.ToDecimal(dgvThongTinPhieu_TPKH.Rows[i].Cells[4].Value.ToString());
                        dto_CT[i].Sltontt = Convert.ToDecimal(dgvThongTinPhieu_TPKH.Rows[i].Cells[5].Value.ToString());
                        dto_CT[i].Slhu = Convert.ToDecimal(dgvThongTinPhieu_TPKH.Rows[i].Cells[6].Value.ToString());
                    }
                else dto_CT[0] = new DTO.InventoryListDetails();

                DTO.InventoryList dto_PKH = new DTO.InventoryList();
                dto_PKH.Manv = 1;
                dto_PKH.Ngaygio = DateTime.Now;

                BUS.InventoryList bus = new BUS.InventoryList();
                int check = bus.createInventoryList(dto_PKH, dto_CT, dgvThongTinPhieu_TPKH.Rows.Count);
                if (check == 1)
                {
                    btnLamLai_TPKH.PerformClick();
                }
            }
        }

        private void txtSLTon_TPKH_Enter(object sender, EventArgs e)
        {
            if (txtSLTon_TPKH.Text == "0")
            {
                txtSLTon_TPKH.Text = "";
            }
        }

        private void txtSLTon_TPKH_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtSLTon_TPKH.Text.ToString().Length; i++)
            {
                if (!Regex.IsMatch(txtSLTon_TPKH.Text.ToString()[i].ToString(), "[0-9]", RegexOptions.IgnoreCase))
                {
                    //this.Refresh();
                    txtSLTon_TPKH.Text = "";
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ////Point locationOnForm = tabControl1.FindForm().PointToClient(tabControl1.Parent.PointToScreen(tabControl1.Location));
            ////Point location = txtSLTon_TPKH.PointToScreen(Point.Empty);
            //Point location1 = tabTaoPhieuKiemHangTon.PointToClient(txtSLTon_TPKH.Location);
            //txtSLTon_TPKH.BorderStyle = BorderStyle.None;
            //    Pen p = new Pen(Color.Red);
            //    Graphics g = e.Graphics;
            //    int variance = 3;
            //    g.DrawRectangle(p, new Rectangle(location1.X - variance, location1.Y - variance, txtSLTon_TPKH.Width + variance, txtSLTon_TPKH.Height + variance));

        }

        private void txtSLTon_TPKH_Leave(object sender, EventArgs e)
        {
            if (txtSLTon_TPKH.Text == "")
            {
                txtSLTon_TPKH.Text = "0";
            }
        }

        private void txtSLHu_TPKH_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtSLHu_TPKH.Text.ToString().Length; i++)
            {
                if (!Regex.IsMatch(txtSLHu_TPKH.Text.ToString()[i].ToString(), "[0-9]", RegexOptions.IgnoreCase))
                {
                    txtSLHu_TPKH.Text = "";
                }
            }
        }

        private void txtSLHu_TPKH_Enter(object sender, EventArgs e)
        {
            if (txtSLHu_TPKH.Text == "0")
            {
                txtSLHu_TPKH.Text = "";
            }
        }

        private void txtSLHu_TPKH_Leave(object sender, EventArgs e)
        {
            if (txtSLHu_TPKH.Text == "")
            {
                txtSLHu_TPKH.Text = "0";
            }
        }

        private void btnTimKiem_KTTHHT_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay_KTTHHT.Value.Date > dtpDenNgay_KTTHHT.Value.Date)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày. Vui lòng nhập lại!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvThongTinChiTiet_KTTHHT.Rows.Clear();
                dgvThongTinPhieuKiem_KTTHHT.Rows.Clear();

                BUS.InventoryList bus = new BUS.InventoryList();
                DataTable dt = new DataTable();
                dt = bus.searchInventoryList_byDate(dtpTuNgay_KTTHHT.Value.Date, dtpDenNgay_KTTHHT.Value.Date);
                dt.Columns["MaNV"].SetOrdinal(1);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvThongTinPhieuKiem_KTTHHT.Rows.Add(dr.ItemArray);
                }
            }
        }

        private void txtTimKiem_KTTHHT_TextChanged(object sender, EventArgs e)
        {
            dgvThongTinChiTiet_KTTHHT.Rows.Clear();
            dgvThongTinPhieuKiem_KTTHHT.Rows.Clear();

            BUS.InventoryList bus = new BUS.InventoryList();
            DataTable dt = new DataTable();
            dt = bus.searchInventoryList_byNumber(txtTimKiem_KTTHHT.Text);
            dt.Columns["MaNV"].SetOrdinal(1);
            foreach (DataRow dr in dt.Rows)
            {
                dgvThongTinPhieuKiem_KTTHHT.Rows.Add(dr.ItemArray);
            }
        }

        private void dgvThongTinPhieuKiem_KTTHHT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTinPhieuKiem_KTTHHT.SelectedRows.Count > 0 & dgvThongTinPhieuKiem_KTTHHT.Rows.Count > 0)
            {
                dgvThongTinChiTiet_KTTHHT.Rows.Clear();

                txtTenNL_KTTHHT.Text = "";
                txtDonVi_KTTHHT.Text = "";
                txtGia_KTTHHT.Text = "0";
                txtSLHaoHut_KTTHHT.Text = "0";
                txtSoTienHaoHut_KTTHHT.Text = "0";
                txtTongTienHaoHut_KTTHHT.Text = "0";


                BUS.InventoryListDetails bus = new BUS.InventoryListDetails();
                dtThongTinChiTiet_KTTHHT = bus.loadInventoryListDetails(Convert.ToInt32(dgvThongTinPhieuKiem_KTTHHT.SelectedRows[0].Cells[0].Value.ToString()));

                dtThongTinChiTiet_KTTHHT.Columns["TenNL"].SetOrdinal(2);
                dtThongTinChiTiet_KTTHHT.Columns["DonVi"].SetOrdinal(4);

                foreach (DataRow dr in dtThongTinChiTiet_KTTHHT.Rows)
                {
                    dgvThongTinChiTiet_KTTHHT.Rows.Add(dr.ItemArray);
                }

                if (dgvThongTinChiTiet_KTTHHT.SelectedRows.Count > 0 & dgvThongTinChiTiet_KTTHHT.Rows.Count > 0)
                {
                    txtTongTienHaoHut_KTTHHT.Text = String.Format("{0:0,0}", Convert.ToDouble(dtThongTinChiTiet_KTTHHT.Rows[0].ItemArray[9].ToString()));
                }
            }
        }

        private void dgvThongTinChiTiet_KTTHHT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongTinChiTiet_KTTHHT.SelectedRows.Count > 0 & dgvThongTinChiTiet_KTTHHT.Rows.Count > 0)
            {
                txtTenNL_KTTHHT.Text = dgvThongTinChiTiet_KTTHHT.SelectedRows[0].Cells[2].Value.ToString();
                txtDonVi_KTTHHT.Text = dgvThongTinChiTiet_KTTHHT.SelectedRows[0].Cells[4].Value.ToString();
                txtGia_KTTHHT.Text = String.Format("{0:0,0}", Convert.ToInt32(dgvThongTinChiTiet_KTTHHT.SelectedRows[0].Cells[3].Value.ToString()));
                txtSLHaoHut_KTTHHT.Text = dgvThongTinChiTiet_KTTHHT.SelectedRows[0].Cells[8].Value.ToString();
                txtSoTienHaoHut_KTTHHT.Text = String.Format("{0:0,0}", Convert.ToDouble(dgvThongTinChiTiet_KTTHHT.SelectedRows[0].Cells[3].Value.ToString()) * Convert.ToDouble(txtSLHaoHut_KTTHHT.Text));
            }
        } 
    }
}
