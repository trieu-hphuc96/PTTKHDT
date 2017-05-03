using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class RevenueStatistic
    {
        public List<Bill> StatisticByBill(DTO.RevenueStatistic statistic)
        {
            SqlCommand cmd = new SqlCommand("sp_StatisticByBill", DBConnection.connectDB());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@NgayBD", SqlDbType.Date).Value = statistic.StartDate;
            cmd.Parameters.Add("@NgayKT", SqlDbType.Date).Value = statistic.EndDate;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Bill> bill_list = new List<Bill>();
            foreach(DataRow row in dt.Rows)
            {
                Bill bill = new Bill();
                bill.ID = row.Field<int>("Mã HĐ").ToString();
                bill.Total = row.Field<int>("Tổng giá trị");
                bill.DiscountAmount = Convert.ToInt32(row.Field<double>("Tiền chiết khấu"));
                bill.ActualTotal = Convert.ToInt32(row.Field<double>("Thanh toán"));
                bill.Staff.ID = row.Field<int>("Mã NV").ToString();
                bill.Customer.ID = row.Field<int>("Mã KH").ToString();
                bill.CreatingTime = row.Field<DateTime>("Ngày");
                bill.CreatingTime = bill.CreatingTime.Add(row.Field<TimeSpan>("Giờ"));
                bill_list.Add(bill);
            }
            return bill_list;
        }

        public List<Product> StatisticByProduct(DTO.RevenueStatistic statistic)
        {
            SqlCommand cmd = new SqlCommand("sp_statisticByProduct", DBConnection.connectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NgayBD", statistic.StartDate);
            cmd.Parameters.AddWithValue("@NgayKT", statistic.EndDate);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            List<Product> product_list = new List<Product>();
            foreach(DataRow row in dt.Rows)
            {
                Product product = new Product();
                product.ID = row.Field<int>("Mã SP").ToString();
                product.Name = row.Field<string>("Tên SP").ToString();
                product.Quantity = row.Field<int>("Số lượng bán ra");
                //Dùng tạm tt Price để lưu doanh thu bán được của sản phảm, Price thực chất là đơn giá.
                product.Price = row.Field<int>("Doanh thu");
                product.Type = row.Field<string>("Loại SP");

                product_list.Add(product);
            }
            return product_list;
        }

        public List<Product> getBillDetail(Bill bill)
        {
            SqlCommand cmd = new SqlCommand("sp_getBillDetail", DBConnection.connectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHD", bill.ID);
             
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Product> bill_detail = new List<Product>();
            foreach(DataRow row in dt.Rows)
            {
                Product product = new Product();
                product.ID = row.Field<int>("Mã SP").ToString();
                product.Name = row.Field<string>("Tên SP");
                product.Price = row.Field<int>("Giá bán");
                product.Quantity = row.Field<int>("Số lượng");

                bill_detail.Add(product);
            }
            return bill_detail;
        }
    }
}
