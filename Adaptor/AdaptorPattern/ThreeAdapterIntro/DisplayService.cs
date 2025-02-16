using AdapterPattern.ThreeAdapterIntro.ActionAdapter;
using AdapterPattern.ThreeAdapterIntro.Interface;
using System;

namespace AdapterPattern.ThreeAdapterIntro
{
    public class DisplayService
    {
        public string GetDataFromFileOrDb(DataSourceType source)
        {
            IDataSourceAdapter dataSource;

            if (source == DataSourceType.File)
                dataSource = new FileActionAdapter(@"People.json"); // IMP
            else if (source == DataSourceType.Database)
                dataSource = new DbActionAdapter();  // IMP
            else
                throw new Exception("Invalid character source");

            return dataSource.GetData(); // ONE COMMON METHOD
        }
    }
}
