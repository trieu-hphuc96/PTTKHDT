using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InventoryListDetails
    {
        private int maphieu;
        private int manl;
        private int soluong;

        public int Maphieu
        {
            get
            {
                return maphieu;
            }

            set
            {
                maphieu = value;
            }
        }

        public int Manl
        {
            get
            {
                return manl;
            }

            set
            {
                manl = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }
    }
}
