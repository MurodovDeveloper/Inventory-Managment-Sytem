using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Infrastructure.Services.Json
{
    public class JsonService<T> : IJsonService<T>
    {
        public IEnumerable<T> GetObjects(string json)
        => JsonConvert
                .DeserializeObject<List<T>>(json)
                .Where(i => i != null)
                .ToList();

        public string SerializeObjects(List<T> objects)
        => JsonConvert.SerializeObject(objects, Newtonsoft.Json.Formatting.Indented);
    }
}
