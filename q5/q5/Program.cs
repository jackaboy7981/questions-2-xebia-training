using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter your age: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 18)
            {
                Console.WriteLine("You are not eligible for casting your vote");
            }
            else
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            Console.ReadKey();
        }
    }
}
