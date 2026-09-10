using System;

namespace abc
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            bool czyliczba,running;
            running = true;
            int liczba;
            do
            {
                Console.Write("Podaj liczbe w przedziale 10-99: ");
                string input = Console.ReadLine();
                czyliczba = int.TryParse(input, out liczba);
                if (!czyliczba)
                {
                    Console.WriteLine("Aby program mogl dzialac prawidlowo musisz podac LICZBE CALKOWITA");
                }
                else if (liczba<10)
                {
                    Console.WriteLine("Podana przez ciebie liczba jest ZA MALA aby program mogl dzialac");
                }
                else if(liczba > 99)
                {
                    Console.WriteLine("Podana przez ciebie liczba jest ZA DUZA aby program mogl dzialac");
                }
                else
                {
                    running = false;
                }
            } while (running);
            if (liczba %2==0)
            {
                Console.WriteLine("Twoja liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Twoja liczba jest nieparzysta");
            }
        }
    }
}