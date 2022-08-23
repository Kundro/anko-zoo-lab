using System.Collections.Generic;
using ZooLab.Animals;
using ZooLab.Employees;
using ZooLab.Exceptions;

namespace ZooLab.Validators
{
    public class ZookeeperHireValidator : HireValidator
    {
        public override List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo)
        {
            var errors = new List<ValidationError>();
            if(!(employee is Zookeeper))
            {
                errors.Add(new ValidationError { ErrorMessage = $"Emplooye {employee.FirstName} {employee.LastName} must be a zookeeper to take ZookeeperHireValidation" });
                return errors;
            }
            List<string> allAnimalTypes = zoo.AllAnimalTypes();
            foreach(string animal in allAnimalTypes)
            {
                if(!(employee as Zookeeper).AnimalExperiences.Contains(animal))
                {
                    errors.Add(new ValidationError { ErrorMessage = $"Zookeeper {employee.FirstName} {employee.LastName} must have experience to work with {animal}" });
                }
            }
            return errors;
        }
    }
}
