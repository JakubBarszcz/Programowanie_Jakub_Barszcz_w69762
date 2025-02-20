using System;

namespace SklepApp
{
    class Produkt
    {
        public string Nazwa;
        public decimal Cena;

        public Produkt(string n, decimal c)
        {
            Nazwa = n;
            Cena = c;
        }

        public override string ToString() => Nazwa + " - " + Cena + " zł";

        public override bool Equals(object obj)
        {
            if (obj is Produkt p)
                return Nazwa.ToLower() == p.Nazwa.ToLower() && Cena == p.Cena;
            return false;
        }

        public override int GetHashCode() => Nazwa.ToLower().GetHashCode() ^ Cena.GetHashCode();
    }
}