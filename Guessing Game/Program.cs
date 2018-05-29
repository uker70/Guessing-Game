using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static int GetIntFromUser(string spørgsmål)
        {
            Console.Write(spørgsmål);
            string input;
            int resultat;
            input = Console.ReadLine();

            while (!int.TryParse(input, out resultat))
            {
                Console.Write("Fejl, prøv igen");
                input = Console.ReadLine();
            }
            return resultat;
        }
        static void Main(string[] args)
        {
            Random TalRand = new Random();
            int a;
            int b;
            int Svar;
            int Gæt;
            int AntalGange;
            int Igen = 2;

            do
            {
                Igen = 2;
                Svar = 1;
                a = GetIntFromUser("Skriv minimum tallet som der kan gættes: ");
                b = GetIntFromUser("Skriv maksimum tallet som der kan gættes: ");
                b++;
                int Tal = TalRand.Next(a, b);
                AntalGange = 0;
                do
                {
                    AntalGange++;
                    Console.WriteLine();
                    Gæt = GetIntFromUser("Kom med et gæt: ");
                    if (Tal == Gæt)
                    {
                        Console.WriteLine("Du gættede rigtigt");
                        Console.WriteLine("Det tog dig " + AntalGange + " gange at gætte rigtigt");
                        Svar++;
                    }
                    else if (Tal > Gæt)
                    {
                        Console.WriteLine("Dit gæt er for lavt");
                    }
                    else if (Tal < Gæt)
                    {
                        Console.WriteLine("Dit gæt er for højt");
                    };

                } while (!(Svar == 2));
                Console.WriteLine();
                Igen = GetIntFromUser("Skriv 1 for at prøve igen, skriv et andet tal for at stoppe: ");
            } while (Igen == 1);

            
        }
    }
}
