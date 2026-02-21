using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_1
{
    internal class Ticket
    {
        public string? MovieName;
        public TicketType Type;
        public Seat Seat;
        private double Price { get; set; }

        public Ticket(string movieName, TicketType type, Seat seat, double price)
        { 
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public Ticket(string movieName): this(movieName , TicketType.Standard , new Seat('A',1) , 50)
        {
        }

        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if(discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }

        public void PrintTicket(double taxPercent)
        {
            Console.WriteLine($"Movie : {MovieName}");
            Console.WriteLine($"Type : {Type}");
            Console.WriteLine($"Seat : {Seat.row}{Seat.number}");
            Console.WriteLine($"Price : {Price:F2}");
            Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent):F2}");
        }


    }
}
