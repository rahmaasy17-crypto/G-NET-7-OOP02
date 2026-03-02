using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Part 02 : Practical
    //1&2
    class Ticket
    {
        private string _MovieName;
        private TicketType _Type;
        private SeatLocation _Seat;
        private double _Price;
        private static int _ticketCounter;

        #region 1:-

        //a:
        public string MovieName
        {
            get { return _MovieName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _MovieName = value;
            }
        }

        public TicketType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public SeatLocation Seat
        {
            get { return _Seat; }
            set { _Seat = value; }
        }

        public double Price
        {
            get { return _Price; }
            set
            {
                if (value > 0)
                    _Price = value;
            }
        }

        //b:
        public double PriceAfterTax
        {
            get { return _Price + (_Price * 14 / 100); }
        }
        #endregion
        #region 2:-
        public int TicketId { get; private set; }
        public static int GetTotalTicketsSold() => _ticketCounter;
        #endregion
        public Ticket(string MovieName)
        {
            _MovieName = MovieName;
            _Type = TicketType.Standard;
            _Seat = new SeatLocation();
            _Price = 50;
            _ticketCounter++;
            TicketId = _ticketCounter;

        }
        public Ticket(string MovieName, TicketType Type, char row, int num, double Price)
        {
            _MovieName = MovieName;
            _Type = Type;
            _Seat = new SeatLocation(row, num);
            _Price = Price;
            _ticketCounter++;
            TicketId = _ticketCounter;
        }
              public void PrintTicket()
        {

            Console.Write("Movie : ");
            Console.WriteLine(TicketId);
            Console.Write("Movie : ");
            Console.WriteLine(_MovieName);
            Console.Write("Type :  ");
            Console.WriteLine(_Type);
            Console.Write("Seat :  ");
            Console.WriteLine(_Seat);
            Console.Write("Price : ");
            Console.WriteLine(_Price.ToString("F2"));
            Console.Write("Total(14 % tax): ");
            Console.WriteLine(PriceAfterTax.ToString("F2"));

        }
        public override string ToString()
        {
            return $"Ticket #{TicketId}| {_MovieName} | {_Type} | Seat: {_Seat} | Price: {_Price} EGP | After Tax: {PriceAfterTax} EGP";
        }

    }
}
