using System;
using CommonCsharp;

class Program
{
    static void Main(string[] args)
    {
        var hero = new GameActor("Knight", 100);
        Console.WriteLine($"{hero.Name} has {hero.Health} health.");

        hero.Move(5, 10);
        hero.TakeDamage(20);

        if (hero.Health <= 0)
        {
            Console.WriteLine($"{hero.Name} has been defeated.");
        }
        else
        {
            Console.WriteLine($"{hero.Name} is still standing with {hero.Health} health.");
        }

        for (int i = 0; i < 3; i++)
        {
            hero.Move(1, 0);
        }
    }

}
