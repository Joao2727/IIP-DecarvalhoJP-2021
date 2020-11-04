using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBMIcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" BMI CALCULATOR ");
            Console.WriteLine(" ============= ");
            

            Console.Write("Lengte :");
            double lengte;
            lengte = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Gewicht :");
            double gewicht;
            gewicht = Convert.ToInt32(Console.ReadLine());

            double BMI = gewicht / (lengte/100 * lengte / 100) ;

            Console.WriteLine(" Je BMI bedraagt " + Math.Round(BMI,2));




        }
    }
}
