using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<---------------- D1 Object ---------------->");
            tDate d1 = new tDate(15,12,1990, "1/1/1900","12/31/2100");
            d1.showDate("E");
            d1.showDate("N");
            Console.WriteLine("<---------------- D2 Object ---------------->");
            tDate d2 = new tDate("12/15/1990", "1/1/1900","12/31/2100" );
            d2.showDate(1);
            d2.showDate(0);
            Console.WriteLine("<---------------- D3 Object ---------------->");
            tDate d3 = new tDate("15/12/1990","1/1/1900","12/31/2100");
            d3.showDate(1);
            d3.showDate(0);
            Console.WriteLine("<---------------- D4 Object ---------------->");
            tDate d4 = new tDate("11/11/1811","1/1/1900","12/31/2100");
            d4.showDate(1);
            d4.showDate(0);
            Console.WriteLine("<---------------- D5 Object ---------------->");
            tDate d5 = new tDate("11/feb/2014","1/1/1900","12/31/2100");
            d5.showDate(1);
            d5.showDate(0);
        }
    }
}
