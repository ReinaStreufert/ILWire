using System.Reflection.Emit;

namespace ILWire_Lib.Host
{
    public interface IRemoteExecutionContext
    {
        public IRemotePersistentStore<T> GetStore<T>();
        public IRemoteStream AttachToStream(ulong streamId, Action<byte[]> messageReceivedAsyncHandler);
    }

    public delegate void RemoteExecutionKernel(IRemoteExecutionContext ctx);
}
