/*
using System;
using System.Collections.Generic;

namespace Kalkulator
{
    
    enum Operacja
    {
        Dodawanie,
        Odejmowanie,
        Mno�enie,
        Dzielenie
    }

    class Program
    {
       
        static List<double> wyniki = new List<double>();

        static void Main(string[] args)
        {
            bool kontynuuj = true;

            while (kontynuuj)
            {
                try
                {
                    
                    Console.WriteLine("Wybierz operacj�:");
                    Console.WriteLine("1. Dodawanie");
                    Console.WriteLine("2. Odejmowanie");
                    Console.WriteLine("3. Mno�enie");
                    Console.WriteLine("4. Dzielenie");
                    Console.WriteLine("5. Wyj�cie");

                    int wybor = int.Parse(Console.ReadLine());

                    
                    if (wybor < 1 || wybor > 5)
                    {
                        Console.WriteLine("Nieprawid�owy wyb�r operacji.");
                        continue;
                    }

                    if (wybor == 5)
                    {
                        kontynuuj = false;
                        break;
                    }

                    
                    Console.Write("Podaj pierwsz� liczb�: ");
                    double liczba1 = double.Parse(Console.ReadLine());

                    Console.Write("Podaj drug� liczb�: ");
                    double liczba2 = double.Parse(Console.ReadLine());

                    Operacja operacja = (Operacja)(wybor - 1);
                    double wynik = 0;

                    
                    switch (operacja)
                    {
                        case Operacja.Dodawanie:
                            wynik = liczba1 + liczba2;
                            break;
                        case Operacja.Odejmowanie:
                            wynik = liczba1 - liczba2;
                            break;
                        case Operacja.Mno�enie:
                            wynik = liczba1 * liczba2;
                            break;
                        case Operacja.Dzielenie:
                            if (liczba2 == 0)
                            {
                                throw new DivideByZeroException("Nie mo�na dzieli� przez zero!");
                            }
                            wynik = liczba1 / liczba2;
                            break;
                    }

                    
                    wyniki.Add(wynik);

                    
                    Console.WriteLine($"Wynik: {wynik}");

                    
                    Console.WriteLine("\nWyniki poprzednich oblicze�:");
                    foreach (var w in wyniki)
                    {
                        Console.WriteLine(w);
                    }

                    Console.WriteLine(); // Przerwa
                }
                catch (FormatException)
                {
                    Console.WriteLine("B��d: Prosz� wprowadzi� prawid�ow� liczb�!");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"B��d: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wyst�pi� nieoczekiwany b��d: {ex.Message}");
                }
            }

            Console.WriteLine("Koniec programu.");
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;

namespace SklepZamowienia
{
    
    enum StatusZamowienia
    {
        Oczekuj�ce,
        Przyj�te,
        Zrealizowane,
        Anulowane
    }

    class Program
    {
        
        static Dictionary<int, List<string>> zamowienia = new Dictionary<int, List<string>>();
        
        static Dictionary<int, StatusZamowienia> statusyZamowien = new Dictionary<int, StatusZamowienia>();

        static void Main(string[] args)
        {
           
            DodajZamowienie(1, new List<string> { "Produkt1", "Produkt2" });
            DodajZamowienie(2, new List<string> { "Produkt3" });
            DodajZamowienie(3, new List<string> { "Produkt4", "Produkt5", "Produkt6" });

            
            bool kontynuuj = true;

            while (kontynuuj)
            {
                Console.WriteLine("1. Zmie� status zam�wienia");
                Console.WriteLine("2. Wy�wietl wszystkie zam�wienia");
                Console.WriteLine("3. Zako�cz");

                try
                {
                    int wybor = int.Parse(Console.ReadLine());

                    switch (wybor)
                    {
                        case 1:
                            ZmienStatusZamowienia();
                            break;

                        case 2:
                            WyswietlZamowienia();
                            break;

                        case 3:
                            kontynuuj = false;
                            break;

                        default:
                            Console.WriteLine("Nieprawid�owy wyb�r.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Prosz� wprowadzi� poprawny numer.");
                }
            }

            Console.WriteLine("Koniec programu.");
        }

        
        static void DodajZamowienie(int numerZamowienia, List<string> produkty)
        {
            zamowienia[numerZamowienia] = produkty;
            statusyZamowien[numerZamowienia] = StatusZamowienia.Oczekuj�ce;
        }

        
        static void ZmienStatusZamowienia()
        {
            Console.Write("Podaj numer zam�wienia: ");
            int numerZamowienia = int.Parse(Console.ReadLine());

            try
            {
                
                if (!zamowienia.ContainsKey(numerZamowienia))
                {
                    throw new KeyNotFoundException("Zam�wienie o podanym numerze nie istnieje.");
                }

                Console.WriteLine("Wybierz nowy status:");
                Console.WriteLine("1. Oczekuj�ce");
                Console.WriteLine("2. Przyj�te");
                Console.WriteLine("3. Zrealizowane");
                Console.WriteLine("4. Anulowane");

                int wybor = int.Parse(Console.ReadLine());

                StatusZamowienia nowyStatus = (StatusZamowienia)(wybor - 1);

                
                if (statusyZamowien[numerZamowienia] == nowyStatus)
                {
                    throw new ArgumentException("Zam�wienie ju� ma ten status.");
                }

                
                statusyZamowien[numerZamowienia] = nowyStatus;
                Console.WriteLine($"Status zam�wienia {numerZamowienia} zmieniono na {nowyStatus}.");
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"B��d: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"B��d: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Prosz� wybra� poprawny numer statusu.");
            }
        }

        
        static void WyswietlZamowienia()
        {
            foreach (var zamowienie in zamowienia)
            {
                int numerZamowienia = zamowienie.Key;
                List<string> produkty = zamowienie.Value;
                StatusZamowienia status = statusyZamowien[numerZamowienia];

                Console.WriteLine($"Numer zam�wienia: {numerZamowienia}");
                Console.WriteLine($"Status: {status}");
                Console.WriteLine("Produkty:");
                foreach (var produkt in produkty)
                {
                    Console.WriteLine($"- {produkt}");
                }
                Console.WriteLine();
            }
        }
    }
}
*/

using System;
using System.Collections.Generic;

namespace GraZGadujKolor
{

    enum Kolor
    {
        Czerwony,
        Niebieski,
        Zielony,
        ��ty,
        Fioletowy
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Kolor> kolory = new List<Kolor>
            {
                Kolor.Czerwony,
                Kolor.Niebieski,
                Kolor.Zielony,
                Kolor.��ty,
                Kolor.Fioletowy
            };


            Random rand = new Random();
            Kolor wylosowanyKolor = kolory[rand.Next(kolory.Count)];


            bool odgadni�to = false;
            Console.WriteLine("Witaj w grze! Zgadnij kolor.");

            while (!odgadni�to)
            {
                Console.WriteLine("Dost�pne kolory: Czerwony, Niebieski, Zielony, ��ty, Fioletowy");
                Console.Write("Wpisz kolor: ");

                string input = Console.ReadLine();

                try
                {

                    Kolor kolorUzytkownika;
                    if (Enum.TryParse(input, true, out kolorUzytkownika))
                    {
                        if (Enum.IsDefined(typeof(Kolor), kolorUzytkownika))
                        {

                            if (kolorUzytkownika == wylosowanyKolor)
                            {
                                Console.WriteLine("Brawo! Zgad�e� kolor.");
                                odgadni�to = true;
                            }
                            else
                            {
                                Console.WriteLine("Niestety, to nie ten kolor. Spr�buj ponownie.");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Nieprawid�owy kolor. Wybierz jeden z dost�pnych kolor�w.");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Nieprawid�owy kolor. Wybierz jeden z dost�pnych kolor�w.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"B��d: {ex.Message}");
                }
            }

            Console.WriteLine("Koniec gry. Dzi�kujemy za udzia�!");
        }
    }
}
