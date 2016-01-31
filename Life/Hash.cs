using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    public class Hash
    {
        public static byte[] GenerateHashWithRandomSalt(string value)
        {
            return GenerateHash(Encoding.UTF8.GetBytes(value), GenerateSalt());
        }

        public static byte[] GenerateHash(string value, byte[] salt)
        {
            return GenerateHash(Encoding.UTF8.GetBytes(value), salt);
        }

        public static byte[] GenerateHash(byte[] value, byte[] salt)
        {
            byte[] saltedValue = value.Concat(salt).ToArray();
            return new SHA256Managed().ComputeHash(saltedValue);
        }

        public static byte[] GenerateSalt()
        {
            Random r = new Random();
            var salt = new byte[100];
            r.NextBytes(salt);

            return salt;
        }

        public static bool CheckHashWihtSalt(string password, byte[] salt, byte[] passwordHash)
        {
            byte[] passwordHashGenerated = GenerateHash(password, salt);

            return passwordHash.SequenceEqual(passwordHashGenerated);
        }
    }
}
