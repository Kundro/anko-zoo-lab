using System.Collections.Generic;
using ZooLab.Employees;

namespace ZooLab.Validators
{
    public abstract class HireValidator : IHireValidator
    {
        public abstract List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo);
    }
}
