using System.IO;

namespace AdapterPattern.TwoProvider
{
    class FileAction
    {
        public string GetDataFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
