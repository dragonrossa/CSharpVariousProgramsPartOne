using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savršen_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Savršen_broj
            //program koji ispisuje jel uneseni broj savršen ili nije
            //savršen broj je jednak zbroju svojih djelitelja bez njega samoga

            Console.WriteLine("Unesite neki prirodni broj: ");
            int broj = int.Parse(Console.ReadLine());

            int zbroj=0;
            int ukupno=0;

            for(int i = 1; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    zbroj += i;
                    ukupno = broj + zbroj;
                    //Console.WriteLine("{0}", i);
                   
                }
                
            }
            Console.WriteLine("{0}", ukupno);

            if (broj == ukupno)
            {
                Console.WriteLine("Broj je savršen");
            }
            else
            {
                Console.WriteLine("Broj nije savršen!");
            }


        }
    }
}
