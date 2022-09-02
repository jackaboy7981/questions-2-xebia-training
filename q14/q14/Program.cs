using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,sum=0;
            Console.Write("Input number of terms : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("The odd numbers are : ");
            for (int i = 0; i < a; i++)
            {
                Console.Write((i*2+1)+", ");
                sum += (i*2+1);
            }
            Console.WriteLine("\nThe Sum of odd Natural Number upto " + a + " terms : " + sum);
            Console.ReadKey();
        }
    }
}
