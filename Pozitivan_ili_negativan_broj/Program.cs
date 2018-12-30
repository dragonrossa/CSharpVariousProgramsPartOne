using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pozitivan_ili_negativan_broj
{
    class Program
    {
        static void Main(string[] args)
        {

            //unos broj te ispisuje jel broj pozitivan ili negativan, ili nula

            int broj;
            Console.WriteLine("Unesite neki broj: ");
            broj = int.Parse(Console.ReadLine());

            if (broj > 0)
            {
                Console.WriteLine("Broj je pozitivan!");
            }
            if (broj == 0)
            {
                Console.WriteLine("Broj je nula!");
            }
            else if (broj < 0)
            {
                Console.WriteLine("Broj je negativan!");
            }
        }
    }
}
