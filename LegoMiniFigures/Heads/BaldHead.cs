using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class BaldHead : Head
    {
        private readonly string _name;

        public override bool HasHair { get { return false; } }
        public int SmoothenessLevel { get; set; }

        public BaldHead(string name)
        {
            _name = name;
        }

        public override void Talk()
        {
            Console.WriteLine( $"Hi, {_name}!");
            base.Talk();
        }

        public override void Eat()
        {
            Console.WriteLine( "*Eats a burrito*");
        }
    }
}
