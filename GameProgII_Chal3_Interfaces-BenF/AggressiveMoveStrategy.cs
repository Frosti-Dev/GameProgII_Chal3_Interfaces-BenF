using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GameProgII_Chal3_Interfaces_Ben.F;

namespace GameProgII_Chal3_Interfaces_BenF
{
    class AggressiveMoveStrategy : IMoveStrategy
    {
        public Position Move(Position position)
        {
            Position _target = new Position(5,5); //test location

            if (position.GetX() > _target.GetX())
            {
                position.MoveX(-1);

                if (position.GetX() > _target.GetX())
                {
                    position.MoveX(-1);
                }

                return position;
            }

            if (position.GetX() < _target.GetX())
            {
                position.MoveX(1);

                if (position.GetX() < _target.GetX())
                {
                    position.MoveX(1);
                }

                return position;
            }

            if (position.GetY() > _target.GetY())
            {
                position.MoveY(-1);

                if (position.GetY() > _target.GetY())
                {
                    position.MoveY(-1);
                }

                return position;
            }

            if (position.GetY() < _target.GetY())
            {
                position.MoveY(1);

                if (position.GetY() < _target.GetY())
                {
                    position.MoveY(1);
                }

                return position;
            }
            return position;
        }
    }
}
