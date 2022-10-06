using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class ToyotaCorolla : RaceCar
    {
        public ToyotaCorolla()
        {
            Name = "Toyota Corolla";
            TopSpeed = 100;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts up like new!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} brakes after crossing the finish line");
            base.Brake();
        }
    }
}
