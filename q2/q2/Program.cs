using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.Write(a + " is even");
            }
            else
            {
                Console.Write(a+" is odd");
            }
            Console.ReadKey();
        }
    }
}
