using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDetails
    {
        private int maphieu;
        private int manl;
        private decimal soluongdat;
        private decimal soluongdanhap;

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

        public decimal Soluongdat
        {
            get
            {
                return soluongdat;
            }

            set
            {
                soluongdat = value;
            }
        }

        public decimal Soluongdanhap
        {
            get
            {
                return soluongdanhap;
            }

            set
            {
                soluongdanhap = value;
            }
        }
    }
}
