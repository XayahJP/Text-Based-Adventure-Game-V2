using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventureGame
{
    class CharacterName
    {
        public string CharName { get; }
        
        public CharacterName(string charname)
        {
            Console.WriteLine("Please choose a name for your character.");
            CharName = charname;

            charname = Console.ReadLine();
        }
    }
}
