﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* namespace summer7
{
    internal class Program
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        static void Main(string[] args)
        {
            Program n = new Program();

            /* local variable definition 
            int a = 100;

            Console.WriteLine("Before method call, value of a : {0}", a);

            /* calling a function to get the value 
            n.getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();
        }
    }
} */

namespace summer7
{
    internal class Program
    {
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Program n = new Program();

            /* local variable definition */
            int a, b;

            /* calling a function to get the values */
            n.getValues(out a, out b);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);
            Console.ReadLine();
        }
    }
}