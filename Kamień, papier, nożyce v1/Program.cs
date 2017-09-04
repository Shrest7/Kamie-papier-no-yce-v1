using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamień__papier__nożyce_v1
{
    class Program
    {
        static int wygrana;
        static int remis;
        static int przegrana;

        static void Main(string[] args)
        {
            char gramy = 't';
            Random liczbaLosowa = new Random();
            while (gramy == 't')
            {
                int liczbaPrzeciwnika = liczbaLosowa.Next(1, 4);
                Console.WriteLine("Wybierz:");
                Console.WriteLine("1. Kamień");
                Console.WriteLine("2. Papier");
                Console.WriteLine("3. Nożyce");
                int wybor = int.Parse(Console.ReadLine());

                funkcja(wybor, liczbaPrzeciwnika);

                Console.WriteLine("");                
                Console.WriteLine("Gramy dalej? (t/n)");
                Console.WriteLine("");
                gramy = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Wygrane: {0}", wygrana);
            Console.WriteLine("Remisy: {0}", remis);
            Console.WriteLine("Przegrane: {0}", przegrana);
            Console.ReadKey();
        }

        static void funkcja(int wybor, int liczbaPrzeciwnika)
        {
            if (wybor == 1 && liczbaPrzeciwnika == 1)
            {
                Console.WriteLine("Pokazałeś kamień");
                Console.WriteLine("Przeciwnik pokazał kamień");
                Console.WriteLine("Remis!");
                remis++;
            }

            if (wybor == 1 && liczbaPrzeciwnika == 2)
            {
                Console.WriteLine("Pokazałeś kamień");
                Console.WriteLine("Przeciwnik pokazał papier");
                Console.WriteLine("Przegrałeś.");
                przegrana++;
            }

            if (wybor == 1 && liczbaPrzeciwnika == 3)
            {
                Console.WriteLine("Pokazałeś kamień");
                Console.WriteLine("Przeciwnik pokazał nożyce");
                Console.WriteLine("Wygrałeś!");
                wygrana++;
            }

            if (wybor == 2 && liczbaPrzeciwnika == 1)
            {
                Console.WriteLine("Pokazałeś papier");
                Console.WriteLine("Przeciwnik pokazał kamień");
                Console.WriteLine("Wygrałeś!");
                wygrana++;
            }

            if (wybor == 2 && liczbaPrzeciwnika == 2)
            {
                Console.WriteLine("Pokazałeś papier");
                Console.WriteLine("Przeciwnik pokazał papier");
                Console.WriteLine("Remis!");
                remis++;
            }

            if (wybor == 2 && liczbaPrzeciwnika == 3)
            {
                Console.WriteLine("Pokazałeś papier");
                Console.WriteLine("Przeciwnik pokazał nożyce");
                Console.WriteLine("Przegrałeś.");
                przegrana++;
            }

            if (wybor == 3 && liczbaPrzeciwnika == 1)
            {
                Console.WriteLine("Pokazałeś nożyce");
                Console.WriteLine("Przeciwnik pokazał kamień");
                Console.WriteLine("Przegrałeś.");
                przegrana++;
            }

            if (wybor == 3 && liczbaPrzeciwnika == 2)
            {
                Console.WriteLine("Pokazałeś nożyce");
                Console.WriteLine("Przeciwnik pokazał papier");
                Console.WriteLine("Wygrałeś!");
                wygrana++;
            }

            if (wybor == 3 && liczbaPrzeciwnika == 3)
            {
                Console.WriteLine("Pokazałeś nożyce");
                Console.WriteLine("Przeciwnik pokazał nożyce");
                Console.WriteLine("Remis!");
                remis++;
            }
        }

        enum Ja
        {
            Kamień,
            Papier,
            Nożyce
        }
    }
}
