using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int length= int.Parse(Console.ReadLine());

            CalculateRectangleArea(width, length);
        }

        static void CalculateRectangleArea(int width, int length)
        {
            int calculate = width * length;
            Console.WriteLine(calculate);
        }
    }
}
