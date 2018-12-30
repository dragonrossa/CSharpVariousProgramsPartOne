using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobar_broj_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //unos broja i ispituje je li taj broj dijeljiv s 5 ili s 3
            //ako jest ispisati "Broj je dobar"
            // ako nije ispisati "Broj nije dobar"

            Console.WriteLine("Unesite broj: ");
            int broj = int.Parse(Console.ReadLine());

            if(broj%5==0 || broj % 3 == 0)
            {
                Console.WriteLine("Broj je dobar");
            }
            else
            {
                Console.WriteLine("Broj nije dobar");
            }
        }
    }
}
