namespace AnimalMotel.Classes.Animals.Fish
{
    abstract class Fish : Animal
    {
        public Fish(Main mainfrm) : base(mainfrm)
        {
            AnimalType = AnimalTypes.Fish;
        }

        public override void SetSpecification1()
        {
            base.SetSpecification1();
            Specification1 = $"Fish breed: {Specification1}";
        }

        public override void SetSpecification2()
        {
            base.SetSpecification2();
            Specification2 = $"Water preference: {Specification2}";
        }

        public enum FishTypes
        {
            Clownfish,
            PufferFish,
            Shark,
            Whale,
            Salmon
        }

        public enum WaterPreference
        {
            Saltwater,
            Freshwater
        }
    }
}
