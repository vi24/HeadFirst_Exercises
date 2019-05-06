using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clown
{
    public class ScaryScary: FunnyFunny, IScaryClown
    {
        private int _numberOfScaryThings;

        public ScaryScary (string funnyThingIHave, int numberOfScaryThings): base(funnyThingIHave)
        {
            this._numberOfScaryThings = numberOfScaryThings;
        }

        #region properties
        public string ScaryThingIHave
        {
            get
            {
                return _numberOfScaryThings + " spiders";
            }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha!");
        }


        #endregion
    }
}
