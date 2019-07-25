using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your Name: ");
            string name = Console.ReadLine();
            Console.Write("Please Enter Your Last Name: ");
            string lname = Console.ReadLine();
            Console.Write("Please Enter Your Address: ");
            string address = Console.ReadLine();
            Console.Write("Please Enter Your Age: ");
            double age = double.Parse(Console.ReadLine());
            Console.Write("Please Enter Your Email Address: ");
            string email = Console.ReadLine();
            Console.Write("Please Enter A 4 Digit Pin Number : ");
            int pin = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello {name} {lname}, nice to meet you. ");
            Console.WriteLine($"Your Address Is {address}. ");
            Console.WriteLine($"You Are {age} Years Old. ");
            Console.WriteLine($"Your email address is {email}. ");
            Console.WriteLine($"{pin} is your 4 digit pin. ");

            Console.ReadLine();

            Console.WriteLine($"\n...Details...\nName: {name} {lname}\nAddress: {address}\nAge: {age}\nEmail: {email}\nPin: {pin}");
            Console.ReadLine();
        }
    }
}
