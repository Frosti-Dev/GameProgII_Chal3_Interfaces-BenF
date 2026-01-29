using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Chal3_Interfaces_Ben.F
{
    internal class Program
    {
        static Position playerPosition = new Position(5, 5);
        static Position enemyPosition = new Position(10, 10);

        static void Main(string[] args)
        {
            Player player = new Player(playerPosition, ConsoleColor.Cyan);
            Enemy enemy = new Enemy(enemyPosition, ConsoleColor.Red, Enemy.MovementStrategy.agressive, playerPosition);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                keyInfo = Console.ReadKey(true);
                Console.Clear();

                if (keyInfo.Key == ConsoleKey.I)
                {
                    enemy.ChangeMoveType(Enemy.MovementStrategy.agressive);
                    Debug.WriteLine("Enemy Movement Changed to aggressive");
                }

                if (keyInfo.Key == ConsoleKey.O)
                {
                    enemy.ChangeMoveType(Enemy.MovementStrategy.random);
                    Debug.WriteLine("Enemy Movement Changed to random");
                }

                if (keyInfo.Key == ConsoleKey.P)
                {
                    enemy.ChangeMoveType(Enemy.MovementStrategy.passive);
                    Debug.WriteLine("Enemy Movement Changed to passive");
                }

                if (keyInfo.Key == ConsoleKey.M)
                {
                    enemy.Move();
                }

                enemy.Draw();
                player.Draw();

            }
        }
    }
}
