using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DTO;
using System.Drawing.Printing;
using System.Drawing;

namespace QLNHDN
{
    public partial class frmQLNHDN : Form
    {
        #region Variable
        DataTable dtThongTinChiTiet_KTTHHT = new DataTable();
        int tongtienHH_PN, tongtienTT_PN;
        Staff current_staff;
        Bill[] bill;
        int currentBillIndex;
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
            current_staff = new Staff("1");
            InitializeBillList();
        }

        private void InitializeBillList()
        {
            const int bill_count = 12;
            bill = new Bill[bill_count];
            for(int i = 0; i < bill_count; i++)
            {
                bill[i] = new Bill();
                bill[i].Staff = current_staff;
            }
            currentBillIndex = 0;
            showBill(0);
        }

        #region Refresh
        void refreshInventoryList()
        {
            dgvNguyenLieu_TPKH.Rows.Clear();

            BUS.Ingredients bus = new BUS.Ingredients();
            DataTable dt = new DataTable();
            dt = bus.loadIngredients();

            dt.Columns.RemoveAt(6);
            dt.Columns.RemoveAt(3);

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

        private void frmQLNHDN_Load(object sender, EventArgs e)
        {
            tabMenu.TabPages.Clear();
            lblTitle.Text = "Trang chủ";
            cbStatisticCriteria.SelectedIndex = 0;
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

        private void hienMotTab(TabControl tab_menu ,TabPage tab)
        {
            //Nguyên tắc DRY (Don't repeat yourself)
            tab_menu.TabPages.Clear();
            tab_menu.TabPages.Add(tab);
            lblTitle.Text = tab.Text;
        }
        private void showBill(int index)
        {
            currentBillIndex = index;
            gridBillDetail.DataSource = bill[index].DetailTable;
            gridBillDetail.Refresh();

            gridBillDetail.Columns["Tên SP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //Không cho chỉnh sửa nội dung tất cả các cột, trừ cột "Số lượng"
            foreach(DataGridViewColumn col in gridBillDetail.Columns)
            {
                if(col.HeaderText != "Số lượng")
                {
                    col.ReadOnly = true;
                }
            }
            txtCustomerID.Text = bill[index].Customer.ID;
            btnChangeCustomerID_Click(new object(), new EventArgs());
            lblBillTitle.Text = String.Format("Hoá đơn {0}", index + 1);

            //Đổi màu nút khi hoá đơn được chọn
            foreach(Button button in grpbxBillButtonList.Controls)
            {
                if(button.Name.Equals(String.Format("btnBill{0}", currentBillIndex + 1)))
                    button.BackColor = System.Drawing.Color.White;
                else
                    button.BackColor = System.Drawing.Color.Transparent;
            }
            //Nếu hoá đơn chưa được thanh toán thì vô hiệu hoá nút in, ngược lại thì kích hoạt nút in
            btnBillPrinting.Enabled = !(bill[currentBillIndex].ID == "");
        }
        private void changeTableIcon(int ImageIndex)
        {
            Button button = (Button)this.Controls.Find(String.Format("btnBill{0}", currentBillIndex + 1), true)[0];
            button.ImageIndex = ImageIndex;
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabBillManagement);
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
            hienMotTab(tabMenu, tabRevenueStatistics);
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
        private void tạoPhiếuĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabTaoPhieuDat);
        }

        private void kiểmTraTìnhHìnhĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabKTTHDat);
        }


        private void txtFoodQuantity_Enter(object sender, EventArgs e)
        {
            txtFoodQuantity.SelectAll();
        }

        private void txtBeverageQuantity_Enter(object sender, EventArgs e)
        {
            txtBeverageQuantity.SelectAll();
        }


        #region Bill Button Click Events
        private void btnBill1_Click(object sender, EventArgs e)
        {
            showBill(0);
        }

        private void btnBill2_Click(object sender, EventArgs e)
        {
            showBill(1);
        }

        private void btnBill3_Click(object sender, EventArgs e)
        {
            showBill(2);
        }

        private void btnBill4_Click(object sender, EventArgs e)
        {
            showBill(3);
        }

        private void btnBill5_Click(object sender, EventArgs e)
        {
            showBill(4);
        }

        private void btnBill6_Click(object sender, EventArgs e)
        {
            showBill(5);
        }

        private void btnBill7_Click(object sender, EventArgs e)
        {
            showBill(6);
        }

        private void btnBill8_Click(object sender, EventArgs e)
        {
            showBill(7);
        }

        private void btnBill9_Click(object sender, EventArgs e)
        {
            showBill(8);
        }

        private void btnBill10_Click(object sender, EventArgs e)
        {
            showBill(9);
        }

        private void btnBill11_Click(object sender, EventArgs e)
        {
            showBill(10);
        }

        private void btnBill12_Click(object sender, EventArgs e)
        {
            showBill(11); 
            #endregion
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
        private void addProductToBill(DataGridView p_gridProduct, DataGridView p_gridBill, TextBox p_Quantity)
        {
            errorProvider.Clear();
            try
            {
                DataTable dt = (DataTable)p_gridBill.DataSource;
                string product_ID = p_gridProduct.SelectedRows[0].Cells[0].Value.ToString();
                string product_Name = p_gridProduct.SelectedRows[0].Cells[1].Value.ToString();
                string product_Price = p_gridProduct.SelectedRows[0].Cells[2].Value.ToString();
                int product_Quantity = Convert.ToInt16(p_Quantity.Text);
                string product_TypeName = p_gridProduct.SelectedRows[0].Cells[3].Value.ToString();

                //Nếu SP đã có trong hoá đơn thì cộng thêm số lượng
                bool already_added = false;
                foreach (DataRow row in dt.Rows)
                {
                    if (row.ItemArray[0].ToString() == product_ID)
                    {
                        int quantity = Convert.ToInt32(row.ItemArray[3].ToString());
                        quantity += Convert.ToInt16(product_Quantity);
                        row.SetField<int>(3, quantity);
                        row.SetField<string>(4, VNDfromNumber(quantity * (NumberFromVND(product_Price))));
                        already_added = true;
                        break;
                    }
                }
                //Nếu chưa thì thêm một dòng mới vào bảng               
                if (already_added == false)
                {
                    string product_SumPrice = VNDfromNumber(NumberFromVND(product_Price) * Convert.ToInt32(product_Quantity));
                    dt.Rows.Add(product_ID, product_Name, product_Price, product_Quantity,
                        product_SumPrice, product_TypeName);
                }
                p_gridBill.DataSource = dt;
                p_gridBill.Refresh();

                //Đổi màu nút Hoá đơn sang đỏ
                changeTableIcon(2);

                //Tính lại tổng Hoá đơn
                btnCalculateSum_Click(new object(), new EventArgs());
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
            addProductToBill(gridFood, gridBillDetail, txtFoodQuantity);
        }


        private void btnAddBeverage_Click(object sender, EventArgs e)
        {
            addProductToBill(gridBeverage, gridBillDetail, txtBeverageQuantity);
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

        private void btnChangeCustomerID_Click(object sender, EventArgs e)
        {
            int number;
            if (txtCustomerID.Text == null || int.TryParse(txtCustomerID.Text, out number)==false)
            {
                MessageBox.Show("Mã khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK);
                txtCustomerID.Text = "1";
                btnChangeCustomerID_Click(sender, e);
            }
            else
            {
                BUS.BillManagement bus = new BUS.BillManagement();
                Customer customer = bus.getCustomerDetail(txtCustomerID.Text);
                if(customer.ID == null)
                {
                    MessageBox.Show("Không tìm thấy mã khách hàng!", "Lỗi", MessageBoxButtons.OK);
                    txtCustomerID.Text = "1";
                    btnChangeCustomerID_Click(sender, e);
                }
                else
                {
                    txtCustomerID.Text = customer.ID;
                    txtDiscountRate.Text = customer.DiscountRate.ToString();
                    bill[currentBillIndex].Customer = customer;
                }
            }            
            btnCalculateSum_Click(sender, e);
        }

        private void txtCustomerID_Enter(object sender, EventArgs e)
        {
            btnChangeCustomerID_Click(sender, e);
        }

        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
            btnChangeCustomerID_Click(sender, e);
        }
        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            BUS.BillManagement bus = new BUS.BillManagement();
            Customer customer = bus.getCustomerDetail(txtCustomerID.Text);
            StringBuilder sb_customer_info = new StringBuilder();
            sb_customer_info.AppendLine("Mã KH: " + customer.ID);
            sb_customer_info.AppendLine("Họ tên KH: " + customer.FullName);
            sb_customer_info.AppendLine("CMND: " + customer.CivilID);
            sb_customer_info.AppendLine("Số điện thoại: " + customer.PhoneNumber);
            sb_customer_info.AppendLine("Cấp độ khách hàng: " + customer.Type);
            sb_customer_info.AppendLine("Tỉ lệ chiết khấu: " + customer.DiscountRate);

            MessageBox.Show(sb_customer_info.ToString());
        }

        private void txtCustomerID_Bill1_Leave(object sender, EventArgs e)
        {
             btnChangeCustomerID_Click(sender, e);
        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataRow row in bill[currentBillIndex].DetailTable.Rows)
            {
                int productSumPrice = NumberFromVND(row.Field<string>(4));
                total += productSumPrice;
            }
            double discountRate = Convert.ToDouble(txtDiscountRate.Text);
            int discountAmount = (int)(total * discountRate);
            int actualTotal = total - discountAmount;

            txtTotal.Text = VNDfromNumber(total);
            txtDiscountAmount.Text = VNDfromNumber(discountAmount);
            txtActualTotal.Text = VNDfromNumber(actualTotal);
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
            errorProvider.Clear();
        }

        private void tồnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hienMotTab(tabMenu, tabKTTHHangTon);
            refreshCheckInventoryState();
        }
        private void itemDelete_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Bạn muốn xoá dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                gridBillDetail.Rows.Remove(gridBillDetail.SelectedRows[0]);
                btnCalculateSum_Click(sender, e);
            }
        }
        private void btnBillCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Đồng ý tạo lại hoá đơn?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                bill[currentBillIndex] = new Bill();
                showBill(currentBillIndex);
                changeTableIcon(1);
            }
        }
        private void txtFoodSearching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFoodSearching_Click(sender, e);
            }
        }

        private void btnSettlePay_Click(object sender, EventArgs e)
        {           
            if(bill[currentBillIndex].DetailTable.Rows.Count == 0 )
                MessageBox.Show("Hoá đơn rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(bill[currentBillIndex].ID == "")
            {
                BUS.BillManagement bus = new BUS.BillManagement();
                bill[currentBillIndex] = bus.createNewBill(bill[currentBillIndex]);
                DialogResult result = MessageBox.Show("Lưu hoá đơn thành công! Bạn có muốn in hoá đơn?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    btnBillPrinting_Click(btnBillPrinting, e);
                    btnBillCancel_Click(btnBillCancel, e);
                }
                changeTableIcon(1);
            }
            else
                MessageBox.Show("Hoá đơn đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showBill(currentBillIndex);
        }
        #region Printing Function
        private void printBill()
        {
            PrintDocument print_doc = new PrintDocument();
            print_doc.DefaultPageSettings.Landscape = true; //set portrait orientation to print page
            print_doc.DefaultPageSettings.Margins = new Margins(50, 50, 10, 10);    //100 = 1 inch = 2.54 cm
            print_doc.DocumentName = String.Format(@"{0}_{1}", DateTime.Now.ToString("yyyyMMdd"), bill[currentBillIndex].ID);


        }
        private void btnBillPrinting_Click(object sender, EventArgs e)
        {
            if (bill[currentBillIndex].DetailTable.Rows.Count == 0)
            {
                MessageBox.Show("Hoá đơn rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                printPreviewDialog.Document = printDoc;
                printPreviewDialog.ShowDialog();
            }            
        }

        private string generateBillPrintingContent()
        {
            StringBuilder sb = new StringBuilder();
            Bill currentBill = bill[currentBillIndex];
            sb.AppendFormat("Mã hoá đơn: {0}\n", currentBill.ID);
            sb.AppendLine(String.Format("Mã khách hàng: {0,-5} {1,20}: {2,-15}", currentBill.Customer.ID, "Cấp độ khách hàng", currentBill.Customer.Type));
            sb.AppendLine(String.Format("Mã nhân viên: {0}", currentBill.Staff.ID));
            sb.AppendLine(String.Format("Thời gian: {0:d} {0:t}", currentBill.CreatingTime));
            sb.AppendLine("---------------------------------------------------------");
            foreach (DataRow row in currentBill.DetailTable.Rows)
            {
                sb.AppendLine(row.Field<string>("Tên SP"));
                string productDetail = String.Format("{0,20}{1,3}{2,5}{3,2}{4,20}", row.Field<string>("Đơn giá"), "x", row.Field<int>("Số lượng"), "=", row.Field<string>("Thành tiền"));
                sb.AppendLine(productDetail);
            }
            sb.AppendLine("---------------------------------------------------------");
            sb.AppendFormat("{0,30}{1,20}\n", "Tổng tiền", txtTotal.Text);
            string discountRate = (Convert.ToDouble(txtDiscountRate.Text) * 100).ToString();
            sb.AppendFormat("{0,30}({1,2}%){2,15}\n", "Tiền chiết khấu", discountRate, txtDiscountAmount.Text);
            sb.AppendFormat("{0,30}{1,20}\n", "THANH TOÁN", txtActualTotal.Text);
            return sb.ToString();
        }
        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(generateBillPrintingContent(), new Font("Courier New", 12), Brushes.Black, e.MarginBounds);
        }
        #endregion
        private void gridBillDetail_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataGridView dgv = ((DataGridView)sender);
            dgv.Rows[e.RowIndex].ErrorText = "Dữ liệu không hợp lệ!";
            e.Cancel = true;
        }

        private void gridBillDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Xoá thông báo lỗi
            DataGridView dgv = ((DataGridView)sender);
            dgv.Rows[e.RowIndex].ErrorText = "";

            //Tính lại thành tiền dựa trên số lương mới
            DataRow row = ((DataTable)dgv.DataSource).Rows[e.RowIndex];
            int quantity = Convert.ToInt32(row.ItemArray[3].ToString());
            int productPrice = NumberFromVND(row.ItemArray[2].ToString());
            row.SetField<int>(3, quantity);
            row.SetField<string>(4, VNDfromNumber(quantity * productPrice));

        }
        private void dtpBeginDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpBeginDate.Value;
        }
        private void btnGenerateStatistic_Click(object sender, EventArgs e)
        {
            BUS.RevenueStatistic bus = new BUS.RevenueStatistic();
        }
        //Phần của Phúc
        private void btnLamMoi_TPKH_Click(object sender, EventArgs e)
        {
            txtTimKiem_TPKH.Text = "";

            refreshInventoryList();

            dgvThongTinPhieu_TPKH.Rows.Clear();
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
                dgvThongTinPhieu_TPKH.Rows.Add(dgvNguyenLieu_TPKH.SelectedRows[0].Cells[0].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[1].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[2].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[3].Value.ToString(), dgvNguyenLieu_TPKH.SelectedRows[0].Cells[4].Value.ToString(), txtSLTon_TPKH.Text, txtSLHu_TPKH.Text);
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
                txtDVT_TPKH.Text = dgvNguyenLieu_TPKH.SelectedRows[0].Cells[2].Value.ToString();
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
                        dto_CT[i].Gia = Convert.ToInt32(dgvThongTinPhieu_TPKH.Rows[i].Cells[3].Value.ToString());
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
            if (!decimal.TryParse(txtSLTon_TPKH.Text, out d))
            {
                MessageBox.Show("Vui lòng nhập số!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSLTon_TPKH.Text = "";
                txtSLTon_TPKH.Focus();
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
            if (!decimal.TryParse(txtSLHu_TPKH.Text, out d))
            {
                MessageBox.Show("Vui lòng nhập số!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSLHu_TPKH.Text = "";
                txtSLHu_TPKH.Focus();
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
                txtSoLuong_PN.Text = "";
                txtSoLuong_PN.Focus();
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

        private void btnLamMoi_PN_Click(object sender, EventArgs e)
        {
            txtTimKiemNL_PN.Text = "";

            refreshGoodsReceipt();

            dgvPhieuNhap_PN.Rows.Clear();
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
