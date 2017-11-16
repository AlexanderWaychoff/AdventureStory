using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class Pathway
    {
        EncounterDescriptions encounterDescriptions = new EncounterDescriptions();
        public string choice1;
        public string choice2;
        public string choice3;

        public void GrandAdventure()
        {
            Console.WriteLine("You're off on a grand adventure!  Barely two steps in you're already left with a choice to make!  The path splits into 3 directions, which way do you go?  ('left', 'middle', or 'right')");
            choice1 = Console.ReadLine();

            switch (choice1)
            {
                case "left":
                    encounterDescriptions.GBChangeColor();
                    Console.WriteLine("You venture down the left path.  The sky is " + encounterDescriptions.colorGreenBlue + " and full of " + encounterDescriptions.size + " clouds.  Nothing happens for a while until you come upon a " + encounterDescriptions.firstObject + ".  What do you do?");
                    Console.ReadKey();
                    break;
                case "middle":
                    Console.WriteLine("You venture down the middle path.  You notice some " + encounterDescriptions.colorYellowRed + " wisps floating about the air.  ");
                    break;
                case "right":

                    break;

                default:

                    break;
            }
            choice2 = Console.ReadLine();
        }
    }
}
