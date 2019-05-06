using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clown
{
    class TallGuy : IClown
    {
        public string name;
        public int height;

        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + name + " and I'm " + height + " inches tall.");
        }

        public string FunnyThingIHave
        {
            get { return "big shoes"; }
        }
        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }
    }
}
