using ILWire_Lib.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Net
{
    public class SecretPacketHandler<TBinaryType> : PacketHandler<TBinaryType> where TBinaryType : notnull
    {
        public SecretPacketHandler(byte id, ISecretCryptographicIdentity recipientSecret, Action<TBinaryType> handler) : base(id, handler)
        {
            _RecipientSecret = recipientSecret;
        }

        private ISecretCryptographicIdentity _RecipientSecret;

        public override async Task HandleAsync(byte[] body)
        {
            await base.HandleAsync(_RecipientSecret.Decrypt(body));
        }
    }
}
