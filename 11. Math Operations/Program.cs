using System;

namespace _11._Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            double numOne = double.Parse(Console.ReadLine()); 
            string @operator = Console.ReadLine();
            double numTwo = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(numOne, @operator, numTwo));
        }

        static double Calculate(double numOne, string @operator, double numTwo)
        {
            double sum = 0;

            switch (@operator)
            {
                case "/": sum = numOne / numTwo;
                    break;
                case "*":
                    sum = numOne * numTwo;
                    break;
                case "+":
                    sum = numOne + numTwo;
                    break;
                case "-":
                    sum = numOne - numTwo;
                    break;
            }

            return sum;
        }
    }
}
