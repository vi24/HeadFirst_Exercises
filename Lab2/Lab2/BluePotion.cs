using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class BluePotion : Weapon, IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {
        }

        public override string Name
        {
            get
            {
                return "Blue Potion";
            }
        }

        public bool Used { get; }

        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }

        
    }
}
