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
        public int choiceCompleted = 0;
        public string storyline;
        public string choice1;
        public string choice2;
        public string choice3;

        public int GrandAdventure()
        {
            if (choiceCompleted == 0)
            {
                Console.WriteLine("You're off on a grand adventure!  Barely two steps in you're already left with a choice to make!  The path splits into 3 directions, which way do you go?  ('left', 'middle', or 'right')");
                choice1 = Console.ReadLine();

                switch (choice1)
                {
                    case "left":
                        encounterDescriptions.GBChangeColor();
                        choiceCompleted += 1;
                        storyline = "You venture down the left path.  The sky is " + encounterDescriptions.colorGreenBlue + " and full of " + encounterDescriptions.size + " clouds.  Nothing happens for a while until you come upon a " + encounterDescriptions.firstObject + ".  What do you do?";
                        break;
                    case "middle":
                        choiceCompleted += 1;
                        storyline = "You venture down the middle path.  You notice some " + encounterDescriptions.colorYellowRed + " wisps floating about the air and the source appears to be coming from a " + encounterDescriptions.thirdObject + ".  What do you do?";
                        break;
                    case "right":
                        choiceCompleted += 1;

                        break;

                    default:
                        defaultChoice += 1;
                        Console.WriteLine("You hear rumbling nearby.  You're inability to type accurately has apparently disturbed something.");
                        GrandAdventure();
                        return 0;
                }
            }
            if (choiceCompleted == 1)
            {
                Console.WriteLine(storyline);
                Console.WriteLine("You can 'stare', 'yell', or 'comment'");
                choice2 = Console.ReadLine();

                switch  (choice2)
                {
                    case "stare":
                        storyline = "";
                        break;
                    case "yell":
                        storyline = "";
                        break;
                    case "comment":

                        break;

                    default:
                        defaultChoice += 1;
                        Console.WriteLine("You hear rumbling nearby.  You're inability to type accurately has apparently disturbed something.");
                        GrandAdventure();
                        return 0;
                }

            }


            return 0;
        }
    }
}
