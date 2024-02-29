using System;
using System.Collections.Generic;

namespace AnimalMotel.Classes.Animals
{
    class Dog : Mammal
    {
        public Dog(Main mainfrm) : base(mainfrm)
        {
            AnimalName = "Dog";
        }

        public override void SetSpecification2()
        {
            base.SetSpecification2();
            object breed = Enum.Parse(typeof(DogBreeds), Specification2.ToString());
            string breedName = DogBreedNames[(DogBreeds)breed];
            Specification2 = $"Dog breed: {breedName}";
            Console.WriteLine(Specification2);
        }

        public enum DogBreeds
        {
            JackRussellTerrier,
            GoldenRetriever,
            GermanShepherd,
            SiberianHusky,
            BorderCollie,
            Pomeranian,
            Rottweiler,
            Chihuahua,
            Labrador,
            ShibaInu,
            Samoyed,
            Beagle,
            Borzoi,
        }

        public Dictionary<DogBreeds, string> DogBreedNames = new Dictionary<DogBreeds, string>
        {
            { DogBreeds.JackRussellTerrier, "Jack Russell Terrier" },
            { DogBreeds.GoldenRetriever, "Golden Retriever" },
            { DogBreeds.GermanShepherd, "German Shepherd" },
            { DogBreeds.SiberianHusky, "Siberian Husky" },
            { DogBreeds.BorderCollie, "Border Collie" },
            { DogBreeds.Pomeranian, "Pomeranian" },
            { DogBreeds.Rottweiler, "Rottweiler" },
            { DogBreeds.Chihuahua, "Chihuahua" },
            { DogBreeds.Labrador, "Labrador" },
            { DogBreeds.ShibaInu, "Shiba Inu" },
            { DogBreeds.Samoyed, "Samoyed" },
            { DogBreeds.Beagle, "Beagle" },
            { DogBreeds.Borzoi, "Borzoi" }
        };
    }
}
