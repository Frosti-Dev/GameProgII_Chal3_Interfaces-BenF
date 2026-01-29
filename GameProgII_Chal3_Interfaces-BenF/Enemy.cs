using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GameProgII_Chal3_Interfaces_BenF;

namespace GameProgII_Chal3_Interfaces_Ben.F
{
    internal class Enemy
    {
        Position _position;
        ConsoleColor _color;
        public IMoveStrategy _moveStrategy;

        public Enemy(Position position, ConsoleColor Color, IMoveStrategy Movement)
        {
            _position = position;
            _color = Color;
            _moveStrategy = Movement;
        }


        public void Draw(Position position)
        {
            Console.ForegroundColor = _color;
            Console.SetCursorPosition(position.GetX(), position.GetY());
            Console.Write("0");
        }

        public void ChangeMoveType(IMoveStrategy moveStrategy)
        {
            _moveStrategy = moveStrategy;
        }

    }
}
