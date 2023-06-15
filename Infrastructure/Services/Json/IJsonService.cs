using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Json
{
    public interface IJsonService<T>
    {
        IEnumerable<T> GetObjects(string json);

        string SerializeObjects(List<T> objects);
    }
}
