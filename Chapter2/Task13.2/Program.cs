using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a:{0} b:{1}", a, b);
        }
    }
}
