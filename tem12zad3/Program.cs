using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace abc
{
    abstract class Pracownik
    {
        protected string imie;
        public abstract double ObliczWynagrodzenie();
    }
    class PracownikEtatowy : Pracownik
    {
        public string imie;
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
        public string imie;
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
            List<Pracownik> pr = new List<Pracownik>(
                    new Zleceniobiorca(676, 67,"Mariusz")

                );
        }
    }
}