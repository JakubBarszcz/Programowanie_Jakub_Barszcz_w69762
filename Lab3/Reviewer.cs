//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.PortableExecutable;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programowanie_Jakub_Barszcz_w69762

//class Reviewer : Reader
//{
//    private static Random random = new Random();

//    public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

//    public void ReviewBooks()
//    {
//        Console.WriteLine($"{FirstName} {LastName} reviews books:");
//        foreach (var book in ReadBooks)
//        {
//            Console.WriteLine($"- {book.Title}: {random.Next(1, 10)} stars");
//        }
//    }
//}