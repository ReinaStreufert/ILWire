using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib
{
    public interface IILWISocket
    {
        public void AddPacketHandler(IPacketHandler handler);
        public void EnableSymmetricEncyption(byte[] key, byte[] iv);
        public Task SendPacketAsync(IPacket packet);
        public Task ConnectAsync(IPAddress ipAddress, int port);
    }
}
