using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamonkeres1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozitiv = 0;
            int negativ = 0;
            int szam;

            Console.WriteLine("adj meg 10 egész számot:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Add meg a {i}. számot: ");
                if (int.TryParse(Console.ReadLine(), out szam))
                {
                    if (szam > 0)
                    {
                        pozitiv += szam;
                    }
                    else if (szam < 0)
                    {
                        negativ += szam;
                    }
                }
                else
                {
                    Console.WriteLine("Érvénytelen szám, kérlek próbáld újra!");
                    i--;
                }
            }

            Console.WriteLine($"\nA pozitív számok összege: {pozitiv}");
            Console.WriteLine($"A negatív számok összege: {negativ}");

        }
    }
}
