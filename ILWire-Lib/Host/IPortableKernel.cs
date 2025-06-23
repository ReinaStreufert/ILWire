using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Host
{
    public interface IPortableKernel
    {
        public byte[] LocalSignature { get; }
        public byte[] Code { get; }
    }

    public interface IPortableKernelCompiler
    {
        public RemoteExecutionKernel Compile(IPortableKernel kernel);
    }
}
