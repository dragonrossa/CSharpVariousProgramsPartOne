using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_vjezba1
{
    class Program
    {
        static void Main(string[] args)
        {

            //napišite program koji traži unos 2 cijela broja i prikazuje na ekranu njihov zbroj te razliku

            float a, b;

            Console.WriteLine("Unesite prvi cijeli broj: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi cijeli broj: ");
            b = float.Parse(Console.ReadLine());

            //int zbroj;
            Console.WriteLine("Unos dva broja iznosi :");
           
            //zbroj = a + b;
            Console.WriteLine("{0}", a+b);

           // int razlika;
            Console.WriteLine("Razlika dvaju broja iznosi: ");
           // razlika = a - b;
            Console.WriteLine("{0}", a-b);

            // umnožak i kvocijent

            Console.WriteLine("Umožak dvaju brojeva iznosi {0}", a*b);
            Console.WriteLine("Kvocijent dvaju brojeva iznosi {0}", Convert.ToDecimal(a / b));
           

           
           
       
        }
    }
}
