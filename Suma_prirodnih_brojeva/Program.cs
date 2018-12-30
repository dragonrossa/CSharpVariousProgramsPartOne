using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_prirodnih_brojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            int suma=0;
            do
            {
                Console.WriteLine("Unesite neki broj:");
                broj = int.Parse(Console.ReadLine());
                suma = suma+broj;
               
                if (broj == 0)
                {
                    Console.WriteLine("Kraj rada");
                    Console.WriteLine("Suma svih brojeva iznosi {0}", suma);

                }
               
            } while (!(broj == 0));
           
           
        }

    }
}
