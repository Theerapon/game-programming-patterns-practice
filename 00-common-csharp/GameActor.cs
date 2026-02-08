using System;

namespace CommonCsharp
{
    public class GameActor
    {
        private int _x;
        private int _y;

        public int Health { get; private set; }
        public string Name { get; set; }

        public GameActor(string name, int initialHealth)
        {
            Name = name;
            Health = initialHealth;
            _x = 0;
            _y = 0;
        }

        
        public void Move(int x, int y)
        {
            _x += x;
            _y += y;
            Console.WriteLine($"{Name} moved to position ({_x}, {_y}).");
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
            Console.WriteLine($"{Name} took {amount} damage and now has {Health} health.");
        }
    }
}