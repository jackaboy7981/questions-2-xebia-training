using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Input a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a<0)
            {
                Console.WriteLine(a + " is  negative");
            }
            else if (a>0)
            {
                Console.WriteLine(a + " is  positive");
            }
            Console.ReadKey();
        }
    }
}
