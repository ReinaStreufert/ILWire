using AssemblyGen.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Net
{
    public class Packet<TBinaryType> : IPacket where TBinaryType : notnull
    {
        public byte Id => _Id;

        public Packet(byte Id, TBinaryType data)
        {
            _Id = Id;
            _Data = data;
        }

        private byte _Id;
        private TBinaryType _Data;

        public virtual byte[] GetBody()
        {
            using (var ms = new MemoryStream())
            using (var writer = new BinaryWriter(ms))
            {
                BinarySerializer.Serialize(_Data, writer);
                return ms.ToArray();
            }
        }
    }
}
