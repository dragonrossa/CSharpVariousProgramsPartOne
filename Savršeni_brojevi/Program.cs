﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savršeni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Savršeni brojevi iz intervala [1,1000] su: ");
            int zbrojDjelitelja;

            for(int i = 1; i < 1000; i++)
            {
                zbrojDjelitelja = 0;

                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0) {
                        zbrojDjelitelja += j;
                     
                            }
                }
                if(i==zbrojDjelitelja)
                {
                    Console.WriteLine("{0}", i.ToString());
                }
            }
            Console.ReadKey();
           
          
            
        }
    }
}
