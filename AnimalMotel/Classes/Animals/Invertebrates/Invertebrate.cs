namespace AnimalMotel.Classes.Animals.Invertebrates
{
    abstract class Invertebrate : Animal
    {
        Main main;
        public Invertebrate(Main mainfrm) : base(mainfrm)
        {
            AnimalType = AnimalTypes.Invertebrate;
            main = mainfrm;
        }

        public override void SetSpecification1()
        {
            base.SetSpecification1();
            Specification1 = $"{main.lbAnimal.SelectedItem} type: {Specification1}";
        }

        public override void SetSpecification2()
        {
            base.SetSpecification2();
            Specification2 = $"Invertebrate phylum: {Specification2}";
        }

        public enum InvertebrateTypes
        {
            Insect,
            Arachnid,
            Snail,
            Crustacean,
            Clam,
            Coral,
            JellyFish
        }

        public enum InvertebratePhylums
        {
            Arthropoda,
            Mollusca,
            Cnidaria,
            Echinoderm
        }
    }
}