using ConnectionAPI.Serializers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionAPI.Handlers
{

    public class Kanye
    {
        public static Models.Kanye? ToJson(string json) => JsonConvert.DeserializeObject<Models.Kanye>(json, KanyeConverter.Settings);

        public static string ToString(Models.Kanye quote) => KanyeSerializer.ToJson(quote);
    }
   
}
