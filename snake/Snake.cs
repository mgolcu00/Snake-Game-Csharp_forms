using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace snake
{
    public class Snake
    {
        Pieces[] pieces;
        public int SneakeSize { get; set; }
        Direction ourdirection;
        public Snake()
        {
            pieces = new Pieces[3];
            pieces[0] = new Pieces(150, 150);
            pieces[1] = new Pieces(160, 150);
            pieces[2] = new Pieces(170, 150);
            SneakeSize = 3;

        }
        public void Forward(Direction direction)
        {
            ourdirection = direction;

            if (direction._x == 0 && direction._y == 0)
            {

            }
            else
            {
                for (int i = pieces.Length - 1; i > 0; i--)
                {
                    pieces[i] = new Pieces(pieces[i - 1].x_, pieces[i - 1].y_);
                }
                pieces[0] = new Pieces(pieces[0].x_ + direction._x, pieces[0].y_ + direction._y);

            }
        }
        public void GrowUp()
        {
            Array.Resize<Pieces>(ref pieces, pieces.Length + 1);
            pieces[pieces.Length - 1] = new Pieces(pieces[pieces.Length - 2].x_ - ourdirection._x, pieces[pieces.Length - 2].y_ - ourdirection._y);
            SneakeSize++;
        }
        public Point getPosition(int num)
        {
            return new Point(pieces[num].x_, pieces[num].y_);
        }
        public void setPosition(int x,int y)
        {
            pieces[0] = new Pieces(x, y);
        }
    }
    public class Pieces
    {
        const int SIZE = 10;
        public int x_;
        public int y_;
        public readonly int size_x;
        public readonly int size_y;

        public Pieces(int x, int y)
        {
            this.x_ = x;
            this.y_ = y;
            size_x = SIZE;
            size_y = SIZE;
        }

    }
    public class Direction
    {
        public readonly int _x;
        public readonly int _y;
        public Direction(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
