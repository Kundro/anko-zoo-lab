using System.Collections.Generic;
using ZooLab.Employees;

namespace ZooLab.Validators
{
    public class VeterinarianHireValidator : HireValidator
    {
        public override List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo)
        {
            List<ValidationError> errors = new List<ValidationError>();
            if(!(employee is Veterinarian))
            {
                errors.Add(new ValidationError { ErrorMessage = $"Employee {employee.FirstName} {employee.LastName} must be a veterinarian to take VeterinarianHireValidator" });
                return errors;
            }

            // Using my own method to get all animal types in zoo
            List<string> allAnimalTypes = zoo.AllAnimalTypes();

            foreach(string animal in allAnimalTypes)
            {
                if (!(employee as Veterinarian).AnimalExperiences.Contains(animal))
                {
                    errors.Add(new ValidationError { ErrorMessage = $"Veterinarian {employee.FirstName} {employee.LastName} must have experience to work with {animal}" });
                }
            }
            return errors;
        }
    }
}
