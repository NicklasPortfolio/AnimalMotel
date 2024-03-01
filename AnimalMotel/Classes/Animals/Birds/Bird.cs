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

        public override void SetSpecification2()
        {
            base.SetSpecification2();
            Specification2 = $"Can speak: {Specification2}";
        }

        public enum BirdTypes
        {
            Raven,
            Flamingo
        }

        public enum CanSpeak
        {
            Yes,
            No
        }
    }
}
