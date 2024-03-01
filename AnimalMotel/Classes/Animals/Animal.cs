namespace AnimalMotel.Classes
{
    // Bas klass för alla djur, alla djur typ klasser ärver från denna, och alla individuella djur klasser ärver från deras typ klass.
    // ex. Animal -> Mammal -> Dog
    abstract class Animal
    {
        Main main;

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderTypes Gender { get; set; }
        public string AnimalName {  get; set; }
        public AnimalTypes AnimalType { get; set; }
        public object Specification1 { get; set; }
        public object Specification2 { get; set; }

        public Animal(Main mainfrm)
        {
            main = mainfrm;

            Name = main.txtName.Text;
            Age = int.Parse(main.txtAge.Text);
            Gender = (GenderTypes)main.lbGender.SelectedItem;
        }

        public virtual void SetSpecification1()
        {
            Specification1 = main.txtSpec1.Text;
        }

        public virtual void SetSpecification2()
        {
            Specification2 = main.cbSpec2.SelectedItem;
        }

        public override string ToString()
        {
            return $"{Id} | {Name} | {Age} | {Gender} | {AnimalName} | {AnimalType} | {Specification1?.ToString() ?? "N/A"} | {Specification2?.ToString() ?? "N/A"}";
        }
    }

    public enum GenderTypes
    {
        Male,
        Female,
        Unspecified
    }

    public enum AnimalTypes
    {
        Mammal,
        Bird,
        Reptile,
        Amphibian,
        Fish,
        Invertebrate
    }

    public enum AllAnimals
    {
        // Mammals
        Dog,
        Cat,
        // Birds
        Raven,
        Flamingo,
        // Reptiles
        Crocodile,
        BeardedDragon,
        Turtle,
        // Amphibians
        Frog,
        Salamander,
        Axolotl,
        // Fish
        Clownfish,
        PufferFish,
        Shark,
        Whale,
        Salmon,
        // Invertebrates
        Insect,
        Arachnid,
        Snail,
        Crustacean,
        Clam,
        Coral,
        JellyFish
    }
}
