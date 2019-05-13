using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Lab2
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location): base(game, location)
        {}

        public override string Name
        {
            get
            {
                return "Sword";
            }
        }

        public override void Attack(Direction direction, Random random)
        {
            bool enemyHit = false;
            Direction clockWiseDirection;
            Direction counterClockWiseDirection;

            switch (direction)
            {
                case Direction.Up:
                    clockWiseDirection = Direction.Right;
                    counterClockWiseDirection = Direction.Down;
                    break;
                case Direction.Down:
                    clockWiseDirection = Direction.Left;
                    counterClockWiseDirection = Direction.Up;
                    break;
                case Direction.Left:
                    clockWiseDirection = Direction.Up;
                    counterClockWiseDirection = Direction.Right;
                    break;
                case Direction.Right:
                    clockWiseDirection = Direction.Down;
                    counterClockWiseDirection = Direction.Left;
                    break;
                default:
                    clockWiseDirection = direction;
                    counterClockWiseDirection = direction;
                    break;
            }

            if (!enemyHit)
            {
                enemyHit = DamageEnemy(direction, 10, 3, random);
                if (!enemyHit)
                {
                    enemyHit = DamageEnemy(clockWiseDirection, 10, 3, random);
                    if (!enemyHit)
                    {
                        DamageEnemy(counterClockWiseDirection, 10, 3, random);
                    }
                }
            }
        }
    }
}
