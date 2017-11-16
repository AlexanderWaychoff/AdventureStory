using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class Pathway
    {
        public string choice1;
        public string choice2;
        public string choice3;

        public void GrandAdventure()
        {
            Console.WriteLine("You're off on a grand adventure!  Barely two steps in you're already left with a choice to make!  The path splits into 3 directions, which way do you go?  ('left', 'middle', or 'right')");
            choice1 = Console.ReadLine();

            switch (choice1)
            {


            }
        }
    }
}
