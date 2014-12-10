using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter a Value : ");
            double i = Convert.ToDouble( Console.ReadLine());
            double result = GetSquare(i);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static double GetSquare(double aValue)
        {
             double square = aValue * aValue;
             return square;
        }
        
    }
}
