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
        public List<Product> loadFoodList(string name)
        {           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.connectDB();
            cmd.CommandText = "sp_FoodSearch";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 50).Value = name;
        

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Product food;
            var food_list = new List<Product>();
            foreach(DataRow row in dt.Rows)
            {
                food = new Product();
                food.ID = row.Field<int>("MaSP");
                food.Name = row.Field<string>("TenSP");
                food.Price = row.Field<int>("Gia");
                food.MaLoai = row.Field<int>("MaLoaiSP");
                food.Type = row.Field<string>("TenLoai");
                food_list.Add(food);
            }
            return food_list;
        }
        public List<Product> loadBeverageList(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.connectDB();
            cmd.CommandText = "sp_BeverageSearch";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 50).Value = name;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Product beverage;
            var beverage_list = new List<Product>();
            foreach (DataRow row in dt.Rows)
            {
                beverage = new Product();
                beverage.ID = row.Field<int>("MaSP");
                beverage.Name = row.Field<string>("TenSP");
                beverage.Price = row.Field<int>("Gia");
                beverage.MaLoai = row.Field<int>("MaLoaiSP");
                beverage.Type = row.Field<string>("TenLoai");
                beverage_list.Add(beverage);
            }
            return beverage_list;
        }

        public Customer getCustomerDetail(string customerID)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DBConnection.connectDB();
            cmd.CommandText = "sp_CustomerDetail";
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
                    customer.CustomerID = row.Field<int>("MaKH").ToString();
                    customer.FullName = row.Field<string>("HoTenKH");
                    customer.ID_Number = row.Field<string>("CMND");
                    customer.PhoneNumber = row.Field<string>("SoDT");
                    customer.Type = row.Field<string>("TenLoai");
                    customer.DiscountRate = row.Field<double>("TyLeChietKhau");
                }
                return customer;
            }
        }
    }
}
