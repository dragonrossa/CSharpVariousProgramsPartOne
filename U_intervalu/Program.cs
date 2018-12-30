using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_intervalu
{
    class Program
    {
        static void Main(string[] args)
        {

            //program koji traži unos broja i ispisuje jel navedeni u intervalu [100,200] ili nije
           
            Console.WriteLine("Unesite neki broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unijeli ste broj {0}", a);
            if (a > 100 && a<200)
            {
                Console.WriteLine("Broj se nalazi u rangu od 100 do 200");
            }
            else
            {
                Console.WriteLine("Broj se ne nalazi u rangu od 100 do 200");
            }
        }
    }
}
