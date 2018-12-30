using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_Ispis
{
    class Program
    {
        static void Main(string[] args)
        {
            //ispis brojeva u intervalu 1-100 koji su dijeljivi sa 7, ali nisu sa 3

            for (int i=1;i<=100;i++)
            {
                if(i%7==0 && !(i%3==0))
                    Console.WriteLine("{0}",i);
            }
        }
    }
}
