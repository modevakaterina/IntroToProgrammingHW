﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1002; i++)
            {
                Console.WriteLine("{0}", i % 2 == 0 ? i : -i);
            }


        }
    }
}
