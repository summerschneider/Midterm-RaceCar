using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Summer : Driver
    {
        public Summer(RaceCar car) : base(car)
        {
            Name = "Summer";
            SkillLevel = 7;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
