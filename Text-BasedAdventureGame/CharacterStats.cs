using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventureGame
{
    public class Stats
    {
        public int Strength { get; }
        public int Luck { get; }
        public int Health { get; }
        private Random _damageRange { get; }

        public Stats(int strength, int luck, int health)
        {
            Strength = strength;
            Luck = luck;
            Health = health;
            var StartingCharStats = new Stats(1, 0, 10);
        }

        public Stats()
        {
            // Damage range for the character
            // Make sure it works first, then later make damage equal to: _damageRange + Strength
            _damageRange = new Random();
            _damageRange.Next(0, 3);
        }
    }
}