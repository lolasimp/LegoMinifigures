using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Legs
{
    class BabyLegs :Legs
    {
        public BabyLegs()
        {
            Length = 10;
            HasPants = false;
        }

      

        public override void Kick(Minifigure minifigure)
        {
            Console.WriteLine($"Baby legs kicked {minifigure.Name}, the {minifigure.Description}.");
        }
    }
}
