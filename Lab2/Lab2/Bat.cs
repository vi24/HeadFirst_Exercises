using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab2
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location): base(game, location, 6)
        {}
        public override void Move(Random random)
        {
            if (HitPoints > 0)
            {
                int rand = random.Next(1, 2);
                switch (rand)
                {
                    case 1:
                        Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                        break;
                    case 2:
                        location = Move((Direction)random.Next(3), game.Boundaries);
                        break;
                }
                if (NearPlayer())
                {
                    Hit(2, random);
                }
            }
        }
    }
}
