using System;



namespace WalidacjaPesel

{

    class Program

    {

        static void Main()

        {

            Console.WriteLine("=== Sprawdzanie numeru PESEL ===");

            Console.Write("Podaj numer PESEL: ");

            string pesel = Console.ReadLine();

            if (!CzyPoprawnyFormat(pesel))

            {

                Console.WriteLine("Błąd: numer PESEL musi składać się dokładnie z 11 cyfr.");

                Console.ReadKey();

                return; 

            }

            char plec = OkreslPlec(pesel);

            if (plec == 'K')

            {

                Console.WriteLine("Płeć: Kobieta");

            }

            else

            {

                Console.WriteLine("Płeć: Mężczyzna");

            }


            if (CzyPoprawnaSumaKontrolna(pesel))

            {

                Console.WriteLine("Suma kontrolna: zgodna (numer poprawny).");

            }

            else

            {

                Console.WriteLine("Suma kontrolna: niezgodna (numer błędny).");

            }

            Console.WriteLine($"Rok urodzenia: {PobierzRokUrodzenia(pesel)}");

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć…");

            Console.ReadKey();

        }



        /********************************************** 

        * Nazwa funkcji: OkreslPlec 

        * Opis działania: ustala płeć na podstawie dziesiątej cyfry numeru PESEL 

        * Parametry: pesel — napis z jedenastoma cyframi numeru PESEL 

        * Zwracana wartość: 'K' dla kobiety lub 'M' dla mężczyzny (char) 

        * Autor: numer zdającego 

        **********************************************/

        static char OkreslPlec(string pesel)

        {

            int cyfraPlci = pesel[9] - '0';

            return (cyfraPlci % 2 == 0) ? 'K' : 'M';

        }


        static bool CzyPoprawnaSumaKontrolna(string pesel)
        {

            int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            int suma = 0;

            for (int i = 0; i < 10; i++)

            {

                int cyfra = pesel[i] - '0';

                suma += cyfra * wagi[i];

            }

            int cyfraKontrolnaObliczona = (10 - (suma % 10)) % 10;

            int cyfraKontrolnaZPesel = pesel[10] - '0';

            return cyfraKontrolnaObliczona == cyfraKontrolnaZPesel;

        }

        static bool CzyPoprawnyFormat(string pesel)
        {

            if (pesel == null || pesel.Length != 11)

            {

                return false;

            }

            foreach (char znak in pesel)

            {

                if (!char.IsDigit(znak))

                {

                    return false;

                }

            }

            return true;

        }


        static int PobierzRokUrodzenia(string pesel)
        {

            int pierwszaliczba = pesel[0] - '0';
            int drugaliczba = pesel[1] - '0';
            int trzecialiczba = pesel[2] - '0';

            int koncowka = pierwszaliczba * 10 + drugaliczba;
            int rok = koncowka;
            if(trzecialiczba < 2)
            {
                rok += 1900;
            }
            else if(trzecialiczba < 4)
            {
                rok += 2000;
            }
            else if(trzecialiczba < 6)
            {
                rok += 2100;
            }
            else if(trzecialiczba < 8)
            {
                rok += 2200;
            }
            else
            {
                rok += 1800;
            }


            return rok;

        }

        static int LiczbaKobiet(string[] peseleTablica)
        {

            int liczba = 0;

            foreach(string pesel in peseleTablica)
            {

                if(OkreslPlec(pesel) == 'K')
                {

                    liczba++;

                }

            }

            return liczba;
        }
    }

}