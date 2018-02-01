using System.IO;

namespace ReadFiles
{
    public class ReadService
    {
        public string ReadTextFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
