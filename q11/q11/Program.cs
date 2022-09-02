using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Input number of terms : ");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i =1;i<a+1; i++)
            {
                Console.WriteLine("Number is : " + i + " and cube of the " + i + " is :" + (i * i * i) + "");
            }
            Console.ReadKey();
        }
    }
}
