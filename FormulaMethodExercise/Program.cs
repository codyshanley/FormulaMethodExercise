using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOutput();
        }

        public static double GetRectArea(double a, double b)
        {
            return a * b;
        }

        public static double GetCircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public static double GetTriangleArea(double b, double h)
        {
            return (b * h) / 2;
        }

        public static double GetDistance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double[] GetMidPoint(double x1, double x2, double y1, double y2)
        {

            double p1 = (x1 + x2) / 2;
            double p2 = (y1 + y2) / 2;

            double[] midPoint = { p1, p2 };
            return midPoint;
        }

        public static double GetPythagorean(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        public static void PrintOutput()
        {
            double rectArea = GetRectArea(4, 5.5);
            double circleArea = GetCircleArea(9);
            double triangleArea = GetTriangleArea(3.5, 8);
            double distance = GetDistance(-3, 2, 7, 13);
            double midPointX = GetMidPoint(-3, 2, 7, 13)[0];
            double midPointY = GetMidPoint(-3, 2, 7, 13)[1];
            double c = GetPythagorean(3, 4);

            Console.WriteLine("Area of rectangle: " + rectArea);
            Console.WriteLine("Area of circle: " + circleArea);
            Console.WriteLine("Area of triangle: " + triangleArea);
            Console.WriteLine("Distance between points: " + distance);
            Console.WriteLine("Midpoint: (" + midPointX + "," + midPointY + ")");
            Console.WriteLine("Pythagorean: c=" + c);
        }
    }
}
