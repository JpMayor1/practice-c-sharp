class Cat
{
    string Name = "";
    int Age;
    int Energy = 100;

    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Meow()
    {
        if (Energy <= 0)
        {
            Console.WriteLine("Too tired to meow!");
        }
        else
        {
            Console.WriteLine($"{Name} ({Age} years old) says: Meow!");
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
    static void Main()
    {
        Cat mike = new Cat("Mike", 2);
        Cat mark = new Cat("Mark", 4);

        mike.Meow();
        mike.Eat(20);
        mike.Sleep(2);

        mark.Meow();
        mark.Eat(20);
        mark.Sleep(2);
    }
}