using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionAPI.Models
{
    public class Kanye
    {
        public Kanye(string quote)
        {
            Quote = quote;
        }

        [JsonProperty("quote")]
        public string Quote { get; set; }
    }
}
