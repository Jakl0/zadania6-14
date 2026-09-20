using System;
namespace zadanie3
{
    class Program
    {
        static void WykonajSito(bool[] czyPierwsza)

        {

            int n = czyPierwsza.Length - 1;

            for (int i = 2; i <= n; i++)

            {

                czyPierwsza[i] = true;

            } 

            for (int i = 2; i * i <= n; i++)

            {

                if (czyPierwsza[i])

                {

                    for (int wielokrotnosc = i * i; wielokrotnosc <= n; wielokrotnosc += i)

                    {

                        czyPierwsza[wielokrotnosc] = false;

                    }

                }

            }

        }

        static int PoliczLiczbyPierwsze(bool[] czyPierwsza)
        
        {
            int suma = 0;

            foreach(bool b in czyPierwsza)
            {

                if (b)
                {

                    suma++;

                }

            }

            return suma;

        }

        static void Main()

        {

            const int N = 600;

            bool[] czyPierwsza = new bool[N + 1];



            WykonajSito(czyPierwsza);



            Console.WriteLine($"Liczby pierwsze w przedziale od 2 do {N}:");

            int ilosc = PoliczLiczbyPierwsze(czyPierwsza);

            for (int liczba = 2; liczba <= N; liczba++)

            {

                if (czyPierwsza[liczba])

                {

                    Console.Write(liczba + " ");

                }

            }

            Console.WriteLine($"\nŁączna ilość liczb pierwszych w tym przedziale wynosi : {ilosc}");

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}