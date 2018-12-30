using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_nepar
{
    class Program
    {
        static void Main(string[] args)
        {
            //unos brojeva dok se ne unese nula
            //ispisuje koliko je bilo parnih, a koliko neparnih
            // 0 nije niti paran niti kao neparan

            int broj;
            int parni = 0;
            int neparni = 0;
            do
            {
                Console.WriteLine("Unesite broj: ");
                broj = int.Parse(Console.ReadLine());
                if (broj % 2 == 0 && !(broj==0))
                {
                    parni++;
                   
                }
               
                if (!(broj % 2 == 0 && (broj == 0)))
                {
                    neparni++;
                   
                }
               
            } while (!(broj == 0));

            Console.WriteLine("Upisano je {0} parnih brojeva", parni);
            Console.WriteLine("Upisano je {0} neparnih brojeva", neparni);
        }
    }
}
