using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianTraveller
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate minCoordinate = new Coordinate(0, 0);
            Coordinate maxCoordinate = new Coordinate(5, 4);

            Surface surface = new Surface(maxCoordinate, minCoordinate);
            Traveller traveller = new Traveller(new Coordinate(1, 2), "N", surface);
            traveller.MovementDirective("LMLMLMLMM");

            string sonuc = traveller.GetTravellerLocation();
            Console.WriteLine(sonuc);
            Console.ReadLine();


            Traveller traveller2 = new Traveller(new Coordinate(3, 3), "E", surface);
            traveller2.MovementDirective("MMRMMRMRRM");
            string sonuc2 = traveller2.GetTravellerLocation();

            Console.WriteLine(sonuc2);
            Console.ReadLine();
         
        }
    }
}
