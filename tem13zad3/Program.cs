using System;
namespace helloworld
{
    internal class Program
    {
        static bool czyOcenkaDobra(string a)
        {
            int b;
            if (int.TryParse(a, out b))
            {
                if(b <= 6 && b >= 1)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Podaj jakas normalna ocenke od 1 do 6 a nie ");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Wpisz jakas ocenke a nie ");
                return false;
            }
        }
        static void Main(string[] args)
        {
            bool running = true;
            string input;
            List<int> lis = new List<int>();
            do
            {
                Console.Write("Dawaj wpisz jakas ocenke ktora dostales czyli 1-6: ");
                input = Console.ReadLine();
                if (input.ToLower() == "koniec")
                {
                    running = false;
                }
                else if (czyOcenkaDobra(input))
                {
                    lis.Add(int.Parse(input));
                }
            } while (running);
            double sum = 0;
            foreach (int i in lis)
            {
                sum += i;
            }
            sum = sum / lis.Count;
            Console.WriteLine($"Liczba twoich ocen to {lis.Count} a ich srednia to {sum}");
        }
    }
}