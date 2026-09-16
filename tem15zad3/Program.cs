using System;

namespace HelloWorld
{
   
    internal class Program
    {

        static void WczytajOcenyUczniow(int[] uczniowie)

        {

            bool czySieDa = false;

            int x;

            for (int i = 0; i < uczniowie.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Wpisz wynik z zakresu 0-100 dla ucznia nr {i+1}: ");
                    string input = Console.ReadLine();

                    czySieDa = (int.TryParse(input, out x)&& (x < 0 || x > 100));

                } while (czySieDa);

                uczniowie[i] = x;

            }

        }

        /* 

            Nazwa funkcji: ObliczSrednia 

             Opis: Oblicza srednia arytmetyczna wynikow uzyskanych przez uczniow zapisanych w tablicy. 

             Parametry: 

                liczby – tablica liczb calkowitych, dla ktorych liczymy srednia 

             Zwracana wartosc: brak; 

             Autor: zdajacy nr 1 

        */

        static void ObliczSrednia(int[] uczniowie)
        {

            double suma = 0;

            foreach (int x in uczniowie)
            {

                suma += x;

            }

            Console.WriteLine($"Średni wynik klasy wynosi {suma / uczniowie.Length}");

        }
        static void Wyswietl(int[] uczniowie)

        {

            int liczba =0;

            foreach (int x in uczniowie)
            {
                if(x >= 50)
                {

                    liczba++;

                }
            }

            Console.WriteLine($"Uczniow którzy zdali jest {liczba}");

        }


        static void Main(string[] args)
        {

            int liczbauczniow;
            bool czysieda;

            do
            {
                Console.Write("Podaj liczbe uczniow: ");

                string input = Console.ReadLine();

                czysieda = (int.TryParse(input, out liczbauczniow) && liczbauczniow > 0);

            } while (!czysieda);

            int[] ocenyUczniow = new int[liczbauczniow];

            WczytajOcenyUczniow(ocenyUczniow);

            ObliczSrednia(ocenyUczniow);

            Wyswietl(ocenyUczniow);

        }
    }
}