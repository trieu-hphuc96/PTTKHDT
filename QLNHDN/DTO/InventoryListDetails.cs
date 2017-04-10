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
        private int gia;
        private string donvi;
        private decimal sltonlt;
        private decimal sltontt;
        private decimal slhu;

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

        public int Gia
        {
            get
            {
                return gia;
            }

            set
            {
                gia = value;
            }
        }

        public string Donvi
        {
            get
            {
                return donvi;
            }

            set
            {
                donvi = value;
            }
        }

        public decimal Sltonlt
        {
            get
            {
                return sltonlt;
            }

            set
            {
                sltonlt = value;
            }
        }

        public decimal Sltontt
        {
            get
            {
                return sltontt;
            }

            set
            {
                sltontt = value;
            }
        }

        public decimal Slhu
        {
            get
            {
                return slhu;
            }

            set
            {
                slhu = value;
            }
        }
    }
}
