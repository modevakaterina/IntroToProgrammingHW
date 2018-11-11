using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35;
            int p = 6;
            int i = 1;
            int mask = i << p;
            Console.WriteLine((n & mask) != 0 ? "Third bit is 1" : "Third bit is 0");

        }
    }
}
