/*
using System;

class Osoba
{
    private string imie;
    private string nazwisko;
    private int wiek;

   
    public Osoba(string imie, string nazwisko, int wiek)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Wiek = wiek;
    }

    
    public string Imie
    {
        get { return imie; }
        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("Imi� musi mie� co najmniej 2 znaki.");
            }
            imie = value;
        }
    }

    
    public string Nazwisko
    {
        get { return nazwisko; }
        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("Nazwisko musi mie� co najmniej 2 znaki.");
            }
            nazwisko = value;
        }
    }

   
    public int Wiek
    {
        get { return wiek; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Wiek musi by� liczb� dodatni�.");
            }
            wiek = value;
        }
    }

    
    public void WyswietlInformacje()
    {
        Console.WriteLine($"Imi�: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Osoba osoba = new Osoba("Jan", "Kowalski", 30);
            osoba.WyswietlInformacje();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"B��d: {ex.Message}");
        }
    }
}
*/
/*
using System;

public class BankAccount
{
    // Prywatne pole przechowuj�ce saldo
    private decimal saldo;

    // W�a�ciwo�� do odczytu salda
    public decimal Saldo
    {
        get { return saldo; }
    }

    // W�a�ciwo�� przechowuj�ca w�a�ciciela konta
    public string Wlasciciel { get; private set; }

    // Konstruktor, kt�ry inicjalizuje w�a�ciciela oraz pocz�tkowe saldo
    public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
    {
        Wlasciciel = wlasciciel;
        saldo = poczatkoweSaldo;
    }

    // Metoda wp�aty, kt�ra zwi�ksza saldo o okre�lon� kwot�
    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wp�aty musi by� wi�ksza ni� 0.");
        }
        else
        {
            saldo += kwota;
            Console.WriteLine($"Wp�acono: {kwota}. Nowe saldo: {saldo}");
        }
    }

    // Metoda wyp�aty, kt�ra sprawdza, czy saldo jest wystarczaj�ce
    public void Wyplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wyp�aty musi by� wi�ksza ni� 0.");
        }
        else if (kwota > saldo)
        {
            Console.WriteLine("Niewystarczaj�ce �rodki na koncie.");
        }
        else
        {
            saldo -= kwota;
            Console.WriteLine($"Wyp�acono: {kwota}. Nowe saldo: {saldo}");
        }
    }
}

// Przyk�ad u�ycia
class Program
{
    static void Main()
    {
        // Tworzymy nowe konto bankowe
        BankAccount konto = new BankAccount("Jan Kowalski", 1000);

        // Wykonujemy wp�at�
        konto.Wplata(500);

        // Wykonujemy wyp�at�
        konto.Wyplata(200);

        // Wy�wietlamy saldo
        Console.WriteLine($"Saldo: {konto.Saldo}");
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    // Pola przechowuj�ce imi�, nazwisko i tablic� ocen
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    private List<int> oceny;

    // Konstruktor inicjuj�cy imi� i nazwisko
    public Student(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        oceny = new List<int>();
    }

    // W�a�ciwo�� obliczaj�ca �redni� ocen
    public double SredniaOcen
    {
        get
        {
            if (oceny.Count == 0) // je�li brak ocen, zwr�� 0
                return 0;
            return oceny.Average(); // oblicz �redni�
        }
    }

    // Metoda dodaj�ca ocen� do tablicy
    public void DodajOcene(int ocena)
    {
        if (ocena >= 2 && ocena <= 5) // Zak�adaj�c, �e oceny s� w przedziale od 2 do 5
        {
            oceny.Add(ocena);
            Console.WriteLine($"Dodano ocen�: {ocena}");
        }
        else
        {
            Console.WriteLine("Ocena musi by� w przedziale od 2 do 5.");
        }
    }

    // Metoda wypisuj�ca dane studenta
    public void WypiszDane()
    {
        Console.WriteLine($"Student: {Imie} {Nazwisko}");
        Console.WriteLine($"�rednia ocen: {SredniaOcen:F2}");
    }
}

// Przyk�ad u�ycia klasy
class Program
{
    static void Main()
    {
        // Tworzymy nowego studenta
        Student student = new Student("Jan", "Kowalski");

        // Dodajemy oceny
        student.DodajOcene(5);
        student.DodajOcene(4);
        student.DodajOcene(3);

        // Wy�wietlamy dane studenta
        student.WypiszDane();
    }
}
*/
/*
using System;

public class Licz
{
    // Prywatne pole przechowuj�ce warto�� liczbow�
    private int value;

    // Konstruktor, kt�ry inicjalizuje pole 'value' przekazan� liczb�
    public Licz(int initialValue)
    {
        value = initialValue;
    }

    // Metoda Dodaj, kt�ra dodaje przekazan� warto�� do 'value'
    public void Dodaj(int liczba)
    {
        value += liczba;
    }

    // Metoda Odejmij, kt�ra odejmuje przekazan� warto�� od 'value'
    public void Odejmij(int liczba)
    {
        value -= liczba;
    }

    // Metoda do wypisania stanu obiektu (warto�ci 'value')
    public void WypiszStan()
    {
        Console.WriteLine($"Warto��: {value}");
    }
}

// Przyk�ad u�ycia klasy Licz
class Program
{
    static void Main()
    {
        // Tworzymy kilka obiekt�w klasy Licz
        Licz licz1 = new Licz(10);
        Licz licz2 = new Licz(25);

        // Wypisujemy pocz�tkowe warto�ci
        licz1.WypiszStan(); // Warto��: 10
        licz2.WypiszStan(); // Warto��: 25

        // Wykonujemy operacje Dodaj i Odejmij
        licz1.Dodaj(5);
        licz1.Odejmij(3);

        licz2.Dodaj(10);
        licz2.Odejmij(5);

        // Wypisujemy nowe warto�ci
        licz1.WypiszStan(); // Warto��: 12
        licz2.WypiszStan(); // Warto��: 30
    }
}

using System;

public class Sumator
{
    // Prywatne pole przechowuj�ce tablic� liczb
    private int[] Liczby;

    // Konstruktor, kt�ry przyjmuje tablic� liczb i inicjalizuje pole
    public Sumator(int[] liczby)
    {
        Liczby = liczby;
    }

    // Metoda Suma, zwracaj�ca sum� wszystkich liczb w tablicy
    public int Suma()
    {
        int suma = 0;
        foreach (var liczba in Liczby)
        {
            suma += liczba;
        }
        return suma;
    }

    // Metoda SumaPodziel2, zwracaj�ca sum� liczb podzielnych przez 2
    public int SumaPodziel2()
    {
        int suma = 0;
        foreach (var liczba in Liczby)
        {
            if (liczba % 2 == 0)
            {
                suma += liczba;
            }
        }
        return suma;
    }

    // Metoda IleElement�w, zwracaj�ca liczb� element�w w tablicy
    public int IleElement�w()
    {
        return Liczby.Length;
    }

    // Metoda WypiszElementy, wypisuj�ca wszystkie elementy tablicy
    public void WypiszElementy()
    {
        foreach (var liczba in Liczby)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine();
    }

    // Metoda WypiszElementyZZakresu, wypisuj�ca elementy z okre�lonego zakresu indeks�w
    public void WypiszElementyZZakresu(int lowIndex, int highIndex)
    {
        // Sprawdzamy, aby indeksy mie�ci�y si� w poprawnym zakresie tablicy
        for (int i = lowIndex; i <= highIndex; i++)
        {
            if (i >= 0 && i < Liczby.Length) // Sprawdzamy, czy indeks jest w granicach tablicy
            {
                Console.Write(Liczby[i] + " ");
            }
        }
        Console.WriteLine();
    }
}


class Program
{
    static void Main()
    {

        int[] liczby = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Sumator sumator = new Sumator(liczby);


        Console.WriteLine("Wszystkie elementy:");
        sumator.WypiszElementy();


        Console.WriteLine($"Liczba element�w: {sumator.IleElement�w()}");


        Console.WriteLine($"Suma wszystkich liczb: {sumator.Suma()}");


        Console.WriteLine($"Suma liczb podzielnych przez 2: {sumator.SumaPodziel2()}");


        Console.WriteLine("Elementy od indeksu 2 do 7:");
        sumator.WypiszElementyZZakresu(2, 7);


        Console.WriteLine("Elementy z zakresu -1 do 15:");
        sumator.WypiszElementyZZakresu(-1, 15);
    }
}
*/