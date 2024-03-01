using System;
using System.Collections.Generic;

namespace AnimalMotel.Classes.Animals.Mammals
{
    class Cat : Mammal
    {
        public Cat(Main mainfrm) : base(mainfrm)
        {
            AnimalName = "Cat";
        }

        public override void SetSpecification2()
        {
            base.SetSpecification2();
            object breed = Enum.Parse(typeof(CatBreeds), Specification2.ToString());
            string breedName = DogBreedNames[(CatBreeds)breed];
            Specification2 = $"Cat breed: {breedName}";
        }

        public enum CatBreeds
        {
            AmericanShorthair,
            AmericanBobtail,
            ScottishFold,
            Chartreux,
            MaineCoon,
            Balinese,
            Javanese,
            Munchkin,
            Persian,
            Siamese,
            Bombay,
        }

        public Dictionary<CatBreeds, string> DogBreedNames = new Dictionary<CatBreeds, string>
        {
            { CatBreeds.AmericanShorthair, "American Shorthair" },
            { CatBreeds.AmericanBobtail, "American Bobtail" },
            { CatBreeds.ScottishFold, "Scottish Fold" },
            { CatBreeds.Chartreux, "Chartreux" },
            { CatBreeds.MaineCoon, "Maine Coon" },
            { CatBreeds.Balinese, "Balinese" },
            { CatBreeds.Javanese, "Javanese" },
            { CatBreeds.Munchkin, "Munchkin" },
            { CatBreeds.Persian, "Persian" },
            { CatBreeds.Siamese, "Siamese" },
            { CatBreeds.Bombay, "Bombay" }
        };
    }
}
