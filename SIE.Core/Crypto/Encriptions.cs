using System.Security.Cryptography;
using System.Text;

namespace SIE.Core.Crypto
{
    public class Encriptions
    {
        public virtual string GenerateUniqueKey(int maxSize = 10)
        {
            throw new NotImplementedException();
        }
        public virtual string CreateTokenHMACSHA256(string message, string secret)
        {
            throw new NotImplementedException();
        }
        public virtual string CreateMD5(string message)
        {
            throw new NotImplementedException();
        }
        public virtual string Token()
        {
            throw new NotImplementedException();
        }
        public virtual string Base64Decode(string input)
        {
            throw new NotImplementedException();
        }
        public virtual string Base64Encode(string input)
        {
            throw new NotImplementedException();
        }
        public virtual string GenerateSHA1(string message)
        {
            throw new NotImplementedException();
        }
        public virtual string GenerateSHA256(string message)
        {
            throw new NotImplementedException();
        }
        public virtual string GenerateSHA384(string message)
        {
            throw new NotImplementedException();
        }
        public virtual string GenerateSHA512(string message)
        {
            throw new NotImplementedException();
        }
        public virtual string GenerateMD5(string message)
        {
            throw new NotImplementedException();
        }
        public virtual string? Encrypt(string data, string password)
        {
            throw new NotImplementedException();
        }
        public virtual string? Decrypt(string encryptedData, string password)
        {
            throw new NotImplementedException();
        }

        #region Private Methodes
        private byte[] Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            throw new NotImplementedException();
        }
        private byte[] Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}