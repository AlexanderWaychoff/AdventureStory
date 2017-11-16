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
        public string defaultResponse;
        public string defaultChoice1 = "";
        public string defaultChoice2 = "a";
        public string defaultChoice3 = "b";
        public string choice1;
        public string choice2;
        public string choice3;

        public int GrandAdventure()
        {
            if (defaultChoice == 3)
            {
                Console.WriteLine("'Nyaahh my OCD!  I can't take it anymore!'  A " + encounterDescriptions.secondObject + " says as he approaches you from a recently formed hole in the ground.  'I've given you simple options to choose from but you decidedly ignore by typing " + defaultChoice1 + ", " + defaultChoice2 + ", and " + defaultChoice3 + "!  What do you have to say for yourself!?'");
                Console.WriteLine("(???)");
                defaultResponse = Console.ReadLine();
                switch (defaultResponse)
                {
                    case "sorry":
                        Console.WriteLine("'AHHHH oh really?' The " + encounterDescriptions.secondObject + " says with slight shock.  'Well I suppose you can be forgiven, just try to better follow the instructions next time'.  He lowers back into the hole he came from where " + encounterDescriptions.colorGreenBlue + " and " + encounterDescriptions.colorYellowRed + " confetti flies out shortly after.  Hurray this adventure was a success!");
                        Console.ReadKey();
                        return 0;
                    default:
                        Console.WriteLine("'AHHHHHHH' The " + encounterDescriptions.secondObject + " yells into the sky.  A bunch of " + encounterDescriptions.fourthObject + " rain down on you.  You suffer a " + encounterDescriptions.prettiness + " humiliating defeat.");
                        Console.ReadKey();
                        return 0;
                }
            }
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
                        encounterDescriptions.ChangeFourthObject();
                        encounterDescriptions.lockFourthObject += 1;
                        storyline = "You venture down the right path.  The path is a steep decline so you proceed with caution.  A " + encounterDescriptions.fourthObject + " suddenly bursts fourth and spits " + encounterDescriptions.colorYellowRed + " skittles at you.  What do you do?";
                        break;

                    default:
                        defaultChoice += 1;
                        if (defaultChoice == 1)
                        {
                            Console.WriteLine("You hear rumbling nearby.  You're inability to type accurately has apparently disturbed something.");
                            defaultChoice1 = choice1;
                            GrandAdventure();
                            return 0;
                        }
                        if (defaultChoice == 2)
                        {
                            Console.WriteLine("You hear rumbling nearby.  You're inability to type accurately has apparently disturbed something.");
                            defaultChoice2 = choice1;
                            GrandAdventure();
                            return 0;
                        }
                        if (defaultChoice == 3)
                        {
                            defaultChoice3 = choice1;
                            GrandAdventure();
                            return 0;
                        }
                        return 0;
                }
            }
            if (choiceCompleted == 1)
            {
                Console.WriteLine(storyline);
                Console.WriteLine("You can 'stare', 'yell', or 'comment'.");
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
                        if (defaultChoice == 1)
                        {
                            Console.WriteLine("You hear rumbling nearby.  You're inability to type accurately has apparently disturbed something.");
                            defaultChoice1 = choice2;
                            GrandAdventure();
                            return 0;
                        }
                        if (defaultChoice == 2)
                        {
                            Console.WriteLine("You hear rumbling nearby.  You're inability to type accurately has apparently disturbed something.");
                            defaultChoice2 = choice2;
                            GrandAdventure();
                            return 0;
                        }
                        if (defaultChoice == 3)
                        {
                            defaultChoice3 = choice2;
                            GrandAdventure();
                            return 0;
                        }
                        return 0;
                }
                if (choiceCompleted == 2)
                {
                    Console.WriteLine(storyline);
                    Console.WriteLine("You can blank blank or blank.");
                    choice3 = Console.ReadLine();

                    switch (choice3)
                    {

                        default:
                            defaultChoice += 1;
                            Console.WriteLine("You hear rumbling nearby.  You're inability to type accurately has apparently disturbed something.");
                            GrandAdventure();
                            return 0;
                    }
                }

            }


            return 0;
        }
    }
}
