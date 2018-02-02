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

        public string ReadXmlFile(string path)
        {
            return File.ReadAllText(path);
        }

        public string ReadEncryptedTextFile(string path)
        {
            var decodedText = ReadTextFile(path);
            return CryptoManager.Decrypt(decodedText);
            //var decodedWords = decodedText.Split(new[] {" ", "\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            //var stringBuilder = new StringBuilder();
            //foreach (var word in decodedWords)
            //{
            //    stringBuilder.Append($"{word.Reverse()} ");
            //}

            //var encodedText = stringBuilder.ToString();
            //return string.Join(string.Empty, encodedText);
        }
    }
}
