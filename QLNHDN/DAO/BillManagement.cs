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
    public class BillManagement
    {
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
        public List<Product> loadFoodList(string name)
        {           
            SqlCommand cmd = new SqlCommand("sp_FoodSearch", DBConnection.connectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 50).Value = name;       

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Product> foodList = new List<Product>();
            foreach(DataRow row in dt.Rows)
            {
                Product food = new Product();
                food.ID = row.Field<int>(0).ToString();
                food.Name = row.Field<string>(1);
                food.Price = row.Field<int>(2);
                food.Type = row.Field<string>(3);
                foodList.Add(food);
            }
            return foodList;
        }
        public List<Product> loadBeverageList(string name)
        {
            SqlCommand cmd = new SqlCommand("sp_BeverageSearch", DBConnection.connectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 50).Value = name;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Product> beverageList = new List<Product>();
            foreach (DataRow row in dt.Rows)
            {
                Product beverage = new Product();
                beverage.ID = row.Field<int>(0).ToString();
                beverage.Name = row.Field<string>(1);
                beverage.Price = row.Field<int>(2);
                beverage.Type = row.Field<string>(3);
                beverageList.Add(beverage);
            }
            return beverageList;
        }
        public Customer getCustomerDetail(string customerID)
        {
            SqlCommand cmd = new SqlCommand("sp_CustomerDetail", DBConnection.connectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MakH", SqlDbType.NVarChar, 50).Value = customerID;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Customer customer = new Customer();
            //Nếu không tìm được khách hàng thì trả về đối tượng customer rỗng
            if (dt.Rows.Count == 0)
                return customer;
            else
            {
                foreach(DataRow row in dt.Rows)
                {
                    customer.ID = row.Field<int>("MaKH").ToString();
                    customer.FullName = row.Field<string>("HoTenKH");
                    customer.CivilID = row.Field<string>("CMND");
                    customer.PhoneNumber = row.Field<string>("SoDT");
                    customer.Type = row.Field<string>("TenLoai");
                    customer.DiscountRate = row.Field<double>("TyLeChietKhau");
                    customer.Point = row.Field<int>("DiemTichLuy");
                }
                return customer;
            }
        }

        public Bill createNewBill(Bill new_bill)
        {
            //Tạo dòng mới trên bảng HoaDon
            SqlCommand cmd = new SqlCommand("sp_createNewBillInfo", DBConnection.connectDB());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@NgayGio", SqlDbType.DateTime).Value = new_bill.CreatingTime;
            cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = new_bill.Staff.ID;
            cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = new_bill.Customer.ID;
            cmd.Parameters.Add("@TiLeChietKhau", SqlDbType.Float).Value = new_bill.Customer.DiscountRate;
            cmd.Parameters.Add("@MaHD", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            new_bill.ID = cmd.Parameters["@MaHD"].Value.ToString(); //Lấy ra mã HD vừa tạo

            //Tạo các dòng trong bảng CT_HoaDon
            return insertItemsToBill(new_bill);
        }
        private Bill insertItemsToBill(Bill new_bill)
        {
            SqlCommand cmd = new SqlCommand("sp_insertItemsToBill", DBConnection.connectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaHD", SqlDbType.Int).Value = new_bill.ID;
            cmd.Parameters.Add("@MaSP", SqlDbType.Int);
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int);
            cmd.Parameters.Add("@GiaBan", SqlDbType.Int);
            cmd.Prepare();
            foreach (DataRow row in new_bill.DetailTable.Rows)
            {
                cmd.Parameters["@MaSP"].Value = Convert.ToInt32(row.Field<string>("Mã SP"));
                cmd.Parameters["@SoLuong"].Value = row.Field<int>("Số lượng");
                cmd.Parameters["@GiaBan"].Value = NumberFromVND(row.Field<string>("Đơn giá"));
                cmd.ExecuteNonQuery();
            }
            return new_bill;
        }
        public void UpdatePoint(Customer customer, int point)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdatePoint", DBConnection.connectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", customer.ID);
            cmd.Parameters.AddWithValue("@DiemTichLuy", point);
            cmd.ExecuteNonQuery();
        }
        public void UpgradeCustomerToVIP(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("sp_UpgradeCustomerToVIP", DBConnection.connectDB());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaKH", customer.ID);
            cmd.ExecuteNonQuery();
            //Điểm trở về mức 0
            UpdatePoint(customer, 0);

        }

    }
}
