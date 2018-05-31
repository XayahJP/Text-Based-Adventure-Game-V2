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

        //public DamageRange damage { get; }
        // Can I set DamageRange to an array, or only an enum? If I can set to an array, how?

        /*
        public int[] DamageRange = {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };
        */

        public Stats(int strength, int luck, int health)
        {
            Strength = strength;
            Luck = luck;
            Health = health;
            var StartingCharStats = new Stats(1, 0, 10);
        }
    }
}