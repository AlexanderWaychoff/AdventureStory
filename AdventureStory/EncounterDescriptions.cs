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
        public string sizeB = "tiny";

        public int colorCount = 0;
        public bool decideColorGB = false;
        public string colorGreenBlue = "blue";
        public bool decideColorYR = false;
        public string colorYellowRed = "red";

        public void ChangeSize()
        {
            decideSize = !decideSize;
            sizeB = decideSize ? "HUGE" : "tiny";
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


    }
}
