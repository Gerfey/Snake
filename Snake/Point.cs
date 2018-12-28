using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            this.x = _x;
            this.y = _y;
            this.sym = _sym;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    y += offset;
                    break;
                case Direction.DOWN:
                    y -= offset;
                    break;
                case Direction.LEFT:
                    x -= offset;
                    break;
                case Direction.RIGHT:
                    x += offset;
                    break;
            }
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }    
}
