using System;

namespace temat19
{

    internal class Program
    {

        static int WczytajLiczbe()
        {

            bool czyliczba , czysieda = false;
            int liczbauczniow;
            do
            {

                Console.Write("Podaj liczbe uczniow 1-40: ");
                
                string input = Console.ReadLine();

                czyliczba = int.TryParse(input, out liczbauczniow);

                czysieda = czyliczba && (liczbauczniow>0 && liczbauczniow < 40);

            } while (!czysieda);

            return liczbauczniow;
        }

        /********************************************** 

        * Nazwa funkcji: WczytajOceny

        * Opis działania:  wczytuje odpowiednie liczby od użytkownika do tablicy

        * Parametry: oceny  - tablica liczb (ocen uczniow)

        * Zwracana wartość: brak

        * Autor: zdający nr 25

        **********************************************/
        static void WczytajOceny(int[] oceny)
        {
            
            for(int i = 0; i < oceny.Length; i++)
            {

                bool czyliczba, czysieda = false;
                Console.Write($"{i + 1}. ");
                do
                {

                    Console.Write("Podaj ocenę ucznia 1-6: ");

                    string input = Console.ReadLine();

                    czyliczba = int.TryParse(input, out oceny[i]);

                    czysieda = czyliczba && (oceny[i] > 0 && oceny[i] <= 6);

                } while (!czysieda);

            }

        }

        static void Wyswietl(int[] oceny)
        {

            int suma = 0;
            int pomocnicza =1;
            
            foreach(int ocena in oceny)
            {
                
                if(ocena > pomocnicza)
                {

                    pomocnicza = ocena;

                }

            }

            Console.WriteLine("Najwyższa ocena to " + pomocnicza);

            foreach (int ocena in oceny)
            {

                if (ocena < pomocnicza)
                {

                    pomocnicza = ocena;

                }

            }

            Console.WriteLine("Najniższa ocena to " + pomocnicza);

            foreach (int ocena in oceny)
            {

                suma += ocena;

            }
            suma = suma / oceny.Length;

            Console.WriteLine($"Średnia ocen wynosi {suma:F2}");



        }


        static void Main(string[] args)
        {
            int liczbauczniow=0;

            liczbauczniow = WczytajLiczbe();

            int[] oceny = new int[liczbauczniow];

            WczytajOceny(oceny);

            Wyswietl(oceny);

        }

    }

}