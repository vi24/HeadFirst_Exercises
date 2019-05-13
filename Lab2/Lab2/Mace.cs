using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location)
        {
            throw new NotImplementedException();
        }

        public override string Name
        {
            get
            {
                return "Mace";
            }

        }

        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}
