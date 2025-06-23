using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Net
{
    public class PacketHandler : IPacketHandler
    {
        public byte Id { get; }

        public Task HandleAsync(byte[] body)
        {
            throw new NotImplementedException();
        }
    }
}
