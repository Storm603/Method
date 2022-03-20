using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if (action == "add")
            {
                AddNumbers(numOne, numTwo);
            }
            else if (action == "multiply")
            {
                MultiplyNumbers(numOne, numTwo);
            }
            else if (action == "subtract")
            {
                SubtractNumbers(numOne, numTwo);
            }
            else if (action == "divide")
            {
                DivideNumbers(numOne, numTwo);
            }

            static void AddNumbers(int numOne, int numTwo)
            {
                Console.WriteLine(numOne + numTwo);
            } 
            
            static void MultiplyNumbers(int numOne, int numTwo)
            {
                Console.Write(numOne * numTwo);
            }  
            
            static void SubtractNumbers(int numOne, int numTwo)
            {
                Console.WriteLine(numOne - numTwo);
            }  
            
            static void DivideNumbers(int numOne, int numTwo)
            {
                Console.WriteLine(numOne / numTwo);
            }

        }
    }
}
