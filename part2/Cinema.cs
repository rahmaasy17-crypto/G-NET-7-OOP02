using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{

// Part 02 : Practical
//3:
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[20];
        public Ticket this[int index] 
        { 
            get { 
                if (index>=0&& index<tickets.Length) return tickets[index];
                return null;
            }
            set {
                if (index >= 0 && index < tickets.Length) tickets[index] = value;
               }
        }
        public Ticket this[string movieName]
        {
            get
            {
                foreach (var t in tickets)
                { 
                    if(t.MovieName== movieName) 
                        return t;

                }
                return null;
            }
        }
        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null) 
                {
                    tickets[i] = t;
                    return true;    
                }
            }
            return false;
        }
        
    }
}
