using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib
{
    public interface IRemoteStream
    {
        public ulong Id { get; }
        public void Detach();
        public bool Write(byte[] buf);
    }
}
