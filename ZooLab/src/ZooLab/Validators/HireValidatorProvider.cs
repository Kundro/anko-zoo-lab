using System;
using System.Collections.Generic;
using System.Text;
using ZooLab.Employees;

namespace ZooLab.Validators
{
    public class HireValidatorProvider : IHireValidator
    {
        public IHireValidator GetHireValidator(IEmployee employee)
        {
            return GetHireValidator(employee);
        }
    }
}
