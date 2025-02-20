using System;
using System.Collections.Generic;

namespace SklepApp
{
    class Koszyk
    {
        public Dictionary<Produkt, int> Produkty = new Dictionary<Produkt, int>();

        public void DodajProdukt(Produkt p, int ilosc)
        {
            if (Produkty.ContainsKey(p))
                Produkty[p] += ilosc;
            else
                Produkty.Add(p, ilosc);
        }

        public decimal ObliczCene()
        {
            decimal suma = 0;
            foreach (var item in Produkty)
                suma += item.Key.Cena * item.Value;
            return suma;
        }
    }
}