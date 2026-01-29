using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProgII_Chal3_Interfaces_BenF;

namespace GameProgII_Chal3_Interfaces_Ben.F
{
    internal class Program
    {
        static Position playerPosition = new Position(5, 5);
        static Position enemyPosition = new Position(10, 10);

        static void Main(string[] args)
        {
            AggressiveMoveStrategy aggressiveMoveStrategy = new AggressiveMoveStrategy();
            PassiveMoveStrategy passiveMoveStrategy = new PassiveMoveStrategy();
            RandomMoveStrategy randomMoveStrategy = new RandomMoveStrategy();

            Player player = new Player(playerPosition, ConsoleColor.Cyan);
            Enemy enemy = new Enemy(enemyPosition, ConsoleColor.Red, aggressiveMoveStrategy);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;

                enemy.Draw(enemyPosition);
                player.Draw();

                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                keyInfo = Console.ReadKey(true);
                Console.Clear();

                if (keyInfo.Key == ConsoleKey.I)
                {
                    enemy.ChangeMoveType(aggressiveMoveStrategy);
                    Debug.WriteLine("Enemy Movement Changed to aggressive");
                }

                if (keyInfo.Key == ConsoleKey.O)
                {
                    enemy.ChangeMoveType(passiveMoveStrategy);
                    Debug.WriteLine("Enemy Movement Changed to random");
                }

                if (keyInfo.Key == ConsoleKey.P)
                {
                    enemy.ChangeMoveType(randomMoveStrategy);
                    Debug.WriteLine("Enemy Movement Changed to passive");
                }

                if (keyInfo.Key == ConsoleKey.M)
                {
                    enemyPosition = enemy._moveStrategy.Move(enemyPosition);
                }
                
                Debug.WriteLine($"{enemyPosition.GetX()} {enemyPosition.GetY()}");

            }
        }
    }
}
