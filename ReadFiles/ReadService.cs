using System;
using System.IO;
using System.Linq;
using System.Text;

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

        public string ReadEncryptedFile(string path, string fileType)
        {
            var fileContent = ReadFile(path, fileType);
            return CryptoManager.Decrypt(fileContent);
        }

        public string ReadXmlFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
