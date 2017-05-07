using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderDetails
    {
        public void addOrderDetails(DTO.OrderDetails dto, int maphieu)
        {
            DAO.OrderDetails dao = new DAO.OrderDetails();
            dao.addOrderDetails(dto, maphieu);
        }

        public DataTable loadOrderDetails(int maphieu)
        {
            DAO.OrderDetails dao = new DAO.OrderDetails();
            return dao.loadOrderDetails(maphieu);
        }
    }
}
