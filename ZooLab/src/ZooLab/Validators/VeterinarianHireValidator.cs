using System.Collections.Generic;
using ZooLab.Employees;

namespace ZooLab.Validators
{
    public class VeterinarianHireValidator : HireValidator
    {
        public override List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo)
        {
            return ValidateEmployee(employee, zoo);
        }
    }
}
