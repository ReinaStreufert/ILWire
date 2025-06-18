using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib
{
    public interface IPacketHandler
    {
        public byte Id { get; }
        public void Handle(byte[] body);
    }
}
