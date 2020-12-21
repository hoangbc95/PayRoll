using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace PayRoll.FileUtilities
{
    class CsvUtilities<TModel, TMap> : IFileUtilitties<TModel, TMap> where TMap : ClassMap<TModel>, new()
    {
        public List<TModel> ReadFile(string path)
        {
            try
            {
                var records = new List<TModel>();
                using (var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Configuration.RegisterClassMap<TMap>();
                    records = csv.GetRecords<TModel>().ToList();
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
