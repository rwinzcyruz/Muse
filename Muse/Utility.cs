using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Muse
{
    public class Utility
    {
        public static string SHA1Digest(string plain)
        {
            var sha1 = SHA1.Create();
            byte[] input = Encoding.ASCII.GetBytes(plain);
            byte[] hash = sha1.ComputeHash(input);

            var output = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                output.Append(hash[i].ToString("X2"));
            }
            return output.ToString();
        }
    }
}
