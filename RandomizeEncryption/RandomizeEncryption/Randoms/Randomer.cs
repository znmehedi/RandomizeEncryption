using System.Security.Cryptography;
using System.Text;


namespace RandomizeEncryption.Randoms
{
    public class Randomer : IRandomer
    {
        public string? GetUniqueKey(string pattern, int size)
        {
            if (pattern == null || pattern.Length <= 0 || size <= 0)
                return null;
            char[] chars = pattern.ToCharArray();

            byte[] data = new byte[4 * size];
            using (var crypto = RandomNumberGenerator.Create())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                var rnd = BitConverter.ToUInt32(data, i * 4);
                var idx = rnd % chars.Length;

                result.Append(chars[idx]);
            }

            return result.ToString();
        }
    }
}











