using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clown
{
    static class Program
    {
        static void Main(string[] args)
        {
            //TallGuy tallguy = new TallGuy() { height = 74, name = "Jimmy" };
            //tallguy.TalkAboutYourself();
            //Console.ReadKey();
            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = someFunnyClown as ScaryScary;
            someOtherScaryClown.Honk();
            Console.ReadKey();
        }

    }
    
   
}
