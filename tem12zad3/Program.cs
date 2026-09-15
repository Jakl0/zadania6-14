using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace abc
{
    abstract class Pracownik
    {
        public string imie;
        public abstract double ObliczWynagrodzenie();
    }
    class PracownikEtatowy : Pracownik
    {
        public double pensjaMiesieczna;
        public PracownikEtatowy(double a , string b)
        {
            pensjaMiesieczna = a;
            imie = b;
        }
        public override double ObliczWynagrodzenie()
        {
            return pensjaMiesieczna;
        }
    }
    class Zleceniobiorca : Pracownik
    {
        public double stawkaGodzinowa;
        public int LiczbaGodzin;
        public Zleceniobiorca(double a, int b,string c)
        {
            
            stawkaGodzinowa = a;
            LiczbaGodzin = b;
            imie = c;
        }
        public override double ObliczWynagrodzenie()
        {
            return stawkaGodzinowa * LiczbaGodzin;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> pr = new List<Pracownik>();
            pr.Add(new Zleceniobiorca(3, 3, "Bogdan"));
            pr.Add(new PracownikEtatowy(3,"Mariusz"));
            pr.Add(new Zleceniobiorca(78, 5, "Gabriel"));
            pr.Add(new PracownikEtatowy(123, "Bartosz Benc"));
            foreach(Pracownik p in pr)
            {
                Console.WriteLine(p.imie);
                Console.WriteLine(p.ObliczWynagrodzenie());
            }
        }
    }
}