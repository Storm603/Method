﻿using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            RaiseToPower(number, power);
            
        }

        static void RaiseToPower(double number, int power)
        {
            double result = Math.Pow(number, power);

            Console.WriteLine(result);
        }
    }
}
