using System;
namespace helloworld
{
    internal class Program
    {
        bool czyOcenkaDobra(string a)
        {

        }
        static void Main(string[] args)
        {
            bool running = true;
            string input;
            bool czysieda;
            int ocenka;
            List<int> lis = new List<int>();
            do
            {
                Console.Write("Dawaj wpisz jakas ocenke ktora dostales czyli 1-6: ");
                input = Console.ReadLine();
                czysieda = int.TryParse(input, out ocenka);
                if (!czysieda && input.ToLower() == "koniec")
                {
                    running = false;
                }
                else if(!czysieda){
                    Console.WriteLine("Wpisz jakas ocenke a nie ");
                }
                else if(czysieda && (ocenka > 6 || ocenka < 1)){
                    Console.WriteLine("Podaj jakas normalna ocenke od 1 do 6 a nie ");
                }
                else
                {
                    lis.Add(ocenka);
                }
            } while (running);
        }
    }
}