using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20150910_FirstnameLastname
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks a user for first name and last name separately, and prints both names on one line.

            Console.WriteLine("What is your first name?");
            string FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string LastName = Console.ReadLine();

            Console.WriteLine("Your full name is " + FirstName + " " + LastName);

        }
    }
}
