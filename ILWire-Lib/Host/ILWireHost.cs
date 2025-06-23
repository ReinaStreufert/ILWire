using ILWire_Lib.Cryptography;
using ILWire_Lib.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Host
{
    public class ILWireHost : IILWIHost
    {
        public ILWireHost(IILWISocket socket, IRemoteExecutionContext executionContext, IPortableKernelCompiler kernelCompiler)
        {

        }

        private IILWISocket _Socket;
        private IRemoteExecutionContext _ExecutionContext;
        private IPortableKernelCompiler _KernelCompiler;

        public Task ListenAsync(IPAddress addr, int port, ISecretCryptographicIdentity cryptSecret)
        {
            throw new NotImplementedException();
        }
    }
}
