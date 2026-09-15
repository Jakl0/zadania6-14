using System;
using System.IO;

class Program
{
    static void ZapiszLosy(string nazwapliku)
    {
        Random random = new Random();
        using (StreamWriter pis = new StreamWriter(nazwapliku))
        {
            for(int i = 0; i < 10;i++)
            {
                pis.WriteLine(random.Next(1,101));
            }
        }
        
    }
    static void OdczytajLosy(string nazwapliku)
    {
        try
        {
            string[] linie = File.ReadAllLines(nazwapliku);
            int m ,s;
            m = 0;
            s = 0;
            foreach (string line in linie)
            {
                if (int.TryParse(line, out int x))
                {
                    Console.WriteLine(x);
                    if(x > m)
                    {
                        m = x;
                    }
                }
            }
            Console.WriteLine($"Najwieksza liczba to {m}");
            foreach (string line in linie)
            {
                if (int.TryParse(line, out int x))
                {
                    s += x;
                    if (x < m)
                    {
                        m = x;
                    }
                }
            }
            Console.WriteLine($"Najmniejsza liczba to {m}");
            Console.WriteLine($"Suma tych liczb wynosi {s}");
        }
        catch(System.IO.FileNotFoundException)
        {
            Console.WriteLine("Nie znaleziono pliku");
        }
    }
    static void Main()
    {
        string pliczek = "losowania.txt";
        ZapiszLosy(pliczek);
        OdczytajLosy(pliczek);
    }

}
