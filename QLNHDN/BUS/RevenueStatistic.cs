using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BUS
{
    public class RevenueStatistic
    {
        DAO.RevenueStatistic dao = new DAO.RevenueStatistic();
        private string VNDfromNumber(int number)
        {
            return number.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
        }
        //Hàm chuyển đổi từ Tiền tệ thành Số
        private int NumberFromVND(string currency)
        {
            return int.Parse(currency, System.Globalization.NumberStyles.Currency, new System.Globalization.CultureInfo("vi-VN"));
        }
        public DataTable[] getStatistic(DTO.RevenueStatistic statistic)
        {
            //1. Bảng thống kê theo hoá đơn
            List<Bill> bill_list = dao.StatisticByBill(statistic);
            DataTable bill_table = new DataTable();
            bill_table.Columns.Add("Mã HĐ");
            bill_table.Columns.Add("Tổng giá trị");
            bill_table.Columns.Add("Lượng chiết khấu");
            bill_table.Columns.Add("Thanh toán");
            bill_table.Columns.Add("Mã NV");
            bill_table.Columns.Add("Mã KH");
            bill_table.Columns.Add("Thời gian");
            int total = 0, discountAmount = 0, actualTotal = 0;
            foreach (Bill bill in bill_list)
            {
                object[] fields = new object[]
                {
                    bill.ID,
                    VNDfromNumber(bill.Total),
                    VNDfromNumber(bill.DiscountAmount),
                    VNDfromNumber(bill.ActualTotal),
                    bill.Customer.ID,
                    bill.Staff.ID,
                    bill.CreatingTime
                };
                bill_table.Rows.Add(fields);

                total += bill.Total;
                discountAmount += bill.DiscountAmount;
                actualTotal += bill.ActualTotal;
            }

            //2. Bảng thống kê theo sản phẩm
            List<Product> product_list = dao.StatisticByProduct(statistic);
            DataTable product_table = new DataTable();
            product_table.Columns.Add("Mã SP");
            product_table.Columns.Add("Tên SP");
            product_table.Columns.Add("Số lượng bán ra");
            product_table.Columns.Add("Doanh thu");
            product_table.Columns.Add("Loại SP");
            foreach (Product product in product_list)
            {
                object[] obj_arr = new object[]
                {
                    product.ID,
                    product.Name,
                    product.Quantity,
                    VNDfromNumber(product.Price),
                    product.Type
                };
                product_table.Rows.Add(obj_arr);
            }

            //3. Bảng thống kê tổng
            DataTable SummaryStatistic = new DataTable();
            SummaryStatistic.Columns.Add("Tổng giá trị");
            SummaryStatistic.Columns.Add("Tổng lượng chiết khấu");
            SummaryStatistic.Columns.Add("Tổng thanh toán");
            object[] row = new object[]
            {
                VNDfromNumber(total),
                VNDfromNumber(discountAmount),
                VNDfromNumber(actualTotal)
            };
            SummaryStatistic.Rows.Add(row);

           


            //Mảng 3 datatable
            DataTable[] dt = new DataTable[3];
            dt[0] = bill_table;
            dt[1] = product_table;
            dt[2] = SummaryStatistic;
            return dt;
        }

        public Bill getBillDetail(Bill bill)
        {
            List<Product>bill_detail = dao.getBillDetail(bill);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã SP");
            dt.Columns.Add("Tên SP");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thành tiền");
            foreach (Product product in bill_detail)
            {
                object[] object_array = new object[]
                {
                    product.ID,
                    product.Name,
                    VNDfromNumber(product.Price),
                    product.Quantity,
                    VNDfromNumber(product.Price * product.Quantity)
                };
                dt.Rows.Add(object_array);
            }
            bill.DetailTable = dt;
            return bill;
        }
    }
}
