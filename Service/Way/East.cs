using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class East : TravellerWay
    {
        public East(Traveller traveller) : base(traveller)
        {

        }
        public override void Move()
        {
            Coordinate coordinate = _traveller.GetCoordinates();
            coordinate = new Coordinate(coordinate.X+1, coordinate.Y);
            _traveller.CoordinateSet(coordinate);
        }

        public override string ToString()
        {
            return "E";
        }

        public override void TurnLeft()
        {
            _traveller.TravellerDirectionSet(new North(_traveller));
        }

        public override void TurnRight()
        {
            _traveller.TravellerDirectionSet(new South(_traveller));
        }
    }
}
