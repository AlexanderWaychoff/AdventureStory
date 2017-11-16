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
        public int defaultChoice = 0;
        public string choice1;
        public string choice2;
        public string choice3;

        public int GrandAdventure()
        {
            Console.WriteLine("You're off on a grand adventure!  Barely two steps in you're already left with a choice to make!  The path splits into 3 directions, which way do you go?  ('left', 'middle', or 'right')");
            choice1 = Console.ReadLine();

            switch (choice1)
            {
                case "left":
                    encounterDescriptions.GBChangeColor();
                    Console.WriteLine("You venture down the left path.  The sky is " + encounterDescriptions.colorGreenBlue + " and full of " + encounterDescriptions.size + " clouds.  Nothing happens for a while until you come upon a " + encounterDescriptions.firstObject + ".  What do you do?");
                    break;
                case "middle":
                    Console.WriteLine("You venture down the middle path.  You notice some " + encounterDescriptions.colorYellowRed + " wisps floating about the air and the source appears to be coming from a " + encounterDescriptions.thirdObject + ".  What do you do?");
                    break;
                case "right":

                    break;

                default:
                    defaultChoice += 1;
                    Console.WriteLine("You hear rumbling nearby.  You're inability to type accurately has apparently disturbed something.");
                    GrandAdventure();
                    return 0;
            }
            choice2 = Console.ReadLine();


            return 0;
        }
    }
}
