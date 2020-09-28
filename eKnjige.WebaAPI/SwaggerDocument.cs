using System.Collections.Generic;

namespace eKnjige.WebaAPI
{
    public class SwaggerDocument
    {
        public Dictionary<string, IEnumerable<string>>[] Security { get; internal set; }
    }
}