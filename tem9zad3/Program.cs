using System;



namespace Loteria

{

    class Program

    {

        

        static void WypelnijZestaw(int[] liczby, Random generator)

        {

            for (int i = 0; i < liczby.Length; i++)

            {

                liczby[i] = generator.Next(1, 50); 

            }

        }

 

        static void WyswietlZestaw(int numer, int[] liczby)

        {

            Console.Write($"Zestaw {numer}: ");

            foreach (int liczba in liczby)

            {

                Console.Write(liczba + " ");

            }
            Console.Write($"- Liczby parzyste : {IleParzystych(liczby)}");
            Console.WriteLine();

        }

        static int IleParzystych(int[] liczby)
        {
            int ilosc = 0;
            foreach(int i in liczby)
            {
                if (i % 2 == 0)
                {
                    ilosc++;
                }
            }
            return ilosc;
        }


        static void Main(string[] args)

        {

            Random generator = new Random();



            Console.Write("Ile zestawów wylosować? ");

            int n = int.Parse(Console.ReadLine());



            

            for (int zestaw = 1; zestaw <= n; zestaw++)

            {

                int[] liczby = new int[6];   

                WypelnijZestaw(liczby, generator); 

                WyswietlZestaw(zestaw, liczby);  

            }



            Console.ReadKey();

        }

    }

}