using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static double Rect(double length, double width)
        {
            return length * width;
        }
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

      public static void Main(string[] args)
        {
            // Calculating the area of the Teotihuacan
            double teoRect = Rect(2500, 1500);  
            double teoCircle = Circle(375) / 2;
            double teoTriangle = Triangle(750, 500);
            double teoArea = teoRect + teoCircle + teoTriangle;
            double teoCost = teoArea * 180;
            // round the area to two decimal places
            teoArea = Math.Round(teoArea, 2);
            // round the cost to two decimal places
            teoCost = Math.Round(teoCost, 2);
            Console.WriteLine($"The area of the Teotihuacan is {teoArea} m^2");
            Console.WriteLine($"The cost of the Teotihuacan is {teoCost} pesos");

        }
    }
}