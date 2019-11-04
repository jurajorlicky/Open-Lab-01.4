using System;

namespace OpenLab_01._4
{
    class Program
    {
        public static int spolu(int zakladna, int vyska)
            {
             int vysledok = (zakladna * vyska) / 2;
             return vysledok;
            }
        static void Main(string[] args)
        {
        Console.WriteLine("Zadaj dĺžku základňe trojuholníka :");
        int zakladna = int.Parse(Console.ReadLine());
        Console.WriteLine("Zadaj výšku trojuholníka :");
        int vyska = int.Parse(Console.ReadLine());
        int vysledok2 = spolu(zakladna, vyska);
        Console.WriteLine($"Obsah trojuholníka je {vysledok2}");
        Console.ReadLine();
        }
    }
}
