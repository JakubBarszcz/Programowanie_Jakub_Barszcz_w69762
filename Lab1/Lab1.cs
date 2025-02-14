/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program obliczaj¹cy wyró¿nik delta i pierwiastki trójmianu kwadratowego.");


        Console.Write("Podaj wspó³czynnik a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wspó³czynnik b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj wspó³czynnik c: ");
        double c = Convert.ToDouble(Console.ReadLine());


        double delta = b * b - 4 * a * c;
        Console.WriteLine($"Wyró¿nik delta wynosi: {delta}");


        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Trójmian ma dwa pierwiastki rzeczywiste: x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Trójmian ma jeden pierwiastek podwójny: x = {x}");
        }
        else
        {
            Console.WriteLine("Trójmian nie ma pierwiastków rzeczywistych (delta < 0). Pierwiastki s¹ zespolone.");
        }


        Console.WriteLine("Naciœnij dowolny klawisz, aby zakoñczyæ...");
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
            Console.WriteLine("\nKalkulator - Wybierz opcjê:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Ró¿nica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potêga");
            Console.WriteLine("6. Pierwiastek");
            Console.WriteLine("7. Funkcje trygonometryczne");
            Console.WriteLine("8. Wyjœcie");

            Console.Write("Twój wybór: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Podaj pierwsz¹ liczbê: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drug¹ liczbê: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Suma: {num1 + num2}");
                    break;

                case 2:
                    Console.Write("Podaj pierwsz¹ liczbê: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drug¹ liczbê: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Ró¿nica: {num1 - num2}");
                    break;

                case 3:
                    Console.Write("Podaj pierwsz¹ liczbê: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drug¹ liczbê: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Iloczyn: {num1 * num2}");
                    break;

                case 4:
                    Console.Write("Podaj pierwsz¹ liczbê: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drug¹ liczbê: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Iloraz: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("B³¹d: Nie mo¿na dzieliæ przez zero.");
                    }
                    break;

                case 5:
                    Console.Write("Podaj podstawê: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj wyk³adnik: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Potêga: {Math.Pow(num1, num2)}");
                    break;

                case 6:
                    Console.Write("Podaj liczbê: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    if (num1 >= 0)
                    {
                        Console.WriteLine($"Pierwiastek kwadratowy: {Math.Sqrt(num1)}");
                    }
                    else
                    {
                        Console.WriteLine("B³¹d: Nie mo¿na obliczyæ pierwiastka z liczby ujemnej.");
                    }
                    break;

                case 7:
                    Console.Write("Podaj k¹t w radianach: ");
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
                        Console.WriteLine("Cotangens: Nieokreœlony (cosinus = 0)");
                    }
                    break;

                case 8:
                    Console.WriteLine("Do widzenia!");
                    return;

                default:
                    Console.WriteLine("B³¹d: Niepoprawny wybór.");
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

        Console.WriteLine("WprowadŸ 10 liczb rzeczywistych:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Liczba [{i + 1}]: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Wyœwietl tablicê od pierwszego do ostatniego indeksu.");
            Console.WriteLine("2. Wyœwietl tablicê od ostatniego do pierwszego indeksu.");
            Console.WriteLine("3. Wyœwietl elementy o nieparzystych indeksach.");
            Console.WriteLine("4. Wyœwietl elementy o parzystych indeksach.");
            Console.WriteLine("5. Wyjœcie.");

            Console.Write("Wybierz opcjê: ");
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
                Console.WriteLine("B³¹d: Niepoprawny wybór.");
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

        Console.WriteLine("WprowadŸ 10 liczb rzeczywistych:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Liczba [{i + 1}]: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Obliczanie sumy elementów
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"Suma elementów tablicy: {sum}");

        // Obliczanie iloczynu elementów
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        Console.WriteLine($"Iloczyn elementów tablicy: {product}");

        // Obliczanie œredniej
        double average = sum / numbers.Length;
        Console.WriteLine($"Œrednia wartoœæ elementów tablicy: {average}");

        // Wyznaczanie wartoœci minimalnej
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine($"Minimalna wartoœæ w tablicy: {min}");

        // Wyznaczanie wartoœci maksymalnej
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine($"Maksymalna wartoœæ w tablicy: {max}");
    }
}
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Liczby od 20 do 0 z pominiêciem: 2, 6, 9, 15, 19:");

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
        Console.WriteLine("WprowadŸ liczby ca³kowite. Wprowadzenie liczby ujemnej zakoñczy dzia³anie programu.");

        while (true)
        {
            Console.Write("Podaj liczbê: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Wprowadzono liczbê ujemn¹. Zakoñczenie programu.");
                break;
            }

            Console.WriteLine($"Wprowadzono liczbê: {number}");
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
        Console.Write("Ile liczb chcesz wprowadziæ? ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[n];

        Console.WriteLine("WprowadŸ liczby:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Liczba [{i + 1}]: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Sortowanie b¹belkowe
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