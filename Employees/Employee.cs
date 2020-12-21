using System;
using PayRoll.Salary;
using System.Collections.Generic;
using System.Text;

namespace PayRoll.Employees
{
    class Employee
    {
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Role { get; set; }
        public string StartDate { get; set; }
        public long StartSalary { get; set; }
        private static readonly string DATE_FORMAT = "yyyyMMdd";
        private static readonly int MONTHS_OF_DAY = 12;
        private static readonly double COEFFICIENT_SALARY = 1.06;
        private ISalaryCalculator SalaryCalculator = new EmployeeSalaryCalculator();

        private DateTime ConvertStringToDate(string input)
        {
            return DateTime.ParseExact(input, DATE_FORMAT, null);
        }
        public int GetAge()
        {
            var birthDay = ConvertStringToDate(Dob);
            var age = DateTime.Now.Year - birthDay.Year;
            if (DateTime.Now.DayOfYear < birthDay.DayOfYear)
            {
                age--;
            }

            return age;
        }

        public int GetWorkingYears()
        {
            var starDate = ConvertStringToDate(StartDate);
            var workingYears = DateTime.Now.Year - starDate.Year;
            if (DateTime.Now.DayOfYear < starDate.DayOfYear)
            {
                workingYears--;
            }

            return workingYears;
        }

        public int GetWorkingMonths()
        {
            var startDate = ConvertStringToDate(StartDate);
            var workingMonth = DateTime.Now.Month - startDate.Month;
            if (DateTime.Now.DayOfYear < startDate.DayOfYear)
            {
                workingMonth += MONTHS_OF_DAY;
            }

            return workingMonth;
        }

        public void Show()
        {
            Console.WriteLine($"Ten nhan vien: {Name}");
            Console.WriteLine($"Ngay sinh: {ConvertStringToDate(Dob):yyyy-MM-dd}");
            Console.WriteLine($"Tuoi: {GetAge()}");
            Console.WriteLine($"Thoi gian lam viec: {GetWorkingYears()} nam, {GetWorkingMonths()} thang");
            Console.WriteLine($"Muc luong khoi diem: {StartSalary}");
            Console.WriteLine($"Muc luong hien tai: {SalaryCalculator.CalculateSalary(StartSalary, GetWorkingYears(), COEFFICIENT_SALARY)}");
            Console.WriteLine("--------------------------");
        }
    }
}
