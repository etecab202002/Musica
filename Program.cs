using System;

namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("A Galinha e o Galo Carijó");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Galinha Pintadinha");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("Pó, pó, pó, pó, pó");
            Console.WriteLine();

            Console.WriteLine("A galinha pintadinha");
            Console.WriteLine("E o galo carijó");
            Console.WriteLine("A galinha usa saia");
            Console.WriteLine("E o galo um palitó");

            Console.WriteLine();
            Console.WriteLine("...");
            Console.WriteLine();

            Console.Write("A ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("galinha");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" pintadinha");
            Console.WriteLine("E o galo carijó");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("A galinha usa saia");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("E o galo paletó (tó-tó)");

            Console.ResetColor();
        }
    }
}
