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
using DTO;

namespace QLNHDN
{
    public partial class frmQLNHDN : Form
    {
        #region Variable
        DataTable dtThongTinChiTiet_KTTHHT = new DataTable();
        int tongtienHH_PN, tongtienTT_PN;
        #endregion
        public frmQLNHDN(frmDangNhap fDN, DataTable dtNhanVien)
        {
            InitializeComponent();

            lbNhanVien.Text = dtNhanVien.Rows[0].Field<string>(1)+"!";

            if(dtNhanVien.Rows[0].Field<int>(8) != 1)
            {
                thốngKêToolStripMenuItem.Visible = false;
                menuItemQLNhanVien.Visible = false;
                menuItemSanPham.Visible = false;
                menuItemNguyenLieu.Visible = false;
            }
        }

        #region Refresh
        void refreshInventoryList()
        {
            dgvNguyenLieu_TPKH.Rows.Clear();

            BUS.Ingredients bus = new BUS.Ingredients();
            DataTable dt = new DataTable();
            dt = bus.loadIngredients();

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
            dt = bus.searchInventoryList_byDate(dtpTuNgay_KTTHHT.Value.Date, dtpDenNgay_KTTHHT.Value.Date);

            dt.Columns["MaNV"].SetOrdinal(1);

            foreach (DataRow dr in dt.Rows)
            {
                dgvThongTinPhieuKiem_KTTHHT.Rows.Add(dr.ItemArray);
            }
        }

        void refreshGoodsReceipt()
        {
            dgvNguyenLieu_PN.Rows.Clear();

            BUS.Ingredients bus = new BUS.Ingredients();
            DataTable dt = new DataTable();
            dt = bus.loadIngredients();

            dt.Columns["Gia"].SetOrdinal(3);

            foreach (DataRow dr in dt.Rows)
            {
                dgvNguyenLieu_PN.Rows.Add(dr.ItemArray);
            }
        }

        void refreshCheckGoodsReceiptState()
        {
            dgvNguyenLieu_TPKH.Rows.Clear();

            BUS.GoodsReceipt bus = new BUS.GoodsReceipt();
            DataTable dt = new DataTable();
            dt = bus.searchGoodsReceipt_byDate(dtpTuNgay_KTNH.Value.Date, dtpDenNgay_KTNH.Value.Date);

            dt.Columns["MaNV"].SetOrdinal(1);

            foreach (DataRow dr in dt.Rows)
            {
                dgvPhieuNhap_KTNH.Rows.Add(dr.ItemArray);
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
            hienMotTab(tablistBill, tabBill1);
            lblTitle.Text = "Trang chủ";
        }
        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTinhTien);
        }

        private void menuItemPhieuNhap_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoPhieuNhap);
            refreshGoodsReceipt();
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

        private void tìnhHìnhNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabKTTHNhap);
            refreshCheckGoodsReceiptState();
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
            hienMotTab(tablistBill, tabBill2);
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill1 );
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill3 );
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill4 );
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill5 );
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill6 );
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill7 );
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill8 );
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill9 );
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill10 );
        }

        private void btnBan11_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill11 );
        }

        private void btnBan12_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill12 );
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
        private void btnHuyHD_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_MouseClick(object sender, MouseEventArgs e)
        {
            //if(e.Button == MouseButtons.Right)
            //{
            //    menuStripTuyChonBan.Show(btnHD1, 0, 0);
            //}
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
        private void txt_Ban1_SoLuong_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnBill1_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill1);
        }
        private void btnHD2_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill2);
        }

        private void btnHD3_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill3);
        }

        private void btnHD4_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill4);
        }

        private void btnHD5_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill5);
        }

        private void btnHD6_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill6);
        }

        private void btnHD7_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill7);
        }

        private void btnHD8_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill8);
        }

        private void btnHD9_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill9);
        }

        private void btnHD10_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill10);
        }

        private void btnHD11_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill11);
        }

        private void btnHD12_Click(object sender, EventArgs e)
        {
            hienMotTab(tablistBill, tabBill12);
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
            grpBill.Enabled = true;
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

        //Hàm chuyển đổi từ Số thành Tiền tệ
        private string VNDfromNumber(int number)
        {
            return number.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
        }
        //Hàm chuyển đổi từ Tiền tệ thành Số
        private int NumberFromVND(string currency)
        {
            return int.Parse(currency, System.Globalization.NumberStyles.Currency, new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btnFoodSearching_Click(object sender, EventArgs e)
        {
            string keyword = txtFoodSearching.Text;
            BUS.BillManagement bill = new BUS.BillManagement();           
            gridFood.DataSource = bill.loadFoodList(keyword);
            gridFood.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void btnBeverageSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtBeverageSearch.Text;
            BUS.BillManagement bill = new BUS.BillManagement();
            gridBeverage.DataSource = bill.loadBeverageList(keyword);
            gridBeverage.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }
        private DataGridView billDetailOf(TabPage tabBill)
        {
            string current_tab_name = tabBill.Name;
            switch(current_tab_name)
            {
                case "tabBill1": return gridBillDetail_Bill1;
            }
            return null;
        }

        private void addProductToBill(DataGridView p_gridProduct, DataGridView p_gridBill, TextBox p_Quantity)
        {
            errorProvider.Clear();
            try
            {
                string product_ID = p_gridProduct.SelectedRows[0].Cells[0].Value.ToString();
                string product_Name = p_gridProduct.SelectedRows[0].Cells[1].Value.ToString();
                string product_Price = p_gridProduct.SelectedRows[0].Cells[2].Value.ToString();
                string product_Quantity = p_Quantity.Text;
                string product_TypeName = p_gridProduct.SelectedRows[0].Cells[3].Value.ToString();

                //Kiểm tra xem mã SP này đã có trong HĐ chưa.
                bool already_added = false;
                foreach (DataGridViewRow row in p_gridBill.Rows)
                {
                    if (row.Cells[0].Value.ToString() == product_ID)
                    {
                        int quantity = Convert.ToInt32(row.Cells[3].Value);
                        quantity += Convert.ToInt16(product_Quantity);
                        row.Cells["colProductQuantity_Bill1"].Value = quantity.ToString();
                        row.Cells["colSumPrice_Bill1"].Value = VNDfromNumber(quantity * (NumberFromVND(product_Price)));
                        already_added = true;
                        break;
                    }
                }
                //Nếu chưa thì thêm một dòng mới vào bảng
                if (already_added == false)
                {
                    string product_SumPrice = VNDfromNumber(NumberFromVND(product_Price) * Convert.ToInt32(product_Quantity));
                    DataGridViewRow product_row = new DataGridViewRow();
                    product_row.CreateCells(p_gridBill, product_ID, product_Name, product_Price, product_Quantity, 
                        product_SumPrice, product_TypeName);
                    p_gridBill.Rows.Add(product_row);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                errorProvider.SetError(p_gridProduct, "Chưa chọn món ăn/thức uống!");
            }
            catch(FormatException)
            {
                errorProvider.SetError(p_Quantity, "Chưa nhập số lượng!");
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            DataGridView current_bill_detail = billDetailOf(tablistBill.SelectedTab);
            addProductToBill(gridFood, current_bill_detail, txtFoodQuantity);
            switch(current_bill_detail.Name)
            {
                case "gridBillDetail_Bill1": btnCalculateSum_Bill1_Click(sender, e); break;
            }
        }


        private void btnAddBeverage_Click(object sender, EventArgs e)
        {
            DataGridView current_bill_detail = billDetailOf(tablistBill.SelectedTab);
            addProductToBill(gridBeverage, current_bill_detail, txtBeverageQuantity);
            switch (current_bill_detail.Name)
            {
                case "gridBillDetail_Bill1": btnCalculateSum_Bill1_Click(sender, e); break;
            }
        }

        private void gridBillDetail_Bill1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView dgv = ((DataGridView)sender);
                int row_index = dgv.HitTest(e.X, e.Y).RowIndex;
                dgv.ClearSelection();
                if (row_index == -1) return;
                dgv.Rows[row_index].Selected = true;
                contextBillItemSelection.Show(dgv, e.X, e.Y);
            }
        }

        private void btnChangeCustomerID_Bill1_Click(object sender, EventArgs e)
        {
            BUS.BillManagement bus = new BUS.BillManagement();
            Customer customer = bus.getCustomerDetail(txtCustomerID_Bill1.Text);
            if (customer.CustomerID == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Lỗi", MessageBoxButtons.OK);
                txtCustomerID_Bill1.Text = "1";
                btnChangeCustomerID_Bill1_Click(sender, e);
            }
            else
            {
                txtCustomerID_Bill1.Text = customer.CustomerID;
                txtDiscountRate_Bill1.Text = customer.DiscountRate.ToString();
            }
            btnCalculateSum_Bill1_Click(sender, e);
        }

        private void btnCustomerDetail_Bill1_Click(object sender, EventArgs e)
        {
            BUS.BillManagement bus = new BUS.BillManagement();
            Customer customer = bus.getCustomerDetail(txtCustomerID_Bill1.Text);
            StringBuilder sb_customer_info = new StringBuilder();
            sb_customer_info.AppendLine("Mã KH: " + customer.CustomerID);
            sb_customer_info.AppendLine("Họ tên KH: " + customer.FullName);
            sb_customer_info.AppendLine("CMND: " + customer.ID_Number);
            sb_customer_info.AppendLine("Số điện thoại: " + customer.PhoneNumber);
            sb_customer_info.AppendLine("Cấp độ khách hàng: " + customer.Type);
            sb_customer_info.AppendLine("Tỉ lệ chiết khấu: " + customer.DiscountRate);

            MessageBox.Show(sb_customer_info.ToString());
        }

        private void txtCustomerID_Bill1_Leave(object sender, EventArgs e)
        {
            if (txtCustomerID_Bill1.Text == "")
            {
                txtCustomerID_Bill1.Text = "1";
                btnChangeCustomerID_Bill1_Click(sender, e);
            }
        }

        private void btnCalculateSum_Bill1_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in gridBillDetail_Bill1.Rows)
            {
                int productSumPrice = NumberFromVND(row.Cells["colSumPrice_Bill1"].Value.ToString());
                total += productSumPrice;
            }
            double discountRate = Convert.ToDouble(txtDiscountRate_Bill1.Text);
            int discountAmount = (int)(total * discountRate);
            int actualTotal = total - discountAmount;

            txtTotal_Bill1.Text = VNDfromNumber(total);
            txtDiscountAmount_Bill1.Text = VNDfromNumber(discountAmount);
            txtActualTotal_Bill1.Text = VNDfromNumber(actualTotal);
        }

        private void itemEdit_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)contextBillItemSelection.SourceControl;
            int col_index = dgv.CurrentCell.ColumnIndex;
            dgv.CurrentCell = dgv.SelectedRows[0].Cells[col_index];
            dgv.BeginEdit(true);
        }

        private void gridBillDetail_Bill1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gridBillDetail_Bill1.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void tồnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabKTTHHangTon);
            refreshCheckInventoryState();
        }
        private void gridBillDetail_Bill1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int quantity;
            bool check = int.TryParse(e.FormattedValue.ToString(), out quantity);
            if (check == false || quantity < 0)
            {
                dgv.Rows[e.RowIndex].ErrorText = "Số lượng không hợp lệ!";
                e.Cancel = true;
            }
        }

        private void itemDelete_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Bạn muốn xoá dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                gridBillDetail_Bill1.Rows.Remove(gridBillDetail_Bill1.SelectedRows[0]);
                btnCalculateSum_Bill1_Click(sender, e);
            }
        }
        //Phần của Phúc
        private void btnLamMoi_TPKH_Click(object sender, EventArgs e)
        {
            txtTimKiem_TPKH.Text = "";

            refreshInventoryList();

            btnXoaHet_TPKH.PerformClick();
        }

        private void btnXoaHet_TPKH_Click(object sender, EventArgs e)
        {
            if (dgvThongTinPhieu_TPKH.Rows.Count <= 0)
            {
                MessageBox.Show("Không có nguyên liệu để xoá! Vui lòng nhập nguyên liệu!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn có chắc chắn muốn xoá hết nguyên liệu trong phiếu kiểm?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                dgvThongTinPhieu_TPKH.Rows.Clear();
            }
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

            BUS.Ingredients bus = new BUS.Ingredients();
            DataTable dt = new DataTable();
            dt = bus.searchIngredients(txtTimKiem_TPKH.Text);

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
            if(dgvThongTinPhieu_TPKH.Rows.Count == 0)
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
                    btnLamMoi_TPKH.PerformClick();
                }
            }            
        }

        private void txtSLTon_TPKH_Enter(object sender, EventArgs e)
        {
            if(txtSLTon_TPKH.Text == "0")
            {
                txtSLTon_TPKH.Text = "";
            }
        }

        private void txtSLTon_TPKH_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtSLTon_TPKH.Text, "[0 - 9]$", RegexOptions.IgnoreCase))
            {
                //this.Refresh();
                txtSLTon_TPKH.Text = "";
            }
        }

        private void txtSLTon_TPKH_Leave(object sender, EventArgs e)
        {
            if(txtSLTon_TPKH.Text == "")
            {
                txtSLTon_TPKH.Text = "0";
            }

            if (txtSLTon_TPKH.Text == "")
            {
                txtSLTon_TPKH.Text = "1";
            }
            Decimal d;
            if (decimal.TryParse(txtSLTon_TPKH.Text, out d))
            {
                MessageBox.Show("Vui lòng nhập số!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSLHu_TPKH_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtSLHu_TPKH.ToString(), "[0 - 9]$", RegexOptions.IgnoreCase))
            {
                txtSLHu_TPKH.Text = "";
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

            if (txtSLHu_TPKH.Text == "")
            {
                txtSLHu_TPKH.Text = "1";
            }
            Decimal d;
            if (decimal.TryParse(txtSLHu_TPKH.Text, out d))
            {
                MessageBox.Show("Vui lòng nhập số!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtTimKiemNL_PN_TextChanged(object sender, EventArgs e)
        {
            dgvNguyenLieu_PN.Rows.Clear();

            BUS.Ingredients bus = new BUS.Ingredients();
            DataTable dt = new DataTable();
            dt = bus.searchIngredients(txtTimKiemNL_PN.Text);

            dt.Columns["Gia"].SetOrdinal(3);

            foreach (DataRow dr in dt.Rows)
            {
                dgvNguyenLieu_PN.Rows.Add(dr.ItemArray);
            }
        }

        private void txtSoLuong_PN_Enter(object sender, EventArgs e)
        {
            txtSoLuong_PN.Text = "";
        }

        private void txtSoLuong_PN_Leave(object sender, EventArgs e)
        {
            if (txtSoLuong_PN.Text == "")
            {
                txtSoLuong_PN.Text = "1";
            }
            Decimal d;
            if (!decimal.TryParse(txtSoLuong_PN.Text,out d))
            {
                MessageBox.Show("Vui lòng nhập số!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_PN_Click(object sender, EventArgs e)
        {
            int check = 0;
            foreach (DataGridViewRow row in dgvPhieuNhap_PN.Rows)
            {
                if (dgvNguyenLieu_PN.SelectedRows[0].Cells[1].Value == row.Cells[1].Value && cboNhaCC_PN.Text == row.Cells[2].Value.ToString())
                {
                    dgvPhieuNhap_PN.Rows[row.Index].Cells[5].Value = (Convert.ToDecimal(dgvPhieuNhap_PN.Rows[row.Index].Cells[5].Value.ToString()) + Convert.ToDecimal(txtSoLuong_PN.Text)).ToString();
                    dgvPhieuNhap_PN.Rows[row.Index].Cells[6].Value = (Convert.ToDecimal(dgvPhieuNhap_PN.Rows[row.Index].Cells[5].Value.ToString()) * Convert.ToDecimal(dgvPhieuNhap_PN.Rows[row.Index].Cells[4].Value.ToString())).ToString();
                    check = 1;
                    break;
                }
            }
            if (check == 0)
            {
                dgvPhieuNhap_PN.Rows.Add(dgvNguyenLieu_PN.SelectedRows[0].Cells[0].Value.ToString(), dgvNguyenLieu_PN.SelectedRows[0].Cells[1].Value.ToString(), cboNhaCC_PN.Text, dgvNguyenLieu_PN.SelectedRows[0].Cells[2].Value.ToString(), dgvNguyenLieu_PN.SelectedRows[0].Cells[3].Value.ToString(), txtSoLuong_PN.Text, (Convert.ToDecimal(dgvNguyenLieu_PN.SelectedRows[0].Cells[3].Value.ToString()) * Convert.ToDecimal(txtSoLuong_PN.Text)).ToString());
            }

            //tính tiền
            tongtienHH_PN = 0;
            for(int i = 0; i < dgvPhieuNhap_PN.RowCount; i++)
            {
                tongtienHH_PN = tongtienHH_PN + Convert.ToInt32(dgvPhieuNhap_PN.Rows[i].Cells[6].Value.ToString());
            }
            int thue = tongtienHH_PN * 10 / 100;
            tongtienTT_PN = tongtienHH_PN + thue;

            txtTongTien_PN.Text = String.Format("{0:0,0}", tongtienHH_PN);
            txtThue_PN.Text = String.Format("{0:0,0}", thue);
            txtTongTien_TT_PN.Text = String.Format("{0:0,0}", tongtienTT_PN);
        }

        private void dgvNguyenLieu_PN_SelectionChanged(object sender, EventArgs e)
        {
            txtSoLuong_PN.Text = "1";
            cboNhaCC_PN.SelectedItem = "BigC";
        }

        private void btnXoa_PN_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap_PN.Rows.Count <= 0)
            {
                MessageBox.Show("Không có nguyên liệu để xoá! Vui lòng nhập nguyên liệu!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dgvPhieuNhap_PN.SelectedRows.Count == 0)
                    dgvPhieuNhap_PN.Rows.RemoveAt(dgvPhieuNhap_PN.Rows.Count - 1);
                else dgvPhieuNhap_PN.Rows.RemoveAt(dgvPhieuNhap_PN.SelectedRows[0].Index);
            }
        }

        private void txtSoLuong_PN_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtSoLuong_PN.Text, "[0-9]$", RegexOptions.IgnoreCase))
            {
                txtSoLuong_PN.Text = "";
            }
        }

        private void btnLamMoi_PN_Click(object sender, EventArgs e)
        {
            txtTimKiemNL_PN.Text = "";

            refreshGoodsReceipt();

            btnXoaHet_PN.PerformClick();
        }

        private void btnTaoPhieu_PN_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap_PN.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập nguyên liệu trước khi tạo phiếu!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DTO.GoodsReceiptDetails[] dto_CT = new DTO.GoodsReceiptDetails[30];
                if (dgvPhieuNhap_PN.Rows.Count > 0)
                    for (int i = 0; i < dgvPhieuNhap_PN.Rows.Count; i++)
                    {
                        dto_CT[i] = new DTO.GoodsReceiptDetails();
                        dto_CT[i].Manl = Convert.ToInt32(dgvPhieuNhap_PN.Rows[i].Cells[0].Value.ToString());
                        dto_CT[i].Nhacc = dgvPhieuNhap_PN.Rows[i].Cells[2].Value.ToString();
                        dto_CT[i].Gianhap = Convert.ToInt32(dgvPhieuNhap_PN.Rows[i].Cells[4].Value.ToString());
                        dto_CT[i].Soluong = Convert.ToDecimal(dgvPhieuNhap_PN.Rows[i].Cells[5].Value.ToString());
                    }
                else dto_CT[0] = new DTO.GoodsReceiptDetails();

                DTO.GoodsReceipt dto_PNH = new DTO.GoodsReceipt();
                dto_PNH.Manv = 1;
                dto_PNH.Ngaygio = DateTime.Now;

                BUS.GoodsReceipt bus = new BUS.GoodsReceipt();
                int check = bus.createGoodsReceipt(dto_PNH, dto_CT, dgvPhieuNhap_PN.Rows.Count);
                if (check == 1)
                {
                    btnLamMoi_PN.PerformClick();
                }
            }
        }

        private void btnTimKiem_KTNH_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay_KTNH.Value.Date > dtpDenNgay_KTNH.Value.Date)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày. Vui lòng nhập lại!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvPhieuNhap_KTNH.Rows.Clear();
                dgvPhieuNhap_ChiTiet_KTNH.Rows.Clear();

                BUS.GoodsReceipt bus = new BUS.GoodsReceipt();
                DataTable dt = new DataTable();
                dt = bus.searchGoodsReceipt_byDate(dtpTuNgay_KTNH.Value.Date, dtpDenNgay_KTNH.Value.Date);

                dt.Columns["MaNV"].SetOrdinal(1);

                foreach (DataRow dr in dt.Rows)
                {
                    dgvPhieuNhap_KTNH.Rows.Add(dr.ItemArray);
                }
            }
        }

        private void txtTimKiem_KTNH_TextChanged(object sender, EventArgs e)
        {
            dgvPhieuNhap_ChiTiet_KTNH.Rows.Clear();
            dgvPhieuNhap_KTNH.Rows.Clear();

            BUS.GoodsReceipt bus = new BUS.GoodsReceipt();
            DataTable dt = new DataTable();
            dt = bus.searchGoodsReceipt_byNumber(txtTimKiem_KTNH.Text);
            dt.Columns["MaNV"].SetOrdinal(1);
            foreach (DataRow dr in dt.Rows)
            {
                dgvPhieuNhap_KTNH.Rows.Add(dr.ItemArray);
            }
        }

        private void dgvPhieuNhap_KTNH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuNhap_KTNH.SelectedRows.Count > 0 & dgvPhieuNhap_KTNH.Rows.Count > 0)
            {
                dgvPhieuNhap_ChiTiet_KTNH.Rows.Clear();

                BUS.GoodsReceiptDetails bus = new BUS.GoodsReceiptDetails();
                DataTable dt = new DataTable();
                dt = bus.loadGoodsReceiptDetails(Convert.ToInt32(dgvPhieuNhap_KTNH.SelectedRows[0].Cells[0].Value.ToString()));

                dt.Columns.RemoveAt(0);
                dt.Columns["TenNL"].SetOrdinal(1);
                dt.Columns["DonVi"].SetOrdinal(3);

                foreach (DataRow dr in dt.Rows)
                {
                    dgvPhieuNhap_ChiTiet_KTNH.Rows.Add(dr.ItemArray);
                }
                int tongtienHH = 0, thue, tongtienTT;
                if (dgvPhieuNhap_ChiTiet_KTNH.SelectedRows.Count > 0 & dgvPhieuNhap_ChiTiet_KTNH.Rows.Count > 0)
                {
                    for(int i = 0; i < dgvPhieuNhap_ChiTiet_KTNH.RowCount; i++)
                    {
                        tongtienHH += Convert.ToInt32(Convert.ToDecimal(dgvPhieuNhap_ChiTiet_KTNH.Rows[i].Cells[4].Value.ToString()) * Convert.ToDecimal(dgvPhieuNhap_ChiTiet_KTNH.Rows[i].Cells[5].Value.ToString()));
                    }
                    thue = tongtienHH * 10 / 100;
                    tongtienTT = tongtienHH + thue;
                    txtTongTienHH_KTNH.Text = String.Format("{0:0,0}", tongtienHH);
                    txtThue_KTNH.Text = String.Format("{0:0,0}", thue);
                    txtTongTienTT_KTNH.Text = String.Format("{0:0,0}", tongtienTT);
                }
            }
        }

        private void btnXoaHet_PN_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap_PN.Rows.Count <= 0)
            {
                MessageBox.Show("Không có nguyên liệu để xoá! Vui lòng nhập nguyên liệu!", "Nhắc nhở!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn có chắc chắn muốn xoá hết nguyên liệu trong phiếu kiểm?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                dgvPhieuNhap_PN.Rows.Clear();
            }
        }

        
    }
}
