using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order
    {
        private int maphieu;
        private int manv;
        private DateTime ngaydat;
        private DateTime ngaygiao;
        private int tinhtrang;

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

        public DateTime Ngaydat
        {
            get
            {
                return ngaydat;
            }

            set
            {
                ngaydat = value;
            }
        }

        public DateTime Ngaygiao
        {
            get
            {
                return ngaygiao;
            }

            set
            {
                ngaygiao = value;
            }
        }

        public int Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }
    }
}
