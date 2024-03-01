namespace AnimalMotel.Classes.Animals.Reptiles
{
    abstract class Reptile : Animal
    {
        public Reptile(Main mainfrm) : base(mainfrm)
        {
            AnimalType = AnimalTypes.Reptile;
        }

        public override void SetSpecification1()
        {
            base.SetSpecification1();
            Specification1 = $"Number of teeth: {Specification1}";
        }

        public override void SetSpecification2()
        {
            base.SetSpecification2();
            Specification2 = $"Scale toughness: {Specification2}";
        }

        public enum ReptileTypes
        {
            Crocodile,
            BeardedDragon,
            Turtle,
        }

        public enum ScaleToughness
        {
            Tender,
            Sturdy,
            Rugged
        }
    }
}
