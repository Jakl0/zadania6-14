using System;



namespace LoteriaLiczbowa

{

    class Program

    {

        const int LiczbWZestawie = 6; 

        const int MinWartosc = 1; 

        const int MaxWartosc = 49; 



        static void Main()

        {

            Console.WriteLine("=== Loteria liczbowa ===");

            int liczbaZestawow = WczytajLiczbeZestawow();

            int[,] zestawy = new int[liczbaZestawow, LiczbWZestawie];


            Random generator = new Random();

            WypelnijZestawy(zestawy, generator);

            WyswietlZestawy(zestawy);

            int[] liczniki = PoliczWystapienia(zestawy);

            WyswietlWystapienia(liczniki);

            Console.WriteLine($"\nIlość liczb które nie wystąpiły ani razu wynosi: {PoliczNiewylosowane(liczniki)}");

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć…");

            Console.ReadKey();

        }



        /********************************************** 

        * Nazwa funkcji: WczytajLiczbeZestawow 

        * Opis działania: pobiera od użytkownika dodatnią liczbę całkowitą 

        *     oznaczającą liczbę zestawów do wylosowania 

        * Parametry: brak 

        * Zwracana wartość: liczba całkowita dodatnia (int) 

        * Autor: numer zdającego 

        **********************************************/

        static int WczytajLiczbeZestawow()

        {
            int liczba;
            bool poprawne;

            do
            {

                Console.Write("Podaj liczbę zestawów do wylosowania: ");

                string wejscie = Console.ReadLine();

                poprawne = int.TryParse(wejscie, out liczba) && liczba > 0;

                if (!poprawne)

                {

                    Console.WriteLine("Błąd: należy podać liczbę całkowitą większą od zera.");

                }

            } while (!poprawne);



            return liczba;

        }

        static void WypelnijZestawy(int[,] zestawy, Random generator)

        {

            int liczbaZestawow = zestawy.GetLength(0);



            for (int wiersz = 0; wiersz < liczbaZestawow; wiersz++)

            {

                for (int kolumna = 0; kolumna < LiczbWZestawie; kolumna++)

                {

                    int wylosowana;

                    do

                    {


                        wylosowana = generator.Next(MinWartosc, MaxWartosc + 1);

                    } while (CzyZawiera(zestawy, wiersz, kolumna, wylosowana));



                    zestawy[wiersz, kolumna] = wylosowana;

                }

            }

        }

        static bool CzyZawiera(int[,] zestawy, int wiersz, int ileWypelnione, int wartosc)

        {

            for (int kolumna = 0; kolumna < ileWypelnione; kolumna++)

            {

                if (zestawy[wiersz, kolumna] == wartosc)

                {

                    return true;

                }

            }

            return false;

        }

        static void WyswietlZestawy(int[,] zestawy)

        {

            int liczbaZestawow = zestawy.GetLength(0);



            Console.WriteLine("\nWylosowane zestawy:");

            for (int wiersz = 0; wiersz < liczbaZestawow; wiersz++)

            {

                Console.Write($"Zestaw {wiersz + 1}: ");

                for (int kolumna = 0; kolumna < LiczbWZestawie; kolumna++)

                {

                    Console.Write($"{zestawy[wiersz, kolumna],3}");

                }

                Console.WriteLine();

            }

        }

        static int[] PoliczWystapienia(int[,] zestawy)

        {

            int[] liczniki = new int[MaxWartosc + 1];



            int liczbaZestawow = zestawy.GetLength(0);

            for (int wiersz = 0; wiersz < liczbaZestawow; wiersz++)

            {

                for (int kolumna = 0; kolumna < LiczbWZestawie; kolumna++)

                {

                    int wartosc = zestawy[wiersz, kolumna];

                    liczniki[wartosc]++;

                }

            }



            return liczniki;

        }

        static void WyswietlWystapienia(int[] liczniki)

        {

            Console.WriteLine("\nWystąpienia poszczególnych liczb:");

            for (int liczba = MinWartosc; liczba <= MaxWartosc; liczba++)

            {

                Console.WriteLine($"Liczba {liczba,2}: {liczniki[liczba]} wystąpień");

            }

        }

        static int ZnajdzNajczestszaLiczbe(int[] liczniki)
        
        {

            int wartoscnajczestrzej = 1;
            int najczestrza = 1;

            for(int i = 1; i < liczniki.Length; i++)
            {

                if (liczniki[i] > wartoscnajczestrzej)
                {

                    najczestrza = i;
                    wartoscnajczestrzej = liczniki[i];

                }

            }

            return najczestrza;

        }

        static int PoliczNiewylosowane(int[] liczniki)
        
        {

            int licznikpustych = 0;

            for(int i = 1;i < liczniki.Length; i++)
            
            {

                if (liczniki[i] ==0)
                {

                    licznikpustych++;

                }


            }

            return licznikpustych;

        }

    }

}