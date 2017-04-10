using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InventoryList
    {
        private int maphieu;
        private DateTime ngaygio;
        private int manv;

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

        public int Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public DateTime Ngaygio
        {
            get
            {
                return ngaygio;
            }

            set
            {
                ngaygio = value;
            }
        }
    }
}
