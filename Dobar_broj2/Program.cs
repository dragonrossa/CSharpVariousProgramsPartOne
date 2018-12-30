using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobar_broj2
{
    class Program
    {
        static void Main(string[] args)
        {
            //unos broja
            //broj dijeljiv s 4 i nije manji od 100
            // ako jest ispisuje "Broj je dobar"
            //ako nije ispisuje "Broj nije dobar"
            //programski kod osigurati od pogrešaka

           

            try
            {
                int broj;
                Console.WriteLine("Unesite neki broj: ");
                broj = int.Parse(Console.ReadLine());

                if (broj % 4 == 0 && broj > 100)
                {
                    Console.WriteLine("Broj je dobar");
                }
                else
                {
                    Console.WriteLine("Broj nije dobar");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Dogodila se greška u programu!");
                Console.WriteLine("Opis greške:" +ex.Message);
               
               
            }
            finally
            {
                Console.WriteLine("Pritisnite neku tipku za kraj :");
                Console.ReadKey();
            }
        }
    }
}
