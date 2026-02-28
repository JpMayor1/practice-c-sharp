using System;

class Program
{
    static void Main(string[] args)
    {
        double firstNumber;
        while (true)
        {
            Console.WriteLine("Enter first number: ");
            string? firstNumberInput = Console.ReadLine();
            if (double.TryParse(firstNumberInput, out firstNumber))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number, Please try again.");
            }
        }

        double secondNumber;
        while (true)
        {
            Console.WriteLine("Enter second number: ");
            string? secondNumberInput = Console.ReadLine();
            if (double.TryParse(secondNumberInput, out secondNumber))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid number, Please try again.");
            }
        }

        Console.WriteLine($"Sum: {Add(firstNumber, secondNumber)}");
        Console.WriteLine($"Difference: {Subtract(firstNumber, secondNumber)}");
        Console.WriteLine($"Product: {Multiply(firstNumber, secondNumber)}");
        Console.WriteLine($"Quotient: {Divide(firstNumber, secondNumber)}");
        Console.WriteLine($"Remainder: {Modulus(firstNumber, secondNumber)}");
    }

    static double Add(double firstNumber, double secondNumber)
    {
        return firstNumber + secondNumber;
    }

    static double Subtract(double firstNumber, double secondNumber)
    {
        return firstNumber - secondNumber;
    }

    static double Multiply(double firstNumber, double secondNumber)
    {
        return firstNumber * secondNumber;
    }

    static string Divide(double firstNumber, double secondNumber)
    {
        if (secondNumber == 0)
        {
            return "Cannot divide by zero";
        }
        return (firstNumber / secondNumber).ToString();
    }

    static string Modulus(double firstNumber, double secondNumber)
    {
        if (secondNumber == 0)
        {
            return "Cannot divide by zero";
        }
        return (firstNumber % secondNumber).ToString();
    }
}