using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel.Classes.Animals.Birds
{
    class Raven : Bird
    {
        public Raven(Main mainfrm) : base(mainfrm)
        {
            AnimalName = "Raven";
        }

        public override void SetSpecification2()
        {
            base.SetSpecification1();
            Specification
        }
    }
}
