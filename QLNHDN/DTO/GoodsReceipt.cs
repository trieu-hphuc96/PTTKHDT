﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GoodsReceipt
    {
        private int maphieu;
        private int maphieudat;
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

        public int Maphieudat
        {
            get
            {
                return maphieudat;
            }

            set
            {
                maphieudat = value;
            }
        }
    }
}
