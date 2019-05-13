using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Ghoul : Enemy
    {
        public Ghoul (Game game, Point location): base(game, location, 10)
        {}
        public override void Move(Random random)
        {
            if(HitPoints > 0)
            {
                int rand = random.Next(1, 3);

                switch (rand)
                {
                    case 1:
                        location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                        break;
                    case 2:
                        location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                        break;
                    case 3:
                        break;
                }
                if (NearPlayer())
                {
                    Hit(4, random);
                }
            }
        }
    }
}
