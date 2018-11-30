using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class Coordinate
    {
        private int _x;
        private int _y;

        //Parametre gönderilmeden set edilmesini kapatıyorum.
        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get { return _x; }
            private set
            {
                if (value < 0)
                    _x = 0;
                else
                    _x = value;
            }
        }

        public int Y
        {
            get { return _y; }
            private set
            {
                if (value < 0)
                    _y = 0;
                else
                    _y = value;
            }
        }
    }
}
