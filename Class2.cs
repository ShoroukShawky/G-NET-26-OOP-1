using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_1
{
    internal struct Seat
    {
        public char row;
        public int number;

        public Seat(char row, int number)
        {
            this.row = row;
            this.number = number;
        }
    }
}
