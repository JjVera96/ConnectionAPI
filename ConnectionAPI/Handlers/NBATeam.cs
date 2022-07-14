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

    public class NBATeam
    {
        public static Models.NBATeam? ToJson(string json) => JsonConvert.DeserializeObject<Models.NBATeam>(json, NBATeamConverter.Settings);
        public static string ToString(Models.NBATeam team) => NBATeamSerializer.ToJson(team);
    }
}
