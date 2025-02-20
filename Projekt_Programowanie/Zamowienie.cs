using System;
using System.Linq;

namespace SklepApp
{
    class Zamowienie
    {
        public Klient Klient;
        public Koszyk Koszyk;
        public DateTime Data;

        public Zamowienie(Klient k, Koszyk kosz)
        {
            Klient = k;
            Koszyk = kosz;
            Data = DateTime.Now;
        }

        public override string ToString()
        {
            string klientInfo = (Klient == null) ? "Detaliczna" : Klient.ToString();
            string produkty = string.Join(", ", Koszyk.Produkty.Select(x => x.Key.ToString() + " x" + x.Value));
            return "Zamówienie (" + Data + "): " + klientInfo + ", " + produkty;
        }
    }
}