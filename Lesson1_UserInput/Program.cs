using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter you name: ");
        string? name = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name is required: ");
            name = Console.ReadLine();
        }

        int age;
        while (true)
        {
            Console.WriteLine("Enter a valid age: ");
            string? ageInput = Console.ReadLine();
            if (int.TryParse(ageInput, out age) && age > 0)
            {
                break;
            }
        }


        Console.WriteLine($"Hi {name}! Your are is {age} year's old.");
    }
}