using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktorijel
{
    class Program
    {
        static void Main(string[] args)
        {

            //izračunati faktorijel
            Console.WriteLine("Unesite neki broj: ");
            int broj = int.Parse(Console.ReadLine());

            long faktorijel = 1;
            for (int i=1; i < broj; i++)
            {
                faktorijel *= i;
            }
            Console.WriteLine("{0}!={1}",broj,faktorijel);
            Console.ReadKey();

        }
    }
}
