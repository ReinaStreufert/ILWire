using ILWire_Lib.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Net
{
    public class SecretPacket<TBinaryType> : Packet<TBinaryType> where TBinaryType : notnull
    {
        public SecretPacket(byte id, ICryptographicIdentity recipientIdentity, TBinaryType data) : base(id, data)
        {
            _RecipientIdentity = recipientIdentity;
        }

        private ICryptographicIdentity _RecipientIdentity;

        public override byte[] GetBody()
        {
            return _RecipientIdentity.Encrypt(base.GetBody());
        }
    }
}
