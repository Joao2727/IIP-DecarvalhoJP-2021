using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHello
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hallo Wereld");
            Console.Write("Hoe heet je? : ");
            String naam = Console.ReadLine();
            Console.Write("Aangename kennismaking, ");
            Console.WriteLine(naam);
            Console.Write("Druk op een toets om vervder te gaan...");
            Console.ReadLine();

        }
    }
}
