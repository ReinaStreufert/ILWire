using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib
{
    public interface IPacket
    {
        public byte Id { get; }
        public byte[] GetBody();
    }
}
