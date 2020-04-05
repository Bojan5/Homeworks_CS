using System;

namespace Homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] operators = new char[] { '+', '-', '*', '/', 'S' };
            char InputChar;

            while (true)
            {
                string numInputOne;
                string numInputTwo;

                while (true)
                {
                    Console.WriteLine("Input type of arithmetic operation (+, -, *, /)");

                    bool answer = char.TryParse(Console.ReadLine(), out InputChar);
                    if (answer && Array.IndexOf(operators, InputChar) != -1)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid operation selected.The application will automatically close");
                }

                if (InputChar == 's')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have not used calculator.Thank you for the interest,try the calculation another time.The application wil automatically close.");
                    Console.ReadLine();
                    break;
                }

                int numOne;
                while (true)
                {
                    Console.WriteLine("Enter first number:");
                    numInputOne = Console.ReadLine();
                    bool parsed = int.TryParse(numInputOne, out numOne);

                    if (parsed)
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input numbers.The application will automatically close:");
                   
                }

                int numTwo;
                while (true)
                {
                    Console.WriteLine("Enter second number:");
                    numInputTwo = Console.ReadLine();
                    bool parsed = int.TryParse(numInputTwo, out numTwo);

                    if (parsed)
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input numbers.The application will automatically close:");
                   
                }

                switch (InputChar)
                {
                    case '+':
                        int suming = Sum(numOne, numTwo);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: + {suming}");
                        break;

                    case '-':
                        int minus = Substract(numOne, numTwo);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: {minus}");
                        break;

                    case '*':
                        int product = Multiply(numOne, numTwo);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: {product}");
                        break;

                    case '/':
                        int result = Divide(numOne, numTwo);

                        if (numOne == 0 || numTwo == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Division with zero is not possible.The application will automatically close:");
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Result: {result}");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid operation selected.The application will automatically close:");
                        break;
                }

                char close;
                bool exit = char.TryParse(Console.ReadLine(), out close);

                if (Char.ToLower(close) == 's')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thank you for using calculator! The application will autoatically close.");
                    return;
                }

                Console.ReadLine();

            }
        }

        public static int Sum(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Substract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
    }
}
