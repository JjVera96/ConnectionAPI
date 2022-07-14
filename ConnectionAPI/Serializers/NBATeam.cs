﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionAPI.Serializers
{
    public static class NBATeamSerializer
    {
        public static string ToJson(this Models.NBATeam self) => JsonConvert.SerializeObject(self);
    }

    public static class NBATeamConverter
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
