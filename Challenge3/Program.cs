using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class Program
    {
        static void Main(string[] args)
        {

            // A program to output circumfrence and area of a circle when radius is input

            Console.WriteLine("Enter Radius");

            double r = double.Parse(Console.ReadLine());
            double circumfrence = 2 * r * Math.PI; //formula for circumfrence

            double area = Math.PI * r * r; //formula for area
            

            Console.WriteLine("Circumfrence: " + circumfrence);
            Console.WriteLine("Area: " + area);
            
            
            




        }
    }
}
