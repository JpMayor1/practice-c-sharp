using System;

class Dog
{
    public string Name = "";

    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

class Program
{
    static void Main()
    {
        Dog buddy = new Dog();
        Dog rocky = new Dog();

        buddy.Name = "Buddy";
        buddy.Bark();

        rocky.Name = "Rocky";
        rocky.Bark();
    }
}