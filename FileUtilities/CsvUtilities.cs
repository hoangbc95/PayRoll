using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using PayRoll.Employees;

namespace PayRoll.FileUtilities
{
    class CsvUtilities : IFileUtilitties
    {
        public List<Employee> ReadFile(string path)
        {
            try
            {
                var records = new List<Employee>();
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Configuration.RegisterClassMap<EmployeeMap>();
                    records = csv.GetRecords<Employee>().ToList();
                }

                return records;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
