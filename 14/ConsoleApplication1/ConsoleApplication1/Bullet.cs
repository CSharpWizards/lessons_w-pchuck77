using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public  class Bullet
    {
      public int x;
      public int y;
      public Direction direction=Direction.Left;
      public Bullet(int x, int y, Direction direction)
      {
          this.x = x;
          this.y = y;
          this.direction = direction;
      }
      public void Draw()
      {



          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.SetCursorPosition(x, y);
          Console.Write("*");
          Move();
          Console.ForegroundColor = ConsoleColor.White;
      }
      void Move()
      {
          if (direction == Direction.Left)
          {
              x = x - 1;
          }
          if (direction == Direction.Right)
          {
              x = x + 1;
          }
          if (direction == Direction.Up)
          {
              y = y - 1;
          }
          if (direction == Direction.Down)
          {
              y = y + 1;
          }
      }
      

    }
}
