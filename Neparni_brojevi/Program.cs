using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neparni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            //ispis svih neparnih brojeva iz intervala 1 do 10 - za jedan veći ili manji od pozitivnog

            for(int i = 1; i <= 10; i++)
            {
                if (!(i % 2 == 0)){
                    Console.WriteLine("{0}",i);
                }
            }
        }
    }
}
