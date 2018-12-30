using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djeljivi_s_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ispis svih brojeva od 1 do 100 koji su dijeljivi s 5

            Console.WriteLine("Ispis svih brojeva od 1 do 100 koju dijeljivi s 5");
            for(int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
               
               
            }
        }
    }
}
