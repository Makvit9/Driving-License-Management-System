using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BL.Settings
{
    public static class HashSettings
    {
        public static HashAlgorithmName HashName => HashAlgorithmName.SHA512;

        public const int KEYSIZE = 64;
        public const int ITERATIONS = 350000;

    }
}
