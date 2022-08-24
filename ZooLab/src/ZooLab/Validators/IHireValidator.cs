using System.Collections.Generic;
using ZooLab.Employees;

namespace ZooLab.Validators
{
    public interface IHireValidator
    {
        public List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo) => new List<ValidationError>();
    }
}
