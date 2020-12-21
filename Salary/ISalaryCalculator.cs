namespace PayRoll.Salary
{
    interface ISalaryCalculator
    {
        long CalculateSalary(long startSalary, int workingYears, double coefficientSalary);
    }
}
