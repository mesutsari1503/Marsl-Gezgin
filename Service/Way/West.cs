using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Service
{
   public class West:TravellerWay
    {
        public West(Traveller traveller) : base(traveller)
        {

        }

        public override void Move()
        {
            Coordinate coordinate = _traveller.GetCoordinates();
            coordinate = new Coordinate(coordinate.X - 1, coordinate.Y);
            _traveller.CoordinateSet(coordinate);
        }

        public override void TurnRight()
        {
            _traveller.TravellerDirectionSet(new North(_traveller));
        }

        public override void TurnLeft()
        {
            _traveller.TravellerDirectionSet(new South(_traveller));
        }
        public override string ToString()
        {
            return "W";
        }
    }
}