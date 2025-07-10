using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace summer9
{
    internal class Program
    {
        public string model;
        public Program()
        {
            model = "Mustang"; //constructor method tasarlama 
        }
        static void Main(string[] args)
        {
            Program Ford = new Program(); // nesne oluşturduk
            Console.WriteLine(Ford.model);
        }
    }
}
