using System.IO;

namespace Serialization
{
    public interface ISerializer<T> where T : new ()
    {
        T Deserialize(Stream pStream); 
    }
}