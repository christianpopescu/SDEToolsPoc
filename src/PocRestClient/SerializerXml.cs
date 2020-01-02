using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public class SerializerXml<T> : ISerializer<T> where T : new()
    {
        private static SerializerXml<T> _instance;

        private SerializerXml() { }   

        public static SerializerXml<T> GetInstance() 
        {
            if (_instance == null) _instance = new SerializerXml<T>();
            return _instance;
        }
        
        public T Deserialize(Stream pStream)
        {
            T objectDeserialized = new T();
            var serializer = new XmlSerializer(typeof(T));
            objectDeserialized = (T)serializer.Deserialize(pStream);
            return objectDeserialized;

        }
    }
}
