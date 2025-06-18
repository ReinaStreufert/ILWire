using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib
{
    public interface ICryptographicIdentity
    {
        string PublicKeyDigest { get; }
        public byte[] Encrypt(byte[] data);
    }

    public interface ISecretCryptographicIdentity : ICryptographicIdentity
    {
        public byte[] Decrypt(byte[] data);
    }
}
