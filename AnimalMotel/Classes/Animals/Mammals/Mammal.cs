﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalMotel.Classes
{
    abstract class Mammal : Animal
    {
        public Mammal(Main mainfrm) : base(mainfrm)
        {
            AnimalType = AnimalTypes.Mammal;
        }

        public override void SetSpecification1()
        {
            base.SetSpecification1();
            Specification1 = $"Number of teeth: {Specification1}";
        }

        public enum MammalTypes
        {
            Dog,
            Cat,
        }
    }
}
