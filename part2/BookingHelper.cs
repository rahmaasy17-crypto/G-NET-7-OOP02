using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class BookingHelper
    {
        private static int counter=0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket) 
        {
            double total = numberOfTickets * pricePerTicket;
            if (numberOfTickets >= 5) 
                return  total - (total * .1);
            else return total;
        }
        public static string GenerateBookingReference()
        {
            return $"Booking Reference {++counter} : BK-{counter}";
        }


     }
}
