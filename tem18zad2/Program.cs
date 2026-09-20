using System;
namespace zadanie18_2 {

    class Program
    {

    static void Main()

        {

            Console.WriteLine("=== Największy wspólny dzielnik (algorytm Euklidesa) ===");



            int a = WczytajLiczbeDodatnia("Podaj pierwszą liczbę (a): ");

            int b = WczytajLiczbeDodatnia("Podaj drugą liczbę (b): ");



            int wynik = Nwd(a, b);

            Console.WriteLine($"NWD({a}, {b}) = {wynik}");

            Console.WriteLine($"NWW({a}, {b}) = {Nww(a,b)}");



            Console.ReadKey();

        }

    static int WczytajLiczbeDodatnia(string komunikat)

    {

        int liczba;

        bool poprawne;



        do

        {

            Console.Write(komunikat);

            poprawne = int.TryParse(Console.ReadLine(), out liczba) && liczba > 0;



            if (!poprawne)

            {

                Console.WriteLine("Błąd: należy podać liczbę całkowitą dodatnią.");

            }

        } while (!poprawne);



        return liczba;

    }
        static int Nwd(int a, int b)

        {


            while (a != b)

            {

                if (a > b)

                {

                    a = a - b;

                }

                else

                {

                    b = b - a;

                }

            }



            return a;
        }

        static int Nww(int a, int b) 
        {

            return (a * b) / Nwd(a,b);

        }
    } 
}