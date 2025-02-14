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
                throw new ArgumentException("Imiê musi mieæ co najmniej 2 znaki.");
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
                throw new ArgumentException("Nazwisko musi mieæ co najmniej 2 znaki.");
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
                throw new ArgumentException("Wiek musi byæ liczb¹ dodatni¹.");
            }
            wiek = value;
        }
    }

    
    public void WyswietlInformacje()
    {
        Console.WriteLine($"Imiê: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
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
            Console.WriteLine($"B³¹d: {ex.Message}");
        }
    }
}
*/
/*
using System;

public class BankAccount
{
    // Prywatne pole przechowuj¹ce saldo
    private decimal saldo;

    // W³aœciwoœæ do odczytu salda
    public decimal Saldo
    {
        get { return saldo; }
    }

    // W³aœciwoœæ przechowuj¹ca w³aœciciela konta
    public string Wlasciciel { get; private set; }

    // Konstruktor, który inicjalizuje w³aœciciela oraz pocz¹tkowe saldo
    public BankAccount(string wlasciciel, decimal poczatkoweSaldo)
    {
        Wlasciciel = wlasciciel;
        saldo = poczatkoweSaldo;
    }

    // Metoda wp³aty, która zwiêksza saldo o okreœlon¹ kwotê
    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wp³aty musi byæ wiêksza ni¿ 0.");
        }
        else
        {
            saldo += kwota;
            Console.WriteLine($"Wp³acono: {kwota}. Nowe saldo: {saldo}");
        }
    }

    // Metoda wyp³aty, która sprawdza, czy saldo jest wystarczaj¹ce
    public void Wyplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wyp³aty musi byæ wiêksza ni¿ 0.");
        }
        else if (kwota > saldo)
        {
            Console.WriteLine("Niewystarczaj¹ce œrodki na koncie.");
        }
        else
        {
            saldo -= kwota;
            Console.WriteLine($"Wyp³acono: {kwota}. Nowe saldo: {saldo}");
        }
    }
}

// Przyk³ad u¿ycia
class Program
{
    static void Main()
    {
        // Tworzymy nowe konto bankowe
        BankAccount konto = new BankAccount("Jan Kowalski", 1000);

        // Wykonujemy wp³atê
        konto.Wplata(500);

        // Wykonujemy wyp³atê
        konto.Wyplata(200);

        // Wyœwietlamy saldo
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
    // Pola przechowuj¹ce imiê, nazwisko i tablicê ocen
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    private List<int> oceny;

    // Konstruktor inicjuj¹cy imiê i nazwisko
    public Student(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        oceny = new List<int>();
    }

    // W³aœciwoœæ obliczaj¹ca œredni¹ ocen
    public double SredniaOcen
    {
        get
        {
            if (oceny.Count == 0) // jeœli brak ocen, zwróæ 0
                return 0;
            return oceny.Average(); // oblicz œredni¹
        }
    }

    // Metoda dodaj¹ca ocenê do tablicy
    public void DodajOcene(int ocena)
    {
        if (ocena >= 2 && ocena <= 5) // Zak³adaj¹c, ¿e oceny s¹ w przedziale od 2 do 5
        {
            oceny.Add(ocena);
            Console.WriteLine($"Dodano ocenê: {ocena}");
        }
        else
        {
            Console.WriteLine("Ocena musi byæ w przedziale od 2 do 5.");
        }
    }

    // Metoda wypisuj¹ca dane studenta
    public void WypiszDane()
    {
        Console.WriteLine($"Student: {Imie} {Nazwisko}");
        Console.WriteLine($"Œrednia ocen: {SredniaOcen:F2}");
    }
}

// Przyk³ad u¿ycia klasy
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

        // Wyœwietlamy dane studenta
        student.WypiszDane();
    }
}
*/
/*
using System;

public class Licz
{
    // Prywatne pole przechowuj¹ce wartoœæ liczbow¹
    private int value;

    // Konstruktor, który inicjalizuje pole 'value' przekazan¹ liczb¹
    public Licz(int initialValue)
    {
        value = initialValue;
    }

    // Metoda Dodaj, która dodaje przekazan¹ wartoœæ do 'value'
    public void Dodaj(int liczba)
    {
        value += liczba;
    }

    // Metoda Odejmij, która odejmuje przekazan¹ wartoœæ od 'value'
    public void Odejmij(int liczba)
    {
        value -= liczba;
    }

    // Metoda do wypisania stanu obiektu (wartoœci 'value')
    public void WypiszStan()
    {
        Console.WriteLine($"Wartoœæ: {value}");
    }
}

// Przyk³ad u¿ycia klasy Licz
class Program
{
    static void Main()
    {
        // Tworzymy kilka obiektów klasy Licz
        Licz licz1 = new Licz(10);
        Licz licz2 = new Licz(25);

        // Wypisujemy pocz¹tkowe wartoœci
        licz1.WypiszStan(); // Wartoœæ: 10
        licz2.WypiszStan(); // Wartoœæ: 25

        // Wykonujemy operacje Dodaj i Odejmij
        licz1.Dodaj(5);
        licz1.Odejmij(3);

        licz2.Dodaj(10);
        licz2.Odejmij(5);

        // Wypisujemy nowe wartoœci
        licz1.WypiszStan(); // Wartoœæ: 12
        licz2.WypiszStan(); // Wartoœæ: 30
    }
}

using System;

public class Sumator
{
    // Prywatne pole przechowuj¹ce tablicê liczb
    private int[] Liczby;

    // Konstruktor, który przyjmuje tablicê liczb i inicjalizuje pole
    public Sumator(int[] liczby)
    {
        Liczby = liczby;
    }

    // Metoda Suma, zwracaj¹ca sumê wszystkich liczb w tablicy
    public int Suma()
    {
        int suma = 0;
        foreach (var liczba in Liczby)
        {
            suma += liczba;
        }
        return suma;
    }

    // Metoda SumaPodziel2, zwracaj¹ca sumê liczb podzielnych przez 2
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

    // Metoda IleElementów, zwracaj¹ca liczbê elementów w tablicy
    public int IleElementów()
    {
        return Liczby.Length;
    }

    // Metoda WypiszElementy, wypisuj¹ca wszystkie elementy tablicy
    public void WypiszElementy()
    {
        foreach (var liczba in Liczby)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine();
    }

    // Metoda WypiszElementyZZakresu, wypisuj¹ca elementy z okreœlonego zakresu indeksów
    public void WypiszElementyZZakresu(int lowIndex, int highIndex)
    {
        // Sprawdzamy, aby indeksy mieœci³y siê w poprawnym zakresie tablicy
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


        Console.WriteLine($"Liczba elementów: {sumator.IleElementów()}");


        Console.WriteLine($"Suma wszystkich liczb: {sumator.Suma()}");


        Console.WriteLine($"Suma liczb podzielnych przez 2: {sumator.SumaPodziel2()}");


        Console.WriteLine("Elementy od indeksu 2 do 7:");
        sumator.WypiszElementyZZakresu(2, 7);


        Console.WriteLine("Elementy z zakresu -1 do 15:");
        sumator.WypiszElementyZZakresu(-1, 15);
    }
}
*/