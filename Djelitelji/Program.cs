using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djelitelji
{
    class Program
    {
        static void Main(string[] args)
        {

            //za unešeni prirodni broj ispisuje sve njegove dijelitelje

            Console.WriteLine("Unesite neki prirodni broj: ");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine("Dijelitelji broja {0} su: ", broj);

            for(int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    Console.WriteLine("{0}", i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
