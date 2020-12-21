using System;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Salary
{
    class EmployeeSalaryCalculator : ISalaryCalculator
    {
        public long CalculateSalary(long startSalary, int workingYears, double coefficientSalary)
        {
            long currentSalary = startSalary;
            for (int i = 1; i <= workingYears; i++)
            {
                currentSalary = (long)(currentSalary * coefficientSalary);
            }

            return currentSalary;
        }
    }
}
