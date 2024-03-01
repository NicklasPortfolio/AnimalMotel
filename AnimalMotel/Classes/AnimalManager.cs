using AnimalMotel.Classes.Animals.Mammals;
using AnimalMotel.Classes.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            main.lbCategory.DataSource = Enum.GetValues(typeof(AnimalTypes));
            main.lbGender.DataSource = Enum.GetValues(typeof(GenderTypes));
        }

        public void CreateNewAnimal(Enum selectedEnum)
        {
            object[] mainfrm = { main };

            Type animalClass = animalEnumTypeDict[selectedEnum];
            object animalObject = Activator.CreateInstance(animalClass, mainfrm);

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

        public Dictionary<Enum, Type> animalEnumTypeDict = new Dictionary<Enum, Type>
        {
            { AllAnimals.Dog, typeof(Dog) },
            { AllAnimals.Cat, typeof(Cat) },
        };
    }
}
