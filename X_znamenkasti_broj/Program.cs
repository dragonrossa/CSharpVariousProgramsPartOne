using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_znamenkasti_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            //unos broja
            // je li taj broj jednoznamenkast, dvoznamenkast, troznamenkasti ili višeznamenkast
            //treba raditi i s negativnim brojevima

            Console.WriteLine("Unesite neki broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj < 0) broj = -broj;

            if (broj < 10 && broj>0)
            {
                Console.WriteLine("Broj je jednoznamenkast");
            }

            else
            {
                if (broj <= 99)
                {
                    Console.WriteLine("Broj je dvoznamenkast");
                }
                else if (broj <= 999 )
                {
                    Console.WriteLine("Broj je troznamenkast");
                }
                else if (broj <= 9999)
                {
                    Console.WriteLine("Broj je višeznamenkast");
                }

                
            }
        
           
        }
    }
}
