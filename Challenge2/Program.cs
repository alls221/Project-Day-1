using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            // a program that accepts input of 5 intergers add prints their sum to the console

            Console.WriteLine("Enter Number a:");
            int a = int.Parse (Console.ReadLine());
            
            Console.WriteLine("Enter Number b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number c");
            int c = int.Parse( Console.ReadLine());

            Console.WriteLine("Enter Number d");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number E");
            int e = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Sum: ");
            Console.WriteLine(a + b + c + d + e);







        }
    }
}
