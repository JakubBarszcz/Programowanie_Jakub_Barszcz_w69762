using System;

namespace SklepApp
{
    class Program
    {
        static void Main()
        {
            Sklep sklep = new Sklep();
            sklep.WczytajDane();
            sklep.Menu();
            sklep.ZapiszDane();
        }
    }
}