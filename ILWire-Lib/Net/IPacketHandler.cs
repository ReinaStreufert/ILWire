using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Net
{
    public interface IPacketHandler
    {
        public byte Id { get; }
        public Task HandleAsync(byte[] body);
    }
}
