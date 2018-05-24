using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static double timer = 0;
        static List<Tank> enemytanks = new List<Tank>();
        static bool gameover = false;
        static Tank player = new Tank(15, 15, Direction.Left);
        static void Main(string[] args)
        {         
            player.color = ConsoleColor.Green;
            
            while (!gameover)
            {
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    Update();
                    Thread.Sleep(100);
                    
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key==ConsoleKey.Spacebar)
                {
                    player.Shoot();
                    
                }
                else
                {
                    
                    if (player.direction == KeyDirection(keyInfo.Key)&&timer==1)
                    {
                        timer = 0;
                        player.Move();
                    }
                    else
                    {
                        Turn(keyInfo);
                    }
                }
                Console.WriteLine("Вы проиграли");
                
            }

        }
        static Random random = new Random();
        static Direction RandomDirection()
        {

                int n = random.Next(1, 5);
                if (n == 1)
                {
                    return Direction.Left;
                }
                if (n == 2)
                {
                    return Direction.Right;
                }
                if (n == 3)
                {
                    return Direction.Up;
                }
                if (n == 4)
                {
                    return Direction.Down;
                }

                return Direction.Down;
            
        }
        static void Update()
        {
            
            if (random.Next(1,40)==20)
            {

                int x = random.Next(1, Console.WindowWidth);
                int y = random.Next(1, Console.WindowHeight);
                enemytanks.Add(new Tank(x,y, RandomDirection()));
                enemytanks[enemytanks.Count - 1].color = ConsoleColor.Red;
            }
            timer = 1;

            player.Draw();
            
            for (int i = 0; i < Tank.bullets.Count; i++)
            {
               
                if (Tank.bullets[i].x <= 0 || Tank.bullets[i].y <= 0 || Tank.bullets[i].y >= Console.WindowHeight || Tank.bullets[i].x >= Console.WindowWidth)
                {
                    Tank.bullets.RemoveAt(i);
                    i = i - 1;
                }
                else
                {

                    Tank.bullets[i].Draw();
                    if (Tank.bullets[i].x == player.x && Tank.bullets[i].y == player.y)
                    {
                        Tank.bullets.RemoveAt(i);
                        i = i - 1;
                        gameover = true;
                    }
                    for (int b = 0; b < enemytanks.Count; b++)
                    {
                        
                        if (Tank.bullets[i].x == enemytanks[b].x && Tank.bullets[i].y == enemytanks[b].y)
                        {
                            Tank.bullets.RemoveAt(i);
                            i = i - 1;
                            enemytanks.RemoveAt(b);
                            b = b - 1;
                        }
                    }
                }
                
            
            }
            for (int i = 0; i < enemytanks.Count; i++)
            {
                if (random.Next(1, 10) == 2)
                {
                    enemytanks[i].direction = RandomDirection();
                }
                if (random.Next(1, 5) == 2)
                {
                    enemytanks[i].Shoot();
                }
                enemytanks[i].Draw();
                enemytanks[i].Move();
            }
        }
        static Direction KeyDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.UpArrow)
            {
                return Direction.Up;

            }
            if (key == ConsoleKey.DownArrow)
            {
                return Direction.Down;
            }
            if (key == ConsoleKey.RightArrow)
            {
                return Direction.Right;
            }
            if (key == ConsoleKey.LeftArrow)
            {
                return Direction.Left;
            }
            return Direction.Left;
        }
        static void Turn(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                player.direction = Direction.Up;
                
            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                player.direction = Direction.Down;
            }
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                player.direction = Direction.Right;
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                player.direction = Direction.Left;
            }
            
        }
    }
}
