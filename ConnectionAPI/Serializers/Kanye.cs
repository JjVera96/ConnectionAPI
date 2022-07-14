using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionAPI.Serializers
{
    public static class KanyeSerializer
    {
        public static string ToJson(this Models.Kanye self) => JsonConvert.SerializeObject(self);
    }

    public static class KanyeConverter
    {
        public static readonly JsonSerializerSettings Settings = new ()
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
