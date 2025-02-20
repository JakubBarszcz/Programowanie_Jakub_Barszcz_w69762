using System;
using System.Collections.Generic;

namespace SklepApp
{
    class Magazyn
    {
        public Dictionary<Produkt, int> Produkty = new Dictionary<Produkt, int>();

        public void DodajProdukt(Produkt p, int ilosc)
        {
            foreach (var item in Produkty)
            {
                if (item.Key.Nazwa.ToLower() == p.Nazwa.ToLower())
                {
                    Produkty[item.Key] += ilosc;
                    return;
                }
            }
            Produkty.Add(p, ilosc);
        }

        public Produkt PobierzProdukt(int index)
        {
            if (index < 0 || index >= Produkty.Count) return null;
            int i = 0;
            foreach (var item in Produkty)
            {
                if (i == index) return item.Key;
                i++;
            }
            return null;
        }

        public bool SprawdzDostepnosc(int index, int ilosc)
        {
            if (index < 0 || index >= Produkty.Count) return false;
            int i = 0;
            foreach (var item in Produkty)
            {
                if (i == index) return item.Value >= ilosc;
                i++;
            }
            return false;
        }

        public void UsunProdukt(Produkt p, int ilosc)
        {
            if (Produkty.ContainsKey(p))
            {
                Produkty[p] -= ilosc;
                if (Produkty[p] <= 0)
                    Produkty.Remove(p);
            }
        }

        public void WyswietlProdukty()
        {
            int i = 0;
            foreach (var item in Produkty)
            {
                Console.WriteLine(i + ". " + item.Key.Nazwa + " - " + item.Key.Cena + " zł, Ilość: " + item.Value);
                i++;
            }
        }
    }
}