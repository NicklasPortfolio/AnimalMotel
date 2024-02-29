using AnimalMotel.Classes.Animals;
using AnimalMotel.Classes.Animals.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalMotel.Classes
{
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
            Specification2 = main.txtSpec2.Enabled ? main.txtSpec2.Text : main.cbSpec2.SelectedItem;
        }

        public override string ToString()
        {
            return $"{Id} | {Name} | {Age} | {Gender} | {AnimalName} | {AnimalType} | {Specification1} | {Specification2}";
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
        Amphibian,
        Reptile,
        Fish,
        Invertebrate
    }

    public enum AllAnimals
    {
        Dog,
        Cat,
    }
}
