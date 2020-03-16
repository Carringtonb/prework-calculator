using System;

namespace Prework_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator!");
            Console.Write("Choose a method: + - / * \n");
            string input = Console.ReadLine().ToLower();

            Console.WriteLine("Insert 2 numbers, then hit enter");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            float total = 0;

            if (input == "add" || input == "+")
            {
                total = addNumbers(num1, num2);
            }
            else if (input == "subtract" || input == "-")
            {
                total = subtractNumbers(num1, num2);
            }
            else if (input == "multiply" || input == "*")
            {
                total = multiplyNumbers(num1, num2);
            }
            else if (input == "divide" || input == "/")
            {
                total = divideNumbers(num1, num2);
            }
            Console.WriteLine("The sum is {0}", total);
        }
        public static int addNumbers(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }
        public static int subtractNumbers(int num1, int num2)
        {
            int total = num1 - num2;
            return total;
        }
        public static int multiplyNumbers(int num1, int num2)
        {
            int total = num1 * num2;
            return total;
        }
        public static float divideNumbers(float num1, float num2)
        {
            float total = num1 / num2;
            return total;
        }
    }
}
