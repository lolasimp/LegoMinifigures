using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Heads
{
    class NathanHead : Head
    {
 //must add override since base is abstract or virtual
        public override bool HasHair { get { return true; } }
        public string HairColor { get { return "Salt and Pepper"; } }
        public string Texture { get; set; }
//must add override since base is abstract or virtual
        public override void Talk()
        {
            Console.WriteLine("Hey");
        }
//must add override since base is abstract or virtual
        public override void Eat()
        {
            Console.WriteLine( "I never get to eat because of needy students" );
        }
    }
}
