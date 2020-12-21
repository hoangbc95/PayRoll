using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Salary
{
    interface ISalaryCalculator
    {
        long CalculateSalary(long startSalary, int workingYears, double coefficientSalary);
    }
}
