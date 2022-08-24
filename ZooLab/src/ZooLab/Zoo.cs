using System;
using System.Collections.Generic;
using ZooLab.Animals;
using ZooLab.Employees;
using ZooLab.Exceptions;
using ZooLab.MedicineTypes;
using ZooLab.Validators;

namespace ZooLab
{
    public class Zoo
    {
        public Zoo(string location)
        {
            Location = location;
            Enclosures = new List<Enclosure>();
            Employees = new List<IEmployee>();
        }
        public List<Enclosure> Enclosures { get; set; }
        public List<IEmployee> Employees { get; set; }
        public string Location { get; private set; }
        public Enclosure AddEnclosure(string name, int squareFeet, Zoo parentZoo)
        {
            Enclosure enclosure = new Enclosure(name, squareFeet, parentZoo);
            Enclosures.Add(enclosure);
            Console.WriteLine($"\"{name}\" enclosure was added to Zoo at {parentZoo.Location}");
            return enclosure;
        }
        public Enclosure AddAnimal(Animal animal)
        {
            Enclosure enclosure = FindAvailableEnclosure(animal);
            enclosure.AddAnimals(animal);
            return enclosure;
        }
        public Enclosure FindAvailableEnclosure(Animal animal)
        {
            foreach (Enclosure enclosure in this.Enclosures)
            {
                int enclosureOccupiedSpace = 0;
                foreach (Animal enclosureAnimals in enclosure.Animals)
                {
                    enclosureOccupiedSpace += enclosureAnimals.RequiredSpaceSqFt;
                }
                if (enclosureOccupiedSpace + animal.RequiredSpaceSqFt > enclosure.SquareFeet) continue;

                bool isFriendly = true;
                foreach (Animal enclosureAnimals in enclosure.Animals)
                {
                    if (!enclosureAnimals.IsFriendlyWith(animal))
                    {
                        isFriendly = false;
                        break;
                    }
                }

                if (isFriendly && (enclosureOccupiedSpace + animal.RequiredSpaceSqFt <= enclosure.SquareFeet))
                {
                    return enclosure;
                }
            }
            throw new NoAvailableEnclosureException();
        }
        // Create my own method to get all types of animals in zoo
        public List<string> AllAnimalTypes()
        {
            List<string> allAnimalTypes = new List<string>();
            foreach (var enclosure in this.Enclosures)
            {
                foreach (var animal in enclosure.Animals)
                {
                    string animalType = animal.GetType().Name;
                    if (!allAnimalTypes.Contains(animalType))
                    {
                        allAnimalTypes.Add(animalType);
                    }
                }
            }
            return allAnimalTypes;
        }
        public void HireEmployee(IEmployee employee)
        {
            HireValidatorProvider provider = new HireValidatorProvider();
            IHireValidator validator = provider.GetHireValidator(employee);
            validator.ValidateEmployee(employee, this);

            // If there're exceptions - validation isn't right
            Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} hired to zoo ({this.Location})");
            Employees.Add(employee);
        }
        public void FeedAnimals(DateTime dateTime)
        {
            foreach (var enclosure in Enclosures)
            {
                foreach (var animal in enclosure.Animals)
                {
                    foreach (var employee in Employees)
                    {
                        if (employee is Zookeeper)
                        {
                            Zookeeper zookeeper = (Zookeeper)employee;
                            if (zookeeper.HasAnimalExperience(animal))
                            {
                                Console.Write($"At {dateTime}:");
                                zookeeper.FeedAnimal(animal);
                                break;
                            }
                        }
                    }
                }
            }
        }
        public void HealAnimals()
        {
            foreach (var enclosure in Enclosures)
            {
                foreach (var animal in enclosure.Animals)
                {
                    foreach (var employee in Employees)
                    {
                        if (employee is Veterinarian)
                        {
                            Veterinarian veterinarian = (Veterinarian)employee;
                            if ((employee as Veterinarian).HasAnimalExperience(animal))
                            {
                                Console.Write($"In {enclosure.Name}:");
                                Medicine medicine = new Antibiotics();
                                veterinarian.HealAnimal(animal, medicine);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}