using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGreenHouseRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***  WELKOM BIJ GREENHOUSE RESTAURANT  ***"); //HOOFDTEKST
            Console.WriteLine("===========================================");

            Console.Write(" Kies een grootte uit (KLein of grote) : ");
            string grote = Console.ReadLine(); //STRING GROOTTE MENU

            Console.Write(" Kies een basis uit (quinoa, rijst of salade) : ");
            string basis = Console.ReadLine(); //STRING BASIS MENU

            Console.Write(" Kies een soort (vegan, zalm of kip) : ");
            string soort = Console.ReadLine();//STRING SOORT MENU

            Console.WriteLine("Je besteling : "+ "een "+grote+" "+ basis+ "met "+soort );

        }
    }
}
