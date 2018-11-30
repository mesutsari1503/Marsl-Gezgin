using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    //Daha sonra üzerinde sürekli değişiklik yapacağımız için bu sınıfı abstract tanımladık
   public abstract class TravellerWay
    {
        protected Traveller _traveller;

        public TravellerWay(Traveller traveller)
        {
            _traveller = traveller;
        }

        public abstract void TurnRight();
        public abstract void TurnLeft();

        public abstract void Move();
    }
}
