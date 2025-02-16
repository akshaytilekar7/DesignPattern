using System;

namespace AdapterPattern.TwoProvider
{
    public class DisplayService
    {
        public string GetDataFromFileOrDb(DataSourceType source)
        {
            string outputText;
            if (source == DataSourceType.File)
            {
                var fileAction = new FileAction();
                outputText = fileAction.GetDataFromFile(@"People.json");
            }
            else if (source == DataSourceType.Database)
            {
                var dbAction = new DbAction();
                outputText = dbAction.GetDataFromDb();
            }
            else
            {
                throw new Exception("Invalid character source");
            }

            return outputText;
        }
    }
}
