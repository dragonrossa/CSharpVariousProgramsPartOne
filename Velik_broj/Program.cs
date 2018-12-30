using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velik_broj
{
    class Program
    {
        static void Main(string[] args)
        {

            //unos broj
            //ako ima više od 3 znamenke "Broj je velik"
            //ako ima manje tada "Broj nije velik"

            Console.WriteLine("Unesite broj: ");
            int a = int.Parse(Console.ReadLine());

            if(a>=100)
            {
                Console.WriteLine("Broj je velik!");
            }
            else
            {
                Console.WriteLine("Broj nije velik!");
            }
        }
    }
}
