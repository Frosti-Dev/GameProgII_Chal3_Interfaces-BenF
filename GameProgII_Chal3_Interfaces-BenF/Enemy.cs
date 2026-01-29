using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Chal3_Interfaces_Ben.F
{
    internal class Enemy
    {
        Position _position;
        Position _target;
        ConsoleColor _color;

        public Enemy(Position position, ConsoleColor Color, MovementStrategy Movement, Position target)
        {
            _position = position;
            _color = Color;
            _movementStrategy = Movement;
            _target = target;
        }


        public void Draw()
        {
            Console.ForegroundColor = _color;
            Console.SetCursorPosition(_position.GetX(), _position.GetY());
            Console.Write("0");
        }

        public enum MovementStrategy
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
                if(_position.GetX() > _target.GetX())
                {
                    _position.MoveX(-1);
                    if (_position.GetX() > _target.GetX())
                    {
                        _position.MoveX(-1);
                    }
                }

                if (_position.GetX() < _target.GetX())
                {
                    _position.MoveX(1);
                    if (_position.GetX() < _target.GetX())
                    {
                        _position.MoveX(1);
                    }
                }

                if (_position.GetY() > _target.GetY())
                {
                    _position.MoveY(-1);
                    if (_position.GetY() > _target.GetY())
                    {
                        _position.MoveY(-1);
                    }
                }

                if (_position.GetY() < _target.GetY())
                {
                    _position.MoveY(1);
                    if (_position.GetY() < _target.GetY())
                    {
                        _position.MoveY(1);
                    }
                }
            }

            else if (_movementStrategy == MovementStrategy.passive)
            {
                if (_position.GetX() > _target.GetX())
                {
                    _position.MoveX(-1);
                }

                if (_position.GetX() < _target.GetX())
                {
                    _position.MoveX(1);
                }

                if (_position.GetY() > _target.GetY())
                {
                    _position.MoveY(-1);
                }

                if (_position.GetY() < _target.GetY())
                {
                    _position.MoveY(1);
                }
            }

            else if (_movementStrategy == MovementStrategy.random)
            {
                Random random = new Random();

                int randomnum = random.Next(0, 4);

                if (randomnum == 1)
                {
                    _position.MoveX(1);
                }

                else if (randomnum == 2)
                {
                    _position.MoveY(1);
                }

                else if (randomnum == 3)
                {
                    _position.MoveX(-1);
                }

                else
                {
                    _position.MoveY(-1);
                }

            }

        }

        public void ChangeMoveType(MovementStrategy movement)
        {
            _movementStrategy = movement;
        }

    }
}
