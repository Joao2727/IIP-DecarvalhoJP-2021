using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHMS
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.Write("Geef het aantal seconden:");
            int input = Convert.ToInt32(Console.ReadLine()); //Deze wordt omgezet naar een int.

            int uren = input / 3600; // uren
            int rest = input % 3600; // rest
            int minuten = rest / 60; // minuten
            int seconden = rest % 60; // seconden
            Console.WriteLine($"omgezet in hms formaat: {uren}:{minuten}:{seconden} ");

            Console.ReadLine();
        }
    }
}
