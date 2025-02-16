using AdapterPattern.ThreeAdapterIntro.Action;
using AdapterPattern.ThreeAdapterIntro.Interface;

namespace AdapterPattern.ThreeAdapterIntro.ActionAdapter
{
    public class FileActionAdapter : IDataSourceAdapter
    {
        private readonly FileAction _fileAction = new FileAction();
        private readonly string _fileName;

        public FileActionAdapter(string fileName)
        {
            _fileName = fileName;
        }

        public string GetData()
        {
            return _fileAction.GetDataFromFile(_fileName);
        }
    }
}