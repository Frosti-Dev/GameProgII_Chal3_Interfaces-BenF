using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Chal3_Interfaces_Ben.F
{
    internal class Enemy
    {
        Position _position;
        ConsoleColor _color;

        public Enemy(Position position, ConsoleColor Color)
        {
            _position = position;
            _color = Color;
        }

        public void Draw()
        {
            Console.ForegroundColor = _color;
            Console.SetCursorPosition(_position.GetX(), _position.GetY());
            Console.Write("0");
        }

        enum MovementStrategy
        {
            agressive,
            passive,
            random
        };

        MovementStrategy _movementStrategy;

        public void Move()
        {
            if (_movementStrategy == MovementStrategy.agressive)
            {
                //do stuff
            }

            else if (_movementStrategy == MovementStrategy.passive)
            {
                //do stuff
            }

            else if (_movementStrategy == MovementStrategy.random)
            {
                //do stuff
            }
        }
    }
}
