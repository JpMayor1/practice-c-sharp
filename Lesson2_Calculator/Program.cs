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
                Console.WriteLine("Invalid number. Please try again.");
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
                Console.WriteLine("Invalid number. Please try again.");
            }
        }

        Console.WriteLine($"Sum: {firstNumber + secondNumber}");
        Console.WriteLine($"Difference: {firstNumber - secondNumber}");
        Console.WriteLine($"Product: {firstNumber * secondNumber}");
        string quotientResult = secondNumber == 0 ? "Cannot divide by zero." : $"Quotient: {firstNumber / secondNumber}";
        string remainderResult = secondNumber == 0 ? "Cannot compute remainder with zero." : $"Remainder: {firstNumber % secondNumber}";
        Console.WriteLine(quotientResult);
        Console.WriteLine(remainderResult);
    }
}