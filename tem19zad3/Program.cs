using System;

namespace temat19
{

    internal class Program
    {

        static void WczytajLiczby(int[] liczby)
        {

            for(int i = 0; i < liczby.Length; i++)
            {
                bool czysieda = false;
                Console.Write($"{i+1}.");
                do
                {
                    Console.Write("Wpisz Liczbę całkowitą: ");

                    string input = Console.ReadLine();

                    czysieda = int.TryParse(input, out liczby[i]);

                } while (!czysieda);
    
            }

        }

        /********************************************** 

        * Nazwa funkcji: ObliczSume

        * Opis działania:  dodaje wszystkie liczby w tablicy

        * Parametry: liczby - tablica liczb wpisanych przez użytkownika

        * Zwracana wartość: suma wszystkich liczb 

        * Autor: zdający nr 7

        **********************************************/
        static int ObliczSume(int[] liczby)
        {
            int suma =0;

            foreach(int liczba in liczby)
            {

                suma += liczba;

            }

            return suma;

        }

        static int PoliczDodatnie(int[] liczby)
        {
            int dodatnie = 0;

            foreach (int liczba in liczby)
            {

                if (liczba > 0)
                {

                    dodatnie++;

                }

            }

            return dodatnie;

        }


        static void Main(string[] args)
        {

            int[] liczby = new int[5];
            
            WczytajLiczby(liczby);

            Console.WriteLine($"Suma twoich liczb wynosi: {ObliczSume(liczby)}");

            Console.WriteLine($"Liczba wartości dodatnich : {PoliczDodatnie(liczby)}");
            

        }

    }

}