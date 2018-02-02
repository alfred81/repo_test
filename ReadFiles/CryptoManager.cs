using System.Linq;
using System.Text;

namespace ReadFiles
{
    public static class CryptoManager
    {
        public static string Decrypt(string content)
        {
            var reversed = content.Reverse();
            var stringBuilder = new StringBuilder();
            foreach (var symbol in reversed)
            {
                stringBuilder.Append(symbol);
            }
            var decodedString = stringBuilder.ToString();
            return decodedString.Replace("\n\r", "\r\n");
        }
    }
}
