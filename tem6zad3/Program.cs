using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int liczba;
        Console.Write("Podaj liczbe elementow twojej tablicy: ");
        string input = Console.ReadLine();
        liczba = int.Parse(input);
        int[] tabliczka = new int[liczba];

        Console.WriteLine("No to wpisz teraz wartosc tych liczb");
        for (int i = 0; i < liczba; i++)
        {
            Console.Write($"{i + 1}: ");

            input = Console.ReadLine();
            tabliczka[i] = int.Parse(input);
        }
        int wyznacznik = tabliczka[0];
        foreach (int i in tabliczka)
        {
            if (i > wyznacznik)
            {
                wyznacznik = i;
            }
        }
        Console.WriteLine($"Najwieksza liczba twojej tablicy to {wyznacznik}");
        wyznacznik = tabliczka[0];
        foreach (int i in tabliczka)
        {
            if (i < wyznacznik)
            {
                wyznacznik = i;
            }
        }
        Console.WriteLine($"Najmniejsza liczba twojej tablicy to {wyznacznik}");

        for (int i = 0; i < liczba; i++)
        {
            for (int j = 0; j < liczba-1; j++)
            {
                if (tabliczka[j] < tabliczka[j + 1])
                {
                    var temp = tabliczka[j];
                    tabliczka[j] = tabliczka[j + 1];
                    tabliczka[j+1] = temp;
                }
            }
        }
        Console.WriteLine("No i to jest twoja tablica tylko że ładnie posortowana");
        foreach (int i in tabliczka)
        {
            Console.Write(i);
            Console.Write(" ");
        }
    }
}