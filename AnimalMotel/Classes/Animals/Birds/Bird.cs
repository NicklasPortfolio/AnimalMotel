using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel.Classes.Animals.Birds
{
    abstract class Bird : Animal
    {
        public Bird(Main mainfrm) : base(mainfrm)
        {
            AnimalType = AnimalTypes.Bird;
        }

        public override void SetSpecification1()
        {
            base.SetSpecification1();
            Specification1 = $"Primary color: {Specification1}";
        }

        public enum BirdTypes
        {
            Raven,
            Flamingo
        }
    }
}
