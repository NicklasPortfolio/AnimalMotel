using AnimalMotel.Classes;
using AnimalMotel.Classes.Animals;
using AnimalMotel.Classes.Animals.Birds;
using AnimalMotel.Classes.Animals.Mammals;
using AnimalMotel.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalMotel
{
    public partial class Main : Form
    {
        AnimalManager manager;
        public Main()
        {
            InitializeComponent();

            manager = new AnimalManager(this);
        }

        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalTypes selectedAnimal = (AnimalTypes)lbCategory.SelectedItem;

            if (selectedAnimal == AnimalTypes.Mammal)
            {
                txtSpec2.Visible = false;
                txtSpec2.Enabled = false;
                cbSpec2.Visible = true;
                cbSpec2.Enabled = true;
            }
            else
            {
                txtSpec2.Visible = true;
                txtSpec2.Enabled = true;
                cbSpec2.Visible = false;
                cbSpec2.Enabled = false;
            }

            switch (selectedAnimal)
            {
                case AnimalTypes.Mammal:
                    lbAnimal.DataSource = Enum.GetValues(typeof(Mammal.MammalTypes));
                    break;
                case AnimalTypes.Bird:
                    lbAnimal.DataSource = Enum.GetValues(typeof(Bird.BirdTypes));
                    break;
                case AnimalTypes.Amphibian:
                    // lbAnimal.DataSource = Enum.GetValues(typeof(Amphibian.AmphibianTypes));
                    break;
                case AnimalTypes.Reptile:
                    // lbAnimal.DataSource = Enum.GetValues(typeof(Reptile.ReptileTypes));
                    break;
                case AnimalTypes.Fish:
                    // lbAnimal.DataSource = Enum.GetValues(typeof(Fish.FishTypes));
                    break;
                case AnimalTypes.Invertebrate:
                    // lbAnimal.DataSource = Enum.GetValues(typeof(Invertebrate.InvertebrateTypes));
                    break;
                default:
                    break;
            }
        }

        private void lbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalTypes selectedType = (AnimalTypes)lbCategory.SelectedItem;
            AllAnimals selectedAnimal = (AllAnimals)lbAnimal.SelectedItem;

            if (selectedType == AnimalTypes.Mammal)
            {
                lblSpec1.Text = "Tail Length, Breed";

                if (selectedAnimal == AllAnimals.Dog)
                {
                    cbSpec2.DataSource = Enum.GetValues(typeof(Dog.DogBreeds));
                }
                else if (selectedAnimal == AllAnimals.Cat)
                {
                    cbSpec2.DataSource = Enum.GetValues(typeof(Cat.CatBreeds));
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Enum selectedEnum = (Enum)Enum.Parse(typeof(AllAnimals), lbAnimal.SelectedItem.ToString());

            manager.CreateNewAnimal(selectedEnum);
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            string selected;
            selected = cbSpec2.Enabled ? cbSpec2.SelectedItem.ToString() : lbAnimal.SelectedItem.ToString();
            selected = selected.Replace(" ", "").ToLower();
            Console.WriteLine(selected);
            picAnimal.Image = (Image)Resources.ResourceManager.GetObject(selected);
        }
    }
}
