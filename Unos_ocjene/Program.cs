using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unos_ocjene
{
    class Program
    {
        static void Main(string[] args)
        {

            int ocjena;

            do
            {
                Console.WriteLine("Unesite ocjenu: ");
                ocjena = int.Parse(Console.ReadLine());
            } while (!(ocjena == 5 || ocjena == 4 || ocjena == 3 || ocjena == 2 || ocjena == 1));

            if (ocjena == 0 || ocjena<0)
            {
                Console.WriteLine("Ponovo unesite ocjenu");
            }
        }
    }
}
