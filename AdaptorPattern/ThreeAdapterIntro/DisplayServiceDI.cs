using AdapterPattern.ThreeAdapterIntro.Interface;

namespace AdapterPattern.ThreeAdapterIntro
{
    public class DisplayServiceDI
    {
        private readonly IDataSourceAdapter _dataSourceAdapter;

        public DisplayServiceDI(IDataSourceAdapter dataSourceAdapter)
        {
            _dataSourceAdapter = dataSourceAdapter;
        }
        public string GetDataFromFileOrDb(DataSourceType source)
        {
            return _dataSourceAdapter.GetData();
        }
    }
}
