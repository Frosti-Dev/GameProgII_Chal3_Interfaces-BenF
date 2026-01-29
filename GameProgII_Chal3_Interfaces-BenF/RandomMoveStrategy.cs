using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProgII_Chal3_Interfaces_Ben.F;

namespace GameProgII_Chal3_Interfaces_BenF
{
    class RandomMoveStrategy : IMoveStrategy
    {
        public Position Move(Position position)
        {
            Random random = new Random();

            int randomnum = random.Next(0, 4);

            if (randomnum == 1)
            {
                position.MoveX(1);
                return position;
            }

            else if (randomnum == 2)
            {
                position.MoveY(1);
                return position;
            }

            else if (randomnum == 3)
            {
                position.MoveX(-1);
                return position;
            }

            else
            {
                position.MoveY(-1);
                return position;
            }
        }
    }
}
