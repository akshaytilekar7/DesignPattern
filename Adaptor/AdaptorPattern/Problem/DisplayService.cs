using System;
using System.IO;

namespace AdapterPattern.Problem
{
    public class DisplayService
    {

        public string GetDataFromFileOrDb(DataSourceType source)
        {
            string outputText;
            if (source == DataSourceType.File)
            {
                string filePath = @"People.json";
                outputText = File.ReadAllText(filePath);
            }
            else if (source == DataSourceType.Database)
            {
                var dbService = new DatabaseService();
                outputText = dbService.GetFromDb();
            }
            else
            {
                throw new Exception("Invalid character source");
            }

            return outputText;
        }
    }
}
