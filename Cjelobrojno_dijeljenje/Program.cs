using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cjelobrojno_dijeljenje
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak Cijelobrojno dijeljenje
            //unos broja
            //broj paran ili neparan
            //djeljiv s 3 ili koliki je ostatak pri dijeljenju s 3

            Console.WriteLine("Unesite neki broj ");
            int broj = int.Parse(Console.ReadLine());


            int ostatak;
            ostatak = broj % 3;

            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj je paran!");

                if (broj % 3 == 0)
                {
                    Console.WriteLine("Broj je dijeljiv sa 3");
                }
                else
                {
                    Console.WriteLine("Broj nije dijeljiv sa 3, a ostatak je {0}", ostatak);
                }
            }
            else
            {
                Console.WriteLine("Broj nije paran!");

                if (broj % 3 == 0)
                {
                    Console.WriteLine("Broj je dijeljiv sa 3");
                }
                else
                {
                    Console.WriteLine("Broj nije dijeljiv sa 3, a ostatak je {0}", ostatak);
                }
            }
          
           
        }
    }
}
