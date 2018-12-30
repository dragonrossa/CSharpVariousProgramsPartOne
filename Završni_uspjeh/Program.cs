using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Završni_uspjeh
{
    class Program
    {
        static void Main(string[] args)
        {

            //završni uspjeh
            //unijeti broj predmeta za koje će se unositi ocjene za računanje završnog uspjeha nekog učenika
            //zatim se unose ocjene
            //ako je sve pozitivno ispisuje se prosjek
            //ako nije ispisuje se "Uspjeh je nedovoljan"
            //za pogrešno unesenu ocjenu treba javiti grešku i zatražiti ponovan unos

            int predmeti;
            int ocjena;
            int prosjek=0;
            
            Console.WriteLine("Unesite broj predmeta za računanje završnog uspjeha: ");
            predmeti = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite ocjenu predmeta: ");

            for (int i=0; i < predmeti; i++)
            {
               
                ocjena = int.Parse(Console.ReadLine());

                if(ocjena>1 && ocjena <= 5)
                {
                    prosjek = prosjek + ocjena;
                   
                }

               

                if (ocjena == 1)
                {
                    Console.WriteLine("Uspjeh je nedovoljan!");
                    break;
                }

            }
            Console.WriteLine("Ukupni prosjek je {0}", prosjek / predmeti);

        }
    }
}
