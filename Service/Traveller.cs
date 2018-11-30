using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class Traveller
    {
        private Coordinate _coordinate;
        private string _compassdirection;
        private Surface _surface;
        private TravellerWay _travellerWay;

        public Traveller(Coordinate coordinate, string compassdirection, Surface surface)
        {
            _coordinate = coordinate;
            _compassdirection = compassdirection;
            _surface = surface;
            _travellerWay = TransactionOfWay.CreateTravellerDirection(compassdirection, this);
        }

        public Coordinate GetCoordinates()
        {
            return _coordinate;
        }

        public void CoordinateSet(Coordinate coordinate)
        {
            bool IsReal = _surface.IsAtPlane(coordinate);
            if (IsReal)
            {
                _coordinate = coordinate;
            }
            else
            {
                Console.WriteLine("Diktörtgen yüzeyin bulunduğu x veya y koordinatından  birini aşıyor");
                Console.ReadLine();
            }
        }

        public void TravellerDirectionSet(TravellerWay travellerWay)
        {
            this._travellerWay = travellerWay;
        }
        public string GetTravellerLocation()
        {
            return "Gezginin gerçek konumu -> x :" + _coordinate.X + ", y:" + _coordinate.Y + ", Yön:" + _travellerWay.ToString();
        }

        public void MovementDirective(string talimat)
        {
            for (int i = 0; i < talimat.Length; i++)
            {
                if (talimat[i] == 'L')
                {
                    _travellerWay.TurnLeft();
                }
                if (talimat[i] == 'R')
                {
                    _travellerWay.TurnRight();
                }
                if (talimat[i] == 'M')
                {
                    _travellerWay.Move();
                }

            }
        }
    }
}
