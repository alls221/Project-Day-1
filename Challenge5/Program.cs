using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    class Program
    {
        static void Main(string[] args)
        {
            // program that will print the manager's information, formatted so that it is 20 charecters wide and the phone number is right aligned

            

            Console.WriteLine("Enter Manager First Name");
            string managerName = Console.ReadLine();

            Console.WriteLine("Enter Manager Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Manager Phone Number");
            string managerPhone = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("{0,-20}|{1,-20}|{2,20}", managerName, lastName, managerPhone);





        }
    }
}
