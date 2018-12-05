using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaGhicesteNr
{
    class Program
    {
        static void Main(string[] args)
        {
            Random nrRandom = new Random();
            int nrDeGhicit = nrRandom.Next(1, 100);
            //Console.WriteLine(nrDeGhicit);
            int nrIntrodus;

            do
            {
                Console.WriteLine("Introduceti un nr de la 1 la 100 :");
                nrIntrodus = int.Parse(Console.ReadLine());

                if (nrIntrodus == nrDeGhicit)
                {
                    Console.WriteLine("Felicitari, ati ghicit numarul!");
                }

                else if (nrIntrodus < nrDeGhicit)
                {
                    Console.WriteLine("Numarul trebuie sa fie mai mare");
                }

                else
                {
                    Console.WriteLine("Numarul trebuie sa fie mai mic");
                }
            } while (nrIntrodus != nrDeGhicit);

            Console.ReadKey(true);
        }
    }
}

