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
            Console.WriteLine(Rect(5, 6));
            Console.WriteLine(Circle(4));
            Console.WriteLine(Triangle(10, 5));
        }
    }
}