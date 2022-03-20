using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            string result = RepeatString(input, repeat);
            Console.WriteLine(result);
        }

        static string RepeatString(string input, int repeat)
        {
            string result = String.Empty;

            for (int i = 0; i < repeat; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
