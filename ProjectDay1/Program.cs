using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay1
{
    class Program
    {
        static void Main(string[] args)
        {

            //a program that allows input of a company's information and prints it to the console

            Console.WriteLine("Enter Company Name");
            string companyName = Console.ReadLine();

            Console.WriteLine("Enter Company Address");
            string companyAddress = Console.ReadLine();

            Console.WriteLine("Enter Company Phone Number");
            string companyPhone = Console.ReadLine();

            Console.WriteLine("Enter Company Fax Number");
            string faxNumber = Console.ReadLine();

            Console.WriteLine("Enter Company Website");
            string companyWeb = Console.ReadLine();

            Console.WriteLine("Enter Manager First Name");
            string managerName = Console.ReadLine();

            Console.WriteLine("Enter Manager Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Manager Phone Number");
            string managerPhone = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The company is: " + companyName);
            Console.WriteLine();
            Console.WriteLine("It is located at: " + companyAddress);
            Console.WriteLine();
            Console.WriteLine("The contact information is: " + companyPhone);
            Console.WriteLine();
            Console.WriteLine("Fax:" + faxNumber);
            Console.WriteLine();
            Console.WriteLine("Website: " + companyWeb);
            Console.WriteLine();
            Console.WriteLine(companyName + " " + "is managed by:" + managerName + " " + lastName);
            Console.WriteLine();
            Console.WriteLine("The manager can be reached at: " + managerPhone);


        }
    }
}
