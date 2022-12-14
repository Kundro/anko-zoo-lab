using System.Collections.Generic;
using ZooLab.Entities.Employees;
using ZooLab.Entities;

namespace ZooLab.Validators
{
    public class ZookeeperHireValidator : HireValidator
    {
        public override List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo)
        {
            var errors = new List<ValidationError>();
            if (!(employee is Zookeeper))
            {
                errors.Add(new ValidationError { ErrorMessage = $"Emplooye {employee.FirstName} {employee.LastName} must be a zookeeper to take ZookeeperHireValidator" });
                return errors;
            }

            // Using my own method to get all animal types in zoo
            List<string> allAnimalTypes = zoo.AllAnimalTypes();

            foreach (string animal in allAnimalTypes)
            {
                if (!(employee as Zookeeper).AnimalExperiences.Contains(animal))
                {
                    errors.Add(new ValidationError { ErrorMessage = $"Zookeeper {employee.FirstName} {employee.LastName} must have an experience to work with {animal}" });
                }
            }
            return errors;
        }
    }
}
