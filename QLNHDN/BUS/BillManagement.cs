using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BUS
{
    public class BillManagement
    {
        DAO.BillManagement dao_bill_management = new DAO.BillManagement();
        //Hàm chuyển đổi từ Số thành Tiền tệ
        private string VNDfromNumber(int number)
        {
            return number.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
        }
        //Hàm chuyển đổi từ Tiền tệ thành Số
        private int NumberFromVND(string currency)
        {
            return int.Parse(currency, System.Globalization.NumberStyles.Currency);
        }

        public DataTable loadFoodList(string name)
        {
            List<Product> food_list = dao_bill_management.loadFoodList(name);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã");
            dt.Columns.Add("Tên món ăn");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Tên loại");
            foreach (Product food in food_list)
            {
                dt.Rows.Add(food.ID, food.Name, VNDfromNumber(food.Price), food.Type);
            }
           
            return dt;
        }

        public DataTable loadBeverageList(string name)
        {
            List<Product> beverage_list = dao_bill_management.loadBeverageList(name);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã");
            dt.Columns.Add("Tên thức uống");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Tên loại");
            foreach (Product beverage in beverage_list)
            {
                dt.Rows.Add(beverage.ID, beverage.Name, VNDfromNumber(beverage.Price), beverage.Type);
            }

            return dt;
        }

        public Customer getCustomerDetail(string CustomerID)
        {
            return dao_bill_management.getCustomerDetail(CustomerID);
        }
    }
}
