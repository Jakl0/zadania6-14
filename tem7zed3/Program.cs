using System;
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            List<int> lis = new List<int>();
            string input;
            int liczba,suma;
            suma = 0;
            bool running = true;
            do
            {
                Console.Write("wpisz liczbe do listy: ");
                input = Console.ReadLine();
                liczba = int.Parse(input);
                if(liczba !=0)
                {
                    lis.Add(liczba);
                }
                else
                {
                    running = false;
                }
            } while (running);
            for(int i=0;i<lis.Count;i++)
            {
                if(lis[i]<0)
                {
                    lis.Remove(lis[i]);
                    i--;
                }
            }
            foreach (int i in lis)
            {
                Console.Write($"{i} ");
                suma += i;
                
            }
            Console.WriteLine();
            Console.WriteLine($"Liczba elementow dodatnich w tablicy to {lis.Count}");
            Console.WriteLine($"Suma liczb dodatnich to {suma}");

        }
    }
}