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
        public string defaultChoice1;
        public string defaultChoice2;
        public string defaultChoice3;
        public string choice1;
        public string choice2;
        public string choice3;
        public string carryover1;
        public string carryover2;

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
                        Console.WriteLine("'AHHHHHHH' The " + encounterDescriptions.secondObject + " yells into the sky.  A bunch of " + encounterDescriptions.fourthObject + "s rain down on you.  You suffer a " + encounterDescriptions.prettiness + " humiliating defeat.");
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
                        encounterDescriptions.ChangeTasty();
                        carryover1 = encounterDescriptions.firstObject;
                        carryover2 = carryover1;
                        encounterDescriptions.ChangeFirstObject();
                        encounterDescriptions.lockFirstObject += 1;
                        encounterDescriptions.lockSecondObject += 1;
                        break;
                    case "middle":
                        choiceCompleted += 1;
                        storyline = "You venture down the middle path.  You notice some " + encounterDescriptions.colorYellowRed + " wisps floating about the air and the source appears to be coming from a " + encounterDescriptions.thirdObject + ".  What do you do?";
                        carryover1 = encounterDescriptions.thirdObject;
                        carryover2 = carryover1;
                        encounterDescriptions.ChangeSecondObject();
                        encounterDescriptions.lockSecondObject += 1;
                        break;
                    case "right":
                        choiceCompleted += 1;
                        encounterDescriptions.ChangeFourthObject();
                        encounterDescriptions.lockFourthObject += 1;
                        storyline = "You venture down the right path.  The path is a steep decline so you proceed with caution.  A " + encounterDescriptions.fourthObject + " suddenly bursts fourth and spits " + encounterDescriptions.colorYellowRed + " " + encounterDescriptions.fifthObject + " at you.  What do you do?";
                        carryover1 = encounterDescriptions.fifthObject;
                        carryover2 = encounterDescriptions.fourthObject;
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
                Console.WriteLine("You can 'stare', 'yell', or 'taste'.");
                choice2 = Console.ReadLine();

                switch  (choice2)
                {
                    case "stare":
                        choiceCompleted += 1;
                        storyline = "You decide to stare at the " + carryover2 + ".";
                        break;
                    case "yell":
                        choiceCompleted += 1;
                        storyline = "You decide to yell at the " + carryover2 + ".";
                        break;
                    case "taste":
                        choiceCompleted += 1;
                        storyline = "'This is " + encounterDescriptions.tastiness + "!'  You exclaim, having decided to taste " + carryover1 + ".";
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

            }
            if (choiceCompleted == 2)
            {
                Console.WriteLine(storyline);
                if (choice1 == "left")
                {

                }
                else if (choice1 == "middle")
                {
                    if (choice2 == "yell")
                    {
                        Console.WriteLine("'Who dares disturb my peaceful abode??' You hear something say.  A " + encounterDescriptions.secondObject + " bursts forth from the fountain and stares into your soul.  You may have been loud, but at least you didn't stare!  You take the middle and index fingers of your hand and abruptly poke the " + encounterDescriptions.secondObject + " in the eyes.  'Ow no!  My eyes!'  He says.  He screams in apparent agony as a black hole forms in his chest and slowly sucks him up.  After a few minutes of his painful wails he finally vanishes completely along with the black hole.  You just stand there for another minute trying to take it in, though perhaps this is enough adventuring for one day.  You decide to head home where you can tell your friends of the day you vanquished a " + encounterDescriptions.secondObject + ".  Adventure was a success(?)");
                        Console.ReadKey();
                        return 0;
                    }
                    else if (choice2 == "taste")
                    {
                        storyline = "'Tis a glorious fountain, is it not?'  A " + encounterDescriptions.secondObject + " says as he reveals himself from inside the " + carryover1 + ".  You silently gag having unknowingly tasted mythical creature.  'How can I help you on this fine day' He asks.  What do you do?";
                    }
                    else
                    {
                        storyline = "'Tis a glorious fountain, is it not?'  A " + encounterDescriptions.secondObject + " says as he reveals himself from inside the " + carryover1 + ".  Admittedly you decide to nod in agreement.  'How can I help you on this fine day' He asks.  What do you do?";
                    }
                }
                else
                {
                    if (choice2 == "taste" || choice2 == "yell")
                    {
                        encounterDescriptions.YRChangeColor();
                        storyline = "The " + carryover2 + " nods happily and shoots off into a now " + encounterDescriptions.colorYellowRed + " sky.  The whole which the narwhal left now lay exposed.  What do you do?";
                    }
                    else
                    {
                        encounterDescriptions.ChangeFifthObject();
                        Console.WriteLine("As you stare at the " + carryover2 + " his horn begins to glow.  You begin to feel weird; it's probably because he just turned you into a " + encounterDescriptions.fifthObject + ".  With a little chortle he pulls out a sharpie and draws a face with a bushy mustache onto you.  As a watermelon having no functional extremities anymore, you're adventure ends here.  At least the " + carryover2 + " drew your face with a smile, but we both know that only goes skin deep.");
                        Console.ReadKey();
                        return 0;
                    }
                }
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

            return 0;
        }
    }
}
