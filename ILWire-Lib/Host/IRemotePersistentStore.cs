using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILWire_Lib.Host
{
    public interface IRemotePersistentStore<T>
    {
        public Type StorageType { get; } 
        public T Get(Guid uuid);
        public void Set(Guid uuid, T value);
    }
}
