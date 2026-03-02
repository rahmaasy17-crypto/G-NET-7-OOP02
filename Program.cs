using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
 
   
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 02 : Practical
            //A:
            Console.WriteLine("=============Ticket Booking=============");
            Console.WriteLine();
            Ticket Tic;
            Cinema cin = new Cinema();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter Data For Ticket {i}:");
                Console.Write("Enter Movie Name: ");
                string movie_name = Console.ReadLine();
                Console.Write("Enter Ticket Type(O= Standard, 1 = VIP,2 = IMAX ): ");
                bool t = Enum.TryParse<TicketType>(Console.ReadLine(), true, out TicketType Ticket_Type);
                Console.Write("Enter Seat Row(A, B, c...): ");
                char seat_row = char.Parse(Console.ReadLine());
                Console.Write("Enter Seat Number: ");
                int seat_number = int.Parse(Console.ReadLine());
                Console.Write("Enter Price: ");
                double price = double.Parse(Console.ReadLine());
                          Console.WriteLine("");
                 Tic = new Ticket(movie_name, Ticket_Type, seat_row, seat_number, price);
               
                cin.AddTicket(Tic);
            }
            //B:
            Console.WriteLine("=============ALL Tickets=============");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
               Console.WriteLine( cin[i]);
            }
            Console.WriteLine();
            //C:
            Console.WriteLine("=============Search by Movie=============");
            Console.WriteLine();
            Console.Write("Enter  movie name: ");
            string name = Console.ReadLine();
            if (cin[name] == null)
                Console.WriteLine("not found");
            else 
                Console.WriteLine($"Found: Ticket # {cin[name].TicketId}| {cin[name].MovieName} | {cin[name].Type} | Seat: {cin[name].Seat} | Price: {cin[name].Price} EGP ");
            //D:
            Console.WriteLine();
            Console.WriteLine("=============Statistics=============");
            Console.WriteLine();
            Console.WriteLine( $"Total tickets sold: {Ticket.GetTotalTicketsSold()}");
            Console.WriteLine();
            //E:
            Console.WriteLine(BookingHelper.GenerateBookingReference());
            Console.WriteLine(BookingHelper.GenerateBookingReference());
            //F:
            Console.WriteLine($"Group Discount (5 tickets x 80 EGP) : {BookingHelper.CalcGroupDiscount(5,80)} EGP (10% OFF applied)");
            #endregion

        }
    }
}
