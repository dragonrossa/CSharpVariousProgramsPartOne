using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zadatak Prijestupna godina
            //unos godine i ispisuje je li ta godine prijestupna ili ne
            //ako je djeljiva s 4, nije djeljiva sa 100 osim ako je djeljiva sa 400

            Console.WriteLine("Unesite neku godinu: ");
            int godina = int.Parse(Console.ReadLine());

            if (godina % 4 == 0 && !(godina%100==0) || godina%400==0)
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna");
            }
        }
    }
}
