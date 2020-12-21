using System.Collections.Generic;
using PayRoll.Employees;

namespace PayRoll.FileUtilities
{
    interface IFileUtilitties
    {
        List<Employee> ReadFile(string path);
    }
}
