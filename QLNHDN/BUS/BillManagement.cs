using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Windows.Forms;

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
            return int.Parse(currency, System.Globalization.NumberStyles.Currency, new System.Globalization.CultureInfo("vi-VN"));
        }

        public DataTable loadFoodList(string foodName)
        {
            List<Product> foodList = dao_bill_management.loadFoodList(foodName);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã món ăn");
            dt.Columns.Add("Tên món ăn");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Loại");
            foreach (Product food in foodList)
            {
                dt.Rows.Add(food.ID, food.Name, VNDfromNumber(food.Price), food.Type);
            }
            return dt;
        }

        public DataTable loadBeverageList(string beverageName)
        {
            List<Product> beverageList = dao_bill_management.loadBeverageList(beverageName);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã thức uống");
            dt.Columns.Add("Tên thức uống");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Loại");
            foreach (Product beverage in beverageList)
            {
                dt.Rows.Add(beverage.ID, beverage.Name, VNDfromNumber(beverage.Price), beverage.Type);
            }
            return dt;
        }

        public Customer getCustomerDetail(string customer_id)
        {
            return dao_bill_management.getCustomerDetail(customer_id);
        }

        public Bill createNewBill(Bill new_bill)
        {
            new_bill.CreatingTime = DateTime.Now;
            return dao_bill_management.createNewBill(new_bill);
        }
    }
}
