using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Login
    {
        public int checkUsername(string tendangnhap)
        {
            DAO.Login dao = new DAO.Login();
            return dao.checkUsername(tendangnhap);
        }

        public Tuple<DataTable, int> checkLogin(string tendangnhap, string matkhau)
        {
            DAO.Login dao = new DAO.Login();
            return dao.checkLogin(tendangnhap, matkhau);
        }
    }
}
