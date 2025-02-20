using System;
using System.Collections.Generic;
using System.IO;

namespace SklepApp
{
    class Sklep
    {
        private Magazyn magazyn = new Magazyn();
        private List<Klient> klienci = new List<Klient>();
        private List<Zamowienie> zamowienia = new List<Zamowienie>();
        private List<string> zamowieniaZPliku = new List<string>();

        private const string plikMagazyn = "magazyn.txt";
        private const string plikKlienci = "klienci.txt";
        private const string plikZamowienia = "zamowienia.txt";

        public void WczytajDane()
        {
            if (File.Exists(plikMagazyn))
            {
                foreach (string line in File.ReadAllLines(plikMagazyn))
                {
                    string[] p = line.Split(';');
                    if (p.Length == 3)
                        magazyn.DodajProdukt(new Produkt(p[0], decimal.Parse(p[1])), int.Parse(p[2]));
                }
            }
            if (File.Exists(plikKlienci))
            {
                foreach (string line in File.ReadAllLines(plikKlienci))
                {
                    string[] p = line.Split(';');
                    if (p.Length == 3)
                        klienci.Add(new Klient(p[0], p[1], decimal.Parse(p[2])));
                }
            }
            if (File.Exists(plikZamowienia))
                zamowieniaZPliku.AddRange(File.ReadAllLines(plikZamowienia));
        }

        public void ZapiszDane()
        {
            var magLines = new List<string>();
            foreach (var item in magazyn.Produkty)
                magLines.Add(item.Key.Nazwa + ";" + item.Key.Cena + ";" + item.Value);
            File.WriteAllLines(plikMagazyn, magLines);

            var klientLines = new List<string>();
            foreach (var k in klienci)
                klientLines.Add(k.Imie + ";" + k.Nazwisko + ";" + k.Saldo);
            File.WriteAllLines(plikKlienci, klientLines);

            var allOrders = new List<string>(zamowieniaZPliku);
            foreach (var z in zamowienia)
                allOrders.Add(z.ToString());
            File.WriteAllLines(plikZamowienia, allOrders);
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Dodaj produkt\n2. Sprzedaż detaliczna\n3. Sprzedaż hurtowa\n4. Produkty\n5. Dodaj klienta\n6. Klienci\n7. Zamówienia\n8. Wyjście");
                Console.Write("Wybierz: ");
                string o = Console.ReadLine();
                if (o == "1") PrzyjmijTowar();
                else if (o == "2") SprzedazDetaliczna();
                else if (o == "3") SprzedazHurtowa();
                else if (o == "4") magazyn.WyswietlProdukty();
                else if (o == "5") DodajKlienta();
                else if (o == "6") WyswietlKlientow();
                else if (o == "7") WyswietlZamowienia();
                else if (o == "8") break;
                else Console.WriteLine("Błędna opcja");
            }
        }

        private void PrzyjmijTowar()
        {
            Console.Write("Nazwa: ");
            string n = Console.ReadLine();
            Console.Write("Cena: ");
            decimal c = decimal.Parse(Console.ReadLine());
            Console.Write("Ilość: ");
            int i = int.Parse(Console.ReadLine());
            magazyn.DodajProdukt(new Produkt(n, c), i);
            Console.WriteLine("Produkt dodany");
        }

        private void SprzedazDetaliczna()
        {
            Console.WriteLine("Sprzedaż detaliczna:");
            Koszyk koszyk = new Koszyk();
            while (true)
            {
                magazyn.WyswietlProdukty();
                Console.Write("ID produktu (-1 aby zakończyć): ");
                int id = int.Parse(Console.ReadLine());
                if (id == -1) break;
                Produkt p = magazyn.PobierzProdukt(id);
                if (p == null)
                {
                    Console.WriteLine("Nie ma takiego produktu");
                    continue;
                }
                Console.Write("Ilość: ");
                int ilosc = int.Parse(Console.ReadLine());
                if (!magazyn.SprawdzDostepnosc(id, ilosc))
                {
                    Console.WriteLine("Niewystarczająco");
                    continue;
                }
                koszyk.DodajProdukt(p, ilosc);
            }
            decimal suma = koszyk.ObliczCene();
            Console.WriteLine("Do zapłaty: " + suma);
            Console.Write("Kwota: ");
            decimal kw = decimal.Parse(Console.ReadLine());
            if (kw < suma)
            {
                Console.WriteLine("Za mało");
                return;
            }
            decimal reszta = kw - suma;
            if (reszta > 0)
                Console.WriteLine("Reszta: " + reszta);
            foreach (var item in koszyk.Produkty)
                magazyn.UsunProdukt(item.Key, item.Value);
            zamowienia.Add(new Zamowienie(null, koszyk));
            Console.WriteLine("Sprzedaż zakończona");
        }

        private void SprzedazHurtowa()
        {
            Console.WriteLine("Sprzedaż hurtowa:");
            Console.Write("ID klienta: ");
            int idk = int.Parse(Console.ReadLine());
            if (idk < 0 || idk >= klienci.Count)
            {
                Console.WriteLine("Nie ma klienta");
                return;
            }
            Klient k = klienci[idk];
            Koszyk koszyk = new Koszyk();
            while (true)
            {
                magazyn.WyswietlProdukty();
                Console.Write("ID produktu (-1 aby zakończyć): ");
                int id = int.Parse(Console.ReadLine());
                if (id == -1) break;
                Produkt p = magazyn.PobierzProdukt(id);
                if (p == null)
                {
                    Console.WriteLine("Nie ma takiego produktu");
                    continue;
                }
                Console.Write("Ilość: ");
                int il = int.Parse(Console.ReadLine());
                if (!magazyn.SprawdzDostepnosc(id, il))
                {
                    Console.WriteLine("Niewystarczająco");
                    continue;
                }
                koszyk.DodajProdukt(p, il);
            }
            decimal suma = koszyk.ObliczCene();
            Console.WriteLine("Do zapłaty: " + suma);
            if (k.Saldo < suma)
            {
                Console.WriteLine("Za mało środków");
                return;
            }
            k.Saldo -= suma;
            foreach (var item in koszyk.Produkty)
                magazyn.UsunProdukt(item.Key, item.Value);
            zamowienia.Add(new Zamowienie(k, koszyk));
            Console.WriteLine("Sprzedaż hurtowa zakończona");
        }

        private void DodajKlienta()
        {
            Console.Write("Imię: ");
            string i = Console.ReadLine();
            Console.Write("Nazwisko: ");
            string n = Console.ReadLine();
            Console.Write("Saldo: ");
            decimal s = decimal.Parse(Console.ReadLine());
            klienci.Add(new Klient(i, n, s));
            Console.WriteLine("Klient dodany");
        }

        private void WyswietlKlientow()
        {
            Console.WriteLine("Klienci:");
            for (int i = 0; i < klienci.Count; i++)
                Console.WriteLine(i + ". " + klienci[i]);
        }

        private void WyswietlZamowienia()
        {
            Console.WriteLine("Zamówienia (poprzednie sesje):");
            foreach (string s in zamowieniaZPliku)
                Console.WriteLine(s);
            Console.WriteLine("Zamówienia (ta sesja):");
            foreach (Zamowienie z in zamowienia)
                Console.WriteLine(z);
        }
    }
}