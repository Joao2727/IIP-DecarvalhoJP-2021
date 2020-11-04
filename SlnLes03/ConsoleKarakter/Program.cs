using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKarakter
{
    class Program
    {
        static void Main(string[] args)
        {

            
                
                Console.Write(" Geef een kleine letter : ");
                char grote = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("");



            //Console.WriteLine($"Het nummer is {grote}");
                Console.WriteLine($" De hoofdletter is { grote} ");
                Console.WriteLine($"De vorige letter is {grote}");
                Console.WriteLine($" De volgende letter is {grote}");
                Console.ReadKey();
            }
        }
    }

