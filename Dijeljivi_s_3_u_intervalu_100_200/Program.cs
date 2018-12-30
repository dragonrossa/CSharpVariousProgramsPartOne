using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijeljivi_s_3_u_intervalu_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            //ispisuje sve prirodne brojeve iz intervala 100-200 koji su dijeljivi s brojem 3


            for (int i=100;i<200;i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Ispis brojeva u intervalu 100 do 200 koji su dijeljivi s 3: {0}", i);
                }

            }
        }
    }
}
