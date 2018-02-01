using System;
using System.IO;

namespace ReadFiles
{
    public class ReadService
    {
        public string ReadTextFile(string path)
        {
            return File.ReadAllText(path);
        }

        public string ReadFile(string path, string fileType)
        {
            switch (fileType)
            {
                case "txt":
                    return ReadTextFile(path);
                case "xml":
                    return ReadXmlFile(path);
                    default:
                        throw new NotSupportedException($"{fileType}");
            }
        }

        public string ReadXmlFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
