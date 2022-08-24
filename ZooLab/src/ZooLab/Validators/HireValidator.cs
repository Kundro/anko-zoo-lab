using System.Collections.Generic;
using ZooLab.Entities.Employees;
using ZooLab.Entities;

namespace ZooLab.Validators
{
    public abstract class HireValidator : IHireValidator
    {
        public abstract List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo);
    }
}
