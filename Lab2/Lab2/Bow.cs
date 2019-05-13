using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Bow : Weapon
    {
        public Bow(Game game, Point location): base(game, location)
        {
            throw new NotImplementedException();
        }
        public override string Name
        {
            get
            {
                return "Bow";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}
