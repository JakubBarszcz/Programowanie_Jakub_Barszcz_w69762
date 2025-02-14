//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.PortableExecutable;
//using System.Text;
//using System.Threading.Tasks;

//namespace Programowanie_Jakub_Barszcz_w69762

//class Reader : Person
//{
//    private List<Book> ReadBooks = new List<Book>();

//    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

//    public void AddBook(Book book)
//    {
//        ReadBooks.Add(book);
//    }

//    public void ViewBooks()
//    {
//        Console.WriteLine($"Books read by {FirstName} {LastName}:");
//        foreach (var book in ReadBooks)
//        {
//            Console.WriteLine($"- {book.Title}");
//        }
//    }

//    public override void View()
//    {
//        base.View();
//        ViewBooks();
//    }
//}