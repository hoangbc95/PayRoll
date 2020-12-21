using System;
using PayRoll.FileUtilities;
using PayRoll.Employees;

namespace PayRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fileReader = new CsvUtilities<Employee, EmployeeMap>();
                var employees = fileReader.ReadFile(@"CsvTemplates\employee.csv");
                foreach (var employee in employees)
                {
                    employee.Show();
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
