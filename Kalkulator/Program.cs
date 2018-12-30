using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //unos dva broja pa izbor računske operacije
            //nakon toga ponovan unos ili prekid programa
            //program treba ispisivati sve poruke za korisnika

            float a;
            float b;
            string kraj;

           
            do
            {
                Console.WriteLine("Unesite prvi broj: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Unesite drugi broj: ");
                b = float.Parse(Console.ReadLine());
                string operacija;
                Console.WriteLine("Izaberite računsku operaciju : + , - , *, /");
                operacija = Console.ReadLine();

                switch (operacija)
                {
                    case "+":
                        Console.WriteLine("Zbroj dvaju brojeva iznosi : {0}", a + b);
                        Console.WriteLine("Kraj rada programa ili ponovan unos?");
                        kraj = Console.ReadLine();
                        break;
                    case "-":
                        Console.WriteLine("Razlika dvaju brojeva iznosi: {0}", a - b);
                        Console.WriteLine("Kraj rada programa ili ponovan unos?");
                        kraj = Console.ReadLine();
                        break;
                    case "*":
                        Console.WriteLine("Umnožak dvaju brojeva iznosi {0}", a * b);
                        Console.WriteLine("Kraj rada programa ili ponovan unos?");
                        kraj = Console.ReadLine();
                        break;
                    case "/":
                        Console.WriteLine("Dijeljenje dvaju brojeva iznosi {0}", a / b);
                        Console.WriteLine("Kraj rada programa ili ponovan unos?");
                        kraj = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Ova računska operacija ne postoji!");
                        Console.WriteLine("Kraj rada programa ili ponovan unos?");
                        kraj = Console.ReadLine();
                        break;

                }
            } while (kraj == "N" || kraj == "n");

           
            

          
            
        }
    }
}
