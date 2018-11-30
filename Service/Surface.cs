using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class Surface
    {
        private Coordinate _maxCoordinate;
        private Coordinate _minCoordinate;

        public Surface(Coordinate maxCoordinate, Coordinate minCoordinate)
        {
            _maxCoordinate = maxCoordinate;
            _minCoordinate = minCoordinate;
        }


        public bool IsAtPlane(Coordinate coordinat)
        {
            if (!IsCoordinateAtPlane(coordinat.X, coordinat.Y))
            {
                return false;
            }
            return true;
        }


        // NASA’dan gönderilen harf katarları sonucu robotik gezginin son konumu,
        // diktörtgen yüzeyin bulunduğu x veya y koordinatından en az birini aşarsa, aşan koordinat dikdörtgenin maksimum konumunda kalacaktır.
        //     (ÖRN: diktörtgenin koordinatları 0,0 ve 5,5 ise ve yeni konum 7,4 çıktı ise robotik gezginin son konumu 5,4 olacaktır.)

        private bool IsCoordinateXAtPlane(int x)
        {
            return x >= _minCoordinate.X && x <= _maxCoordinate.X;
        }
        private bool IsCoordinateYAtPlane(int y)
        {
            return y >= _minCoordinate.Y && y <= _maxCoordinate.Y;
        }
        private bool IsCoordinateAtPlane(int x, int y)
        {
            return (IsCoordinateXAtPlane(x) && IsCoordinateYAtPlane(y));
        }

    }
}
