using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Application.Security {

    /*
     * Class to handle the creation of hashed passwords.
     * SaltSize, HashSize, NumIterations should not be changed once a password is in the database
     */
    public sealed class PasswordHash {

        private const int SaltSize = 32;
        private const int HashSize = 64;
        private const int NumIterations = 10000;

        private readonly byte[] _hash;
        private readonly byte[] _salt;

        public byte[] Salt { get { return (byte[])_salt.Clone(); } }
        public byte[] Hash { get { return (byte[])_hash.Clone(); } }

        public PasswordHash(string plainTextPassword) {

            new RNGCryptoServiceProvider().GetBytes(_salt = new byte[SaltSize]);
            _hash = new Rfc2898DeriveBytes(plainTextPassword, _salt, NumIterations).GetBytes(HashSize);
        }

        public PasswordHash(byte[] hashBytes) {

            Array.Copy(hashBytes, 0, _salt = new byte[SaltSize], 0, SaltSize);
            Array.Copy(hashBytes, SaltSize, _hash = new byte[HashSize], 0, HashSize);
        }

        public byte[] ToArray() {

            byte[] hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(_salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(_hash, 0, hashBytes, SaltSize, HashSize);

            return hashBytes;
        }

        public bool Verify(string password) {

            byte[] test = new Rfc2898DeriveBytes(password, _salt, NumIterations).GetBytes(HashSize);

            for (int i = 0; i < HashSize; i++)
                if (test[i] != _hash[i])
                    return false;
            return true;
        }
    }
}
