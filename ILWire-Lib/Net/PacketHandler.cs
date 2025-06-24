using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyGen.Serialization;
using ILWire_Lib.Net.Packets;

namespace ILWire_Lib.Net
{
    public class PacketHandler<TBinaryType> : IPacketHandler where TBinaryType : notnull
    {
        public byte Id => _Id;

        public PacketHandler(byte id, Action<TBinaryType> handler)
        {
            _Id = id;
            _Callback = handler;
        }

        private byte _Id;
        private Action<TBinaryType> _Callback;

        public virtual async Task HandleAsync(byte[] body)
        {
            await Task.Run(() =>
            {
                TBinaryType packet;
                using (var ms = new MemoryStream(body))
                using (var reader = new BinaryReader(ms))
                    packet = BinarySerializer.Deserialize<TBinaryType>(reader);
                _Callback(packet);
            });
        }
    }
}
