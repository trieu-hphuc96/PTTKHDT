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
        private DateTime ngay;
        private DateTime gio;
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

        public DateTime Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }

        public DateTime Gio
        {
            get
            {
                return gio;
            }

            set
            {
                gio = value;
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
    }
}
