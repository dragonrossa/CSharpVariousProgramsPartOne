using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koliko_ima_brojeva_dijeljivih_i_nedjeljivih
{
    class Program
    {
        static void Main(string[] args)
        {

            //program koji ispisuje koliko ima brojeva
            //dijeljivih sa 7 i nedjeljivih sa 3 u rasponu od 1 do 1000

            int broj = 0;
            for (int i = 1; i <= 1000; i++)
            {
               
                if (i % 7 == 0 && !(i%3==0))
                {

                    broj++;
                   
                }
               
            }
            Console.WriteLine("Ima {0} brojeva dijeljivih sa 7 i nedjeljivih sa 3", broj);

        }
    }
}
