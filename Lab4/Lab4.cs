/*
using System;
using System.Collections.Generic;


public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    
    public virtual void Draw()
    {
        Console.WriteLine("Rysujê kszta³t.");
    }
}


public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Rysujê prostok¹t o wymiarach {Width} x {Height}, w pozycji ({X}, {Y}).");
    }
}


public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Rysujê trójk¹t o wysokoœci {Height} i podstawie {Width}, w pozycji ({X}, {Y}).");
    }
}


public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine($"Rysujê okr¹g o promieniu {Width}, w pozycji ({X}, {Y}).");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        
        shapes.Add(new Rectangle { X = 1, Y = 1, Height = 4, Width = 6 });
        shapes.Add(new Triangle { X = 2, Y = 2, Height = 5, Width = 4 });
        shapes.Add(new Circle { X = 3, Y = 3, Height = 0, Width = 7 }); // Promieñ to Width

        
        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}
 */
/*
using System;
using System.Collections.Generic;

public interface IOsoba
{
    string Imie { get; set; }
    string Nazwisko { get; set; }
    string ZwrocPelnaNazwe();
}

public class Osoba : IOsoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Pesel { get; set; }

    public Osoba(string imie, string nazwisko, string pesel)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Pesel = pesel;
    }

    public string ZwrocPelnaNazwe()
    {
        return $"{Imie} {Nazwisko}";
    }

    
    public int GetAge()
    {
        int year = int.Parse(Pesel.Substring(0, 2));
        int month = int.Parse(Pesel.Substring(2, 2));
        int day = int.Parse(Pesel.Substring(4, 2));

        int currentYear = DateTime.Now.Year;
        int currentMonth = DateTime.Now.Month;
        int currentDay = DateTime.Now.Day;

        year = (year > 20) ? 1900 + year : 2000 + year;

        int age = currentYear - year;

        if (currentMonth < month || (currentMonth == month && currentDay < day))
            age--;

        return age;
    }

    
    public string GetGender()
    {
        return (int.Parse(Pesel.Substring(9, 1)) % 2 == 0) ? "Kobieta" : "Mê¿czyzna";
    }

    public virtual void GetEducationInfo()
    {
        Console.WriteLine("Brak informacji o edukacji.");
    }

    public virtual void CanGoAloneToHome()
    {
        Console.WriteLine("Brak dostêpu do sprawdzania.");
    }
}
*/
/*
public class Uczen : Osoba
{
    public string Szko³a { get; set; }
    public bool MozeSamWracacDoDomu { get; set; }

    public Uczen(string imie, string nazwisko, string pesel, string szko³a)
        : base(imie, nazwisko, pesel)
    {
        Szko³a = szko³a;
    }

    public void SetSchool(string szko³a)
    {
        Szko³a = szko³a;
    }

    public void ChangeSchool(string nowaSzko³a)
    {
        Szko³a = nowaSzko³a;
    }

    public void SetCanGoHomeAlone(bool canGo)
    {
        MozeSamWracacDoDomu = canGo;
    }

    // Implementacja metod z klasy Osoba
    public override void GetEducationInfo()
    {
        Console.WriteLine($"Uczeñ {Imie} {Nazwisko} chodzi do szko³y: {Szko³a}");
    }

    public override void CanGoAloneToHome()
    {
        int age = GetAge();
        if (age >= 12 || MozeSamWracacDoDomu)
        {
            Console.WriteLine($"{Imie} {Nazwisko} mo¿e wracaæ do domu samodzielnie.");
        }
        else
        {
            Console.WriteLine($"{Imie} {Nazwisko} nie mo¿e wracaæ do domu samodzielnie.");
        }
    }
}
*/
/*
public class Nauczyciel : Uczen
{
    public string TytulNaukowy { get; set; }
    public List<Uczen> PodwladniUczniowie { get; set; }

    public Nauczyciel(string imie, string nazwisko, string pesel, string szko³a, string tytulNaukowy)
        : base(imie, nazwisko, pesel, szko³a)
    {
        TytulNaukowy = tytulNaukowy;
        PodwladniUczniowie = new List<Uczen>();
    }

    public void AddStudent(Uczen uczen)
    {
        PodwladniUczniowie.Add(uczen);
    }

    public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
    {
        foreach (var uczen in PodwladniUczniowie)
        {
            uczen.CanGoAloneToHome();
        }
    }
}
*/
/*
public static class IOsobaExtensions
{
    public static void WypiszOsoby(this List<IOsoba> osoby)
    {
        foreach (var osoba in osoby)
        {
            Console.WriteLine(osoba.ZwrocPelnaNazwe());
        }
    }

    public static void PosortujOsobyPoNazwisku(this List<IOsoba> osoby)
    {
        osoby.Sort((x, y) => x.Nazwisko.CompareTo(y.Nazwisko));
    }
}
*/
/*
public interface IStudent : IOsoba
{
    string Uczelnia { get; set; }
    string Kierunek { get; set; }
    int Rok { get; set; }
    int Semestr { get; set; }
}
*/
/*
public class Student : IStudent
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Uczelnia { get; set; }
    public string Kierunek { get; set; }
    public int Rok { get; set; }
    public int Semestr { get; set; }

    public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        Uczelnia = uczelnia;
        Kierunek = kierunek;
        Rok = rok;
        Semestr = semestr;
    }

    public string ZwrocPelnaNazwe()
    {
        return $"{Imie} {Nazwisko}";
    }

    public string WypiszPelnaNazweIUczelnie()
    {
        return $"{Imie} {Nazwisko} – {Rok} {Semestr} {Kierunek} {Uczelnia}";
    }
}
*/
/*
public class StudentWSIiZ : Student
{
    public StudentWSIiZ(string imie, string nazwisko, string uczelnia, string kierunek, int rok, int semestr)
        : base(imie, nazwisko, uczelnia, kierunek, rok, semestr)
    {
    }

    // Przeci¹¿enie metody
    public new string WypiszPelnaNazweIUczelnie()
    {
        return $"{Imie} {Nazwisko} – {Rok} {Semestr} {Kierunek} {Uczelnia} - WSIiZ";
    }
}
*/
/*
class Program
{
    static void Main(string[] args)
    {
        // Tworzenie obiektów
        var uczen1 = new Uczen("Jan", "Kowalski", "12345678901", "Szko³a Podstawowa");
        var uczen2 = new Uczen("Anna", "Nowak", "98765432101", "Szko³a Œrednia");
        var nauczyciel = new Nauczyciel("Adam", "Wójcik", "11122334455", "Szko³a Techniczna", "Profesor");

        // Dodanie uczniów do nauczyciela
        nauczyciel.AddStudent(uczen1);
        nauczyciel.AddStudent(uczen2);

        // Sprawdzenie, którzy uczniowie mog¹ wracaæ sami do domu
        nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);

        // Tworzenie listy osób
        List<IOsoba> osoby = new List<IOsoba>
        {
            uczen1,
            uczen2,
            new StudentWSIiZ("Krzysztof", "Wróbel", "WSIiZ", "Informatyka", 2, 3)
        };

        // Wyœwietlanie pe³nych nazwisk osób
        osoby.WypiszOsoby();

        // Sortowanie po nazwiskach
        osoby.PosortujOsobyPoNazwisku();
        osoby.WypiszOsoby();
    }
}
*/