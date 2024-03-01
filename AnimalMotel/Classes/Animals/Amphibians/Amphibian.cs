namespace AnimalMotel.Classes.Animals.Amphibians
{
    abstract class Amphibian : Animal
    {
        public Amphibian(Main mainfrm) : base(mainfrm)
        {
            AnimalType = AnimalTypes.Amphibian;
        }

        public override void SetSpecification1()
        {
            base.SetSpecification1();
            Specification1 = $"Larval stage duration: {Specification1}";
        }

        public override void SetSpecification2()
        {
            base.SetSpecification2();
            Specification2 = $"Size: {Specification2}";
        }

        public enum AmphibianTypes
        {
            Frog,
            Salamander,
            Axolotl
        }

        public enum Size
        {
            Tiny,
            Small,
            Moderate,
            Large,
        }
    }
}
