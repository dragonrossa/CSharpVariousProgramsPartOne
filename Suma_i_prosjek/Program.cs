using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_i_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj=0;
            //unesite 5 prirodnih brojeva pa ispis njihove sume i prosjeka
            for(int i = 0; i < 5; i++) {
                int broj;
                Console.WriteLine("Unesite prirodni broj:");
                broj = int.Parse(Console.ReadLine());
                zbroj += broj;
                if (i == 4)
                {
                    
                    Console.WriteLine("Ispis sume: {0}", zbroj);
                    Console.WriteLine("Ispis prosjeka {0}", zbroj/5);
                }

            }
        }
    }
}
