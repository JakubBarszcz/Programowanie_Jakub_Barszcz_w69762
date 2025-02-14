/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program obliczaj�cy wyr�nik delta i pierwiastki tr�jmianu kwadratowego.");


        Console.Write("Podaj wsp�czynnik a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wsp�czynnik b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wsp�czynnik c: ");
        double c = Convert.ToDouble(Console.ReadLine());


        double delta = b * b - 4 * a * c;
        Console.WriteLine($"Wyr�nik delta wynosi: {delta}");


        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Tr�jmian ma dwa pierwiastki rzeczywiste: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Tr�jmian ma jeden pierwiastek podw�jny: x = {x}");
        }
        else
        {
            Console.WriteLine("Tr�jmian nie ma pierwiastk�w rzeczywistych (delta < 0). Pierwiastki s� zespolone.");
        }


        Console.WriteLine("Naci�nij dowolny klawisz, aby zako�czy�...");
        Console.ReadKey();
    }
}
*/
/*
using System;

class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nKalkulator - Wybierz opcj�:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. R�nica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Pot�ga");
            Console.WriteLine("6. Pierwiastek");
            Console.WriteLine("7. Funkcje trygonometryczne");
            Console.WriteLine("8. Wyj�cie");

            Console.Write("Tw�j wyb�r: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Podaj pierwsz� liczb�: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drug� liczb�: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Suma: {num1 + num2}");
                    break;

                case 2:
                    Console.Write("Podaj pierwsz� liczb�: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drug� liczb�: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"R�nica: {num1 - num2}");
                    break;

                case 3:
                    Console.Write("Podaj pierwsz� liczb�: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drug� liczb�: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Iloczyn: {num1 * num2}");
                    break;

                case 4:
                    Console.Write("Podaj pierwsz� liczb�: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drug� liczb�: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Iloraz: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("B��d: Nie mo�na dzieli� przez zero.");
                    }
                    break;

                case 5:
                    Console.Write("Podaj podstaw�: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj wyk�adnik: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Pot�ga: {Math.Pow(num1, num2)}");
                    break;

                case 6:
                    Console.Write("Podaj liczb�: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    if (num1 >= 0)
                    {
                        Console.WriteLine($"Pierwiastek kwadratowy: {Math.Sqrt(num1)}");
                    }
                    else
                    {
                        Console.WriteLine("B��d: Nie mo�na obliczy� pierwiastka z liczby ujemnej.");
                    }
                    break;

                case 7:
                    Console.Write("Podaj k�t w radianach: ");
                    double angle = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Sinus: {Math.Sin(angle)}");
                    Console.WriteLine($"Cosinus: {Math.Cos(angle)}");
                    Console.WriteLine($"Tangens: {Math.Tan(angle)}");
                    if (Math.Cos(angle) != 0)
                    {
                        Console.WriteLine($"Cotangens: {1 / Math.Tan(angle)}");
                    }
                    else
                    {
                        Console.WriteLine("Cotangens: Nieokre�lony (cosinus = 0)");
                    }
                    break;

                case 8:
                    Console.WriteLine("Do widzenia!");
                    return;

                default:
                    Console.WriteLine("B��d: Niepoprawny wyb�r.");
                    break;
            }
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = new double[10];

        Console.WriteLine("Wprowad� 10 liczb rzeczywistych:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Liczba [{i + 1}]: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Wy�wietl tablic� od pierwszego do ostatniego indeksu.");
            Console.WriteLine("2. Wy�wietl tablic� od ostatniego do pierwszego indeksu.");
            Console.WriteLine("3. Wy�wietl elementy o nieparzystych indeksach.");
            Console.WriteLine("4. Wy�wietl elementy o parzystych indeksach.");
            Console.WriteLine("5. Wyj�cie.");

            Console.Write("Wybierz opcj�: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nTablica od pierwszego do ostatniego indeksu:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nTablica od ostatniego do pierwszego indeksu:");
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("\nElementy o nieparzystych indeksach:");
                for (int i = 1; i < numbers.Length; i += 2)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("\nElementy o parzystych indeksach:");
                for (int i = 0; i < numbers.Length; i += 2)
                {
                    Console.WriteLine($"Indeks {i}: {numbers[i]}");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Do widzenia!");
                break;
            }
            else
            {
                Console.WriteLine("B��d: Niepoprawny wyb�r.");
            }
        } while (true);
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = new double[10];

        Console.WriteLine("Wprowad� 10 liczb rzeczywistych:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Liczba [{i + 1}]: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Obliczanie sumy element�w
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"Suma element�w tablicy: {sum}");

        // Obliczanie iloczynu element�w
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        Console.WriteLine($"Iloczyn element�w tablicy: {product}");

        // Obliczanie �redniej
        double average = sum / numbers.Length;
        Console.WriteLine($"�rednia warto�� element�w tablicy: {average}");

        // Wyznaczanie warto�ci minimalnej
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine($"Minimalna warto�� w tablicy: {min}");

        // Wyznaczanie warto�ci maksymalnej
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine($"Maksymalna warto�� w tablicy: {max}");
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Liczby od 20 do 0 z pomini�ciem: 2, 6, 9, 15, 19:");

        for (int i = 20; i >= 0; i--)
        {
            // Pomijamy liczby 2, 6, 9, 15, 19
            if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
            {
                continue;
            }

            Console.WriteLine(i);
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wprowad� liczby ca�kowite. Wprowadzenie liczby ujemnej zako�czy dzia�anie programu.");

        while (true)
        {
            Console.Write("Podaj liczb�: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Wprowadzono liczb� ujemn�. Zako�czenie programu.");
                break;
            }

            Console.WriteLine($"Wprowadzono liczb�: {number}");
        }
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ile liczb chcesz wprowadzi�? ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("Wprowad� liczby:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Liczba [{i + 1}]: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Sortowanie b�belkowe
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    // Zamiana miejscami
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nPosortowane liczby:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
*/