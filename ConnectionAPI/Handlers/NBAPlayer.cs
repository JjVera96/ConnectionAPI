using ConnectionAPI.Serializers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionAPI.Handlers
{
    public class NBAPlayer
    {
        public static Models.NBAPlayer? ToJson(string json) => JsonConvert.DeserializeObject<Models.NBAPlayer>(json, NBAPlayerConverter.Settings);
        public static string ToString(Models.NBAPlayer player) => NBAPlayerSerializer.ToJson(player);
    }

}
