using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prijestupne_godine_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //prijestupne od 1900 do 2007

            for (int i =1900; i<=2007;i++)
            {
                if (i%4==0 || !(i%100==0) && i%400==0)
                {
                   
                    Console.WriteLine("{0}", i);
                }
               
            }
            

        }
    }
}
