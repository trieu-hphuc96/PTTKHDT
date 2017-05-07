using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Supplier
    {
        public DataTable loadSupplier()
        {
            DAO.Supplier dao = new DAO.Supplier();
            return dao.loadSupplier();
        }
    }
}
