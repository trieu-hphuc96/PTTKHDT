using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GoodsReceiptDetails
    {
        private int maphieu;
        private int manl;
        private string nhacc;
        private int gianhap;
        private decimal soluong;

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

        public string Nhacc
        {
            get
            {
                return nhacc;
            }

            set
            {
                nhacc = value;
            }
        }

        public int Gianhap
        {
            get
            {
                return gianhap;
            }

            set
            {
                gianhap = value;
            }
        }

        public decimal Soluong
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
