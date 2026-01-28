using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Chal3_Interfaces_Ben.F
{
    public struct Position
    {
        int _x;
        int _y;

        public Position(int X, int Y)
        {
            _x = X;
            _y = Y;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

    }
}
