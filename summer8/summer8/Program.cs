using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(); // assigns default value 01.01.0001 
           
            Console.WriteLine(dt);
            //assigns year, month, day 
            DateTime dt1 = new DateTime(2020, 09, 07);
            Console.WriteLine(dt1);
            //assigns year, month, day, hour, min, seconds 
            DateTime dt2 = new DateTime(2019, 11, 23, 5, 10, 20);
            Console.WriteLine(dt2);
            //assigns year, month, day, hour, min, seconds, UTC timezone 
            DateTime dt3 = new DateTime(2019, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt3);
        }
    }
}
