using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

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
            hienMotTab(tablistBill, tabBill1);
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

        private void tồnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTKTon);
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
                case "tabBill2": return gridBillDetail_Bill2;
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
