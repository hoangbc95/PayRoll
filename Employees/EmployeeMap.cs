using CsvHelper.Configuration;

namespace PayRoll.Employees
{
    class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Map(m => m.Name).Name("name");
            Map(m => m.Dob).Name("dob");
            Map(m => m.Role).Name("role");
            Map(m => m.StartDate).Name("startdate");
            Map(m => m.StartSalary).Name("salary");
        }
    }
}
