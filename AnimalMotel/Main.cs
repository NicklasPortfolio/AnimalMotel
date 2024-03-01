using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using AnimalMotel.Properties;
using AnimalMotel.Classes;
using AnimalMotel.Classes.Animals;
using AnimalMotel.Classes.Animals.Mammals;
using AnimalMotel.Classes.Animals.Birds;
using AnimalMotel.Classes.Animals.Reptiles;
using AnimalMotel.Classes.Animals.Amphibians;
using AnimalMotel.Classes.Animals.Fish;
using AnimalMotel.Classes.Animals.Invertebrates;

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

        // Kollar om all data är ifylld och i korrekt format
        private bool ValidateData()
        {
            bool validName = txtName.Text != "";
            bool validAge = int.TryParse(txtAge.Text, out _) && txtAge.Text != "";
            bool validGender = lbGender.SelectedItem != null;
            bool validType = lbType.SelectedItem != null;
            bool validAnimal = lbAnimal.SelectedItem != null;
            bool validSpec1 = txtSpec1.Text != "";
            bool validSpec2 = cbSpec2.SelectedItem != null;
            bool validTypeAnimalPair = true;

            if (checkListAll.Checked)
            {
                validTypeAnimalPair = CheckTypeAnimalPairValidity();
            }

            var validatedInputs = new Dictionary<string, bool>
            {
                { "Name", validName },
                { "Age", validAge },
                { "Gender", validGender },
                { "Type", validType },
                { "Animal", validAnimal },
                { "Specification1", validSpec1 },
                { "Specification2", validSpec2 },
                { "TypeAnimalPair", validTypeAnimalPair }
            };

            var invalidInputs = new List<string>();

            foreach (var input in validatedInputs)
            {
                if (!input.Value)
                {
                    invalidInputs.Add(input.Key);
                }
            }

            // Skapa error meddelande om någon data är fel
            if (invalidInputs.Count > 0)
            {
                string errorMessage = $"The following inputs were invalid or empty:\n\n";

                foreach (string input in invalidInputs)
                {
                    if (input == "Age")
                    {
                        errorMessage += $"{input} is empty or must be a number,\n";
                    }
                    else if (input == "TypeAnimalPair")
                    {
                        errorMessage += $"{lbAnimal.SelectedItem} is not a(n) {lbType.SelectedItem},\n";
                    }
                    else
                    {
                        errorMessage += $"{input} was null or empty,\n";
                    }
                }

                MessageBox.Show(errorMessage, "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Metod för att kolla om det valda djuret ärver från den valda typen
        private bool CheckTypeAnimalPairValidity()
        {
            bool validPair;

            /* Det finns ingen inbyggt metod för att få fram en Type från
             * en Enum eftersom att de inte är direkt relaterade till varandra,
             * därför krävs en dictionary mapping */
            var animalTypeReferenceMap = new Dictionary<Enum, Type>
            {
                { AnimalTypes.Mammal, typeof(Mammal) },
                { AnimalTypes.Bird, typeof(Bird) },
                { AnimalTypes.Reptile, typeof(Reptile) },
                { AnimalTypes.Amphibian, typeof(Amphibian) },
                { AnimalTypes.Fish, typeof(Fish) },
                { AnimalTypes.Invertebrate, typeof(Invertebrate) }
            };

            Type selectedType = animalTypeReferenceMap[(Enum)lbType.SelectedItem];
            Type selectedAnimal = manager.animalEnumToTypeMap[(Enum)lbAnimal.SelectedItem];

            // Använder Type.IsAssignableFrom() för att se om djuret ärver från typen
            validPair = selectedType.IsAssignableFrom(selectedAnimal) ? true : false;
            return validPair;
        }

        // Metod för att ladda djur bild från Resources filen
        private void LoadImg()
        {
            string selectedAnimal = "";

            if (lbAnimal.SelectedItem.ToString() == "Dog" | lbAnimal.SelectedItem.ToString() == "Cat")
            {
                selectedAnimal = cbSpec2.SelectedItem.ToString();
            }
            else
            {
                selectedAnimal = lbAnimal.SelectedItem.ToString();
            }

            Console.WriteLine(selectedAnimal);
            picAnimal.Image = (Image)Resources.ResourceManager.GetObject(selectedAnimal);
        }

        // Djur typ ändrad event
        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkListAll.Checked)
            {
                return;
            }

            AnimalTypes selectedAnimal = (AnimalTypes)lbType.SelectedItem;
            switch (selectedAnimal)
            {
                case AnimalTypes.Mammal:
                    lbAnimal.DataSource = Enum.GetValues(typeof(Mammal.MammalTypes));
                    break;
                case AnimalTypes.Bird:
                    lbAnimal.DataSource = Enum.GetValues(typeof(Bird.BirdTypes));
                    break;
                case AnimalTypes.Reptile:
                    lbAnimal.DataSource = Enum.GetValues(typeof(Reptile.ReptileTypes));
                    break;
                case AnimalTypes.Amphibian:
                    lbAnimal.DataSource = Enum.GetValues(typeof(Amphibian.AmphibianTypes));
                    break;
                case AnimalTypes.Fish:
                    lbAnimal.DataSource = Enum.GetValues(typeof(Fish.FishTypes));
                    break;
                case AnimalTypes.Invertebrate:
                    lbAnimal.DataSource = Enum.GetValues(typeof(Invertebrate.InvertebrateTypes));
                    break;
                default:
                    break;
            }

            LoadImg();
        }

        // Djur ändrad event med data för vad som ska hända på formuläret för alla typer av djur
        private void lbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnimalTypes selectedType = (AnimalTypes)lbType.SelectedItem;
            AllAnimals selectedAnimal = (AllAnimals)lbAnimal.SelectedItem;

            switch (selectedType)
            {
                case AnimalTypes.Mammal:
                    lblTimeSpecification.Text = "(years)";
                    gbSpecifications.Text = "Mammal Specifications";
                    lblSpec1.Text = "Tail Length\nBreed";

                    if (selectedAnimal == AllAnimals.Dog)
                    {
                        cbSpec2.DataSource = Enum.GetValues(typeof(Dog.DogBreeds));
                    }
                    else if (selectedAnimal == AllAnimals.Cat)
                    {
                        cbSpec2.DataSource = Enum.GetValues(typeof(Cat.CatBreeds));
                    }
                    break;

                case AnimalTypes.Bird:
                    lblTimeSpecification.Text = "(years)";
                    gbSpecifications.Text = "Bird Specifications";
                    lblSpec1.Text = "Primary color\nSpeaks?";
                    cbSpec2.DataSource = Enum.GetValues(typeof(Bird.CanSpeak));
                    break;

                case AnimalTypes.Reptile:
                    lblTimeSpecification.Text = "(months)";
                    gbSpecifications.Text = "Reptile Specifications";
                    lblSpec1.Text = "Teeth count\nScale toughness";
                    cbSpec2.DataSource = Enum.GetValues(typeof(Reptile.ScaleToughness));
                    break;

                case AnimalTypes.Amphibian:
                    lblTimeSpecification.Text = "(months)";
                    gbSpecifications.Text = "Amphibian Specifications";
                    lblSpec1.Text = "Larval stage duration\nSize";
                    cbSpec2.DataSource = Enum.GetValues(typeof(Amphibian.Size));
                    break;

                case AnimalTypes.Fish:
                    lblTimeSpecification.Text = "(years)";
                    gbSpecifications.Text = "Fish Specifications";
                    lblSpec1.Text = "Fish breed\nWater preference";
                    cbSpec2.DataSource = Enum.GetValues(typeof(Fish.WaterPreference));
                    break;

                case AnimalTypes.Invertebrate:
                    lblTimeSpecification.Text = "(years)";
                    gbSpecifications.Text = "Invertebrate Specifications";
                    lblSpec1.Text = $"{lbAnimal.SelectedItem} type\nInvertebrate phylum";
                    cbSpec2.DataSource = Enum.GetValues(typeof(Invertebrate.InvertebratePhylums));
                    break;

                default:
                    break;
            }

            LoadImg();
        }

        // För Cat och Dog ras bilder
        private void cbSpec2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((AnimalTypes)lbType.SelectedItem == AnimalTypes.Mammal)
            {
                LoadImg();
            }
        }

        // Knapp event, kollar om data är rätt innan den skapar en ny Animal instans
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                Enum selectedEnum = (Enum)Enum.Parse(typeof(AllAnimals), lbAnimal.SelectedItem.ToString());

                manager.CreateNewAnimal(selectedEnum);
            }
        }

        // Event för när checkboxen för att lista alla djur blir checked
        private void cbListAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkListAll.Checked)
            {
                lbAnimal.DataSource = Enum.GetValues(typeof(AllAnimals));
            }
            else
            {
                // Unconventional?
                lbCategory_SelectedIndexChanged(sender, e);
            }
        }
    }
}
