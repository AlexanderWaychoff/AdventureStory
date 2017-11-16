using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    class EncounterDescriptions
    {
        public bool decideSize = false;
        public string size = "tiny";

        public int colorCount = 1;
        public bool decideColorGB = true;
        public string colorGreenBlue = "blue";
        public bool decideColorYR = true;
        public string colorYellowRed = "red";

        public bool decideFirstObject = true;
        public string firstObject = "hollowed-out trunk of a tree";
        public bool decideSecondObject = true;
        public string secondObject = "troll";

        public bool isPretty = true;
        public string prettiness = "pretty";
        public bool isFancy = true;
        public string fanciness = "fancy";

        public void ChangeSize()
        {
            decideSize = !decideSize;
            size = decideSize ? "HUGE" : "tiny";
        }
        public void GBChangeColor()
        {
            decideColorGB = !decideColorGB;
            colorGreenBlue = decideColorGB ? "green" : "blue";
            colorCount += 1;
            if (colorCount % 3 == 1)
            {
                colorGreenBlue = colorYellowRed;
            }
        }
        public void YRChangeColor()
        {
            decideColorYR = !decideColorYR;
            colorYellowRed = decideColorYR ? "yellow" : "red";
            colorCount += 1;
            if (colorCount % 3 == 0)
            {
                colorYellowRed = colorGreenBlue;
            }
        }
        public void ChangeFirstObject()
        {
            decideFirstObject = !decideFirstObject;
            firstObject = decideFirstObject ? "hollowed-out trunk of a tree" : size + " " + secondObject + " with " + colorYellowRed + " spots and " + colorGreenBlue + " underwear";
        }
        public void ChangeSecondObject()
        {
            decideSecondObject = !decideSecondObject;
            secondObject = decideSecondObject ? "troll" : "unicorn";
        }


        public void ChangePrettiness()
        {
            isPretty = !isPretty;
            prettiness = isPretty ? "pretty" : "hideous";
        }
        public void ChangeFancy()
        {
            isFancy = !isFancy;
            fanciness = isFancy ? "fancy" : "plain";
        }
    }
}
