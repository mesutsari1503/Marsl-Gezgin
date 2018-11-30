using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class South : TravellerWay
    {
        public South(Traveller traveller) : base(traveller)
        {

        }

        public override void Move()
        {
            Coordinate coordinate = _traveller.GetCoordinates();
            coordinate = new Coordinate(coordinate.X, coordinate.Y-1);
            _traveller.CoordinateSet(coordinate);
        }
        public override string ToString()
        {
            return "S";
        }

        public override void TurnLeft()
        {
            _traveller.TravellerDirectionSet(new East(_traveller));
        }

        public override void TurnRight()
        {
            _traveller.TravellerDirectionSet(new West(_traveller));
        }

    }
}
