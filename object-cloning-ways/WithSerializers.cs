using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace object_cloning_ways
{
    public static class Serializers
    {

        //Method 3 : BinarySerializer

        public static T CreateCloneByBinaryFormatter<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(ms);
            }
        }

        //Method 4 : XmlSerializer

        public static T CreateCloneByXmlSerializer<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(ms, obj);
                ms.Seek(0, SeekOrigin.Begin);
                return (T)serializer.Deserialize(ms);
            }
        }

        //Method 5 : JsonSerializer

        public static T CreateCloneByJsonSerializer<T>(T obj)
        {
            var serializer = JsonSerializer.Serialize(obj);
            return (T)JsonSerializer.Deserialize<T>(serializer);

        }
    }

    [Serializable]
    public class Automobile
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
