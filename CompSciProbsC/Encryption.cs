using System;
using System.Text;
using System.Linq;

namespace CompSciProbsC
{
    class Encryption
    {
        private static byte[] RandomKey(int length)
        {
            var dummy = new byte[length];
            var random = new Random();
            random.NextBytes(dummy);
            return dummy;
        }

        public static (byte[], byte[]) Encrypt(string original)
        {
            var originalBytes = Encoding.UTF8.GetBytes(original);
            var dummyKey = RandomKey(originalBytes.Length);
            var encryptedMessage = originalBytes.Zip(dummyKey, (a, b) => (byte)(a ^ b)).ToArray();
            return (dummyKey, encryptedMessage);
        }

        public static string Decrypt(byte[] dummyKey, byte[] encryptedMessage)
        {
            var decryptedMessage = encryptedMessage.Zip(dummyKey, (a, b) => (byte)(a ^ b)).ToArray();
            return Encoding.UTF8.GetString(decryptedMessage);
        }
    }
}