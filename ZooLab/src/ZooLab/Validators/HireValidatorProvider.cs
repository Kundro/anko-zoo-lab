using System;
using ZooLab.Entities.Employees;

namespace ZooLab.Validators
{
    public class HireValidatorProvider : IHireValidator
    {
        public IHireValidator GetHireValidator(IEmployee employee)
        {
            if (employee is Zookeeper)
            {
                return new ZookeeperHireValidator();
            }
            else if (employee is Veterinarian)
            {
                return new VeterinarianHireValidator();
            }
            else throw new Exception($"For {employee.GetType().Name} class no available validators.");
        }
    }
}
