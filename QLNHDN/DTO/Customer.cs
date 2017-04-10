using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string FullName { get; set; }
        public string ID_Number { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
        public double DiscountRate { get; set; }
    }
}
