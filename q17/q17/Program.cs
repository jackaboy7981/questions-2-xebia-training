﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(i+1);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
