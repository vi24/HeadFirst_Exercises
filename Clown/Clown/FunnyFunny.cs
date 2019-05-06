using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clown
{
    public class FunnyFunny : IClown
    {
        private string _funnything;

        public FunnyFunny (string funnyThingIHave)
        {
            _funnything = funnyThingIHave;
        }

        public string FunnyThingIHave {
            get
            {
                return "Hi kids! I have " + _funnything; 
            }
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
