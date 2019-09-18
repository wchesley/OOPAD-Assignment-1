using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            tDate d1 = new tDate(12,15,1990);
            d1.showDate("E");
            d1.showDate("N");
            tDate d2 = new tDate("12/15/1990");
            d2.showDate(1);
            d2.showDate(0);
            tDate d3 = new tDate("15/12/1990");
            d3.showDate(1);
            d3.showDate(0);
            tDate d4 = new tDate("11/11/1811");
            d4.showDate(1);
            d4.showDate(0);
        }
    }
}
