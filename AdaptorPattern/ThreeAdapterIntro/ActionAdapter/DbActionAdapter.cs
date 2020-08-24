using AdapterPattern.ThreeAdapterIntro.Action;
using AdapterPattern.ThreeAdapterIntro.Interface;

namespace AdapterPattern.ThreeAdapterIntro.ActionAdapter
{
    public class DbActionAdapter : IDataSourceAdapter
    {
        private readonly DbAction _dbAction = new DbAction();


        public string GetData()
        {
            return _dbAction.GetDataFromDb();
        }
    }
}