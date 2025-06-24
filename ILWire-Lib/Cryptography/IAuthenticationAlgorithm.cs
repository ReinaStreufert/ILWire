using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Cryptography
{
    public interface IAuthenticationAlgorithm<TIdentity, TSecret> where TIdentity : ICryptographicIdentity where TSecret : TIdentity, ISecretCryptographicIdentity
    {
        public string AlgorithmName { get; }
        public TSecret GenerateIdentity();
        public TIdentity LoadKeyData(byte[] key);
        public TSecret LoadSecretData(byte[] key);
        public byte[] SaveKeyData(TIdentity identity);
        public byte[] SaveSecretData(TSecret secret);
    }
}
