using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Chal3_Interfaces_Ben.F
{
    internal class Program
    {
        static Position position = new Position(5, 5);
        static void Main(string[] args)
        {
            Player player = new Player(position, ConsoleColor.Cyan);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;

                player.Draw();
            }
        }
    }
}
