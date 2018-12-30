using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max
{
    class Program
    {
        static void Main(string[] args)
        {
            //unos 10 prirodnih brojeva
            //ispisuje najmanji i najveći
            int broj;
            int min = int.MaxValue;
            int max = int.MinValue;

            for(int i = 1; i <10; i++)
            {
                Console.WriteLine("Unesite broj: ");
                broj = int.Parse(Console.ReadLine());

                if (broj < min)
                {
                    min = broj;
                }
                if (broj > max)
                {
                    max = broj;
                }
                
            }
            Console.WriteLine("Minimalan broj je {0} ", min);
            Console.WriteLine("Maksimalan broj je {0}", max);

        }
    }
}
