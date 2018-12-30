using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencije_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Potencije broja 2 su :");
            //potencije broja 2 manje od 1000
            for (int i = 2; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
