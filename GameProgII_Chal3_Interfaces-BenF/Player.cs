using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Chal3_Interfaces_Ben.F
{
    public class Player
    {
        Position _position;
        ConsoleColor _color;

        public Player(Position position, ConsoleColor Color)
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
    }
}
