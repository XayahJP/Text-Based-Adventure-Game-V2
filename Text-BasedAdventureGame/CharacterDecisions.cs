using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_BasedAdventureGame
{
    public class DecisionNode
    {
        public DecisionNode Parent { get; set; }
        public List<DecisionNode> Children { get; private set; }

        public DecisionNode(DecisionNode node)
        {
            Children = new List<DecisionNode>();
            Parent = node;
        }

        public DecisionNode()
        {
            Children = new List<DecisionNode>();
        }

        public DecisionNode CreateChild()
        { 
            return new DecisionNode(this);
        }
    }
}

/*
namespace Text_BasedAdventureGame
{
    class DecisionsArray
    {
        public static void Choice1Options()
        {
            string[] AnoraRiver = {
                "A.) Go North and go on a stupid quest",
                "B.) Run recklessly along the River while yelling, likely catching attention of guards if there are any",
                "C.) Sneak along the Anora River, playing it safe and observing surroundings closely",
            };

            foreach (var str in AnoraRiver)
            {
                Console.WriteLine(str);
            }
        }

        public static void Choice1()
        {
            Choice1Options();

            string input = "";
            Console.WriteLine("Which path will you choose, young one? A, B, or C? Choose wisely... \n");
            input = Console.ReadLine();

            if (input.ToUpper() == "A")
            {
                Console.WriteLine("\nYou decided to take path A.) Go North on a normal, boring, stupid quest. Let me just ask... WHY!?\n" +
                    "Well... Whatever... Your life I guess... I can't stop you. I'm just the narrator.\n\n" +
                    "You appreach the camp during the day, awaiting nightfall to strike.\n" +
                    "Once the sun went down and it became a lot harder time, you had an opportunity to strike.\n" +
                    "What will you do, young adventurer?\n");

                Choice2OptionsA();
            }

            else if (input.ToUpper() == "B")
            {
                Console.WriteLine("\nYou decided to take choice B.) Run in like a complete idiot and likely die... How smart...");
            }

            else if (input.ToUpper() == "C")
            {
                Console.WriteLine("\nYou chose to take path C.)... Something only a smart person would do. Or is it? No but seriously, is it? I wasn't paying attention.\n" +
                    "You walk along the river for 15 minutes before arriving at the edge of the camp, \n" +
                    "then sit patiently by the river bank staring at the camp, observing their movement patterns.\n" +
                    "Throughout your time spent observing, you noticed the camp guards went on break and that some items were left behind.\n\n" +
                    "Would you like to advance into the camp or wait?");
            }

            else
            {
                Console.WriteLine("\nAre you trying to forge your own path? You realize I'm the story teller right...? You jump off a cliff and die... Start over and follow the rules!\n");
                Game.StartGameAgain();
            }
        }

        public static void Choice2OptionsA()
        {
            string[] AnoraCamp = {
                "A.) Silently sneak into the village, take what you can and kill the guards in their sleep.",
                "B.) Wait for an opportune time to strike",
            };

            foreach (var str in AnoraCamp)
            {
                Console.WriteLine(str);
            }
            string input = "";
            Console.WriteLine("Choose path A.) or B.), young hero. It may be your last...\n");
            input = Console.ReadLine();

            if (input.ToUpper() == "A")
            {
                Console.WriteLine("\nYou sneak into the camp, and manage to find a guard's sword sitting outside of the first building you pass.\n" +
                    "You've gained +1 strength!\n");

                Game.AddStrengthSword();

                Console.WriteLine("Your strength is now 2!\n");

                Console.WriteLine("Let's just end the game now...\n");
                Game.EndGame();
            }

            else if (input.ToUpper() == "B")
            {
                Console.WriteLine("I swear you're retarded... JUST ATTACK THEM ALREADY!");
            }
        }
    }
}
*/