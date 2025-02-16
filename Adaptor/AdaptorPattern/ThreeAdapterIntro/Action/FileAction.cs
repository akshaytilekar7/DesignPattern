using System.IO;

namespace AdapterPattern.ThreeAdapterIntro.Action
{
    public class FileAction
    {
        public string GetDataFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}
