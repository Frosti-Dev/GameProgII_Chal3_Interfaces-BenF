using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProgII_Chal3_Interfaces_Ben.F;

namespace GameProgII_Chal3_Interfaces_BenF
{
    interface IMoveStrategy
    {
        Position Move(Position position);
    }
}
