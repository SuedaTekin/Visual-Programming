using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace summer4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list_1 = new ArrayList();

            list_1.Add(1);
            list_1.Add("Sue");
            list_1.Add("");
            list_1.Add(4.5);


            int[] arr = { 100, 200, 300, 400 };
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            list_1.AddRange(arr);
            list_1.AddRange(myQ);
            foreach (var item in list_1) 
            { 
                Console.Write(item + ", ");
             }
            Console.WriteLine();
        }
    }
}
