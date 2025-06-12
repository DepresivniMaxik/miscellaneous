using System;

namespace AdvancedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Advanced Calculator!");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Square Root");
            Console.WriteLine("6. Exponentiation");
            Console.WriteLine("0. Exit");

            while (true)
            {
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = PerformOperation("Addition", (a, b) => a + b);
                        break;
                    case "2":
                        result = PerformOperation("Subtraction", (a, b) => a - b);
                        break;
                    case "3":
                        result = PerformOperation("Multiplication", (a, b) => a * b);
                        break;
                    case "4":
                        result = PerformOperation("Division", (a, b) => a / b);
                        break;
                    case "5":
                        Console.Write("Enter a number: ");
                        double number = GetNumber();
                        result = Math.Sqrt(number);
                        Console.WriteLine($"Square root of {number} is {result}");
                        break;
                    case "6":
                        result = PerformOperation("Exponentiation", Math.Pow);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");
            }
        }

        static double PerformOperation(string operationName, Func<double, double, double> operation)
        {
            Console.Write("Enter first number: ");
            double firstNumber = GetNumber();
            Console.Write("Enter second number: ");
            double secondNumber = GetNumber();
            return operation(firstNumber, secondNumber);
        }

        static double GetNumber()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                Console.Write("Invalid input. Please enter a valid number: ");
            }
        }
    }
}
