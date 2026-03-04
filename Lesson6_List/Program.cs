using System;
using System.Collections.Generic;

class Cat
{
    public string Name = "";
    int Age;
    public int Energy = 100;

    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Meow()
    {
        if (Energy < 0)
        {
            Console.WriteLine("Too tired to meow!");
        }
        else
        {
            Console.WriteLine($"{Name} ({Age}) years old, says Meow!");
            Energy -= 10;
        }
    }

    public void Eat(int foodAmount)
    {
        Energy += foodAmount;
        Console.WriteLine($"{Name} eats and gains {foodAmount} energy. Energy: {Energy}");
    }

    public void Sleep(int hours)
    {
        Energy += hours * 10;
        Console.WriteLine($"{Name} sleeps for {hours} hours. Energy: {Energy}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Cat> cats = new List<Cat>();

        cats.Add(new Cat("Luna", 2));
        cats.Add(new Cat("Milo", 3));
        cats.Add(new Cat("Oliver", 1));
        cats.Add(new Cat("Leo", 4));

        Random rand = new Random();

        Cat highestEnergyCat = null;
        int totalEnergyofAllCats = 0;

        foreach (Cat cat in cats)
        {
            cat.Meow();

            int action = rand.Next(2);

            if (action == 0)
            {
                cat.Eat(rand.Next(5, 21));
            }
            else
            {
                cat.Sleep(rand.Next(1, 4));
            }
            if (highestEnergyCat == null || highestEnergyCat.Energy <= cat.Energy)
            {
                highestEnergyCat = cat;
            }
            totalEnergyofAllCats += cat.Energy;
        }

        Console.WriteLine($"{highestEnergyCat.Name} has the highest energy of {highestEnergyCat.Energy}");
        Console.WriteLine($"Total energy of all cats is {totalEnergyofAllCats}");
    }
}