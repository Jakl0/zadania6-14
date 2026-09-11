using System;

namespace HelloWorld
{
    class KontoBankowe
    {
        private double saldo;
        public double Saldo
        {
            get => saldo; private set => saldo = value;
        }
        public KontoBankowe() 
        {
            this.Saldo = 0;
        }

        public KontoBankowe(double s)
        {
            this.Saldo = s;
        }
        public void Wplac(double p)
        {
            if (Saldo >= 0) 
            {
                Saldo += p;
            }
        }
        public void Wyplac(double p)
        {
            if (Saldo >= 0 && Saldo >= p)
            {
                Saldo -= p;
            }
        }
        public void PokazSaldo()
        {
            Console.WriteLine(Saldo);
        }
    }
    internal class Program
    {
         static void Main(string[] args)
        {
            KontoBankowe k = new KontoBankowe();
            k.PokazSaldo();
            k.Wplac(200);
            k.PokazSaldo();
            k.Wyplac(67);
            k.PokazSaldo();
        }
    }
}