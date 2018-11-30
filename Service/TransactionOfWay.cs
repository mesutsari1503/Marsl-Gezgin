using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    
   public  class TransactionOfWay
    {
         
        public static TravellerWay CreateTravellerDirection(string direction, Traveller traveller)
        {
            TravellerWay travellerWay = null;
            if (direction == "N" || direction == "n")
            {
                travellerWay = new North(traveller);
            }
            else if (direction == "E" || direction == "e")
            {
                travellerWay = new East(traveller);
            }
            else if (direction == "S" || direction == "s")
            {
                travellerWay = new South(traveller);
            }
            else if (direction == "W" || direction == "w")
            {
                travellerWay = new West(traveller);
            }

            return travellerWay;
        }

    }
}
