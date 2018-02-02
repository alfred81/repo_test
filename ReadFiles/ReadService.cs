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
            switch (fileType.ToLower())
            {
                case "txt":
                    return ReadTextFile(path);
                case "xml":
                    return ReadXmlFile(path);
                case "json":
                    return ReadJSONFile(path);
                default:
                        throw new NotSupportedException($"{fileType}");
            }
        }

        public string ReadEncryptedFile(string path, string fileType)
        {
            var fileContent = ReadFile(path, fileType);
            return CryptoManager.Decrypt(fileContent);
        }

        public string ReadXmlFile(string path)
        {
            return File.ReadAllText(path);
        }

        public string ReadJSONFile(string path)
        {
            return File.ReadAllText(path);
        }

    }
}
