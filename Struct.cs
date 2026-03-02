using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct SeatLocation
    {
        public char _row;
        public int _number;
        public SeatLocation()
        {
            _row = 'A';
            _number = 1;
        }
        public SeatLocation(char row, int number)
        {
            _row = char.ToUpper(row);
            _number = number;
        }

        public override string ToString()
        {
            return $"{_row}-{_number}";
        }
    }
}
