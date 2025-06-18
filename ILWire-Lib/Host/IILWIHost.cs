using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Host
{
    public interface IILWIHost
    {
        public Task ListenAsync(IPAddress addr, int port, ISecretCryptographicIdentity cryptSecret);
    }
}
