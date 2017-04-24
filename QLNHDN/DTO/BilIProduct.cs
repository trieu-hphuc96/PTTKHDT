using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillProduct: Product
    {
        public int Quantity { get; set; }
        public int SellingPrice { get; set; }
    }
}
