using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DTO
{
    public class Bill
    {
        public Bill()
        {
            ID = "";
            CreatingTime = DateTime.Now;
            Staff = new Staff("1");
            Customer = new Customer();
            Customer.ID = "1";
            DetailTable = new DataTable();
            DetailTable.Columns.Add("Mã SP");
            DetailTable.Columns.Add("Tên SP");
            DetailTable.Columns.Add("Đơn giá");
            DetailTable.Columns.Add("Số lượng");
            DetailTable.Columns["Số lượng"].DataType = Type.GetType("System.Int32");
            DetailTable.Columns.Add("Thành tiền");
            DetailTable.Columns.Add("Loại");
        }
        public string ID { get; set; }
        public DateTime CreatingTime {get; set;}
        public Staff Staff { get; set; }
        public Customer Customer { get; set; }
        public DataTable DetailTable { get; set; }
    }
}
