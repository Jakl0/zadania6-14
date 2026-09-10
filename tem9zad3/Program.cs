using System;

public class HelloWorld
{
    int IleParzystych(int[] tab)
    {
        int licz = 0;
        foreach(int i in tab)
        {
            if (i % 2 == 0)
            {
                
            }
        }
    }
    public static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Wpisz tu liczbe: ");
        string input = Console.ReadLine();
        int abc = int.Parse(input);
        int[,] lis = new int[abc, 6];
        int[] licznig = new int[49];

        for (int i = 0; i < abc; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                lis[i, j] = random.Next(1, 49);
                for (int k = 0; k < j; k++)
                {
                    if (lis[i, k] == lis[i, j])
                    {
                        lis[i, j] = random.Next(1, 49);
                        k--;
                    }
                }
            }
        }
        for (int i = 0; i < 49; i++)
        {
            licznig[i] = 0;
        }
        for (int i = 0; i < abc; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write($"{lis[i, j]} ");
                licznig[lis[i, j] - 1] += 1;
            }
            Console.WriteLine();
        }
        int inde = 1;
        int wartosc = 1;
        List<int> odpowiedzi = new List<int>(1);
        for (int i = 0; i < 49; i++)
        {
            if (wartosc < licznig[i])
            {
                inde = i;
                wartosc = licznig[i];
                odpowiedzi = new List<int>(inde);
            }
            else if (wartosc == licznig[i])
            {
                odpowiedzi.Add(i);
            }
        }
        if (odpowiedzi.Count > 1)
        {
            Console.Write($"Liczby ");
            foreach (int i in odpowiedzi)
                Console.Write($"{i + 1} ");
            Console.WriteLine($"byly wylosowane {wartosc} razy czyli najwiecej ze wszystkich");
        }
        else
            Console.WriteLine($"Liczba {inde + 1} byla wylosowana {wartosc} razy czyli najwiecej ze wszystkich");
    }
}

