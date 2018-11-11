using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthday in format(dd.mm.yyyy): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            long resulut = DateTime.Today.Subtract(birthDate).Ticks;
            Console.WriteLine("You are {0} years old.", new DateTime(resulut).Year - 1);
            Console.WriteLine("After 10 years uou will be {0} years old.", new DateTime(resulut).AddYears(10).Year - 1);
        }
    }
}
