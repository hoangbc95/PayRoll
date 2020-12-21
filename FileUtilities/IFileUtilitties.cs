using System.Collections.Generic;
using CsvHelper.Configuration;

namespace PayRoll.FileUtilities
{
    interface IFileUtilitties<TModel, TMap> where TMap : ClassMap<TModel>, new()
    {
        List<TModel> ReadFile(string path);
    }
}
