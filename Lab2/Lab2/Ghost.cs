using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Ghost : Enemy
    {
        public Ghost (Game game, Point location): base(game, location, 8)
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
                        break;
                    case 3:
                        break;
                }
                if (NearPlayer())
                {
                    Hit(3, random);
                }
            }
        }
    }
}
