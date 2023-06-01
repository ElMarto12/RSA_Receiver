using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA_app_2.utility
{
    public static class Rsa
    { 
        public static bool CheckSignature(string text, byte[] signature, RSAParameters key)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(key);
                return rsa.VerifyData(textBytes, new SHA256Managed(), signature);
            }
        }

    }
}
