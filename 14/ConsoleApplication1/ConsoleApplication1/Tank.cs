using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public  class Tank
    {
      public static List<Bullet> bullets = new List<Bullet>();
        public int x;
        public int y;
        public ConsoleColor color=ConsoleColor.White;
        public Direction direction=Direction.Left;
        public Tank(int x, int y, Direction direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }
        
        public void Draw(){
            Console.ForegroundColor = color;
           Console.SetCursorPosition(x,y);
           Console.Write("0");
            if (direction==Direction.Left)
            {
                Console.SetCursorPosition(x-1, y);
                Console.Write("-");
                
            }
            if (direction == Direction.Right)
            {
                Console.SetCursorPosition(x + 1, y);
                Console.Write("-");
            }
            if (direction == Direction.Up)
            {
                Console.SetCursorPosition(x, y-1);
                Console.Write("-");
            }
            if (direction == Direction.Down)
            {
                Console.SetCursorPosition(x, y+1);
                Console.Write("-");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Move()
        {

            if (direction == Direction.Left)
            {
                if(Test(x-1,y)){
                    x = x - 1;
                }
            }
            if (direction == Direction.Right)
            {
                if(Test(x+1,y)){
                    x = x + 1;
                }
            }
            if (direction == Direction.Up)
            {
               if(Test(x,y-1)){
                    y = y-1;
                }
            }
            if (direction == Direction.Down)
            {
               if(Test(x,y+1)){
                   y = y+1;
                };
            }
        }
        public void Shoot()
        {

            if (direction == Direction.Left)
            {
                if (Test(x-2,y))
                {
                    bullets.Add(new Bullet(x-2,y,direction));
                }
             bullets.Add(new Bullet(x-2,y,direction));
            }
            if (direction == Direction.Right)
            {
                if (Test(x + 2, y))
                {
                    bullets.Add(new Bullet(x + 2, y, direction));
                }
            }
            if (direction == Direction.Up)
            {
                if (Test(x, y-2))
                {
                    bullets.Add(new Bullet(x, y-2, direction));
                }
            }
            if (direction == Direction.Down)
            {

                if (Test(x , y+2))
                {
                    bullets.Add(new Bullet(x, y+2, direction));
                }
            }
        }
           public bool Test(int x,int y){
                if (x <= 0 || y <= 0 || y >= Console.WindowHeight-1 || x >= Console.WindowWidth-1){
                    return false;
                }
               return true;
           }
        }
    }

