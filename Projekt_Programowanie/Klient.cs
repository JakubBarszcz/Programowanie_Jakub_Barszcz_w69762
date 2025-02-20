using System;

namespace SklepApp
{
    class Klient
    {
        public string Imie;
        public string Nazwisko;
        public decimal Saldo;

        public Klient(string i, string n, decimal s)
        {
            Imie = i;
            Nazwisko = n;
            Saldo = s;
        }

        public override string ToString() => Imie + " " + Nazwisko + " - " + Saldo + " zł";
    }
}