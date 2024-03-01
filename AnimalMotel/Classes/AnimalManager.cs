using System;
using System.Linq;
using System.Collections.Generic;
using AnimalMotel.Classes.Animals;
using AnimalMotel.Classes.Animals.Mammals;
using AnimalMotel.Classes.Animals.Birds;
using AnimalMotel.Classes.Animals.Reptiles;
using AnimalMotel.Classes.Animals.Amphibians;
using AnimalMotel.Classes.Animals.Fish;
using AnimalMotel.Classes.Animals.Invertebrates;

namespace AnimalMotel.Classes
{
    class AnimalManager
    {
        Random rand = new Random();
        Main main;
        List<string> registeredAnimals = new List<string>();

        public AnimalManager(Main mainfrm)
        {
            main = mainfrm;

            main.lbType.DataSource = Enum.GetValues(typeof(AnimalTypes));
            main.lbGender.DataSource = Enum.GetValues(typeof(GenderTypes));
        }

        // Metod för att skapa en ny instans av ett djur
        public void CreateNewAnimal(Enum selectedEnum)
        {
            // För att skicka till constructor
            object[] mainfrm = { main };

            Type animalClass = animalEnumToTypeMap[selectedEnum];
            // Activator.CreateInstance() skapar en klass dynamiskt genom ett Type värde, så man behöver inte ett stort switch statement
            object animalObject = Activator.CreateInstance(animalClass, mainfrm);

            /* Eftersom att typ informationen inte är känd vid compile time kan inte programmet veta vad klassens typ är utöver den klassen som den ärver ifrån,
             * Därför behöver jag använda virtual funktioner i Animal klassen, som jag sedan överskrider i de individuella klasserna */
            if (animalObject is Animal animal)
            {
                animal.SetSpecification1();
                animal.SetSpecification2();
                animal.Id = GenerateID(animal.Gender, animal.AnimalName, animal.AnimalType, animal.Age);

                registeredAnimals.Add(animal.ToString());
                main.lbRegistered.DataSource = null;
                main.lbRegistered.DataSource = registeredAnimals;
            }
        }

        // Metod för att generera ett unikt ID baserat på information från djuret
        public string GenerateID(GenderTypes gender, string animal, AnimalTypes type, int age)
        {
            string newGender = gender.ToString();
            string newType = type.ToString();

            newGender = newGender.First().ToString().ToUpper();
            newType = newType.First().ToString().ToUpper();
            animal = animal.First().ToString().ToUpper();

            string newAge = age < 10 ? $"0{age}" : age.ToString();

            return $"{newGender}{animal}{newType}{newAge}-{rand.Next(1000, 10000)}";
        }

        // Enum till Type mapping för instansiering av klasser
        public Dictionary<Enum, Type> animalEnumToTypeMap = new Dictionary<Enum, Type>
        {
            // Mammals
            { AllAnimals.Dog, typeof(Dog) },
            { AllAnimals.Cat, typeof(Cat) },
            // Birds
            { AllAnimals.Raven, typeof(Raven) },
            { AllAnimals.Flamingo, typeof(Flamingo) },
            // Reptiles
            { AllAnimals.Crocodile, typeof(Crocodile) },
            { AllAnimals.BeardedDragon, typeof(BeardedDragon) },
            { AllAnimals.Turtle, typeof(Turtle) },
            // Amphibians
            { AllAnimals.Frog, typeof(Frog) },
            { AllAnimals.Salamander, typeof(Salamander) },
            { AllAnimals.Axolotl, typeof(Axolotl) },
            // Fish
            { AllAnimals.Clownfish, typeof(Clownfish) },
            { AllAnimals.PufferFish, typeof(PufferFish) },
            { AllAnimals.Shark, typeof(Shark) },
            { AllAnimals.Whale, typeof(Whale) },
            { AllAnimals.Salmon, typeof(Salmon) },
            // Invertebrates
            { AllAnimals.Insect, typeof(Insect) },
            { AllAnimals.Arachnid, typeof(Arachnid) },
            { AllAnimals.Snail, typeof(Snail) },
            { AllAnimals.Crustacean, typeof(Crustacean) },
            { AllAnimals.Clam, typeof(Clam) },
            { AllAnimals.Coral, typeof(Coral) },
            { AllAnimals.JellyFish, typeof(JellyFish) },
        };
    }
}
