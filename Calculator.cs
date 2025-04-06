using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string operation;

            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator (+, -, *, /, %):");
            operation = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                case "%":
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 % num2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }
}