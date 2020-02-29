using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidGame
{
    class VisualTrash : VisualObject
    {
        public VisualTrash(Point Position, Point Direction, int Size)
          : base(Position, Direction, new Size(Size, Size))
        {

        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Pens.Red,
                _Position.X, _Position.Y,
                _Position.X + _Size.Width, _Position.Y);

            g.DrawLine(Pens.Red,
                _Position.X + _Size.Width, _Position.Y,
                _Position.X + _Size.Width, _Position.Y + _Size.Height);

            g.DrawLine(Pens.Red,
                 _Position.X + _Size.Width, _Position.Y + _Size.Height,
                 _Position.X, _Position.Y + _Size.Height);

            g.DrawLine(Pens.Red,
                _Position.X, _Position.Y + _Size.Height,
                _Position.X, _Position.Y);
        }

        public override void Update()
        {
            _Position.X += _Direction.X;
            if (_Position.X < 0)
                _Position.X = Game.Width + _Size.Width;
        }
    }
}
