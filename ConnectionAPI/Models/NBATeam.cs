using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionAPI.Models
{
    public class NBATeam
    {
        public NBATeam(string id, string abbreviation, string city, string conference, string division, string fullName, string name)
        {
            Id = id;
            Abbreviation = abbreviation;
            City = city;
            Conference = conference;
            Division = division;
            FullName = fullName;
            Name = name;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("conference")]
        public string Conference { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
