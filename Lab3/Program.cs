//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.PortableExecutable;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programowanie_Jakub_Barszcz_w69762

//class Program
//{
//    static void Main()
//    {
//        Person author = new Person("John", "Doe", 45);
//        Book book1 = new Book("C# Basics", author, 2020);
//        AdventureBook book2 = new AdventureBook("Jungle Trek", author, 2018, "Amazon");
//        DocumentaryBook book3 = new DocumentaryBook("History of AI", author, 2022, "Technology");

//        Reader reader1 = new Reader("Alice", "Smith", 30);
//        reader1.AddBook(book1);
//        reader1.AddBook(book2);
//        reader1.View();

//        Reviewer reviewer1 = new Reviewer("Bob", "Brown", 40);
//        reviewer1.AddBook(book1);
//        reviewer1.AddBook(book3);
//        reviewer1.ReviewBooks();
//    }
//}