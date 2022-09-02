using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PerHeight;
            Console.Write("Enter your height : ");
            PerHeight = Convert.ToInt32(Console.ReadLine());
            if (PerHeight < 150.0)
                Console.WriteLine("The person is Dwarf. \n");
            else if ((PerHeight >= 150.0) && (PerHeight < 165.0))
                Console.WriteLine("The person is  average heighted. \n");
            else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))
                Console.WriteLine("The person is taller. \n");
            else
                Console.WriteLine("Abnormal height.\n");
            Console.ReadKey();
        }
    }
}
